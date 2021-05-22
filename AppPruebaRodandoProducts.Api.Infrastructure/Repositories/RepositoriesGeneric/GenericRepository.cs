using AppPruebaRodandoProducts.Api.InfrastructureService.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppPruebaRodandoProducts.Api.Infrastructure.Repositories.RepositoriesGeneric
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext context;

        public GenericRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Delete(int id)
        {
            var entity = GetById(id);

            if (entity == null)
            {
                throw new Exception("La entidad es null.");
            }
            
            context.Set<TEntity>().Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public TEntity Insert(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();

            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

            return entity;
        }
    }
}
