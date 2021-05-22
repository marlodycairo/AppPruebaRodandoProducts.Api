using AppPruebaRodandoProducts.Api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppPruebaRodandoProducts.Api.Application
{
    public interface IClienteApplication
    {
        IEnumerable<ClienteModel> GetClientes();
    }
}
