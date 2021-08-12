using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Lekarnik
{
    public class Constants
    {
        public const string DatabaseFilename = "TodoSQLite.db3";
        static TodoItemDatabase Database1;
        public const SQLite.SQLiteOpenFlags Flags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, DatabaseFilename);
            }
        }
        public static TodoItemDatabase DatabasePath1
        { 
            get
            {
                if (Database1 == null)
                {
                    Database1 = new TodoItemDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TodoSQLite1.db3"));
                }
                return Database1;
            }
        }
    }
}
