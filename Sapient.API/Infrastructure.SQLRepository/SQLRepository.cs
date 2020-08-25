using Infrastructure.SQLRepository.Abstraction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Infrastructure.SQLRepository
{
    public class SQLRepository : ISQLRepository
    {
        private readonly IConnectionFactory connectionFactory;

        public SQLRepository(IConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;
        }
        public async Task<int> ExecuteAsync<T>(string sqlQuery, dynamic parameters = null, IDbTransaction dbTransaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            try
            {
                int result;

                using (IDbConnection connection = connectionFactory.CreateConnection())
                {
                    connection.Open();
                    result = await connection.ExecuteAsync(sqlQuery, (Object)parameters, dbTransaction, commandTimeout, commandType);
                }
                return result;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<T>> QueryAsync<T>(string sqlQuery, dynamic parameters = null, IDbTransaction dbTransaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            try
            {
                IEnumerable<T> result = null;

                using (IDbConnection connection = connectionFactory.CreateConnection())
                {
                    connection.Open();
                    result = await connection.QueryAsync<T>(sqlQuery, (Object)parameters, dbTransaction, commandTimeout, commandType);
                }
                return result;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
