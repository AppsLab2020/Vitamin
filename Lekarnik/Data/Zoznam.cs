using System.Collections.Generic;
using Lekarnik.Models;


namespace Lekarnik.Data
{
    public static class Zoznam
    {
        public static IList<Vita> Zoznams { get; private set; }
        static Zoznam()
        {
            Zoznams = new List<Vita>();

            Zoznams.Add(new Vita
            {
                Nazov = " Vitamín A",
                Popis = "Skvely vitamin"
            });

            Zoznams.Add(new Vita
            {
                Nazov = "Vitamín B1",
                Popis = "Dobry vitamin"
            });
           
            Zoznams.Add(new Vita
            {
                Nazov = "Vitamín B2",
                Popis = "Dobry vitamin"
            });
           
            Zoznams.Add(new Vita
            {
                Nazov = "Vitamín B6",
                Popis = "Dobry vitamin"
            });
           
            Zoznams.Add(new Vita
            {
                Nazov = "Vitamín B12",
                Popis = "Dobry vitamin"
            });
            
            Zoznams.Add(new Vita
            {
                Nazov = "Vitamín C",
                Popis = "Dobry vitamin"
            });
            
            Zoznams.Add(new Vita
            {
                Nazov = "Vitamín F",
                Popis = "Dobry vitamin"
            });
          
            Zoznams.Add(new Vita
            {
                Nazov = "Vitamín H",
                Popis = "Dobry vitamin"
            });
           
            Zoznams.Add(new Vita
          
            {
                Nazov = "Vitamín K",
                Popis = "Dobry vitamin"
            });
            
            Zoznams.Add(new Vita

            {
                Nazov = "Draslík",
                Popis = "Dobry vitamin"
            });
           
            Zoznams.Add(new Vita

            {
                Nazov = "Horčík",
                Popis = "Dobry vitamin"
            });
            
            Zoznams.Add(new Vita

            {
                Nazov = "Vápnik",
                Popis = "Dobry vitamin"
            });
            
            Zoznams.Add(new Vita

            {
                Nazov = "Zinok",
                Popis = "Dobry vitamin"
            });

            Zoznams.Add(new Vita

            {
                Nazov = "Železo",
                Popis = "Dobry vitamin"
            });
        }
    }
}
