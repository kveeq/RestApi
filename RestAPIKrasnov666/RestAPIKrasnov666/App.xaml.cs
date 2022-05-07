using RestAPIKrasnov666.Servies;
using RestAPIKrasnov666.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestAPIKrasnov666
{
    public partial class App : Application
    {
        public static RestManager restManager { get;private set; }
        public App()
        {
            restManager = new RestManager(new RestService());
            MainPage = new NavigationPage(new ToDoEntry());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
