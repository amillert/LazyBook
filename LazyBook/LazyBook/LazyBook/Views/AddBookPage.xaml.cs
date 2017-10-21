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
	public partial class AddBookPage : ContentPage
	{
        public AddBookPage()
        {
            //IEnumerable
            //foreach (var value in Enum.GetValues(typeof(Category)))
            //{
            //    value.ToString();
            //}

            InitializeComponent();

            foreach(string cat in Category)
            {
                categories.Item.Add();
            }
        }
	}
}