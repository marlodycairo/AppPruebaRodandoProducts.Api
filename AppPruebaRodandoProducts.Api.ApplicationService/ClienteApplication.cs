using AppPruebaRodandoProducts.Api.Application;
using AppPruebaRodandoProducts.Api.Infrastructure.Repositories.RepositoriesGeneric;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppPruebaRodandoProducts.Api.ApplicationService
{
    public class ClienteApplication<TEntity> : IClienteApplication<TEntity> where TEntity : class
    {
        private IGenericRepository<TEntity> genericRepository;

        public ClienteApplication(IGenericRepository<TEntity> genericRepository)
        {
            this.genericRepository = genericRepository;
        }
        public void Delete(int id)
        {
            genericRepository.Delete(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return genericRepository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return genericRepository.GetById(id);
        }

        public TEntity Insert(TEntity entity)
        {
            return genericRepository.Insert(entity);
        }

        public TEntity Update(TEntity entity)
        {
            return genericRepository.Update(entity);
        }
    }
}
