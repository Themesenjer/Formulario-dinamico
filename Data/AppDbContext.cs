using Microsoft.EntityFrameworkCore;
using ProductosAPI.Models; // 👈 Agregamos esto

namespace ProductosAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; } // 👈 Aqui reconocerá Producto
    }
}
