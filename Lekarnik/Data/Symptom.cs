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
                Popis_Symptom = "B1 pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Únava ",
                Popis_Symptom = "B1 pomôže ale H pomôže"
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
                Popis_Symptom = "B2 pomôže"
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
                Popis_Symptom = "H pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "Depresia",
                Popis_Symptom = "H pomôže"
            });

            Symps.Add(new Symp
            {
                Nazov_Symptom = "BOlesť svalov",
                Popis_Symptom = "H pomôže"
            });
        }
    }
}
