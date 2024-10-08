using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qtasnim_Digital_Teknologi.Model
{
    public class Inventory
    {
        [Key] public int ID { get; set; }
        [Required] public string Name { get; set; }
        public int Quantity { get; set; } = 0;
        public string Description { get; set; }
    }
}
