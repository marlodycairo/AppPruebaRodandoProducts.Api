using AppPruebaRodandoProducts.Api.Application;
using AppPruebaRodandoProducts.Api.Infrastructure.Entities;
using AppPruebaRodandoProducts.Api.InfrastructureService.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppPruebaRodandoProducts.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public readonly IClienteApplication clienteApplication;

        public ClientesController(ApplicationDbContext context, IClienteApplication clienteApplication)
        {
            this.context = context;
            this.clienteApplication = clienteApplication;
        }

        public IEnumerable<Clientes> GetAll()
        {
            return clienteApplication.GetAll();
        }
    }
}
