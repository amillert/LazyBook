using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LazyBook.Models;
using LazyBook.ViewModels;
using LazyBook.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LazyBook.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoggingView : ContentPage
    {

        protected virtual void OnThresholdReached(EventArgs e)
        {
            EventHandler handler = ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler ThresholdReached;

        public LoggingView()
        {
            InitializeComponent();
        }

        private void SignUp_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistrationPage());
        }

        private void LogIn_Clicked(object sender, EventArgs e)
        {
            var azure = new UserAzure();
            var users = azure.GetUsers();
            var userr = new User();

            //bool Success = true;

            foreach (var user in users.Result)
            {
                if (user.Email == emailEntry.Text && user.Password == passwordEntry.Text)
                {
                    DisplayAlert("Registration", "Successfully logged in!", "OK");
                    //Success = true;
                    OnThresholdReached(EventArgs.Empty);
                }
            }
            emailEntry.Text = String.Empty;
            passwordEntry.Text = String.Empty;
            //Success = false;
            DisplayAlert("Registration", "Logging in unsuccessfull!", "OK");
        }
    }
}