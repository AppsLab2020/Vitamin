using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Lekarnik.Models;

namespace Lekarnik
{
    public class TodoItemDatabase
    {
        static SQLiteAsyncConnection Database;
        SQLiteAsyncConnection Database1;
       

        public static readonly AsyncLazy<TodoItemDatabase> Instance = new AsyncLazy<TodoItemDatabase>(async () =>
        {
            var instance = new TodoItemDatabase();
            CreateTableResult result = await Database.CreateTableAsync<TodoItem>();
            return instance;
        });

        public TodoItemDatabase()
        {
            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        }

        public Task<List<TodoItem>> GetItemsAsync()
        {
            return Database.Table<TodoItem>().ToListAsync();
        }
         
        public Task<List<TodoItem>> GetItemsNotDoneAsync()
        {
            return Database.QueryAsync<TodoItem>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
        }

        public Task<TodoItem> GetItemAsync(int id)
        {
            return Database.Table<TodoItem>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(TodoItem item)
        {
            if (item.ID != 0)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(TodoItem item)
        {
            return Database.DeleteAsync(item);
        }
        
        public static Task<int> DeleteAllItems<T>()
        {
            return Database.DeleteAllAsync<TodoItem>();
        }
        //spojenie databáz
        public TodoItemDatabase(string dbPath)
        {
            Database1 = new SQLiteAsyncConnection(dbPath);
            Database1.CreateTableAsync<TodoItem>().Wait();
        }
        public Task<int> SaveItemAsync2(TodoItem item)
        {
            if (item.ID != 0)
            {
                return Database1.UpdateAsync(item);
            }
            else
            {
                return Database1.InsertAsync(item);
            }
        }


        //Delete  
        public Task<int> DeleteItemAsync2(TodoItem item)
        {
            return Database1.DeleteAsync(item);
        }

        //Read All Items  
        public Task<List<TodoItem>> GetItemsAsync2()
        {
            return Database1.Table<TodoItem>().ToListAsync();
        }


        //Read Item  
        public Task<TodoItem> GetItemAsync2(int personId)
        {
            return Database1.Table<TodoItem>().Where(i => i.ID == personId).FirstOrDefaultAsync();
        }
        public Task<int> SumItemAsync()
        {
            try
            {
                var g = Database1.ExecuteScalarAsync<int>("Select SUM (Piece) from TodoItem");
                return g;
            }
            catch
            {
                return null;
            }
        }

       
        
    } 
}