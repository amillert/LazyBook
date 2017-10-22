using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LazyBook
{
    public partial class NewItemPage : ContentPage
    {
        public Item newItem { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            categoriesPicker.ItemsSource = Models.Helper.Categories;
            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            ItemsViewModel ivm = new ItemsViewModel();

            newItem = new Item();
            newItem.Name = titleEntry.Text;
            newItem.Author = authorEntry.Text;
            newItem.Publisher = publisherEntry.Text;
            newItem.Year = yearEntry.Text;
            newItem.Category = categoriesPicker.Items[categoriesPicker.SelectedIndex];
            newItem.Summary = summaryEntry.Text;
            
            await ivm.ExecuteAddItemCommandAsync(newItem);
            //ivm.Items.Add(newItem);


            MessagingCenter.Send(this, "AddItem");
            await Navigation.PopToRootAsync();
        }
    }
}
