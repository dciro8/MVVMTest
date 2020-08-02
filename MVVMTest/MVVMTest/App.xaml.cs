using MVVMTest.Data;
using MVVMTest.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMTest
{
    public partial class App : Application
    {
        static DataBaseQuery _database;

        public static DataBaseQuery DataBase
        {
            get
            {
                if (_database == null)
                {
                    _database = new DataBaseQuery(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"Testname.db3"));
                }
                return _database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
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
