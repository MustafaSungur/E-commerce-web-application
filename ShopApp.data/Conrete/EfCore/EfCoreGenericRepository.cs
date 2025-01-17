﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopApp.data.Abstract;

namespace ShopApp.data.Conrete.EfCore
{
    internal class EfCoreGenericRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class
        where TContext : DbContext, new()
    {
        public void Create(TEntity entity)
        {
            using var context = new TContext();
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            using var context = new TContext();
            context.Set<TEntity>().Remove(entity);
            context.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
            using var context = new TContext();
            return [.. context.Set<TEntity>()];
        }

        public TEntity GetById(Guid id)
        {
            using var context =new TContext();
            return context.Set<TEntity>().Find(id);
        }

        public void Update(TEntity entity)
        {
            using var context = new TContext();
            context.Entry(entity).State= EntityState.Modified;
            context.SaveChanges();

        }
    }
}
