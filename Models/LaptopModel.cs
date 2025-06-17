using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    public class LaptopModel : ProductModel
    {
        // Create the required properties for the class 
        [Required]
        [JsonPropertyName("batteryLife")]
        public int BatteryLife { get; set; }

        [Required]
        [JsonPropertyName("weight")]
        public double Weight { get; set; }
    }
}
