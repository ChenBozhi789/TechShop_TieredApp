using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Desktop : Product
    {
        public string TowerSize { get; set; } = string.Empty;
        public int PowerSupplyWattage { get; set; }
        public string CoolingSystem { get; set; } = string.Empty;
    }

}
