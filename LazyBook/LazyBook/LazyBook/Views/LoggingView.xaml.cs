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
            OnThresholdReached(EventArgs.Empty);
        }
    }
}