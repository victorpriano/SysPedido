using Microsoft.EntityFrameworkCore;
using SysPedido.Domain.Entities;

namespace SysPedido.Domain.Data
{
    public class SysPedidoContext : DbContext
    {
        public SysPedidoContext(DbContextOptions<SysPedidoContext> options) : base(options)
        {
            
        }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=mydatabase;User ID=sa;Password=admin123");
        }
        protected void OnModelCreting(ModelBuilder modelBuilder)
        {
            // modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SysPedidoContext).Assembly);
        }
    }
}