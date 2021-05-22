using AppPruebaRodandoProducts.Api.Application;
using AppPruebaRodandoProducts.Api.Infrastructure.Entities;
using AppPruebaRodandoProducts.Api.InfrastructureService.Context;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppPruebaRodandoProducts.Api.ApplicationService
{
    public class ClienteApplication : IClienteApplication
    {
        private readonly ApplicationDbContext context;
        
        public ClienteApplication(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Delete(int id)
        {
            var cliente = context.Clientes.Find(id);
            context.Clientes.Remove(cliente);
        }

        public IEnumerable<Clientes> GetAll()
        {
            return context.Clientes.ToList();
        }

        public Clientes GetById(int id)
        {
            return context.Clientes.Find(id);
        }

        public Clientes Insert(Clientes cliente)
        {
            context.Clientes.Add(cliente);
            context.SaveChanges();

            return cliente;
        }

        public Clientes Update(Clientes cliente)
        {
            context.Entry(cliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

            return cliente;
        }
    }
}
