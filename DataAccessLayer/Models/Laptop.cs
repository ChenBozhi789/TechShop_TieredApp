using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Laptop : Product
    {
        public int BatteryLife { get; set; }
        public double Weight { get; set; }
    }

}
