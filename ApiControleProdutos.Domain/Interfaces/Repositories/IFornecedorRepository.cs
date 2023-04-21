using ApiControleProdutos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiControleProdutos.Domain.Interfaces.Repositories
{
    public interface IFornecedorRepository : IBaseRepository<Fornecedor, Guid>
    {
    }
}
