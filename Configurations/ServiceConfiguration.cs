using System;
using System.Linq;
using System.Web;
using IForce.WebFormsTest.Databases;
using IForce.WebFormsTest.Services;
using Microsoft.Extensions.DependencyInjection;

namespace IForce.WebFormsTest.Configurations
{
    public static class ServiceConfiguration
    {
        public const string RequestScopeKey = "IForce.RequestScope";

        public static IServiceProvider ServiceProvider { get; private set; }

        public static void Initialize()
        {
            var services = new ServiceCollection();
            var assembly = typeof(ServiceConfiguration).Assembly;

            services.AddScoped<DataContext, SqlServerDataContext>();
            services.AddAutoMapper(assembly);

            var appServiceType = typeof(IAppService);
            var types = assembly
                .GetTypes()
                .Where(type => appServiceType.IsAssignableFrom(type) && type.IsClass && !type.IsAbstract);

            foreach (var type in types)
            {
                services.AddScoped(type);
            }

            ServiceProvider = services.BuildServiceProvider();
        }

        public static void BeginRequest()
        {
            HttpContext.Current.Items[RequestScopeKey] = ServiceProvider.CreateScope();
        }

        public static void EndRequest()
        {
            var scope = HttpContext.Current.Items[RequestScopeKey] as IDisposable;
            scope?.Dispose();
        }

        public static T GetRequiredService<T>()
        {
            var scope = HttpContext.Current.Items[RequestScopeKey] as IServiceScope;
            return scope.ServiceProvider.GetRequiredService<T>();
        }

    }
}
