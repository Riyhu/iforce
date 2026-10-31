using IForce.WebFormsTest.Entities;
using Microsoft.EntityFrameworkCore;

namespace IForce.WebFormsTest.Databases
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
    }
}
