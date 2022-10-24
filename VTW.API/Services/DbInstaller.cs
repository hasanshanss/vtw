using Microsoft.EntityFrameworkCore;
using VTW.API.Services.Abstractions;
using VTW.DAL.Entities;

namespace VTW.API.Services
{
    public class DbInstaller : IServiceInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<VtwContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("Default"),
                    x => x.MigrationsAssembly("VTW.DAL"));
            });
        }
    }
}
