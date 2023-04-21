using ApiControleProdutos.Application.Models;
using ApiControleProdutos.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiControleProdutos.Application.Mappings
{
    public class EntityToModelMap : Profile
    {
        public EntityToModelMap() 
        {
            CreateMap<Produto, ProdutoPostModel>();
            CreateMap<Fornecedor, FornecedorPostModel>();
        }
        
    }
}
