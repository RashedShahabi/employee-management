﻿using ContactProject_DataLayer.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ContactProject_DataLayer.Contract
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        private ContactProject_DBEntities _db;
        private DbSet<TEntity> _dbSet;

        public GenericRepository(ContactProject_DBEntities db)
        {
            _db = db;
            _dbSet = db.Set<TEntity>();
        }
        public virtual TEntity GetById(object Id)
        {
            return _dbSet.Find(Id);
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (where != null)
            {
                query = query.Where(where);
            }
            return query.ToList();
        }
        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }
        public virtual void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }
        public virtual void Delete(object Id)
        {
            var entity = GetById(Id);
            Delete(entity);
        }
    }

}
