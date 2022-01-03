using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Ples_Claudiu_Lab12_proiect.Data;

namespace Ples_Claudiu_Lab12_proiect
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
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
