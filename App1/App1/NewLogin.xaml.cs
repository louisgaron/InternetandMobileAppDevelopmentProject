using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


class Account
{
    public string userName { get; set; }// property
    public string password { get; set; }

};

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewLogin : ContentPage
	{
		public NewLogin ()
		{
			InitializeComponent ();
		}


        private async void btnSaveLogin(object sender, EventArgs e)
        {
            int i = 0;

            Account[] user = new Account[i];

            // Store all  Values
            user[i].userName = UserName.Text;
            user[i].password = Password.Text;
            DisplayAlert("Success", "All Vaues stored", "OK");

            await Navigation.PushAsync(new MainPage(user[i].userName, user[i].password, i));
        }
    }
}