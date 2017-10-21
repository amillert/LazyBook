using System;
using LazyBook.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace LazyBook
{
    public partial class App : Application
    {
            LoggingView loggingView;
        public App()
        {
            InitializeComponent();
            loggingView = new LoggingView();
            Current.MainPage = loggingView;
        }

        static private void LoggedHandler(object sender, EventArgs e)
        {
            Current.MainPage = new MainMasterDetailPage();
        }

        protected override void OnStart()
        {
            loggingView.ThresholdReached += LoggedHandler;

            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}