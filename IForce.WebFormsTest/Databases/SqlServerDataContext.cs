using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace IForce.WebFormsTest.Databases
{
    public class SqlServerDataContext : DataContext
    {
        private readonly string connectionString;

        public SqlServerDataContext()
        {
            connectionString = ConfigurationManager
                .ConnectionStrings["IForceSqlServer"]
                .ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
