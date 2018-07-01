using System;
using LocalDatabaseDS.Models;
using LocalDatabaseDS.SQLite;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace LocalDatabaseDS
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
		    CreateTable();
			MainPage = new MainPage();
		}

	    private void CreateTable()
	    {
	        var _sqLiteConnection = DependencyService.Get<ISQLite>().GetConnection();
	        _sqLiteConnection.CreateTable<StaffTable>();
            //_sqLiteConnection.CreateTable<DeparmenttTable>();
	        //_sqLiteConnection.CreateTable<InComeTable>();

        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
