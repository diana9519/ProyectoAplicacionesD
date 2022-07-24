using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Servicios;
using Xamarin.Essentials;

namespace Movil
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        private async void Button_ClickedAsync(object sender, EventArgs e)
        {
            var userData = texBoxUser.Text;
            var passData = textBoxpass.Text;
            if (userData != "" && passData != "")
            {
                WebServiceClient jsonServer = new WebServiceClient();

                var responseServer = jsonServer.makeGet(Configuraciones.Url + "/checkUser", "user", userData, "pass", passData);

                if (responseServer.Length > 2)
                {
                    Preferences.Set("user", responseServer);
                    // await  DisplayAlert("ERROR", "hasta aqui", "OK");
                    await Navigation.PushAsync(new Inicio(), false);
                }
                else
                {
                    await DisplayAlert("ERROR", "Usuario o Contraseña incorrecta", "OK");
                }
            }
            else
            {
                await DisplayAlert("ERROR", "Usuario o Contraseña incorrecta", "OK");
            }
        }
    }
}
