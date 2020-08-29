using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    class Person //stores all the variable needed to  for the class Person
    {
        public string firstName { get; set; }// property
        public string lastName { get; set; }
        public string dob { get; set; }
        public string contactNum { get; set; }
        public string department { get; set; }
        public int holidays { get; set; }

    };

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Details : ContentPage
	{
		public Details ()
		{
			InitializeComponent ();
		}

        private async void btnLogOut(object sender, EventArgs e)// log out button that directs back into login page
        {
            await Navigation.PushAsync(new MainPage());

        }

        private async void btnSaved_Details(object sender, EventArgs e)
        {
            int i = 0;

             Person[] employee = new Person[i];
            
            // Store all  Values
            employee[i].firstName = FirstName.Text;
            employee[i].lastName = LastName.Text;
            employee[i].dob = DOB.Text;
            employee[i].contactNum = ContactNum.Text;
            employee[i].department = Department.Text;
            employee[i].holidays = Convert.ToInt32(Holidays.Text);
            FirstName.Text = string.Empty;
            LastName.Text = string.Empty;
            DOB.Text = string.Empty;
            ContactNum.Text = string.Empty;
            Department.Text = string.Empty;
            DisplayAlert("Success", "All Vaues stored", "OK");

            await Navigation.PushAsync(new RecordsPage(employee[i].firstName, employee[i].lastName, employee[i].dob, employee[i].contactNum, employee[i].department));
        }


        private async void btnRecordsPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecordsPage());

        }


    }
}