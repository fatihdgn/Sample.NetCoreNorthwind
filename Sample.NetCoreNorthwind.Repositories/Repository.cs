using Microsoft.EntityFrameworkCore;
using Sample.NetCoreNorhwind.Entities;
using Sample.NetCoreNorthwind.Extensions;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Sample.NetCoreNorthwind.Repositories
{
    public class Repository<TDbContext,TEntity>
        where TDbContext : DbContext
        where TEntity : Entity
    {
        public TDbContext Context { get; protected set; }
        public Repository(TDbContext context)
        {
            Context = context;
        }

        public DbSet<TEntity> Set => Context.Set<TEntity>();

        public IQueryable<TEntity> Get() => Set.AsQueryable();
        public TEntity Get(string id) => Set.Find(id);
        public TEntity Add(TEntity entity) => Set.Add(entity)?.Entity;
        public TEntity Update(TEntity entity) => entity.With(x => x.ChangedAt = DateTimeOffset.Now);
        public TEntity Remove(TEntity entity) => Set.Remove(entity)?.Entity;
        public IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> exp) => Set.Where(exp);
        public IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> exp, int index, int count = 100) => Filter(exp).Skip(index).Take(count);
        public TEntity Single(Expression<Func<TEntity, bool>> exp) => Filter(exp).FirstOrDefault();

        public void Save() => Context.SaveChanges();

    }
}
