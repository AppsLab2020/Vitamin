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
                ImageUrl_Symptom = "vitamin_Zinok",
                Popis_Symptom = "Prejavi nedostatku zinku: \nzvýšená náchylnosť na infekcie (oslabená imunita), \nzhoršené hojenie rán, \nvypadávanie vlasov, \nporuchy videnia (šeroslepota), \nneprestávajúca hnačka, \npsychická nerovnováha (depresívna nálada), \nporuchy vnímania chuti. \n\nZinok je dôležitým stopovým prvkom, ktorý sa podieľa na metabolizme makroživín, sacharidov, bielkovín, mastných kyselín a nachádza sa takmer vo všetkých orgánoch. Zinok je kľúčový prvok pre viac ako 300 biochemických reakcií v našom tele vrátane nervových funkcií a dôležitú úlohu hrá tiež v raste a delení buniek či pri syntéze DNA.",
                Vyskyt_Strave_Symptom = "Zinok sa nachádza v týchto potravinách:(mäso, pečeň, vajcia), celozrnných obilninách, strukovinách, koreňovej zelenine alebo v droždí či tekvicových semienkach",
                Upozornenia_Symptom = "Predávkovanie zinkom prijímaným z bežnej stravy je takmer nemožné, pretože ho naše telo pomerne dosť samo vylúči. V takom prípade dochádza k narušeniu metabolizmu medi - to môže viesť k príznakom vzniku anémie.",
                Davkovanie_Symptom = "Odporúčaná denná dávka:                                                          Dojčatá 0-6 mesiacov – 2 mg, \nDojčatá 7-12 mesiacov – 3 mg, \nDeti 1-3 rokov – 4 mg, \nDeti 4-6 rokov – 5 mg, \nDeti 7-10 rokov – 7 mg, \nChlapci 11 - 14 rokov – 10 mg, \nDievčatá 11 -  14 rokov – 10 mg, \nChlapci 15 - 18 rokov – 12 mg, \nDievčatá 15 - 18 rokov – 9 mg, \nMuži – 14 mg, \nŽeny  - 10 mg, \nTehotné ženy – 11 mg, \nDojčiace ženy - 12 mg."
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Bledosť",
                ImageUrl_Symptom = "vitamin_Zelezo",
                Popis_Symptom = "Nedostatok železa sa prejavuje: \nchudokrvnosť, \nbiela a nezdravá farba kože, \nlámanie nechtov, \nochorenie kože a slizníc, \núnava, \nporuchy rastu. \n\nŽelezo patrí medzi tzv. stopové prvky. Stopové preto, že náš organizmus ich potrebuje v pomerne malom množstve. Potrebujeme ho predovšetkým pre transport kyslíka po tele.",
                Vyskyt_Strave_Symptom = "Železo sa nachádza v týchto potravinách: morské plody, špenát, pečeň a iné vnútorné orgány, strukoviny, červené mäso, tekvicové semiačka, quinoa, morčacie mäso, brokolica, tofu, horká čokoláda, ryby.",
                Upozornenia_Symptom = "Nadbytok železa sa prejavuje: hnačkou, zvracaním, krvou v stolici.",
                Davkovanie_Symptom = "Odporúčaná denná dávka:                                                            Dojčatá 0-6 mesiacov – 7 mg, \nDojčatá 7-12 mesiacov – 10 mg, \nDeti 1-3 rokov – 8 mg, \nDeti 4-6 rokov – 9 mg, \nDeti 7-10 rokov – 10 mg, \nChlapci 11 - 14 rokov – 12 mg, \nDievčatá 11 -  14 rokov – 16 mg, \nChlapci 15 - 18 rokov – 12 mg, \nDievčatá 15 - 18 rokov – 15 mg, \nMuži – 11 mg, \nŽeny  - 17 mg, \nTehotné ženy – 30 mg, \nDojčiace ženy - 22 mg"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Bolesť kĺbov",
                ImageUrl_Symptom = "vitamin_C",
                Popis_Symptom = "Nedostatok vitamínu C môže spôsobiť:  krvácanie z nosa alebo z ďasien, časté modriny, pomalé hojenie rán, bolesť kĺbov, anémia, suché vlasy a suchá pokožka, únava, náchylnosť na infekcie, znížená imunita. \n\nVitamín C (kyselina askorbová) je jedným z najdôležitejších vitamínov v našom tele. Má antioxidačné účinky, podieľa sa na tvorbe hormónov, znižuje hladinu cholesterolu, je nevyhnutný pre svaly, kosti, cievy i kožu.",
                Vyskyt_Strave_Symptom = "Vitamín C sa nachádza v čerstvom ovocí a zelenine, hlavne v: brokolici, rakytníku, červenej paprike, černiciach.",
                Upozornenia_Symptom = "Prejavy predávkovania vitamínu C:                      alergické reakcie, \nnevoľnosť, \nzažívacie ťažkosti.",
                Davkovanie_Symptom = "Odporúčaná denná dávka Vitaminu C je:              adeti 0-3 rokov - 50 mg, \nadeti 0-6 rokov - 60 mg, \nadeti 7-10 rokov - 65 mg, \nachlapci 11-18 rokov - 80 mg, \namuži 18 a starší - 100 mg, \nadievčatá 11-18 rokov - 70 mg, \naženy 18 a staršie - 90 mg, \nagravidné ženy - 95 mg, \nadojčiace ženy - 130 mg. \n\nPríčinou môže byť aj nedostatok draslíka.",
                ImageUrlTwo ="vitamin_Vapnik",
                NumberTwo = "Príznaky ktoré symbolizuju nedostatok vápnika: \nosteoporóza, \nzvýšená hladina cholesterolu, \nzubný kaz, \nzápalové ochorenia, \nsvalové kŕče, \nnervozita, \nduševné ťažkosti, \nzvýšená lámavosť nechtov a \nsuchá pokožka. \n\nVápnik je prvok z radu tzv. kovov alkalických zemín. V našom tele sa vyskytuje vo veľkom množstve, každý ho máme približne kilogram. A je veľmi dôležitý, predovšetkým preto, že tvorí základ kostí a zubov. V kostiach máme až 99% z celkového množstva vápnika v našom tele. Mimo to sa ale podieľa na srdcovej činnosti, regulácii nervosvalovej činnosti. \n\nVápnik sa najviac vyskytuje v týchto potravinách: v maku, v mlieku, v syroch, brokolici, vo vajciach, orechoch a rôznych semienkach, ale aj vo vode (v prípade tzv. tvrdej vody) alebo zelenom čaji. \n\n Predávkovanie vápnikom sa môže preukázať: Nevoľnosťou - vracaním, kovovou pachuťou v ústach, bledosťou. Bolesťami hlavy a poruchami vedomia, bolesťou a slabosťou končatín. Ale aj postihnutím obličiek, poruchami vedomia a v extrémnom prípade zástavou srdca. \n \n Odporúčaná denná dávka:                                                          Dojčatá 0-6 mesiacov – 300 mg, \nDojčatá 7-12 mesiacov – 400 mg, \nDeti 1-3 rokov – 600 mg, \nDeti 4-6 rokov – 700 mg, \nDeti 7-10 rokov – 900 mg, \nChlapci 11 -  14 rokov – 1200 mg, \nDievčatá 11 -  14 rokov – 1300 mg, \nChlapci 15 -  18 rokov – 1400 mg, \nDievčatá 15 -  18 rokov – 1300 mg, \nMuži – 1200 mg, \nŽeny  - 1100 mg, \nTehotné ženy – 1400 mg, \nDojčiace ženy - 1600 mg."
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
                ImageUrl_Symptom = "vitamin_H",
                Popis_Symptom = "Nedostatok bitamínu H môže spôsobiť: \nbolesť svalov, \ndepresie, \nnaspavosť, \nvypadáavanie vlasov, \nmravčenie končatín. \n\nVitamín H(Biotín) zasahuje do metabolizmu cukrov, tukov i aminokyselín. Je dôležitý pre vznik energie v tele a spracovanie odpadových látok. Hrá úlohu aj v prenose oxidu uhličitého a pre udržanie stálej hladiny krvného cukru.",
                Vyskyt_Strave_Symptom = "K najbohatším a najčastejším zdrojom, v ktorých biotín prijímame, patria: žĺtky, hovädzie mäso, sója, orechy, obilniny, mlieko, kvasnice, pečeň a obličky.",
                Upozornenia_Symptom = "Predávkovanie biotínom je tiež pomerne ojedinelé, ide o vo vode rozpustný vitamín a jeho nadbytok je vylúčený močom. Predavkovanie však môže spôsobiť nevoľnosť, bolesti hlavy a brucha",
                Davkovanie_Symptom = "Odporúčaná denná dávka:                                            0-6 mesiacov - 5 µg, \n7 - 12 mesiacov - 6 µg, \n1 - 3 rokov - 8 µg, \n4 - 8 rokov - 12 µg, \n9 - 14 rokov - 20 µg, \n15 - 18 rokov - 25 µg, \nženy - 30 µg, \nmuži - 30 µg, \nženy tehotné - 30 µg, \nženy kojacie - 35 µg."
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
                ImageUrl_Symptom = "vitamin_H",
                Popis_Symptom = "Nedostatok bitamínu H môže spôsobiť: \nbolesť svalov, \ndepresie, \nnaspavosť, \nvypadáavanie vlasov, \nmravčenie končatín. \n\nVitamín H(Biotín) zasahuje do metabolizmu cukrov, tukov i aminokyselín. Je dôležitý pre vznik energie v tele a spracovanie odpadových látok. Hrá úlohu aj v prenose oxidu uhličitého a pre udržanie stálej hladiny krvného cukru.",
                Vyskyt_Strave_Symptom = "K najbohatším a najčastejším zdrojom, v ktorých biotín prijímame, patria: žĺtky, hovädzie mäso, sója, orechy, obilniny, mlieko, kvasnice, pečeň a obličky.",
                Upozornenia_Symptom = "Predávkovanie biotínom je tiež pomerne ojedinelé, ide o vo vode rozpustný vitamín a jeho nadbytok je vylúčený močom. Predavkovanie však môže spôsobiť nevoľnosť, bolesti hlavy a brucha",
                Davkovanie_Symptom = "Odporúčaná denná dávka:                                            0-6 mesiacov - 5 µg, \n7 - 12 mesiacov - 6 µg, \n1 - 3 rokov - 8 µg, \n4 - 8 rokov - 12 µg, \n9 - 14 rokov - 20 µg, \n15 - 18 rokov - 25 µg, \nženy - 30 µg, \nmuži - 30 µg, \nženy tehotné - 30 µg, \nženy kojacie - 35 µg."
            });

            Symps.Add(new Symp
            {
               Nazov_Symptom = "Hnačky a črevné problémy",
               ImageUrl_Symptom = "vitamin_A",
               Popis_Symptom = "Nedostatok vytamímu A môže spôsobiť:\nzhoršené videnie,\nhnačka a črevné problémy, \nhrubá koža posiata škvrnamy, \nstrata chuti, \nzastavenie rastu, \nporucha obranyschopnosti, \nšeroslepota, \nvysychanie slizníc(napr.očí – t.j.poškodená rohovka)",
               Vyskyt_Strave_Symptom = "Vitamín A nachádzame v živočíšnych produktoch ako sú pečeň, mäso, vajcia alebo rybí tuk. \nProvitamínom vitamínu A je betakarotén, z ktorého sa v tele vytvára vitamín A.\nBetakarotén nachádzame v žltooranžovej zelenine.",
               Upozornenia_Symptom = "Prejavy predávkovania vitamínom A:            nevoľnosť a vracanie, \napatia, \nsuchá koža, \npadanie vlasov, \nporuchy videnia, \nkrvácanie, \nbolesti kĺbov.",
               Davkovanie_Symptom = "Odporúčaná denná dávka:                                                            Dojčatá 0-6 mesiacov – 250 μg, \nDojčatá 7-12 mesiacov – 250 μg, \nDeti 1-3 rokov – 250 μg, \nDeti 4-6 rokov – 300 μg, \nDeti 7-10 rokov – 400 μg, \nChlapci 11 - 14 rokov – 600 μg, \nDievčatá 11 -  14 rokov – 600 μg, \nChlapci 15 - 18 rokov – 750 μg, \nDievčatá 15 - 18 rokov – 650 μg, \nMuži – 900 μg, \nŽeny - 800 μg, \nTehotné ženy – 700 μg, \nDojčiace ženy - 1300 μg"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Chudokrvnosť",
                ImageUrl_Symptom = "vitamin_Zelezo",
                Popis_Symptom = "Nedostatok železa sa prejavuje: \nchudokrvnosť, \nbiela a nezdravá farba kože, \nlámanie nechtov, \nochorenie kože a slizníc, \núnava, \nporuchy rastu. \n\nŽelezo patrí medzi tzv. stopové prvky. Stopové preto, že náš organizmus ich potrebuje v pomerne malom množstve. Potrebujeme ho predovšetkým pre transport kyslíka po tele.",
                Vyskyt_Strave_Symptom = "Železo sa nachádza v týchto potravinách: morské plody, špenát, pečeň a iné vnútorné orgány, strukoviny, červené mäso, tekvicové semiačka, quinoa, morčacie mäso, brokolica, tofu, horká čokoláda, ryby.",
                Upozornenia_Symptom = "Nadbytok železa sa prejavuje: hnačkou, zvracaním, krvou v stolici.",
                Davkovanie_Symptom = "Odporúčaná denná dávka:                                                            Dojčatá 0-6 mesiacov – 7 mg, \nDojčatá 7-12 mesiacov – 10 mg, \nDeti 1-3 rokov – 8 mg, \nDeti 4-6 rokov – 9 mg, \nDeti 7-10 rokov – 10 mg, \nChlapci 11 - 14 rokov – 12 mg, \nDievčatá 11 -  14 rokov – 16 mg, \nChlapci 15 - 18 rokov – 12 mg, \nDievčatá 15 - 18 rokov – 15 mg, \nMuži – 11 mg, \nŽeny  - 17 mg, \nTehotné ženy – 30 mg, \nDojčiace ženy - 22 mg"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Infekcie",
                ImageUrl_Symptom = "vitamin_Zinok",
                Popis_Symptom = "Prejavi nedostatku zinku: \nzvýšená náchylnosť na infekcie (oslabená imunita), \nzhoršené hojenie rán, \nvypadávanie vlasov, \nporuchy videnia (šeroslepota), \nneprestávajúca hnačka, \npsychická nerovnováha (depresívna nálada), \nporuchy vnímania chuti. \n\nZinok je dôležitým stopovým prvkom, ktorý sa podieľa na metabolizme makroživín, sacharidov, bielkovín, mastných kyselín a nachádza sa takmer vo všetkých orgánoch. Zinok je kľúčový prvok pre viac ako 300 biochemických reakcií v našom tele vrátane nervových funkcií a dôležitú úlohu hrá tiež v raste a delení buniek či pri syntéze DNA.",
                Vyskyt_Strave_Symptom = "Zinok sa nachádza v týchto potravinách:(mäso, pečeň, vajcia), celozrnných obilninách, strukovinách, koreňovej zelenine alebo v droždí či tekvicových semienkach",
                Upozornenia_Symptom = "Predávkovanie zinkom prijímaným z bežnej stravy je takmer nemožné, pretože ho naše telo pomerne dosť samo vylúči. V takom prípade dochádza k narušeniu metabolizmu medi - to môže viesť k príznakom vzniku anémie.",
                Davkovanie_Symptom = "Odporúčaná denná dávka:                                                          Dojčatá 0-6 mesiacov – 2 mg, \nDojčatá 7-12 mesiacov – 3 mg, \nDeti 1-3 rokov – 4 mg, \nDeti 4-6 rokov – 5 mg, \nDeti 7-10 rokov – 7 mg, \nChlapci 11 - 14 rokov – 10 mg, \nDievčatá 11 -  14 rokov – 10 mg, \nChlapci 15 - 18 rokov – 12 mg, \nDievčatá 15 - 18 rokov – 9 mg, \nMuži – 14 mg, \nŽeny  - 10 mg, \nTehotné ženy – 11 mg, \nDojčiace ženy - 12 mg."
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Kazivosť zubov",
                ImageUrl_Symptom = "vitamin_Vapnik",
                Popis_Symptom = "Príznaky ktoré symbolizuju nedostatok vápnika: \nosteoporóza, \nzvýšená hladina cholesterolu, \nzubný kaz, \nzápalové ochorenia, \nsvalové kŕče, \nnervozita, \nduševné ťažkosti, \nzvýšená lámavosť nechtov a \nsuchá pokožka. \n\nVápnik je prvok z radu tzv. kovov alkalických zemín. V našom tele sa vyskytuje vo veľkom množstve, každý ho máme približne kilogram. A je veľmi dôležitý, predovšetkým preto, že tvorí základ kostí a zubov. V kostiach máme až 99% z celkového množstva vápnika v našom tele. Mimo to sa ale podieľa na srdcovej činnosti, regulácii nervosvalovej činnosti.",
                Vyskyt_Strave_Symptom = "Vápnik sa najviac vyskytuje v týchto potravinách: v maku, v mlieku, v syroch, brokolici, vo vajciach, orechoch a rôznych semienkach, ale aj vo vode (v prípade tzv. tvrdej vody) alebo zelenom čaji.",
                Upozornenia_Symptom = "Predávkovanie vápnikom sa môže preukázať: Nevoľnosťou - vracaním, kovovou pachuťou v ústach, bledosťou. Bolesťami hlavy a poruchami vedomia, bolesťou a slabosťou končatín. Ale aj postihnutím obličiek, poruchami vedomia a v extrémnom prípade zástavou srdca.",
                Davkovanie_Symptom = "Odporúčaná denná dávka:                                                          Dojčatá 0-6 mesiacov – 300 mg, \nDojčatá 7-12 mesiacov – 400 mg, \nDeti 1-3 rokov – 600 mg, \nDeti 4-6 rokov – 700 mg, \nDeti 7-10 rokov – 900 mg, \nChlapci 11 -  14 rokov – 1200 mg, \nDievčatá 11 -  14 rokov – 1300 mg, \nChlapci 15 -  18 rokov – 1400 mg, \nDievčatá 15 -  18 rokov – 1300 mg, \nMuži – 1200 mg, \nŽeny  - 1100 mg, \nTehotné ženy – 1400 mg, \nDojčiace ženy - 1600 mg."
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Koža posiatá škvrnami ",
                ImageUrl_Symptom = "vitamin_A",
                Popis_Symptom = "Nedostatok vytamímu A môže spôsobiť:\nzhoršené videnie,\nhnačka a črevné problémy, \nhrubá koža posiata škvrnamy, \nstrata chuti, \nzastavenie rastu, \nporucha obranyschopnosti, \nšeroslepota, \nvysychanie slizníc(napr.očí – t.j.poškodená rohovka)",
                Vyskyt_Strave_Symptom = "Vitamín A nachádzame v živočíšnych produktoch ako sú pečeň, mäso, vajcia alebo rybí tuk. \nProvitamínom vitamínu A je betakarotén, z ktorého sa v tele vytvára vitamín A.\nBetakarotén nachádzame v žltooranžovej zelenine.",
                Upozornenia_Symptom = "Prejavy predávkovania vitamínom A:            nevoľnosť a vracanie, \napatia, \nsuchá koža, \npadanie vlasov, \nporuchy videnia, \nkrvácanie, \nbolesti kĺbov.",
                Davkovanie_Symptom = "Odporúčaná denná dávka:                                                            Dojčatá 0-6 mesiacov – 250 μg, \nDojčatá 7-12 mesiacov – 250 μg, \nDeti 1-3 rokov – 250 μg, \nDeti 4-6 rokov – 300 μg, \nDeti 7-10 rokov – 400 μg, \nChlapci 11 - 14 rokov – 600 μg, \nDievčatá 11 -  14 rokov – 600 μg, \nChlapci 15 - 18 rokov – 750 μg, \nDievčatá 15 - 18 rokov – 650 μg, \nMuži – 900 μg, \nŽeny - 800 μg, \nTehotné ženy – 700 μg, \nDojčiace ženy - 1300 μg"
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
                Davkovanie_Symptom = "Odporúčaná denná dávka:                                                            Dojčatá 0-6 mesiacov – 0,2 mg, \nDojčatá 7-12 mesiacov – 0,4 mg, \nDeti 1-3 rokov – 0,6 mg, \nDeti 4-6 rokov – 0,8 mg, \nDeti 7-10 rokov – 1,2 mg, \nChlapci 11 - 14 rokov – 1,4 mg, \nDievčatá 11 -  14 rokov – 1,6 mg, \nChlapci 15 - 18 rokov – 1,8 mg, \nDievčatá 15 - 18 rokov – 1,7 mg, \nMuži – 1,7 mg, \nŽeny - 1,5 mg, \nTehotné ženy – 1,9 mg, \nDojčiace ženy - 1,9 mg"
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
                ImageUrl_Symptom = "vitamin_draslik",
                Popis_Symptom = "Nedostatok dralíku môže spôsobiť: \npleť plnú akné, \nzápchu, \nnervozitu, \núnavu, \nnespalosť a nekvalitný spánok, \nnesústredenosť a zlú pamäť, \nsvalové kŕče alebo slabosť, \nzvýšenie rizika cukrovky a inzulínovej rezistencie, \nrednutie kostí a bolesť kĺbov, \nzvýšený krvný tlak, \nnesprávnu hladinu pH v tele, \nzvýšené riziko vzniku obličkových kameňov, \nzvýšené riziko srdcových ochorení a mŕtvice. \n\nDraslík je dôležitý pre správne fungovanie nervovej sústavy, svalov a udržanie normálneho tlaku krvi.",
                Vyskyt_Strave_Symptom = "Potraviny v ktorých sa nachádza draslík: banány, zemiaky, sušené marhule, pomarančový džús, chudé mäso, mlieko, strukoviny, kokosová voda, ale aj čierny čaj alebo káva.",
                Upozornenia_Symptom = "Príznakmi predávkovania draslíkom sú:                     slabosť, \npocit ťažoby vo svaloch, \narytmia srdca až kolaps.",
                Davkovanie_Symptom = "Odporúčaná denná dávka:                                             deti do 1 roku - 300 až 1000 mg, \ndeti 1 - 18 rokov - 1000 až 3000 mg, \nmuži a ženy nad 18 rokov 3000 až 4000 mg."
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
                Davkovanie_Symptom = "Odporúčaná denná dávka:                                                            Dojčatá 0-6 mesiacov – 0,2 mg, \nDojčatá 7-12 mesiacov – 0,4 mg, \nDeti 1-3 rokov – 0,6 mg, \nDeti 4-6 rokov – 0,8 mg, \nDeti 7-10 rokov – 1,2 mg, \nChlapci 11 - 14 rokov – 1,4 mg, \nDievčatá 11 -  14 rokov – 1,6 mg, \nChlapci 15 - 18 rokov – 1,8 mg, \nDievčatá 15 - 18 rokov – 1,7 mg, \nMuži – 1,7 mg, \nŽeny - 1,5 mg, \nTehotné ženy – 1,9 mg, \nDojčiace ženy - 1,9 mg"
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
                ImageUrl_Symptom = "vitamin_draslik",
                Popis_Symptom = "Nedostatok dralíku môže spôsobiť: \npleť plnú akné, \nzápchu, \nnervozitu, \núnavu, \nnespalosť a nekvalitný spánok, \nnesústredenosť a zlú pamäť, \nsvalové kŕče alebo slabosť, \nzvýšenie rizika cukrovky a inzulínovej rezistencie, \nrednutie kostí a bolesť kĺbov, \nzvýšený krvný tlak, \nnesprávnu hladinu pH v tele, \nzvýšené riziko vzniku obličkových kameňov, \nzvýšené riziko srdcových ochorení a mŕtvice. \n\nDraslík je dôležitý pre správne fungovanie nervovej sústavy, svalov a udržanie normálneho tlaku krvi.",
                Vyskyt_Strave_Symptom = "Potraviny v ktorých sa nachádza draslík: banány, zemiaky, sušené marhule, pomarančový džús, chudé mäso, mlieko, strukoviny, kokosová voda, ale aj čierny čaj alebo káva.",
                Upozornenia_Symptom = "Príznakmi predávkovania draslíkom sú:                     slabosť, \npocit ťažoby vo svaloch, \narytmia srdca až kolaps.",
                Davkovanie_Symptom = "Odporúčaná denná dávka:                                             deti do 1 roku - 300 až 1000 mg, \ndeti 1 - 18 rokov - 1000 až 3000 mg, \nmuži a ženy nad 18 rokov 3000 až 4000 mg."
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
                ImageUrl_Symptom = "vitamin_Zelezo",
                Popis_Symptom = "Nedostatok železa sa prejavuje: \nchudokrvnosť, \nbiela a nezdravá farba kože, \nlámanie nechtov, \nochorenie kože a slizníc, \núnava, \nporuchy rastu. \n\nŽelezo patrí medzi tzv. stopové prvky. Stopové preto, že náš organizmus ich potrebuje v pomerne malom množstve. Potrebujeme ho predovšetkým pre transport kyslíka po tele.",
                Vyskyt_Strave_Symptom = "Železo sa nachádza v týchto potravinách: morské plody, špenát, pečeň a iné vnútorné orgány, strukoviny, červené mäso, tekvicové semiačka, quinoa, morčacie mäso, brokolica, tofu, horká čokoláda, ryby.",
                Upozornenia_Symptom = "Nadbytok železa sa prejavuje: hnačkou, zvracaním, krvou v stolici.",
                Davkovanie_Symptom = "Odporúčaná denná dávka:                                                            Dojčatá 0-6 mesiacov – 7 mg, \nDojčatá 7-12 mesiacov – 10 mg, \nDeti 1-3 rokov – 8 mg, \nDeti 4-6 rokov – 9 mg, \nDeti 7-10 rokov – 10 mg, \nChlapci 11 - 14 rokov – 12 mg, \nDievčatá 11 -  14 rokov – 16 mg, \nChlapci 15 - 18 rokov – 12 mg, \nDievčatá 15 - 18 rokov – 15 mg, \nMuži – 11 mg, \nŽeny  - 17 mg, \nTehotné ženy – 30 mg, \nDojčiace ženy - 22 mg"
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
                ImageUrl_Symptom = "vitamin_draslik",
                Popis_Symptom = "Nedostatok dralíku môže spôsobiť: \npleť plnú akné, \nzápchu, \nnervozitu, \núnavu, \nnespalosť a nekvalitný spánok, \nnesústredenosť a zlú pamäť, \nsvalové kŕče alebo slabosť, \nzvýšenie rizika cukrovky a inzulínovej rezistencie, \nrednutie kostí a bolesť kĺbov, \nzvýšený krvný tlak, \nnesprávnu hladinu pH v tele, \nzvýšené riziko vzniku obličkových kameňov, \nzvýšené riziko srdcových ochorení a mŕtvice. \n\nDraslík je dôležitý pre správne fungovanie nervovej sústavy, svalov a udržanie normálneho tlaku krvi.",
                Vyskyt_Strave_Symptom = "Potraviny v ktorých sa nachádza draslík: banány, zemiaky, sušené marhule, pomarančový džús, chudé mäso, mlieko, strukoviny, kokosová voda, ale aj čierny čaj alebo káva.",
                Upozornenia_Symptom = "Príznakmi predávkovania draslíkom sú:                     slabosť, \npocit ťažoby vo svaloch, \narytmia srdca až kolaps.",
                Davkovanie_Symptom = "Odporúčaná denná dávka:                                             deti do 1 roku - 300 až 1000 mg, \ndeti 1 - 18 rokov - 1000 až 3000 mg, \nmuži a ženy nad 18 rokov 3000 až 4000 mg."
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Zhoršené videnie",
                ImageUrl_Symptom = "vitamin_A",
                Popis_Symptom = "Nedostatok vytamímu A môže spôsobiť:\nzhoršené videnie,\nhnačka a črevné problémy, \nhrubá koža posiata škvrnamy, \nstrata chuti, \nzastavenie rastu, \nporucha obranyschopnosti, \nšeroslepota, \nvysychanie slizníc(napr.očí – t.j.poškodená rohovka)",
                Vyskyt_Strave_Symptom = "Vitamín A nachádzame v živočíšnych produktoch ako sú pečeň, mäso, vajcia alebo rybí tuk. \nProvitamínom vitamínu A je betakarotén, z ktorého sa v tele vytvára vitamín A.\nBetakarotén nachádzame v žltooranžovej zelenine.",
                Upozornenia_Symptom = "Prejavy predávkovania vitamínom A:            nevoľnosť a vracanie, \napatia, \nsuchá koža, \npadanie vlasov, \nporuchy videnia, \nkrvácanie, \nbolesti kĺbov.",
                Davkovanie_Symptom = "Odporúčaná denná dávka:                                                            Dojčatá 0-6 mesiacov – 250 μg, \nDojčatá 7-12 mesiacov – 250 μg, \nDeti 1-3 rokov – 250 μg, \nDeti 4-6 rokov – 300 μg, \nDeti 7-10 rokov – 400 μg, \nChlapci 11 - 14 rokov – 600 μg, \nDievčatá 11 -  14 rokov – 600 μg, \nChlapci 15 - 18 rokov – 750 μg, \nDievčatá 15 - 18 rokov – 650 μg, \nMuži – 900 μg, \nŽeny - 800 μg, \nTehotné ženy – 700 μg, \nDojčiace ženy - 1300 μg"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Zlá nálada",
                ImageUrl_Symptom = "vitamin_Horcik",
                Popis_Symptom = "Príznaky nedostatku horčíka: \nzlá nálada, \núnava, \nstrata chuti do jedla, \nnevoľnosť, \nsvalové kŕče, \ntŕpnutie končatín, \nsvalové kontrakcie.\n\nHorčík (magnézium) je jeden z hlavných minerálov nevyhnutných pre fungovanie nášho tela. Horčík sa v organizme nachádza v kostiach (až približne 70 % z jeho celkového množstva), v svaloch (27 %), mäkkých tkanivách a v telových tekutinách (vrátane krvi).\n\nMedzi funkcie horčíka v tele patrí: \nTvorba energie – pomáha konvertovať prijatú potravu na energiu, \nTvorba proteínov – pomáha vytvárať nové proteíny z prijatých aminokyselín, \nÚdržba génov – pomáha vytvoriť a opraviť DNA a RNA, \nPohyb svalstva – zúčastňuje sa kontrakcie a relaxácie svalov, \nRegulácia nervového systému – pomáha regulovať tzv. neurotransmitery, teda látky, ktoré posielajú správy prostredníctvom mozgu a nervového systému.",
                Vyskyt_Strave_Symptom = "Potraviny bohaté na horčík: strukoviny – fazuľa, hrach, sója, zelenina - listová zelenina, brokolica, tekvica..., ovocie – banány, marhule, ananás, jablká...., semienka a orechy – najmä mandle, mliečne výrobky – jogurt, maslo, syr...., mäso, čokoláda, káva, minerálne vody – najmä tie s vysokým obsahom minerálnych látok.",
                Upozornenia_Symptom = "Predávkovanie sa horčíkom je viac-menej nemožné. Telo si reguluje jeho hladinu podľa potrieb a jeho nabytok vylúči močom, stolicou alebo potom. Nadbytok horčíka teda môže spôsobiť v takom prípade hnačku.",
                Davkovanie_Symptom = "Odporúčaná denná dávka:                                                          Dojčatá 0-6 mesiacov – 30 mg, \nDojčatá 7-12 mesiacov – 60 mg, \nDeti 1-3 rokov – 80 mg, \nDeti 4-6 rokov – 120 mg, \nDeti 7-10 rokov – 200 mg, \nChlapci 11 -  14 rokov – 300 mg, \nDievčatá 11 -  14 rokov – 330 mg, \nChlapci 15 -  18 rokov – 400 mg, \nDievčatá 15 -  18 rokov – 350 mg, \nMuži – 400 mg, \nŽeny  - 320 mg, \nTehotné ženy – 350 mg, \nDojčiace ženy - 330 mg."
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Zlá sustredenosť",
                ImageUrl_Symptom = "vitamin_Zinok",
                Popis_Symptom = "Prejavi nedostatku zinku: \nzvýšená náchylnosť na infekcie (oslabená imunita), \nzhoršené hojenie rán, \nvypadávanie vlasov, \nporuchy videnia (šeroslepota), \nneprestávajúca hnačka, \npsychická nerovnováha (depresívna nálada), \nporuchy vnímania chuti. \n\nZinok je dôležitým stopovým prvkom, ktorý sa podieľa na metabolizme makroživín, sacharidov, bielkovín, mastných kyselín a nachádza sa takmer vo všetkých orgánoch. Zinok je kľúčový prvok pre viac ako 300 biochemických reakcií v našom tele vrátane nervových funkcií a dôležitú úlohu hrá tiež v raste a delení buniek či pri syntéze DNA.",
                Vyskyt_Strave_Symptom = "Zinok sa nachádza v týchto potravinách:(mäso, pečeň, vajcia), celozrnných obilninách, strukovinách, koreňovej zelenine alebo v droždí či tekvicových semienkach",
                Upozornenia_Symptom = "Predávkovanie zinkom prijímaným z bežnej stravy je takmer nemožné, pretože ho naše telo pomerne dosť samo vylúči. V takom prípade dochádza k narušeniu metabolizmu medi - to môže viesť k príznakom vzniku anémie.",
                Davkovanie_Symptom = "Odporúčaná denná dávka:                                                          Dojčatá 0-6 mesiacov – 2 mg, \nDojčatá 7-12 mesiacov – 3 mg, \nDeti 1-3 rokov – 4 mg, \nDeti 4-6 rokov – 5 mg, \nDeti 7-10 rokov – 7 mg, \nChlapci 11 - 14 rokov – 10 mg, \nDievčatá 11 -  14 rokov – 10 mg, \nChlapci 15 - 18 rokov – 12 mg, \nDievčatá 15 - 18 rokov – 9 mg, \nMuži – 14 mg, \nŽeny  - 10 mg, \nTehotné ženy – 11 mg, \nDojčiace ženy - 12 mg."
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Zlá zrážanlivosť krvi",
                ImageUrl_Symptom = "vitamin_K",
                Popis_Symptom = "Príznaky nedostatku vitaminu K: \nvápenatenie tepien, \nmozgové problémy, \nosteoporóza, \nzubné kazy, \ninfekčné choroby, napr. zápal pľúc, \nkrvácanie z nosa, ďasien, \nľahká tvorba modrín, \nznížená imunita, \nznížená zrážanlivosť krvi, \nlámavosť kostí. \n\nĽudské telo dokáže premeniť vitamín K1 na K2, čo je veľmi dôležité, pretože K1 je výrazne viac obsiahnutý v strave.",
                Vyskyt_Strave_Symptom = "Vitamíny K1 a K2 obsahuje: listová a koreňová zelenina, brokolica a karfiol, paradajky, papriky, uhorky, obilniny - ovos, raž, pšenica, sója, strukoviny – fazuľa, hrach, šošovica, zelený čaj, žihľava, vajcia a mäso, orechy, sójový a olivový olej, tvrdé a mäkké syry, surové maslo, kefír, kyslá kapusta.",
                Upozornenia_Symptom = "Pri vitamíne K nie sú nejaké vedľajšie účinky. Pri predávkovaní škodí len ľuďom, ktorí majú problém so zrážanlivosťou krvi. Vtedy to môže vitamín K zhoršiť.",
                Davkovanie_Symptom = "Odporúčaná denná dávka:                                          Dojčatá 0-6 mesiacov – 2 µg, \nDojčatá 6-12 mesiacov - 2,5 µg, \nDeti vo veku 1-3 roky – 30 µg, \nDeti vo veku 4-8 rokov – 55 µg, \nDeti vo veku 9-13 rokov – 60 µg, \nDospievajúci vo veku 14-18 rokov – 75 µg, \nMuži nad 19 rokov – 120 µg, \nŽeny nad 19 rokov – 90 µg, \nTehotné a dojčiace ženy – 90 µg."
            });
        }
    }
}
