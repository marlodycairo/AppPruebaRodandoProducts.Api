using AppPruebaRodandoProducts.Api.Application;
using AppPruebaRodandoProducts.Api.Domain;
using AppPruebaRodandoProducts.Api.Infrastructure.Entities;
using AppPruebaRodandoProducts.Api.InfrastructureService.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppPruebaRodandoProducts.Api.DomainService
{
    public class ClienteDomain : IClienteDomain
    {
        private readonly ApplicationDbContext context;
        private readonly IClienteApplication clienteApplication;

        public ClienteDomain(ApplicationDbContext context, IClienteApplication clienteApplication)
        {
            this.context = context;
            this.clienteApplication = clienteApplication;
        }

        public void Delete(int id)
        {
            clienteApplication.Delete(id);
        }

        public IEnumerable<Clientes> GetAll()
        {
            return clienteApplication.GetAll();
        }

        public Clientes GetById(int id)
        {
            return clienteApplication.GetById(id);
        }

        public Clientes Insert(Clientes entity)
        {
            return clienteApplication.Insert(entity);
        }

        public Clientes Update(Clientes entity)
        {
            return clienteApplication.Update(entity);
        }
    }
}
