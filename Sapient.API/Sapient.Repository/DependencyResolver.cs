using Microsoft.Extensions.DependencyInjection;
using Sapient.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sapient.Repository
{
    public static class DependencyResolver
    {
        public static void Register(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IMedicineRepository, MedicineRepository>();
        }
    }
}
