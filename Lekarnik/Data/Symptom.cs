using Lekarnik.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lekarnik.Data
{
    class Symptom
    {
        public static IList<Symp> Symps { get; private set; }
        static Symptom()
        {
            Symps = new List<Symp>();

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Bolesť",
                Popis_Symptom = "Dobre toto"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "mala Bolesť",
                Popis_Symptom = "Zle toto"
            });
        }
    }
}
