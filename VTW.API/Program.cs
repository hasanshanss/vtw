using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using VTW.API.Extensions;
using VTW.API.Filters;
using VTW.API.Helpers;
using VTW.API.Services.Abstractions;
using VTW.DAL.Entities;
using VTW.DAL.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

var currentAssembly = typeof(Program).Assembly;
//builder.Services.AddValidatorsFromAssemblyContaining<Program>();

builder.Services.AddFluentValidation(fv =>
{
    fv.RegisterValidatorsFromAssembly(currentAssembly);
});

builder.Services.AddMediatR(m=>m.RegisterServicesFromAssembly(currentAssembly));

builder.Services.AddControllers(options =>
{
    options.Filters.Add<ValidationFilter>();
});

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<VtwContext>();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddAutoMapper(Assembly.Load(AssemblyNames.Services));

builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());


builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterAssemblyTypes(currentAssembly);

});

var installers = currentAssembly
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

app.ConfigureExceptionHandler(app.Logger);

app.UseAuthorization();

app.MapControllers();

app.Run();
