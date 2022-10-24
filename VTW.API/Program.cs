using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection;
using VTW.API.Filters;
using VTW.API.Helpers;
using VTW.API.Services.Abstractions;
using VTW.DAL.Entities;
using VTW.DAL.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddValidatorsFromAssemblyContaining<Program>();

builder.Services.AddFluentValidation(fv =>
{
    fv.RegisterValidatorsFromAssembly(typeof(Program).Assembly);
});


builder.Services.AddControllers(options =>
{
    options.Filters.Add<ValidationFilter>();
});

builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<VtwContext>(); ;
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddAutoMapper(Assembly.Load("VTW.API.Services"));

builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new ServicesModule());
    builder.RegisterModule(new RepositoriesModule());
});

var installers = typeof(Program)
                    .Assembly
                    .ExportedTypes
                    .Where(x => typeof(IServiceInstaller).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                    .Select(Activator.CreateInstance)
                    .Cast<IServiceInstaller>()
                    .ToList();

installers.ForEach(installer => installer.InstallServices(builder.Services, builder.Configuration));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
