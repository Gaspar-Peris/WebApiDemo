using Services.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using WebApiDemo.Data;

namespace Services.UnitOfWork
{
    namespace Services.Repositories
    {
        public interface IUnitOfWork
        {
            IProductRepository Products { get; }

            Task<int> CompleteAsync();
        }
    }
}
