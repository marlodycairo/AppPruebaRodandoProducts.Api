using AppPruebaRodandoProducts.Api.Application;
using AppPruebaRodandoProducts.Api.DomainService;
using AppPruebaRodandoProducts.Api.Infrastructure.Repositories.RepositoriesGeneric;
using AppPruebaRodandoProducts.Api.InfrastructureService.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppPruebaRodandoProducts.Api.ApplicationService
{
    public class ClienteApplication : ClienteDomain, IClienteApplication
    {
        public ClienteApplication(ApplicationDbContext context) : base(context)
        {

        }
    }
}
