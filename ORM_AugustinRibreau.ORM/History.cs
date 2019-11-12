using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_AugustinRibreau.ORM
{
    public class History
    {
        [Key]
        public int HistoryId { get; set; }

        public DateTime OpeningHours { get; set; }
        public DateTime ClosingHours { get; set; }

        public virtual ICollection<Intervention> Interventions { get; set; }

    }
}
