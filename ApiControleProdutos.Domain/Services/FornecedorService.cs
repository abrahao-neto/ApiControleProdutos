using ApiControleProdutos.Domain.Entities;
using ApiControleProdutos.Domain.Interfaces.Repositories;
using ApiControleProdutos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiControleProdutos.Domain.Services
{
    public class FornecedorService : BaseService<Fornecedor, Guid>, IFornecedorService
    {
        public FornecedorService(IBaseRepository<Fornecedor, Guid> repositorio) : base(repositorio)
        {
        }
    }
}
