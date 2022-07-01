using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Linq;

namespace App4.DataBase
{
    internal class Storage
    {
        SQLiteConnection database1;
        public Storage(string databasePath)
        {
            database1 = new SQLiteConnection(databasePath);
            database1.CreateTable<Project>();
            database1.CreateTable<User>();
        }

        public IEnumerable<Project> GetProjects()
        {
            return database1.Table<Project>().ToList();
        }

        public IEnumerable<Project> GetProjectsByUser(int idUser)
        {
            return GetProjects().Where(project => project.ID_User == idUser);
        }
        public Project GetProject(int id)
        {
            return database1.Get<Project>(id);
        }

        public int SaveProject(Project project)
        {
            if (project.Id != 0)
            {
                database1.Update(project);
                return project.Id;
            }
            else
            {
                return database1.Insert(project);
            }
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
        public User GetUser(string login, string password)
        {
            return GetUsers().Where(user => user.Login == login && user.Password == password).FirstOrDefault();
        }
        public int DeleteProject(int idProject)
        {
            return database1.Delete<Project>(idProject);
        }
        public IEnumerable<User> GetUsers()
        {
            return database1.Table<User>().ToList();
        }

    }
}
