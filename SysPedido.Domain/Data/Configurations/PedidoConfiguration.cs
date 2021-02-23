using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SysPedido.Domain.Entities;

namespace SysPedido.Domain.Data.Configurations
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
                builder.ToTable("Pedido");
                builder.HasKey(c => c.Id);
                builder.Property(c => c.IniciadoEm).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
                builder.Property(c => c.Status).HasConversion<string>();
                builder.Property(c => c.TipoFrete).HasConversion<int>();
                builder.Property(c => c.Observacao).HasColumnType("VARCHAR(512)");

                builder.HasMany(c => c.Itens)
                    .WithOne(c => c.Pedido)
                    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}