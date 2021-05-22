﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppPruebaRodandoProducts.Api.Application
{
    public interface IClienteApplication<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        TEntity Insert(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(int id);
    }
}
