using MVVMTest.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTest.Data
{
    public class DataBaseQuery
    {
        readonly SQLiteAsyncConnection _dataBase;

        public DataBaseQuery(string dbPath)
        {
            _dataBase = new SQLiteAsyncConnection(dbPath);
            _dataBase.CreateTableAsync<User>().Wait();
        }

        #region CRUD        
        public Task<List<User>> GetUsers()
        {
            return _dataBase.QueryAsync<User>("Seelct * from user");
        }

        //Isert Update
        public Task<int> SaveUserAsync(User user)
        {
            if (user.Id != 0)
            {
                return _dataBase.UpdateAsync(user);
            }
            else
            {
                return _dataBase.InsertAsync(user);
            }
        }

        //Delete
        public Task<int> DeleteUserAsync(User user)
        {
            return _dataBase.DeleteAsync(user);
        }
        #endregion
    }
}
