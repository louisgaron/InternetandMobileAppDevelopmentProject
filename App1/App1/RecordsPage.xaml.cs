using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RecordsPage : ContentPage
	{

        private async void btnLogOut(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());

        }


        public RecordsPage (string fname, string sname, string date, string contactNum, string department)// functions that prints out all the data stored
		{
            float salary = 0;
            bool sportsMember = false;

			InitializeComponent ();

            Console.WriteLine("Name: " + fname + " " + sname);
            Console.WriteLine("Date of birth: " + date);
            Console.WriteLine("Contact Number: " + contactNum);
            Console.WriteLine("Department: "+department);

            if(department == "Office" || department =="office")
            {
                salary = 600;
                sportsMember = true;
            }

            else
            {
                salary = 500;
                sportsMember = false;
            }

            Console.WriteLine("Salary: " + salary);

            if (sportsMember == true)
            {
                Console.WriteLine("Member of Sports and Social: Yes");
            }
            else
            {
                Console.WriteLine("Member of Sports and Social: No");
            }

        }

        public RecordsPage()
        {
            InitializeComponent();
        }
    }
}