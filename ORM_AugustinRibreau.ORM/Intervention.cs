using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_AugustinRibreau.ORM
{
    public class Intervention
    {
        [Key]
        public int InterventionId { get; set; }

        [Required]
        [StringLength(100)]
        public string InterventionAddress { get; set; }

        public virtual History History { get; set; }
        public virtual Intervener Intervener { get; set; }


    }
}
