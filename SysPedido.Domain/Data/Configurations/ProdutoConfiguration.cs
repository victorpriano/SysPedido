using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SysPedido.Domain.Entities;

namespace SysPedido.Domain.Data.Configurations
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
                builder.ToTable("Produto");
                builder.HasKey(c => c.Id);
                builder.Property(c => c.CodigoBarras).HasColumnType("VARCHAR(14)").IsRequired();
                builder.Property(c => c.Descricao).HasColumnType("VARCHAR(60)");
                builder.Property(c => c.Valor).IsRequired();
                builder.Property(c => c.TipoProduto).HasConversion<string>();
        }
    }
}