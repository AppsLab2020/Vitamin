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
                Nazov = "Vitamín A",
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
                ImageUrl = "vitamin_B2",
                Popis = "Nedostatok vytamínu B2 môže spôsobiť: \npľuzgiere alebo kútiky, \ncitlivosť na svetlo, \nodlupovanie kože na tvári, \npocit vyčerpania a únavy, \nsčervenanie očí, \nzápaly spojiviek, \nvriedky, \nafty, \nvyrážky, \nekzémy, \nťažkosti pri močení, \nsvrbenie v oblasti konečníka. \n\nTiež známy ako riboflavín, vitamín B2 pomáha nášmu telu rozobrať a používať sacharidy, tuky a bielkoviny vo vašej strave. Je dôležitý pre rast tela a tvorbu červených krviniek.",
                Vyskyt_Strave = "Vitamín B2 sa nachádza v týchto veciach: mandliach, divokej ryži, vajciach, ružičkovom kele, špenáte, brokolici, lososovi a hovädzom mäse.",
                Upozornenia = "Nehrozí predávkovanie. Nadbytok je vylučovaný sám z tela.",
                Davkovanie = "Odporúčaná denná dávka Vitamínu B2 je:              deti 1-3 rokov - 0,5 mg, \ndeti 4-6 rokov - 1,1 mg, \ndeti 7-10 rokov - 1,2 mg, \nchlapci 11-18 rokov - 1,5 mg, \nmuži 18 a starší - 1,8 mg, \ndievčatá 11-18 rokov - 1,2 mg, \nženy 18 a staršie - 1,3 mg, \ntehotné ženy - 1,6 mg. "
            });
           
            Zoznams.Add(new Vita
            {
                Nazov = "Vitamín B6",
                ImageUrl = "vitamin_B6",
                Popis = "Nedostatok vytamínu B6 môže spôsobiť: \npodráždenosť, \nslabosť, \ntrhanie viečok, \nvznik zápalov kože, \nzápaly ústnej dutiny, \ntriaška, \npadanie vlasov, \nzvracanie, \nakné, \nvyrážky. \n\nKonzumácia potravín obsahujúcich vitamín B6 jw zásadná, pretože hrá kľúčovú úlohu v mnohých telesných funkciách, vrátane pohybu, pamäte, reguluje stavy úzkosti a uľavuje od depresií. Tiež pomáha k tvorbe protilátok, ktoré posilňujú imunitný systém a udržuje zdravý krvný obeh.",
                Vyskyt_Strave = "Vitamín B6 sa nachádza v týchto veciach: mäse, pečeni, rybách, ovocí a zelenine(avokádo, banány, zemiaky, kapusta, mrkva, špenát), ryži, fazuli, slnečnicových a sezamových semienkach, otruby, obilninách, orechoch, chliebe, vajíčkach, kyslých mliečnych produktoch.",
                Upozornenia = "Predavkovanie môže u mužov zvyšovať riziko vzniku rakoviny. Dlhodobé užívanie vysokých denných dávok môže tiež viesť k poruchám nervového systému. Inak nie je jeho nadbytok nijako nebezpečný, pretože ide o vitamín rozpustný vo vode, neukladá sa v tele a vylučuje močom.",
                Davkovanie = ""
            });
           
            Zoznams.Add(new Vita
            {
                Nazov = "Vitamín B12",
                ImageUrl = "vitamin_B12",
                Popis = "Nedostatok vytamínu B6 môže spôsobiť: \nbolesť nôh a ramien, \nmravčenie v končatinách, \nproblém s chôdzou, \nspomalené reflexy, \ndýchavičnosť. \n\nVitamín B12 je dôležitý predovšetkým pre správnu funkciu krvotvorby, podieľa sa na syntéze DNA a ATP a je nevyhnutný pre správnu funkciu nervového systému.",
                Vyskyt_Strave = "Hlavným zdrojom tohto vitamínu v potrave sú živočíšne produkty: vajcia, mlieko, syry, mäso a vnútornosti.",
                Upozornenia = "1 z 1000 ľudí môže mať - alergické reakcie (svrbenie, kožná vyrážka, žihľavka, akné)",
                Davkovanie = "Dávkovanie majú všetci rovnaké.                                          Denná dávka 300 µg, \ntehotné ženy by sa mali poradiť s lekárom."

            });
            
            Zoznams.Add(new Vita
            {
                Nazov = "Vitamín C",
                ImageUrl = "vitamin_C",
                Popis = "Nedostatok vitamínu C môže spôsobiť:  krvácanie z nosa alebo z ďasien, časté modriny, pomalé hojenie rán, bolesť kĺbov, anémia, suché vlasy a suchá pokožka, únava, náchylnosť na infekcie, znížená imunita. \n\nVitamín C (kyselina askorbová) je jedným z najdôležitejších vitamínov v našom tele. Má antioxidačné účinky, podieľa sa na tvorbe hormónov, znižuje hladinu cholesterolu, je nevyhnutný pre svaly, kosti, cievy i kožu.",
                Vyskyt_Strave = "Vitamín C sa nachádza v čerstvom ovocí a zelenine, hlavne v: brokolici, rakytníku, červenej paprike, černiciach.",
                Upozornenia = "Prejavy predávkovania vitamínu C:                      alergické reakcie, \nnevoľnosť, \nzažívacie ťažkosti.",
                Davkovanie = "Odporúčaná denná dávka Vitaminu C je:              adeti 0-3 rokov - 50 mg, \nadeti 0-6 rokov - 60 mg, \nadeti 7-10 rokov - 65 mg, \nachlapci 11-18 rokov - 80 mg, \namuži 18 a starší - 100 mg, \nadievčatá 11-18 rokov - 70 mg, \naženy 18 a staršie - 90 mg, \nagravidné ženy - 95 mg, \nadojčiace ženy - 130 mg. "
            });

            Zoznams.Add(new Vita
            {
                Nazov = "Vitamín F",
                ImageUrl = "vitamin_F",
                Popis = "Nedostatok Vitamínu F môže spôsobiť: \nlámanie nechtov, \nlupiny, \nsuchá pleť, \nbolesti hlavy, \nzníženie krvného tlaku, \nporuchy metabolizmu, \nkožné problémy. \n\nVitamín F je v skutočnosti spoločné pomenovanie pre zmesku niekoľkých mastných kyselín ako OMEGA-3 a OMEGA-6 mastné kyseliny. Vitamín F je pre život nevyhnutný.  Telo si ho nevie samé vytvoriť, organizmu musí byť preto dodávaný potravou",
                Vyskyt_Strave = "Hlavným zdrojom tohto vitamínu v potrave sú: rastlinný olej, morské živočíchy (langusta, homár), ryby (losos, sleď), vlašské orechy, semienka (slnečnica, tekvica, ľan), sója, mandle, obilné klíčky, avokádo, olej z ľanových semienok.",
                Upozornenia = "Prejavy predávkovania Vitamínu F:               priberanie na váhe, \nkožné ekzémy, \nakné.",
                Davkovanie = "Odporúčaná denná dávka 6-8 mg.                                       "


            });
          
            Zoznams.Add(new Vita
            {
                Nazov = "Vitamín H",
                ImageUrl = "",
                Popis = "Dobry vitamin",
                Vyskyt_Strave = "",
                Upozornenia = "",
                Davkovanie = ""
            });
           
            Zoznams.Add(new Vita
          
            {
                Nazov = "Vitamín K",
                ImageUrl = "",
                Popis = "Dobry vitamin",
                Vyskyt_Strave = "",
                Upozornenia = "",
                Davkovanie = ""
            });
            
            Zoznams.Add(new Vita

            {
                Nazov = "Draslík",
                ImageUrl = "",
                Popis = "Dobry vitamin",
                Vyskyt_Strave = "",
                Upozornenia = "",
                Davkovanie = ""
            });
           
            Zoznams.Add(new Vita

            {
                Nazov = "Horčík",
                ImageUrl = "",
                Popis = "Dobry vitamin",
                Vyskyt_Strave = "",
                Upozornenia = "",
                Davkovanie = ""
            });
            
            Zoznams.Add(new Vita

            {
                Nazov = "Vápnik",
                ImageUrl = "",
                Popis = "Dobry vitamin",
                Vyskyt_Strave = "",
                Upozornenia = "",
                Davkovanie = ""
            });
            
            Zoznams.Add(new Vita

            {
                Nazov = "Zinok",
                ImageUrl = "",
                Popis = "Dobry vitamin",
                Vyskyt_Strave = "",
                Upozornenia = "",
                Davkovanie = ""
            });

            Zoznams.Add(new Vita

            {
                Nazov = "Železo",
                ImageUrl = "",
                Popis = "Dobry vitamin",
                Vyskyt_Strave = "",
                Upozornenia = "",
                Davkovanie = ""
            });
        }
    }
}
