using Xamarin.Forms;
using FreshMvvm;
using FreshMVVMWithLogin.PageModels;

namespace FreshMVVMWithLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

			InitializeNaviagation();
        }
        
        private void InitializeNaviagation()
		{
			var loginPage = FreshPageModelResolver.ResolvePageModel<LoginPageModel>();
			var loginStack = new FreshNavigationContainer(loginPage, NavStacks.LoginNavStack);

			var mainPage = FreshPageModelResolver.ResolvePageModel<MainPageModel>();
			var mainStack = new FreshNavigationContainer(mainPage, NavStacks.MainNavStack);

			MainPage = loginPage;
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

    public class NavStacks
	{
		public static string LoginNavStack = "LoginNavStack";
		public static string MainNavStack = "MainNavStack";
	}
}
