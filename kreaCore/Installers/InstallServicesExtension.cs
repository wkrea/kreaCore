using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace kreaCore.Installers
{
    public static class InstallServicesExtension
    {
        public static void InstallServices<MyStartup>(
            this IServiceCollection services, 
            IConfiguration configuration) where MyStartup : class
        {
            var installers = typeof(MyStartup).Assembly.ExportedTypes.Where(
                x => typeof(IInstaller).IsAssignableFrom(x) &&
                !x.IsInterface && !x.IsAbstract)
                .Select(Activator.CreateInstance)
                .Cast<IInstaller>()
                .ToList();

            installers.ForEach(inst => inst.InstallServices(services, configuration));
        }
    }
}
