using ORM_AugustinRibreau.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_AugustinRibreau.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ContexteBDD())
            {
                var Intervener = db.Intervener;
                var Vehicle = db.Vehicle;
                var Tools = db.Tools;
                var Intervention = db.Intervention;
                var History = db.History;

            }

        }
    }
}