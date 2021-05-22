using AppPruebaRodandoProducts.Api.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppPruebaRodandoProducts.Api.DomainService
{
    public class ClienteDomain : IClienteDomain
    {
        public string CreateMessage()
        {
            string message = "Testing...!!!";
            return message;
        }
    }
}
