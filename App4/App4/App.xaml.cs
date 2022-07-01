using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App4.DataBase;
using System.IO;

namespace App4
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "Project.db";
        internal static DataBase.Tools db;
        internal static DataBase.Storage q;
        internal static Tools Db
        {
            get
            {
                if (db == null)
                {
                    db = new Tools(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return db;
            }
        }
        internal static Tools stor
        {
            get
            {
                if (q == null)
                {
                    q = new Storage(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return db;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
