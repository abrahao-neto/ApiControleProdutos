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
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("FORNECEDOR");

            builder.HasKey(f => f.IdFornecedor);

            builder.Property(f => f.IdFornecedor)
                .HasColumnName("IDFORNECEDOR");

            builder.Property(f => f.Nome)
                .HasColumnName("NOME")
                 .HasColumnType("NVARCHAR(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(f => f.NomeFantasia)
                .HasColumnName("NOMEFANTASIA")
                 .HasColumnType("NVARCHAR(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(f => f.RazaoSocial)
                .HasColumnName("RAZAOSOCIAL")
                 .HasColumnType("NVARCHAR(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(f => f.Cnpj)
               .HasColumnName("CNPJ")
                .HasColumnType("NVARCHAR(18)")
               .HasMaxLength(18)
               .IsRequired();

            builder.Property(f => f.DataHoraCriacao)
               .HasColumnName("DATAHORACRIACAO")
               .HasMaxLength(100);

            builder.Property(f => f.DataHoraAlteracao)
              .HasColumnName("DATAHORAALTERACAO")
              .HasMaxLength(100);
        }
    }
}
