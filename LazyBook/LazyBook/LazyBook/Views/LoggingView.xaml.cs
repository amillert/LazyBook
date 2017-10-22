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

        async private void LogIn_Clicked(object sender, EventArgs e)
        {
            bool Success = true;
            var azure = new UserAzure();
            var users = azure.GetUsers();
            var userr = new User();
            OnThresholdReached(EventArgs.Empty);

            foreach (var user in users.Result)
            {
                if (user.Email == emailEntry.Text && user.Password == passwordEntry.Text)
                {
                    await DisplayAlert("Registration", "Successfully logged in!", "OK");
                    Success = true;
                }
            }
            if(Success == true)
            {
                OnThresholdReached(EventArgs.Empty);
            }
            emailEntry.Text = String.Empty;
            passwordEntry.Text = String.Empty;
            Success = false;
            await DisplayAlert("Registration", "Logging in unsuccessful!", "OK");
        }
    }
}