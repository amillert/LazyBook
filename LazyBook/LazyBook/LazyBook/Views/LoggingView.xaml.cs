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
        public delegate void PageBreakNext(string IRPOlink);
        public event PageBreakNext PageBreak;

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
            OnThresholdReached(EventArgs.Empty);
        }

        private void LogIn_Clicked(object sender, EventArgs e)
        {
            bool Success = true;
            
            for(var user in Users)
            {
                if (user.email == emailEntry.Text && user.password == passwordEntry.Text)
                {
                    DisplayAlert("Registratiion", "Successfully logged in!", "OK");
                    Success = true;
                    break;
                }

                if (user.email == emailEntry.Text && user.password != passwordEntry.Text)
                {
                    DisplayAlert("Registratiion", "Incorrect password!", "OK");
                    Success = false;
                    passwordEntry.Text = String.Empty;
                    break;
                }
            }
        }
    }
}