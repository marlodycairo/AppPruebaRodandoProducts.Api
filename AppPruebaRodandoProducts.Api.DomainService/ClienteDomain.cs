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
        public readonly ApplicationDbContext context;
        
        public ClienteDomain(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Clientes> GetClientes()
        {
            var clientes = context.Clientes;
            return clientes;
        }
    }
}
