using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LazyBook.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            bool Success = true;
            
            for(var user in Users)
            {
                if (user.username == usernameEntry.Text)
                {
                    DisplayAlert("Registration", "Username is already in use!", "OK");
                    Success = false;
                    break;
                }
                if (user.email == emailEntry.Text)
                {
                    DisplayAlert("Registratiion", "E-mail is already in use!", "OK");
                    Success = false;
                    break;
                }
            }

            if (passwordEntry != password2Entry)
            {
                DisplayAlert("Registration", "Your passwords don't match!", "OK");
                Success = false;
                passwordEntry.Text = String.Empty;
                password2Entry.Text = String.Empty;
            }
            if (Success == true)
            {
                //Add to database
                DisplayAlert("Registeration", "Registration completed successfully!", "OK");
            }
        }
    }
}