using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_AugustinRibreau.ORM
{
    public class ContexteBDD : DbContext
    {
        public ContexteBDD()
            : base("theConnexion")
        {
        }

        public virtual DbSet<Intervener> Intervener { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<Tools> Tools { get; set; }
        public virtual DbSet<Intervention> Intervention { get; set; }
        public virtual DbSet<History> History { get; set; }
    }
}
