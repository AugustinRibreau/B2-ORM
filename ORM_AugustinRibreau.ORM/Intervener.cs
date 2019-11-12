using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_AugustinRibreau.ORM
{
    public class Intervener
    {
        [Key]
        public int IntervenerId { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        public int PersonnelNumber { get; set; }

        public virtual Tools Tools { get; set; }
        public virtual Vehicle Vehicles { get; set; }



    }
}
