using Infrastructure.SQLRepository.Abstraction;
using Sapient.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sapient.Repository
{
    public class MedicineRepository : IMedicineRepository
    {
        private readonly ISQLRepository _sqlRepository;
        public MedicineRepository(ISQLRepository sQLRepository)
        {
            _sqlRepository = sQLRepository;
        }
        public async Task<bool> CreateMedcine(Medicines medicine)
        {
            bool isSuccess = false;
            try {
                int rowsEffected = await _sqlRepository.ExecuteAsync<int>(Queries.insertMedicine, new
                {
                    Medname = medicine.Medname,
                    Brand = medicine.Brand,
                    Price = medicine.Price,
                    Quantity = medicine.Quantity,
                    Expirytime = medicine.Expirytime,
                    Notes = medicine.Notes
                });
                isSuccess = (rowsEffected > 0) ? true : false;
            }
            catch (Exception)
            {
                throw;
            }
            return isSuccess;
        }

        public async Task<IEnumerable<Medicines>> GetMedicines()
        {
            IEnumerable<Medicines> result = null;
            try
            {
                result = await _sqlRepository.QueryAsync<Medicines>(Queries.getAllMedicines);
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
    }
}
