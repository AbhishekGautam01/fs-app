using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sapient.Repository.Abstraction
{
    public interface IMedicineRepository
    {
        Task<IEnumerable<Medicines>> GetMedicines();
        Task<bool> CreateMedcine(Medicines medicine);
    }
}
