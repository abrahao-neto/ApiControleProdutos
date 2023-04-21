using ApiControleProdutos.Domain.Entities;
using ApiControleProdutos.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiControleProdutos.Infra.Data.Contexts
{
    /// <summary>
    /// Classe de contexto para o EntityFramework
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Método para configurar a conexão com o banco de dados (connectionstring)
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=NETO\SQLEXPRESS;Initial Catalog=BDApiControleProdutos;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        /// <summary>
        /// Método para adicionarmos cada classe de mapeamento criada no projeto
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FornecedorMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
        }

        /// <summary>
        /// Unidade de trabalho para a entidade Fornecedor
        /// </summary>
        public DbSet<Fornecedor> Categoria { get; set; }

        /// <summary>
        /// Unidade de trabalho para a entidade Produto
        /// </summary>
        public DbSet<Produto> Produto { get; set; }
    }
}
