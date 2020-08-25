using Infrastructure.SQLRepository.Abstraction;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.SQLRepository
{
    public static class DependencyResolver
    {
        public static void Register(IServiceCollection service)
        {
            service.AddTransient<IConnectionFactory, ConnectionFactory>();
            service.AddTransient<ISQLRepository, SQLRepository>();
        }
    }
}
