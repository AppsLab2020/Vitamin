using SQLite;
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

        public int Notes
        {
            get
            {
                var a = Constants.DatabasePath1.SumItemAsync();
                return a.Result;
            }
            set { }
        }
    }
}
