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
                ImageUrl="vitamin_B",
                Popis = "Nedostatok Vitamínu B1 môže spôsobiť: \npodráždenosť, \núnavu, \nstrata chute do jedla, \nzabúdanie, \npomalý a nepravidelný tep, \nnespavosť, \nbolesť hlavy, \n\nVitamín B1 je známy aj ako tiamín, pomáha premieňať potraviny na energiu, zohráva úlohu pri svalových kontrakciách a podporuje normálnu funkciu nervového systému. Navyše sa často nazýva „anti-stresový“ vitamín, pretože má schopnosť chrániť imunitný systém. Vytamín B1 patrí do skupiny vytamínov B z názvom B-komplex.",
                Vyskyt_Strave= "Vitamín B1 sa nachádza v týchto prírodných veciach: celé zrná, fazuľa, špenát, kapusta, droždie, orechy, slnečnicové semená, bravčové mäso a červené mäso.",
                Upozornenia= "Vitamínom B1 sa dá fakt len výnimočne predávkovať. Telo ho vylúčuje v moči.",
                Davkovanie= "Odporúčaná denná výživová dávky (RDA) tiamínu je: \nDojčatá 0-6 mesiacov - 0,2 mg; \nDojčatá 7-12 mesiacov - 0,3 mg; \ndeti 1-3 rokov - 0,5 mg; \ndeti 4-8 rokov - 0,6 mg; \nchlapci 9-13 rokov - 0,9 mg; \nmuži 14 rokov a starší - 1,2 mg; \ndievčatá 9-13 rokov - 0,9 mg; \nženy 14-18 rokov - 1 mg; \nženy nad 18 rokov - 1,1 mg; \ntehotné ženy - 1,4 mg; \ndojčiace ženy - 1,5 mg."
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
