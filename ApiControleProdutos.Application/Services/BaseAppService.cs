using ApiControleProdutos.Application.Interfaces;
using ApiControleProdutos.Domain.Interfaces.Services;
using ApiControleProdutos.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiControleProdutos.Application.Services
{
    public class BaseAppService<TEntity, TKey> : Interfaces.BaseAppService<TEntity, TKey> where TEntity : class
    {
        private readonly IBaseService<TEntity, TKey> _service;

        public BaseAppService(IBaseService<TEntity, TKey> service)
        {
            _service = service;
        }

        public virtual void Add(TEntity entity)
        {
            _service.Add(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            _service.Delete(entity);
        }

        public virtual TEntity Get(Func<TEntity, bool> where)
        {
            return _service.Get(where);
        }

        public virtual List<TEntity> GetAll()
        {
            return _service.GetAll();
        }

        public virtual List<TEntity> GetAll(Func<TEntity, bool> where)
        {
            return _service.GetAll(where);
        }

        public virtual TEntity GetById(TKey id)
        {
            return _service.GetById(id);
        }

        public virtual void Update(TEntity entity)
        {
            _service.Update(entity);
        }
    }
}
