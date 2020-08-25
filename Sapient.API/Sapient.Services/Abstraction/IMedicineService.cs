using Sapient;
using Sapient.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sapient.Services.Abstraction
{
    public interface IMedicineService
    {
        Task<IEnumerable<Medicines>> GetMedicines();
        Task<bool> CreateMedcine(Medicines medicine);
    }
}
