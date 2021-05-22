using AppPruebaRodandoProducts.Api.Domain;
using AppPruebaRodandoProducts.Api.Infrastructure.Entities;
using AppPruebaRodandoProducts.Api.Infrastructure.Repositories.RepositoriesGeneric;
using AppPruebaRodandoProducts.Api.InfrastructureService.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppPruebaRodandoProducts.Api.DomainService
{
    public class ClienteDomain : ClienteRepository, IClienteDomain
    {
        public ClienteDomain(ApplicationDbContext context) : base(context)
        {

        }
        //private IGenericRepository<TEntity> genericRepository;

        //public ClienteDomain(IGenericRepository<TEntity> genericRepository)
        //{
        //    this.genericRepository = genericRepository;
        //}
        //public void Delete(int id)
        //{
        //    genericRepository.Delete(id);
        //}

        //public IEnumerable<TEntity> GetAll()
        //{
        //    return genericRepository.GetAll();
        //}

        //public TEntity GetById(int id)
        //{
        //    return genericRepository.GetById(id);
        //}

        //public TEntity Insert(TEntity entity)
        //{
        //    return genericRepository.Insert(entity);
        //}

        //public TEntity Update(TEntity entity)
        //{
        //    return genericRepository.Update(entity);
        //}
    }
}
