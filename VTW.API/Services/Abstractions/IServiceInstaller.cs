namespace VTW.API.Services.Abstractions
{
    public interface IServiceInstaller
    {
        void InstallServices(IServiceCollection services, IConfiguration configuration);
    }
}
