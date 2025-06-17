using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    public class DesktopModel : ProductModel
    {
        [Required]
        [JsonPropertyName("towerSize")]
        public string TowerSize { get; set; }

        [Required]
        [JsonPropertyName("powerSupplyWattage")]
        public int PowerSupplyWattage { get; set; }

        [Required]
        [JsonPropertyName("coolingSystem")]
        public string CoolingSystem { get; set; }
    }
}
