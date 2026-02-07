using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AssetFlow.App.Models; // Asegúrate de que este sea el namespace de tu clase Asset


namespace AssetFlow.App.Data
{
    public class AssetDbContext : DbContext
    {
        // Esta propiedad representa la tabla en SQL Server
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Status> Statuses { get; set; }

        // Constructor necesario para la fábrica de tiempo de diseño
        public AssetDbContext(DbContextOptions<AssetDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Reemplaza con la IP real de tu VM
                string server = "192.168.1.113";
                string database = "AssetFlowDB";
                string user = "AssetFlowUser";
                string pass = "TuPasswordSeguro123!"; // El que usaste en el script de SQL

                string connectionString = $"Server={server};Database={database};User Id={user};Password={pass};TrustServerCertificate=True;";

                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed para Categorías
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Hardware" },
                new Category { Id = 2, Name = "Licencias" },
                new Category { Id = 3, Name = "Mobiliario" }
            );

            // Seed para Estados
            modelBuilder.Entity<Status>().HasData(
                new Status { Id = 1, Name = "Por Utilizar" },
                new Status { Id = 2, Name = "En Uso" },
                new Status { Id = 3, Name = "Retirado/a" }
            );
        }

    }
}
