using System;
using System.Threading.Tasks;
using FreshMvvm;
using PropertyChanged;
using Xamarin.Forms;

namespace FreshMVVMWithLogin.PageModels
{
	[AddINotifyPropertyChangedInterface]
	public class LoginPageModel : FreshBasePageModel
    {
		public string Username { get; set; }
		public string Password { get; set; }

		public Command LoginCommand => new Command(Login);

		private void Login()
		{
			if (Username == "Bob" && Password == "letmein")
				CoreMethods.SwitchOutRootNavigation(NavStacks.MainNavStack);
			else
				CoreMethods.DisplayAlert("Login Error", "The username or password is incorect.", "Okay");
		}
    }
}
