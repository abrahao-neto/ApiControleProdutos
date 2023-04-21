using ApiControleProdutos.Domain.Interfaces.Repositories;
using ApiControleProdutos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiControleProdutos.Domain.Services
{
    
    /// <summary>
    /// Classe para implementar o serviço genérico
    /// </summary>
    public class BaseService<TEntity, TKey> : IBaseService<TEntity, TKey> where TEntity : class
    {
        private readonly IBaseRepository<TEntity, TKey> _repositorio; 

        public BaseService(IBaseRepository<TEntity, TKey> repositorio)
        {
            _repositorio = repositorio;
        }

        public virtual void Add(TEntity entity)
        {
            _repositorio.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _repositorio.Update(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            _repositorio.Delete(entity);
        }

        public virtual TEntity Get(Func<TEntity, bool> where)
        {
           return _repositorio.Get(where);
        }

        public virtual List<TEntity> GetAll()
        {
            return _repositorio.GetAll();
        }

        public virtual List<TEntity> GetAll(Func<TEntity, bool> where)
        {
            return _repositorio.GetAll(where);
        }

        public virtual TEntity GetById(TKey id)
        {
            return _repositorio.GetById(id);
        }
       
    }
}                                                                                                                                                                                                   
