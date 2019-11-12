using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_AugustinRibreau.ORM
{
    public class Tools
    {
        [Key]
        public int PersonId { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [Required]
        public string Designation { get; set; }

        public DateTime PurchaseDate { get; set; }
    }
}
