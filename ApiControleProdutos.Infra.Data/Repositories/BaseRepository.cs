using ApiControleProdutos.Domain.Interfaces.Repositories;
using ApiControleProdutos.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiControleProdutos.Infra.Data.Repositories
{
    public class BaseRepository<TEntity, TKey> : IBaseRepository<TEntity, TKey> where TEntity : class
    {
        /// <summary>
        /// Classe para implementar o repositório genérico
        /// </summary>
        public void Add(TEntity entity)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Add(entity);
                dataContext.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Entry(entity).State = EntityState.Modified;
                dataContext.SaveChanges();
            }
        }

        public virtual void Delete(TEntity entity)
        {
            using(var dataContext = new DataContext())
            {
                dataContext.Remove(entity);
                dataContext.SaveChanges();
            }
        }

        public virtual TEntity Get(Func<TEntity, bool> where)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Set<TEntity>().Where(where).FirstOrDefault();
            }
        }

        public List<TEntity> GetAll()
        {
            using(var dataContext = new DataContext())
            {
                return dataContext.Set<TEntity>().ToList();
            }
        }

        public List<TEntity> GetAll(Func<TEntity, bool> where)
        {
            using(var dataContext = new DataContext())
            {
                return dataContext.Set<TEntity>().Where(where).ToList();
            }
        }

        public TEntity GetById(TKey id)
        {
            using(var dataContext = new DataContext())
            {
                return dataContext.Set<TEntity>().Find(id);
            }
        }

        
    }
}
