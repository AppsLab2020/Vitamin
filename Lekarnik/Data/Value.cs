using Lekarnik.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lekarnik.Data
{
        public static class Value
        {
            public static IList<Hodnota> Values { get; private set; }
            static Value()
            {
                Values = new List<Hodnota>();

            Values.Add(new Hodnota
            {
                NameOfHodnota = "jablko",
                HodnotaOfHodnota = 15
            }); 
            }
}
}
