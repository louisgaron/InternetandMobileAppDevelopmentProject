using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public MainPage(string useName, string pass, int num)
        {

        }


        private async void btnLogin(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(UserName.Text) || String.IsNullOrEmpty(Password.Text))
            {
                DisplayAlert("Oops!!Validation Error", "Username and Password are required", "Re-try");
            }

            else if (UserName.Text == "Louis" && Password.Text == "1234")
            {
                await Navigation.PushAsync(new Details());
            }
            else
            {
                DisplayAlert("Failed", "Invalid User", "Login Again");
            }
        }

        private async void btnNewLogin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewLogin());
        }


    }


        
}



    