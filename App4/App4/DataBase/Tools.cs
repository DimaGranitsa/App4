using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;

namespace App4.DataBase
{
    public class Tools
    {
        SQLiteConnection database1;
        public Tools(string databasePath)
        {
            database1 = new SQLiteConnection(databasePath);
            database1.CreateTable<User>();
        }
        public int SaveUser(User user)
        {
            if (user.id != 0)
            {
                database1.Update(user);
                return user.id;
            }
            else
            {
                return database1.Insert(user);
            }
        }
        public IEnumerable<User> GetUsers()
        {
            return database1.Table<User>().ToList();
        }
        public User GetUser(string login, string password)
        {
            return GetUsers().Where(user => user.Login == login && user.Password == password).FirstOrDefault();
        }
    }
}
