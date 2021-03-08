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
                ImageUrl = "vitamin_A",
                Popis = "Nedostatok vytamímu A môže spôsobiť:\nzhoršené videnie,\nhnačka a črevné problémy, \nhrubá koža posiata škvrnamy, \nstrata chuti, \nzastavenie rastu, \nporucha obranyschopnosti, \nšeroslepota, \nvysychanie slizníc(napr.očí – t.j.poškodená rohovka)",
                Vyskyt_Strave = "Vitamín A nachádzame v živočíšnych produktoch ako sú pečeň, mäso, vajcia alebo rybí tuk. \nProvitamínom vitamínu A je betakarotén, z ktorého sa v tele vytvára vitamín A.\nBetakarotén nachádzame v žltooranžovej zelenine.",
                Upozornenia = "Prejavy predávkovania vitamínom A:            nevoľnosť a vracanie, \napatia, \nsuchá koža, \npadanie vlasov, \nporuchy videnia, \nkrvácanie, \nbolesti kĺbov.",
                Davkovanie = "Odporúčané denné dávky sú nasledovné:                   deti do 3 rokov − 0,4 mg, \ndeti 4 − 6 rokov − 0,5 mg, \ndeti 7 − 10 rokov − 0,7 mg, \ndeti a dospelí nad 10 rokov − 1 mg, \ndojčiace ženy − 1,6 mg"
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
