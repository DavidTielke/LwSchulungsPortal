using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class Repository<TEntity>
        where TEntity : class, IIdentifyableEntity
    {
        private readonly TpContext _database;

        public Repository()
        {
            _database = new TpContext();
        }

        public IQueryable<TEntity> Query => _database.Set<TEntity>();

        public void Insert(TEntity entity)
        {
            _database.Set<TEntity>().Add(entity);
            _database.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            var entity = _database.Set<TEntity>().Find(id);
            return entity;
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            _database.Set<TEntity>().Remove(entity);
            _database.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _database.Entry(entity).State = EntityState.Modified;

            _database.SaveChanges();
        }
    }
}