using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SysPedido.Domain.Entities;

namespace SysPedido.Domain.Data.Configurations
{
    public class PedidoItemConfiguration : IEntityTypeConfiguration<PedidoItem>
    {
        public void Configure(EntityTypeBuilder<PedidoItem> builder)
        {
                builder.ToTable("PedidoItens");
                builder.HasKey(c => c.Id);
                builder.Property(c => c.Quantidade).HasDefaultValue(1).IsRequired();
                builder.Property(c => c.Valor).IsRequired();
                builder.Property(c => c.Desconto).IsRequired();
        }
    }
}