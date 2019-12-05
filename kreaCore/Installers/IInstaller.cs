using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace kreaCore.Installers
{
    public interface IInstaller
    {
        void InstallServices(IServiceCollection services, IConfiguration configuration);
    }
}
