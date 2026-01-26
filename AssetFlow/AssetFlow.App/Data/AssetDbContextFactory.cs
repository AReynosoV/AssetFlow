using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AssetFlow.App.Data
{
    public class AssetDbContextFactory : IDesignTimeDbContextFactory<AssetDbContext>
    {
        public AssetDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AssetDbContext>();

            // Usa la misma cadena de conexión que definimos en el DbContext
            string server = "192.168.1.113";
            string database = "AssetFlowDB";
            string user = "AssetFlowUser";
            string pass = "TuPasswordSeguro123!";

            string connectionString = $"Server={server};Database={database};User Id={user};Password={pass};TrustServerCertificate=True;";

            optionsBuilder.UseSqlServer(connectionString);

            return new AssetDbContext(optionsBuilder.Options);
        }
    }
}