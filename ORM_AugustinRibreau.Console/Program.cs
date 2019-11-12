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
                var Vehicle = db.Vehicle;
                var Intervention = db.Intervention;
                var History = db.History;

                var intervener = new Intervener()
                {
                    LastName = "Mini",
                    FirstName = "Roux",
                    PersonnelNumber = 000001
                };
                var tool = new Tools
                {
                    Description = "Ribreau",
                    Designation = "Augustin"
                };
                //etc...

                db.Tools.Add(tool);
                db.Intervener.Add(intervener);
                db.SaveChanges();
            }

        }
    }
}