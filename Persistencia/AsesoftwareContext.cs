using Dominio;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class AsesoftwareContext : DbContext
    {
        public AsesoftwareContext(DbContextOptions options) : base(options) {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
          
        }






        public DbSet<Turnos> Turno { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Comercios> Comercio { get; set; }
        public DbSet<Servicios> Servicios { get; set; }
    }
}