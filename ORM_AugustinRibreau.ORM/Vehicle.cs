using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_AugustinRibreau.ORM
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }

        [StringLength(50)]
        public string Brand { get; set; }

        [StringLength(50)]
        public string Model { get; set; }

        [StringLength(100)]
        public string Registration { get; set; }

        public decimal Volume { get; set; }
    }
}
