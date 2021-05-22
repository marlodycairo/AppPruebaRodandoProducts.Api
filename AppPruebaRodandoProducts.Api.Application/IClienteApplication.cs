using AppPruebaRodandoProducts.Api.Application.Models;
using AppPruebaRodandoProducts.Api.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppPruebaRodandoProducts.Api.Application
{
    public interface IClienteApplication
    {
        IEnumerable<Clientes> GetAll();
        Clientes GetById(int id);
        Clientes Insert(Clientes clientes);
        Clientes Update(Clientes clientes);
        void Delete(int id);
    }
}
