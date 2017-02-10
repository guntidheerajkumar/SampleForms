using Xamarin.Forms;

namespace SampleForms
{
	public partial class App : Application
	{
		static PersonDatabase database;
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new PersonListPage());
		}

		public static PersonDatabase Database {
			get {
				if (database == null) {
					database = new PersonDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("PersonSQLite.db3"));
				}
				return database;
			}
		}


		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
