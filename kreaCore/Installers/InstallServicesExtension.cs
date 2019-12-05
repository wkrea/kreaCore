using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace kreaCore.Installers
{
    public static class InstallServicesExtension
    {
        /// <summary>
        /// Metodo que permite la carga dinamica de los servicios desde 
        /// Configure services en el archivo StartUp.cs de un proyecto
        /// web NetCore
        /// </summary>
        /// <typeparam name="MyStartup">Provide your Startup class as Generic parameter</typeparam>
        /// <param name="services"> Provide access to your services collection from Startup.cs </param>
        /// <param name="configuration">Provide access to your IConfiguration intance from Startup.cs</param>
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
