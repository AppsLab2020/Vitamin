using Lekarnik.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lekarnik.Controls
{
   public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Food>().Wait();
        }

        public Task<List<Food>> GetPeopleAsync()
        {
            return _database.Table<Food>().ToListAsync();
        }

        public Task<int> SavePersonAsync(Food food)
        {
            return _database.InsertAsync(food);
        }
    }
}
