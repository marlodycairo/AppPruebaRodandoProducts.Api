using AppPruebaRodandoProducts.Api.Infrastructure.Entities;
using AppPruebaRodandoProducts.Api.Infrastructure.Repositories.IRepositoriesGeneric;
using AppPruebaRodandoProducts.Api.InfrastructureService.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppPruebaRodandoProducts.Api.Infrastructure.Repositories.RepositoriesGeneric
{
    public class ClienteRepository : GenericRepository<Clientes>, IClienteRepository
    {
        public ClienteRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
