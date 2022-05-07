using RestAPIKrasnov666.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestAPIKrasnov666.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToDoEntry : ContentPage
    {
        public ToDoEntry()
        {
            InitializeComponent();
           
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.restManager.GetTasksAsync();
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new ApiPage() { BindingContext = e.Item as EntryModel});
        }
    }
}