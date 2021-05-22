using AppPruebaRodandoProducts.Api.Application;
using AppPruebaRodandoProducts.Api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppPruebaRodandoProducts.Api.ApplicationService
{
    public class ClienteApplication : IClienteApplication
    {
        //public readonly ApplicationDbContext context;
        public List<ClienteModel> clientes;

        //public ClienteApplication(ApplicationDbContext context)
        //{
        //    this.context = context;
        //}

        public IEnumerable<ClienteModel> GetClientes()
        {
            return clientes;
        }
    }
}
