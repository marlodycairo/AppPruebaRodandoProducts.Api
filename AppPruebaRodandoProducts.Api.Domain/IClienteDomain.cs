using AppPruebaRodandoProducts.Api.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppPruebaRodandoProducts.Api.Domain
{
    public interface IClienteDomain
    {
        IEnumerable<Clientes> GetAll();
        Clientes GetById(int id);
        Clientes Insert(Clientes entity);
        Clientes Update(Clientes entity);
        void Delete(int id);
    }
}
