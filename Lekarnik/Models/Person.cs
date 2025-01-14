﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Lekarnik.Models;
using Lekarnik.Views;

namespace Lekarnik
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int PersonID { get; set; }
        public string Name { get; set; }

        public int Piece { get; set; }

        public int num_reg_totales
        {
            get
            {
                var a = App.SQLiteDb.SumItemAsync();
                return a.Result;
            }
            set { }
        }
    }
}
