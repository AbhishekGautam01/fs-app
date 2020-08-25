using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Infrastructure.SQLRepository.Abstraction
{
    public interface IConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
