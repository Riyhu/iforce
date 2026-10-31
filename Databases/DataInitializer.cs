using System.Linq;
using IForce.WebFormsTest.Entities;

namespace IForce.WebFormsTest.Databases
{
    public static class DataInitializer
    {
        public static void Run(DataContext dataContext)
        {
            if (dataContext.Product.Any())
            {
                return;
            }

            dataContext.Product.AddRange(
                new Product { ProductName = "Laptop Pro", Price = 1250.00m },
                new Product { ProductName = "Wireless Keyboard", Price = 79.90m },
                new Product { ProductName = "USB-C Docking Station", Price = 149.50m },
                new Product { ProductName = "27-inch Monitor", Price = 329.00m },
                new Product { ProductName = "Noise Cancelling Headphones", Price = 199.99m });

            dataContext.SaveChanges();
        }
    }
}
