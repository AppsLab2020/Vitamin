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
                Nazov = "Acko",
                Popis = "Skvely vitamin"
            });

            Zoznams.Add(new Vita
            {
                Nazov = "Becko",
                Popis = "Dobry vitamin"
            });
        }
    }
}
