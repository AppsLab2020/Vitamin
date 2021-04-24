using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Lekarnik.Models
{
    public class Food
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Piece { get; set; }
    }
}
