using System;
using LazyBook.Views;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace LazyBook
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Current.MainPage = new NavigationPage(new LoggingView());
        }
    }
}