using System;
using System.Collections.Generic;
using System.Text;

namespace Sapient.Repository
{
    public static class Queries
    {
        public const string getAllMedicines = @"SELECT [Id]
                                                      ,[Medname]
                                                      ,[Brand]
                                                      ,[Price]
                                                      ,[Quantity]
                                                      ,[Expirytime]
                                                      ,[Notes]
                                                  FROM [dbo].[medicines]
                                                ";
        public const string insertMedicine = @"INSERT INTO [dbo].[medicines]
                                                                   (
                                                                   [Medname]
                                                                   ,[Brand]
                                                                   ,[Price]
                                                                   ,[Quantity]
                                                                   ,[Expirytime]
                                                                   ,[Notes])
                                                             VALUES
                                                                   (
                                                                   @Medname
                                                                   ,@Brand
                                                                   ,@Price
                                                                   ,@Quantity
                                                                   ,@Expirytime
                                                                   ,@Notes)";
    }
}
