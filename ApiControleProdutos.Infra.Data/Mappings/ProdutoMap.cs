using ApiControleProdutos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiControleProdutos.Infra.Data.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("PRODUTO");

            builder.HasKey(p => p.IdProduto);

            builder.Property(p => p.IdProduto)
               .HasColumnName("IDPRODUTO");

            builder.Property(p => p.Nome)
                .HasColumnName("NOME")
                .HasColumnType("NVARCHAR(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.Preco)
               .HasColumnName("PRECO")
               .HasPrecision(18, 2)
               .IsRequired();

            builder.Property(p => p.Quantidade)
              .HasColumnName("QUANTIDADE")
              .HasColumnType("INTEGER")
              .IsRequired();

            builder.Property(f => f.DataHoraCriacao)
              .HasColumnName("DATAHORACRIACAO")
              .HasMaxLength(100);

            builder.Property(f => f.DataHoraAlteracao)
             .HasColumnName("DATAHORAALTERACAO")
             .HasMaxLength(100);

            builder.HasOne(p => p.Fornecedor)
                .WithMany(f => f.Produtos)
                .HasForeignKey(p => p.IdFornecedor);
        }
    }
}
