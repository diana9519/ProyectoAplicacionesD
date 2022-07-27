using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Movil
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            if (Preferences.ContainsKey("user"))
            {
                MainPage = new NavigationPage(new HomePage());

            }
            else
            {
                MainPage = new NavigationPage(new LoginPage());
            }
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
