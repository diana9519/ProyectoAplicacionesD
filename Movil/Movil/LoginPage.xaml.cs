using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Movil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var userData = texBoxUser.Text;
            var passData = textBoxpass.Text;
            if (userData != "" && passData != "")
            {
                WebServiceClient jsonServer = new WebServiceClient();

                var responseServer = jsonServer.makeGet(Config.Url + "/checkUser", "user", userData, "pass", passData);

                if (responseServer.Length > 2)
                {
                    Preferences.Set("user", responseServer);
                    // await  DisplayAlert("ERROR", "hasta aqui", "OK");
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        await Navigation.PushAsync(new MainPage());
                    });
                    // 
                }
                else
                {
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        await DisplayAlert("ERROR", "Usuario o Contraseña incorrecta", "OK");
                    });
                }
            }
            else
            {
                //await DisplayAlert("ERROR", "Usuario o Contraseña incorrecta", "OK");
            }
        }
    }
}