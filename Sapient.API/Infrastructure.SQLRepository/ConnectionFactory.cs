using Infrastructure.SQLRepository.Abstraction;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Infrastructure.SQLRepository
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly IConfiguration _configuration;
        
        public ConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IDbConnection CreateConnection()
        {
            IDbConnection dbConnection;
            try
            {
                dbConnection = new SqlConnection(_configuration["ConnectionString"]);
            } catch(Exception ex)
            {
                throw ex;
            }
            return dbConnection;
        }
    }
}
