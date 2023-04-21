using ApiControleProdutos.Domain.Entities;
using ApiControleProdutos.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiControleProdutos.Infra.Data.Repositories
{
    /// <summary>
    /// Classe de repositório para produto
    /// </summary>
    public class ProdutoRepository : BaseRepository<Produto, Guid>, IProdutoRepository
    {
    }
}
