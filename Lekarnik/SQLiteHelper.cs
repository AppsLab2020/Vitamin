using System.Collections.Generic;
using System.Threading.Tasks;
using Lekarnik.Models;
using SQLite;
using Lekarnik.Views;

namespace Lekarnik.Views
{
    public class SQLiteHelper
    {
        SQLiteAsyncConnection db;
        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Person>().Wait();
        }

        //Insert and Update new record  
        public Task<int> SaveItemAsync(Person person)
        {
            if (person.PersonID != 0)
            {
                return db.UpdateAsync(person);
            }
            else
            {
                return db.InsertAsync(person);
            }
        }

        //Delete  
        public Task<int> DeleteItemAsync(Person person)
        {
            return db.DeleteAsync(person);
        }

        //Read All Items  
        public Task<List<Person>> GetItemsAsync()
        {
            return db.Table<Person>().ToListAsync();
        }


        //Read Item  
        public Task<Person> GetItemAsync(int personId)
        {
            return db.Table<Person>().Where(i => i.PersonID == personId).FirstOrDefaultAsync();
        }
        public Task<int> SumItemAsync()
        {
            try
            {
                var g = db.ExecuteScalarAsync<int>("Select SUM (Piece) from Person");
                return g;
            }
            catch
            {
                return null;
            }
        }
    }
}