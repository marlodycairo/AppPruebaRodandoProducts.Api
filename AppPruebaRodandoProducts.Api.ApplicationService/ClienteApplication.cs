using AppPruebaRodandoProducts.Api.Application;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppPruebaRodandoProducts.Api.ApplicationService
{
    public class ClienteApplication : IClienteApplication
    {
        public string CreateMessage()
        {
            string message = "Testing...!!!";
            return message;
        }
    }
}
