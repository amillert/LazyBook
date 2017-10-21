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

        }

        private void LogIn_Clicked(object sender, EventArgs e)
        {
        //    bool Success = true;
            
        //    for(var user in Users)
        //    {
        //        if (user.username == usernameEntry.Text)
        //        {
        //            DisplayAlert("Registration", "Username is already in use!", "OK");
        //            Success = false;
        //            break;
        //        }
        //        if (user.email == emailEntry.Text)
        //        {
        //            DisplayAlert("Registratiion", "E-mail is already in use!", "OK");
        //            Success = false;
        //            break;
        //        }
        //    }

        //    if (passwordEntry != password)
        //    {
        //        DisplayAlert("Registration", "Your password doesn't match confirmation!", "OK");
        //        Success = false;
        //        user.password == passwordEntry.Text
        //    }
        //}
    }
}