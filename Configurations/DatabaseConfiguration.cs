using System;
using IForce.WebFormsTest.Databases;
using Microsoft.Extensions.DependencyInjection;

namespace IForce.WebFormsTest.Configurations
{
    public static class DatabaseConfiguration
    {
        public static void ConfigureDatabase(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            using (var dataContext = scope.ServiceProvider.GetRequiredService<DataContext>())
            {
                dataContext.Database.EnsureCreated();
                DataInitializer.Run(dataContext);
            }
        }
    }
}
