﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lekarnik.Models
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Piece { get; set; }
        public int Notes {
            get
            {
                var a = Constants.DatabasePath1.SumItemAsync();
                return a.Result;
            }
            set { }
        }
      
    }
}