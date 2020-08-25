using System;
using System.Collections.Generic;
using System.Text;

namespace Sapient.Repository
{
    public class Medicines
    {
        public int Id { get; set; }
        public string Medname { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public DateTime Expirytime { get; set; }
        public string Notes { get; set; }
        public int Price { get; set; }
    }
}
