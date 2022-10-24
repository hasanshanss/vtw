using VTW.Services.Options.JwtOptions;
using VTW.API.Services.Abstractions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using VTW.API.Services.Abstractions;

namespace VRW.API.Services.ServiceInstallers
{
    public class JwtInstaller : IServiceInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {

            var jwtSettings = new JwtSettings();
            configuration.Bind(nameof(jwtSettings), jwtSettings);
            services.AddSingleton(jwtSettings);

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                    //options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                    //{
                    //    ValidateIssuerSigningKey = jwtSettings.ValidateIssuerSigningKey,
                    //    IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(jwtSettings.IssuerSigningKey)),
                    //    ValidateIssuer = jwtSettings.ValidateIssuer,
                    //    ValidIssuer = jwtSettings.ValidIssuer,
                    //    ValidateAudience = jwtSettings.ValidateAudience,
                    //    ValidAudience = jwtSettings.ValidAudience,
                    //    RequireExpirationTime = jwtSettings.RequireExpirationTime,
                    //    ValidateLifetime = jwtSettings.RequireExpirationTime,
                    //    ClockSkew = TimeSpan.FromDays(1),
                    //};

                    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(jwtSettings.Secret)),
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        RequireExpirationTime = false,
                        ValidateLifetime = true
                    };
                });
        }
    }
}
