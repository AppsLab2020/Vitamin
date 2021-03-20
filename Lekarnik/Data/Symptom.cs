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
                Nazov_Symptom = "Biele škvrny na nechtoch",
                Popis_Symptom = "Zinok pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Bledosť",
                Popis_Symptom = "Železo pomôže"
            });
            
            Symps.Add(new Symp
            {
                Nazov_Symptom = "Bolesť kĺbov",
                Popis_Symptom = "C pomôže a vápnik"
            });
            
            Symps.Add(new Symp
            {
                Nazov_Symptom = "Bolesť nôh a ramien",
                ImageUrl_Symptom = "vitamin_B12",
                Popis_Symptom = "Nedostatok vytamínu B6 môže spôsobiť: \nbolesť nôh a ramien, \nmravčenie v končatinách, \nproblém s chôdzou, \nspomalené reflexy, \ndýchavičnosť. \n\nVitamín B12 je dôležitý predovšetkým pre správnu funkciu krvotvorby, podieľa sa na syntéze DNA a ATP a je nevyhnutný pre správnu funkciu nervového systému.",
                Vyskyt_Strave_Symptom = "Hlavným zdrojom tohto vitamínu v potrave sú živočíšne produkty: vajcia, mlieko, syry, mäso a vnútornosti.",
                Upozornenia_Symptom = "1 z 1000 ľudí môže mať - alergické reakcie (svrbenie, kožná vyrážka, žihľavka, akné)",
                Davkovanie_Symptom = "Dávkovanie majú všetci rovnaké.                                          Denná dávka 300 µg, \ntehotné ženy by sa mali poradiť s lekárom."

            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Bolesť svalov",
                Popis_Symptom = "H pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Citlivosť na svetlo",
                ImageUrl_Symptom = "vitamin_B2",
                Popis_Symptom = "Nedostatok vytamínu B2 môže spôsobiť: \npľuzgiere alebo kútiky, \ncitlivosť na svetlo, \nodlupovanie kože na tvári, \npocit vyčerpania a únavy, \nsčervenanie očí, \nzápaly spojiviek, \nvriedky, \nafty, \nvyrážky, \nekzémy, \nťažkosti pri močení, \nsvrbenie v oblasti konečníka. \n\nTiež známy ako riboflavín, vitamín B2 pomáha nášmu telu rozobrať a používať sacharidy, tuky a bielkoviny vo vašej strave. Je dôležitý pre rast tela a tvorbu červených krviniek.",
                Vyskyt_Strave_Symptom = "Vitamín B2 sa nachádza v týchto veciach: mandliach, divokej ryži, vajciach, ružičkovom kele, špenáte, brokolici, lososovi a hovädzom mäse.",
                Upozornenia_Symptom = "Nehrozí predávkovanie. Nadbytok je vylučovaný sám z tela.",
                Davkovanie_Symptom = "Odporúčaná dennándávka Vitamínu B2 je:              deti 1-3 rokov - 0,5 mg, \ndeti 4-6 rokov - 1,1 mg, \ndeti 7-10 rokov - 1,2 mg, \nchlapci 11-18 rokov - 1,5 mg, \nmuži 18 a starší - 1,8 mg, \ndievčatá 11-18 rokov - 1,2 mg, \nženy 18 a staršie - 1,3 mg, \ntehotné ženy - 1,6 mg. "
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Časté modriny",
                ImageUrl_Symptom = "vitamin_C",
                Popis_Symptom = "Nedostatok vitamínu C môže spôsobiť:  krvácanie z nosa alebo z ďasien, časté modriny, pomalé hojenie rán, bolesť kĺbov, anémia, suché vlasy a suchá pokožka, únava, náchylnosť na infekcie, znížená imunita. \n\nVitamín C (kyselina askorbová) je jedným z najdôležitejších vitamínov v našom tele. Má antioxidačné účinky, podieľa sa na tvorbe hormónov, znižuje hladinu cholesterolu, je nevyhnutný pre svaly, kosti, cievy i kožu.",
                Vyskyt_Strave_Symptom = "Vitamín C sa nachádza v čerstvom ovocí a zelenine, hlavne v: brokolici, rakytníku, červenej paprike, černiciach.",
                Upozornenia_Symptom = "Prejavy predávkovania vitamínu C:                      alergické reakcie, \nnevoľnosť, \nzažívacie ťažkosti.",
                Davkovanie_Symptom = "Odporúčaná denná dávka Vitaminu C je:              adeti 0-3 rokov - 50 mg, \nadeti 0-6 rokov - 60 mg, \nadeti 7-10 rokov - 65 mg, \nachlapci 11-18 rokov - 80 mg, \namuži 18 a starší - 100 mg, \nadievčatá 11-18 rokov - 70 mg, \naženy 18 a staršie - 90 mg, \nagravidné ženy - 95 mg, \nadojčiace ženy - 130 mg. "
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Depresia",
                Popis_Symptom = "H pomôže"
            });

           Symps.Add(new Symp
            {
               Nazov_Symptom = "Hnačky a črevné problémy",
               ImageUrl_Symptom = "vitamin_A",
               Popis_Symptom = "Nedostatok vytamímu A môže spôsobiť:\nzhoršené videnie,\nhnačka a črevné problémy, \nhrubá koža posiata škvrnamy, \nstrata chuti, \nzastavenie rastu, \nporucha obranyschopnosti, \nšeroslepota, \nvysychanie slizníc(napr.očí – t.j.poškodená rohovka)",
               Vyskyt_Strave_Symptom = "Vitamín A nachádzame v živočíšnych produktoch ako sú pečeň, mäso, vajcia alebo rybí tuk. \nProvitamínom vitamínu A je betakarotén, z ktorého sa v tele vytvára vitamín A.\nBetakarotén nachádzame v žltooranžovej zelenine.",
               Upozornenia_Symptom = "Prejavy predávkovania vitamínom A:            nevoľnosť a vracanie, \napatia, \nsuchá koža, \npadanie vlasov, \nporuchy videnia, \nkrvácanie, \nbolesti kĺbov.",
               Davkovanie_Symptom = "Odporúčané denné dávky sú nasledovné:                   deti do 3 rokov − 0,4 mg, \ndeti 4 − 6 rokov − 0,5 mg, \ndeti 7 − 10 rokov − 0,7 mg, \ndeti a dospelí nad 10 rokov − 1 mg, \ndojčiace ženy − 1,6 mg"
           });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Chudokrvnosť",
                Popis_Symptom = "Železo pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Infekcie",
                Popis_Symptom = "Zinok pomôže"
            });
           
            Symps.Add(new Symp
            {
                Nazov_Symptom = "Kazivosť zubov",
                Popis_Symptom = "Vámpnik pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Koža posiatá škvrnami ",
                ImageUrl_Symptom = "vitamin_A",
                Popis_Symptom = "Nedostatok vytamímu A môže spôsobiť:\nzhoršené videnie,\nhnačka a črevné problémy, \nhrubá koža posiata škvrnamy, \nstrata chuti, \nzastavenie rastu, \nporucha obranyschopnosti, \nšeroslepota, \nvysychanie slizníc(napr.očí – t.j.poškodená rohovka)",
                Vyskyt_Strave_Symptom = "Vitamín A nachádzame v živočíšnych produktoch ako sú pečeň, mäso, vajcia alebo rybí tuk. \nProvitamínom vitamínu A je betakarotén, z ktorého sa v tele vytvára vitamín A.\nBetakarotén nachádzame v žltooranžovej zelenine.",
                Upozornenia_Symptom = "Prejavy predávkovania vitamínom A:            nevoľnosť a vracanie, \napatia, \nsuchá koža, \npadanie vlasov, \nporuchy videnia, \nkrvácanie, \nbolesti kĺbov.",
                Davkovanie_Symptom = "Odporúčané denné dávky sú nasledovné:                   deti do 3 rokov − 0,4 mg, \ndeti 4 − 6 rokov − 0,5 mg, \ndeti 7 − 10 rokov − 0,7 mg, \ndeti a dospelí nad 10 rokov − 1 mg, \ndojčiace ženy − 1,6 mg"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Krvácanie z nosa alebo z ďasien",
                ImageUrl_Symptom = "vitamin_C",
                Popis_Symptom = "Nedostatok vitamínu C môže spôsobiť:  krvácanie z nosa alebo z ďasien, časté modriny, pomalé hojenie rán, bolesť kĺbov, anémia, suché vlasy a suchá pokožka, únava, náchylnosť na infekcie, znížená imunita. \n\nVitamín C (kyselina askorbová) je jedným z najdôležitejších vitamínov v našom tele. Má antioxidačné účinky, podieľa sa na tvorbe hormónov, znižuje hladinu cholesterolu, je nevyhnutný pre svaly, kosti, cievy i kožu.",
                Vyskyt_Strave_Symptom = "Vitamín C sa nachádza v čerstvom ovocí a zelenine, hlavne v: brokolici, rakytníku, červenej paprike, černiciach.",
                Upozornenia_Symptom = "Prejavy predávkovania vitamínu C:                      alergické reakcie, \nnevoľnosť, \nzažívacie ťažkosti.",
                Davkovanie_Symptom = "Odporúčaná denná dávka Vitaminu C je:              adeti 0-3 rokov - 50 mg, \nadeti 0-6 rokov - 60 mg, \nadeti 7-10 rokov - 65 mg, \nachlapci 11-18 rokov - 80 mg, \namuži 18 a starší - 100 mg, \nadievčatá 11-18 rokov - 70 mg, \naženy 18 a staršie - 90 mg, \nagravidné ženy - 95 mg, \nadojčiace ženy - 130 mg. "
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Kŕče v nohách",
                ImageUrl_Symptom = "vitamin_B6",
                Popis_Symptom = "Nedostatok vytamínu B6 môže spôsobiť: \npodráždenosť, \nslabosť, \ntrhanie viečok, \nvznik zápalov kože, \nzápaly ústnej dutiny, \ntriaška, \npadanie vlasov, \nzvracanie, \nakné, \nvyrážky. \n\nKonzumácia potravín obsahujúcich vitamín B6 jw zásadná, pretože hrá kľúčovú úlohu v mnohých telesných funkciách, vrátane pohybu, pamäte, reguluje stavy úzkosti a uľavuje od depresií. Tiež pomáha k tvorbe protilátok, ktoré posilňujú imunitný systém a udržuje zdravý krvný obeh.",
                Vyskyt_Strave_Symptom = "Vitamín B6 sa nachádza v týchto veciach: mäse, pečeni, rybách, ovocí a zelenine(avokádo, banány, zemiaky, kapusta, mrkva, špenát), ryži, fazuli, slnečnicových a sezamových semienkach, otruby, obilninách, orechoch, chliebe, vajíčkach, kyslých mliečnych produktoch.",
                Upozornenia_Symptom = "Predavkovanie môže u mužov zvyšovať riziko vzniku rakoviny. Dlhodobé užívanie vysokých denných dávok môže tiež viesť k poruchám nervového systému. Inak nie je jeho nadbytok nijako nebezpečný, pretože ide o vitamín rozpustný vo vode, neukladá sa v tele a vylučuje močom.",
                Davkovanie_Symptom = ""
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Lámanie nechtov",
                ImageUrl_Symptom = "vitamin_F",
                Popis_Symptom = "Nedostatok Vitamínu F môže spôsobiť: \nlámanie nechtov, \nlupiny, \nsuchá pleť, \nbolesti hlavy, \nzníženie krvného tlaku, \nporuchy metabolizmu, \nkožné problémy. \n\nVitamín F je v skutočnosti spoločné pomenovanie pre zmesku niekoľkých mastných kyselín ako OMEGA-3 a OMEGA-6 mastné kyseliny. Vitamín F je pre život nevyhnutný.  Telo si ho nevie samé vytvoriť, organizmu musí byť preto dodávaný potravou",
                Vyskyt_Strave_Symptom = "Hlavným zdrojom tohto vitamínu v potrave sú: rastlinný olej, morské živočíchy (langusta, homár), ryby (losos, sleď), vlašské orechy, semienka (slnečnica, tekvica, ľan), sója, mandle, obilné klíčky, avokádo, olej z ľanových semienok.",
                Upozornenia_Symptom = "Prejavy predávkovania Vitamínu F:               priberanie na váhe, \nkožné ekzémy, \nakné.",
                Davkovanie_Symptom = "Odporúčaná denná dávka 6-8 mg.                                       "

            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Lupiny",
                ImageUrl_Symptom = "vitamin_F",
                Popis_Symptom = "Nedostatok Vitamínu F môže spôsobiť: \nlámanie nechtov, \nlupiny, \nsuchá pleť, \nbolesti hlavy, \nzníženie krvného tlaku, \nporuchy metabolizmu, \nkožné problémy. \n\nVitamín F je v skutočnosti spoločné pomenovanie pre zmesku niekoľkých mastných kyselín ako OMEGA-3 a OMEGA-6 mastné kyseliny. Vitamín F je pre život nevyhnutný.  Telo si ho nevie samé vytvoriť, organizmu musí byť preto dodávaný potravou",
                Vyskyt_Strave_Symptom = "Hlavným zdrojom tohto vitamínu v potrave sú: rastlinný olej, morské živočíchy (langusta, homár), ryby (losos, sleď), vlašské orechy, semienka (slnečnica, tekvica, ľan), sója, mandle, obilné klíčky, avokádo, olej z ľanových semienok.",
                Upozornenia_Symptom = "Prejavy predávkovania Vitamínu F:               priberanie na váhe, \nkožné ekzémy, \nakné.",
                Davkovanie_Symptom = "Odporúčaná denná dávka 6-8 mg.                                       "

            });
           
            Symps.Add(new Symp
            {
                Nazov_Symptom = "Mravčenie v končatinách",
                ImageUrl_Symptom = "vitamin_B12",
                Popis_Symptom = "Nedostatok vytamínu B6 môže spôsobiť: \nbolesť nôh a ramien, \nmravčenie v končatinách, \nproblém s chôdzou, \nspomalené reflexy, \ndýchavičnosť. \n\nVitamín B12 je dôležitý predovšetkým pre správnu funkciu krvotvorby, podieľa sa na syntéze DNA a ATP a je nevyhnutný pre správnu funkciu nervového systému.",
                Vyskyt_Strave_Symptom = "Hlavným zdrojom tohto vitamínu v potrave sú živočíšne produkty: vajcia, mlieko, syry, mäso a vnútornosti.",
                Upozornenia_Symptom = "1 z 1000 ľudí môže mať - alergické reakcie (svrbenie, kožná vyrážka, žihľavka, akné)",
                Davkovanie_Symptom = "Dávkovanie majú všetci rovnaké.                                          Denná dávka 300 µg, \ntehotné ženy by sa mali poradiť s lekárom."

            });
            Symps.Add(new Symp
            {
                Nazov_Symptom = "Nervozita",
                Popis_Symptom = "Horčík pomôže"
            });
            
            Symps.Add(new Symp
            {
                Nazov_Symptom = "Nespavosť",
                Popis_Symptom = "H pomôže a draslík"
            });
            
            Symps.Add(new Symp
            {
                Nazov_Symptom = "Nízka hladina cukru v krvi",
                ImageUrl_Symptom = "vitamin_B6",
                Popis_Symptom = "Nedostatok vytamínu B6 môže spôsobiť: \npodráždenosť, \nslabosť, \ntrhanie viečok, \nvznik zápalov kože, \nzápaly ústnej dutiny, \ntriaška, \npadanie vlasov, \nzvracanie, \nakné, \nvyrážky. \n\nKonzumácia potravín obsahujúcich vitamín B6 jw zásadná, pretože hrá kľúčovú úlohu v mnohých telesných funkciách, vrátane pohybu, pamäte, reguluje stavy úzkosti a uľavuje od depresií. Tiež pomáha k tvorbe protilátok, ktoré posilňujú imunitný systém a udržuje zdravý krvný obeh.",
                Vyskyt_Strave_Symptom = "Vitamín B6 sa nachádza v týchto veciach: mäse, pečeni, rybách, ovocí a zelenine(avokádo, banány, zemiaky, kapusta, mrkva, špenát), ryži, fazuli, slnečnicových a sezamových semienkach, otruby, obilninách, orechoch, chliebe, vajíčkach, kyslých mliečnych produktoch.",
                Upozornenia_Symptom = "Predavkovanie môže u mužov zvyšovať riziko vzniku rakoviny. Dlhodobé užívanie vysokých denných dávok môže tiež viesť k poruchám nervového systému. Inak nie je jeho nadbytok nijako nebezpečný, pretože ide o vitamín rozpustný vo vode, neukladá sa v tele a vylučuje močom.",
                Davkovanie_Symptom = ""
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Odlupovanie kože na tvári",
                ImageUrl_Symptom = "vitamin_B2",
                Popis_Symptom = "Nedostatok vytamínu B2 môže spôsobiť: \npľuzgiere alebo kútiky, \ncitlivosť na svetlo, \nodlupovanie kože na tvári, \npocit vyčerpania a únavy, \nsčervenanie očí, \nzápaly spojiviek, \nvriedky, \nafty, \nvyrážky, \nekzémy, \nťažkosti pri močení, \nsvrbenie v oblasti konečníka. \n\nTiež známy ako riboflavín, vitamín B2 pomáha nášmu telu rozobrať a používať sacharidy, tuky a bielkoviny vo vašej strave. Je dôležitý pre rast tela a tvorbu červených krviniek.",
                Vyskyt_Strave_Symptom = "Vitamín B2 sa nachádza v týchto veciach: mandliach, divokej ryži, vajciach, ružičkovom kele, špenáte, brokolici, lososovi a hovädzom mäse.",
                Upozornenia_Symptom = "Nehrozí predávkovanie. Nadbytok je vylučovaný sám z tela.",
                Davkovanie_Symptom = "Odporúčaná dennándávka Vitamínu B2 je:              deti 1-3 rokov - 0,5 mg, \ndeti 4-6 rokov - 1,1 mg, \ndeti 7-10 rokov - 1,2 mg, \nchlapci 11-18 rokov - 1,5 mg, \nmuži 18 a starší - 1,8 mg, \ndievčatá 11-18 rokov - 1,2 mg, \nženy 18 a staršie - 1,3 mg, \ntehotné ženy - 1,6 mg. "
            });
            Symps.Add(new Symp
            {
                Nazov_Symptom = "Pleť plná akné",
                Popis_Symptom = "Horčík pomôže"
            });
            Symps.Add(new Symp
            {
                Nazov_Symptom = "Pľuzgiere a kútiky",
                ImageUrl_Symptom = "vitamin_B2",
                Popis_Symptom = "Nedostatok vytamínu B2 môže spôsobiť: \npľuzgiere alebo kútiky, \ncitlivosť na svetlo, \nodlupovanie kože na tvári, \npocit vyčerpania a únavy, \nsčervenanie očí, \nzápaly spojiviek, \nvriedky, \nafty, \nvyrážky, \nekzémy, \nťažkosti pri močení, \nsvrbenie v oblasti konečníka. \n\nTiež známy ako riboflavín, vitamín B2 pomáha nášmu telu rozobrať a používať sacharidy, tuky a bielkoviny vo vašej strave. Je dôležitý pre rast tela a tvorbu červených krviniek.",
                Vyskyt_Strave_Symptom = "Vitamín B2 sa nachádza v týchto veciach: mandliach, divokej ryži, vajciach, ružičkovom kele, špenáte, brokolici, lososovi a hovädzom mäse.",
                Upozornenia_Symptom = "Nehrozí predávkovanie. Nadbytok je vylučovaný sám z tela.",
                Davkovanie_Symptom = "Odporúčaná dennándávka Vitamínu B2 je:              deti 1-3 rokov - 0,5 mg, \ndeti 4-6 rokov - 1,1 mg, \ndeti 7-10 rokov - 1,2 mg, \nchlapci 11-18 rokov - 1,5 mg, \nmuži 18 a starší - 1,8 mg, \ndievčatá 11-18 rokov - 1,2 mg, \nženy 18 a staršie - 1,3 mg, \ntehotné ženy - 1,6 mg. "
            });
            Symps.Add(new Symp
            {
                Nazov_Symptom = "Podráždenosť",
                Popis_Symptom = "B1 pomôže a vápnik"
            });
            
            Symps.Add(new Symp
            {
                Nazov_Symptom = "Pomalé hojenie rán",
                ImageUrl_Symptom = "vitamin_C",
                Popis_Symptom = "Nedostatok vitamínu C môže spôsobiť:  krvácanie z nosa alebo z ďasien, časté modriny, pomalé hojenie rán, bolesť kĺbov, anémia, suché vlasy a suchá pokožka, únava, náchylnosť na infekcie, znížená imunita. \n\nVitamín C (kyselina askorbová) je jedným z najdôležitejších vitamínov v našom tele. Má antioxidačné účinky, podieľa sa na tvorbe hormónov, znižuje hladinu cholesterolu, je nevyhnutný pre svaly, kosti, cievy i kožu.",
                Vyskyt_Strave_Symptom = "Vitamín C sa nachádza v čerstvom ovocí a zelenine, hlavne v: brokolici, rakytníku, červenej paprike, černiciach.",
                Upozornenia_Symptom = "Prejavy predávkovania vitamínu C:                      alergické reakcie, \nnevoľnosť, \nzažívacie ťažkosti.",
                Davkovanie_Symptom = "Odporúčaná denná dávka Vitaminu C je:              adeti 0-3 rokov - 50 mg, \nadeti 0-6 rokov - 60 mg, \nadeti 7-10 rokov - 65 mg, \nachlapci 11-18 rokov - 80 mg, \namuži 18 a starší - 100 mg, \nadievčatá 11-18 rokov - 70 mg, \naženy 18 a staršie - 90 mg, \nagravidné ženy - 95 mg, \nadojčiace ženy - 130 mg. "
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Problém s chôdzov",
                ImageUrl_Symptom = "vitamin_B12",
                Popis_Symptom = "Nedostatok vytamínu B6 môže spôsobiť: \nbolesť nôh a ramien, \nmravčenie v končatinách, \nproblém s chôdzou, \nspomalené reflexy, \ndýchavičnosť. \n\nVitamín B12 je dôležitý predovšetkým pre správnu funkciu krvotvorby, podieľa sa na syntéze DNA a ATP a je nevyhnutný pre správnu funkciu nervového systému.",
                Vyskyt_Strave_Symptom = "Hlavným zdrojom tohto vitamínu v potrave sú živočíšne produkty: vajcia, mlieko, syry, mäso a vnútornosti.",
                Upozornenia_Symptom = "1 z 1000 ľudí môže mať - alergické reakcie (svrbenie, kožná vyrážka, žihľavka, akné)",
                Davkovanie_Symptom = "Dávkovanie majú všetci rovnaké.                                          Denná dávka 300 µg, \ntehotné ženy by sa mali poradiť s lekárom."

            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Spomalené reflexy",
                ImageUrl_Symptom = "vitamin_B12",
                Popis_Symptom = "Nedostatok vytamínu B6 môže spôsobiť: \nbolesť nôh a ramien, \nmravčenie v končatinách, \nproblém s chôdzou, \nspomalené reflexy, \ndýchavičnosť. \n\nVitamín B12 je dôležitý predovšetkým pre správnu funkciu krvotvorby, podieľa sa na syntéze DNA a ATP a je nevyhnutný pre správnu funkciu nervového systému.",
                Vyskyt_Strave_Symptom = "Hlavným zdrojom tohto vitamínu v potrave sú živočíšne produkty: vajcia, mlieko, syry, mäso a vnútornosti.",
                Upozornenia_Symptom = "1 z 1000 ľudí môže mať - alergické reakcie (svrbenie, kožná vyrážka, žihľavka, akné)",
                Davkovanie_Symptom = "Dávkovanie majú všetci rovnaké.                                          Denná dávka 300 µg, \ntehotné ženy by sa mali poradiť s lekárom."

            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Strata chute do jedla",
                ImageUrl_Symptom = "vitamin_B",
                Popis_Symptom = "Nedostatok Vitamínu B1 môže spôsobiť: \npodráždenosť, \núnavu, \nstrata chute do jedla, \nzabúdanie, \npomalý a nepravidelný tep, \nnespavosť, \nbolesť hlavy, \n\nVitamín B1 je známy aj ako tiamín, pomáha premieňať potraviny na energiu, zohráva úlohu pri svalových kontrakciách a podporuje normálnu funkciu nervového systému. Navyše sa často nazýva „anti-stresový“ vitamín, pretože má schopnosť chrániť imunitný systém. Vytamín B1 patrí do skupiny vytamínov B z názvom B-komplex.",
                Vyskyt_Strave_Symptom = "Vitamín B1 sa nachádza v týchto prírodných veciach: celé zrná, fazuľa, špenát, kapusta, droždie, orechy, slnečnicové semená, bravčové mäso a červené mäso.",
                Upozornenia_Symptom = "Vitamínom B1 sa dá fakt len výnimočne predávkovať. Telo ho vylúčuje v moči.",
                Davkovanie_Symptom = "Odporúčaná denná výživová dávky (RDA) tiamínu je: \nDojčatá 0-6 mesiacov - 0,2 mg; \nDojčatá 7-12 mesiacov - 0,3 mg; \ndeti 1-3 rokov - 0,5 mg; \ndeti 4-8 rokov - 0,6 mg; \nchlapci 9-13 rokov - 0,9 mg; \nmuži 14 rokov a starší - 1,2 mg; \ndievčatá 9-13 rokov - 0,9 mg; \nženy 14-18 rokov - 1 mg; \nženy nad 18 rokov - 1,1 mg; \ntehotné ženy - 1,4 mg; \ndojčiace ženy - 1,5 mg."
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Suchá pleť",
                ImageUrl_Symptom = "vitamin_F",
                Popis_Symptom = "Nedostatok Vitamínu F môže spôsobiť: \nlámanie nechtov, \nlupiny, \nsuchá pleť, \nbolesti hlavy, \nzníženie krvného tlaku, \nporuchy metabolizmu, \nkožné problémy. \n\nVitamín F je v skutočnosti spoločné pomenovanie pre zmesku niekoľkých mastných kyselín ako OMEGA-3 a OMEGA-6 mastné kyseliny. Vitamín F je pre život nevyhnutný.  Telo si ho nevie samé vytvoriť, organizmu musí byť preto dodávaný potravou",
                Vyskyt_Strave_Symptom = "Hlavným zdrojom tohto vitamínu v potrave sú: rastlinný olej, morské živočíchy (langusta, homár), ryby (losos, sleď), vlašské orechy, semienka (slnečnica, tekvica, ľan), sója, mandle, obilné klíčky, avokádo, olej z ľanových semienok.",
                Upozornenia_Symptom = "Prejavy predávkovania Vitamínu F:               priberanie na váhe, \nkožné ekzémy, \nakné.",
                Davkovanie_Symptom = "Odporúčaná denná dávka 6-8 mg.                                       "

            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Šklbanie vo svaloch",
                Popis_Symptom = "B2 pomôže a horčík"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Únava ",
                Popis_Symptom = "B1 pomôže, H pomôže, Železo"
            });
          
            Symps.Add(new Symp
            {
                Nazov_Symptom = "Vypadavanie vlasov",
                Popis_Symptom = "Železo pomôže"
            });
            
            Symps.Add(new Symp
            {
                Nazov_Symptom = "Zabúdanie",
                ImageUrl_Symptom = "vitamin_B",
                Popis_Symptom = "Nedostatok Vitamínu B1 môže spôsobiť: \npodráždenosť, \núnavu, \nstrata chute do jedla, \nzabúdanie, \npomalý a nepravidelný tep, \nnespavosť, \nbolesť hlavy, \n\nVitamín B1 je známy aj ako tiamín, pomáha premieňať potraviny na energiu, zohráva úlohu pri svalových kontrakciách a podporuje normálnu funkciu nervového systému. Navyše sa často nazýva „anti-stresový“ vitamín, pretože má schopnosť chrániť imunitný systém. Vytamín B1 patrí do skupiny vytamínov B z názvom B-komplex.",
                Vyskyt_Strave_Symptom = "Vitamín B1 sa nachádza v týchto prírodných veciach: celé zrná, fazuľa, špenát, kapusta, droždie, orechy, slnečnicové semená, bravčové mäso a červené mäso.",
                Upozornenia_Symptom = "Vitamínom B1 sa dá fakt len výnimočne predávkovať. Telo ho vylúčuje v moči.",
                Davkovanie_Symptom = "Odporúčaná denná výživová dávky (RDA) tiamínu je: \nDojčatá 0-6 mesiacov - 0,2 mg; \nDojčatá 7-12 mesiacov - 0,3 mg; \ndeti 1-3 rokov - 0,5 mg; \ndeti 4-8 rokov - 0,6 mg; \nchlapci 9-13 rokov - 0,9 mg; \nmuži 14 rokov a starší - 1,2 mg; \ndievčatá 9-13 rokov - 0,9 mg; \nženy 14-18 rokov - 1 mg; \nženy nad 18 rokov - 1,1 mg; \ntehotné ženy - 1,4 mg; \ndojčiace ženy - 1,5 mg."
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Zápcha",
                Popis_Symptom = "Horčík pomôže"
            });
            
            Symps.Add(new Symp
            {
                Nazov_Symptom = "Zhoršené videnie",
                ImageUrl_Symptom = "vitamin_A",
                Popis_Symptom = "Nedostatok vytamímu A môže spôsobiť:\nzhoršené videnie,\nhnačka a črevné problémy, \nhrubá koža posiata škvrnamy, \nstrata chuti, \nzastavenie rastu, \nporucha obranyschopnosti, \nšeroslepota, \nvysychanie slizníc(napr.očí – t.j.poškodená rohovka)",
                Vyskyt_Strave_Symptom = "Vitamín A nachádzame v živočíšnych produktoch ako sú pečeň, mäso, vajcia alebo rybí tuk. \nProvitamínom vitamínu A je betakarotén, z ktorého sa v tele vytvára vitamín A.\nBetakarotén nachádzame v žltooranžovej zelenine.",
                Upozornenia_Symptom = "Prejavy predávkovania vitamínom A:            nevoľnosť a vracanie, \napatia, \nsuchá koža, \npadanie vlasov, \nporuchy videnia, \nkrvácanie, \nbolesti kĺbov.",
                Davkovanie_Symptom = "Odporúčané denné dávky sú nasledovné:                   deti do 3 rokov − 0,4 mg, \ndeti 4 − 6 rokov − 0,5 mg, \ndeti 7 − 10 rokov − 0,7 mg, \ndeti a dospelí nad 10 rokov − 1 mg, \ndojčiace ženy − 1,6 mg"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Zlá nálada",
                Popis_Symptom = "Zinok pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Zlá sustredenosť",
                Popis_Symptom = "Zinok pomôže"
            });
            
            Symps.Add(new Symp
            {
                Nazov_Symptom = "Zlá zrážanlivosť krvi",
                Popis_Symptom = "K pomôže"
            });
        }
    }
}
