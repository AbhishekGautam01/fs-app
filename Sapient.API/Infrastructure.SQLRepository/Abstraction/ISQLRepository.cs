using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.SQLRepository.Abstraction
{
    public interface ISQLRepository
    {
        Task<IEnumerable<T>> QueryAsync<T>(string sqlQuery, dynamic parameters = null, IDbTransaction dbTransaction = null, int? commandTimeout = null, CommandType? commandType = null);

        Task<int> ExecuteAsync<T>(string sqlQuery, dynamic parameters = null, IDbTransaction dbTransaction = null, int? commandTimeout = null, CommandType? commandType = null);
    }
}
