using System;
using System.Collections.Generic;
using System.Text;

namespace AppPruebaRodandoProducts.Api.Infrastructure.Repositories.RepositoriesGeneric
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        TEntity Insert(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(int id);
    }
}
