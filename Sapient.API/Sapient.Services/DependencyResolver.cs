using Microsoft.Extensions.DependencyInjection;
using Sapient.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sapient.Services
{
    public static class DependencyResolver
    {
        public static void Register(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IMedicineService, MedicineService>();
        }
    }
}
