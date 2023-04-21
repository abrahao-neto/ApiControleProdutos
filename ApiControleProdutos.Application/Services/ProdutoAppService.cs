using ApiControleProdutos.Application.Interfaces;
using ApiControleProdutos.Domain.Entities;
using ApiControleProdutos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiControleProdutos.Application.Services
{
    public class ProdutoAppService : BaseAppService<Produto, Guid>, IProdutoAppService
    {
        public ProdutoAppService(IBaseService<Produto, Guid> service) : base(service)
        {
        }
    }
}
