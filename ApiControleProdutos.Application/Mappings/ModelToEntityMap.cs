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
    public class ModelToEntityMap : Profile
    {
        public ModelToEntityMap()
        {
            CreateMap<ProdutoPostModel, Produto>()
                .AfterMap((model, entity) =>
                {
                    entity.IdProduto = Guid.NewGuid();
                    entity.DataHoraCriacao = DateTime.Now;
                    entity.DataHoraAlteracao= DateTime.Now; 
                });

            CreateMap<FornecedorPostModel, Fornecedor>()
               .AfterMap((model, entity) =>
               {
                   entity.IdFornecedor = Guid.NewGuid();
                   entity.DataHoraCriacao = DateTime.Now;
                   entity.DataHoraAlteracao = DateTime.Now;
               });
        }
    }
}
