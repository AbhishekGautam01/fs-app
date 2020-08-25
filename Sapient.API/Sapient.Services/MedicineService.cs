using Sapient.Repository;
using Sapient.Repository.Abstraction;
using Sapient.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sapient.Services
{
    public class MedicineService : IMedicineService
    {
        private IMedicineRepository _medicienRepo;
        public MedicineService(IMedicineRepository medicineRepository)
        {
            _medicienRepo = medicineRepository;
        }
        public async Task<bool> CreateMedcine(Medicines medicine)
        {
            return await _medicienRepo.CreateMedcine(medicine);
        }

        public async Task<IEnumerable<Medicines>> GetMedicines()
        {
            return await _medicienRepo.GetMedicines();
        }
    }
}
