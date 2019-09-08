using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DemoInfrastructure.Interfaces;
namespace DemoInfrastructure.Respository
{
  public  class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        protected readonly NORTHWNDEntities Context;

        protected DbSet<TEntity> Entities;


        /// <summary>  
        /// Initializes a new instance of the <see cref="BaseRepository{TEntity}"/> class.  
        /// Note that here I've stored Context.Set<TEntity>() in the constructor and store it in a private field like _entities.   
        /// This way, the implementation  of our methods would be cleaner:        ///   
        /// _entities.ToList();  
        /// _entities.Where();  
        /// _entities.SingleOrDefault();  
        /// </summary>  
        public BaseRepository()
        {
            Context = new NORTHWNDEntities();
            Entities = Context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity FirstOrDefault()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }

        public TEntity Get(int id)
        {
            return Entities.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Entities.ToList();
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveEntity(TEntity entityToDelete)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(TEntity entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
