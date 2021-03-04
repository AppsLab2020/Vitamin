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
                Nazov_Symptom = "Zhoršené videnie",
                Popis_Symptom = "A pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Hnačky a črevné problémy",
                Popis_Symptom = "A pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Koža posiatá škvrnami ",
                Popis_Symptom = "A pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Podráždenosť",
                Popis_Symptom = "B1 pomôže a vápnik"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Únava ",
                Popis_Symptom = "B1 pomôže, H pomôže, Železo"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Strata chute do jedla",
                Popis_Symptom = "B1 pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Zbúdanie",
                Popis_Symptom = "B1 pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Pľuzgiere a kútiky",
                Popis_Symptom = "B2 pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Odlupovanie kože na tvári",
                Popis_Symptom = "B2 pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Citlivosť na svetlo",
                Popis_Symptom = "B2 pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Śklbanie vo svaloch",
                Popis_Symptom = "B2 pomôže a horčík"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Kŕče v nohách",
                Popis_Symptom = "B6 pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Nízka hladina cukru v krvi",
                Popis_Symptom = "B6 pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Nespavosť",
                Popis_Symptom = "H pomôže a draslík"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Depresia",
                Popis_Symptom = "H pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Bolesť svalov",
                Popis_Symptom = "H pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Bolesť nôh a ramien",
                Popis_Symptom = "B12 pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Mravčenie v končatinách",
                Popis_Symptom = "B12 pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Spomalené reflexy",
                Popis_Symptom = "B12 pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Problém s chôdzov",
                Popis_Symptom = "B12 pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Vypadavanie vlasov",
                Popis_Symptom = "Železo pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Bledosť",
                Popis_Symptom = "Železo pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Chudokrvnosť",
                Popis_Symptom = "Železo pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Krvácanie z nosa alebo z ďasien",
                Popis_Symptom = "C pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Časté modriny",
                Popis_Symptom = "C pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Pomalé hojenie rán",
                Popis_Symptom = "C pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Bolesť kĺbov",
                Popis_Symptom = "C pomôže a vápnik"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Lámanie nechtov",
                Popis_Symptom = "F pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Lupiny",
                Popis_Symptom = "F pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Suchá pleť",
                Popis_Symptom = "F pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Zlá zrážanlivosť krvi",
                Popis_Symptom = "K pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Infekcie",
                Popis_Symptom = "Zinok pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Biele škvrny na nechtoch",
                Popis_Symptom = "Zinok pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Zlá sustredenosť",
                Popis_Symptom = "Zinok pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Kazivosť zubov",
                Popis_Symptom = "Vámpnik pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Zlá nálada",
                Popis_Symptom = "Zinok pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Pleť plná aknév",
                Popis_Symptom = "Horčík pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Zápcha",
                Popis_Symptom = "Horčík pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Nervozita",
                Popis_Symptom = "Horčík pomôže"
            });
        }
    }
}
