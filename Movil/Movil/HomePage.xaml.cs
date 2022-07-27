using Entidades;
using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using Plugin.LocalNotification;
using Plugin.LocalNotification.EventArgs;
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
    public partial class HomePage : ContentPage
    {
        HubConnection _connection;
        string id = "";
        public UserEntidad result = JsonConvert.DeserializeObject<UserEntidad>(Preferences.Get("user", ""));
        string ubicacion = "";
        WebServiceClient jsonServer = new WebServiceClient();
        public HomePage()
        {
            GetLocation();
            InitializeComponent();
            GetUser();
            SetSignalRAsync();
            NotificationCenter.Current.NotificationTapped += OnLocalNotificationTapped;
        }


        private void OnLocalNotificationTapped(NotificationEventArgs e)
        {

            Device.BeginInvokeOnMainThread(async () =>
            {
                await Navigation.PushAsync(new MapPage(id));
            });
        }

        private void GetUser()
        {
            labelBienvendida.Text += result.USER_USER;
            labelSucur.Text += result.OFFICE_USER;
            labelLocation.Text += ubicacion;
        }

        private async void GetLocation()
        {

            var location = await Geolocation.GetLastKnownLocationAsync();

            if (location == null)
            {
                location = await Geolocation.GetLocationAsync(new GeolocationRequest { DesiredAccuracy = GeolocationAccuracy.Best, Timeout = TimeSpan.FromSeconds(10) });
            }
            if (location == null)
            {
                ubicacion = "no gps";
            }
            else
            {
                ubicacion = location.Latitude + ";" + location.Longitude;
            }
        }

        private async void SetNotifyAsync()
        {
            var alert = new DetailEntidad();
            alert.ID_USER_DETAIL = result.ID_USER;
            alert.DATE_DETAIL = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            alert.LOCATION_DETAIL = ubicacion;

            var alertJSON = JsonConvert.SerializeObject(alert);
            var responseServer = jsonServer.makePost(Config.Url + "/makeNotify", alertJSON);
            var detailResponse = JsonConvert.DeserializeObject<DetailEntidad>(responseServer);

            if (detailResponse != null)
            {
                sendMessage(detailResponse.ID_DETAIL.ToString());
                await DisplayAlert("HECHO", "Alerta enviada.", "OK");

            }
            else
            {
                await DisplayAlert("ERROR", "Ocurrio un error intente nuevamente.", "OK");
            }
        }

        private void sendMessage(string id)
        {
            _connection.SendAsync("Send", "android", id);
        }

        private async void SetSignalRAsync()
        {
            try
            {
                _connection = new HubConnectionBuilder().WithUrl(Config.UrlSignalr).Build();

                _connection.On<string, string>("broadcastMessage", (name, message) =>
                {
                    setLocalNotifyAsync(message);
                });
                await _connection.StartAsync();

            }
            catch (Exception ex)
            {
                //  AppendMessage($"An error occurred while connecting: {ex}");
                //UpdateState(ViewState.Disconnected);
                _ = DisplayAlert("HECHO", ex.ToString(), "OK");

                return;
            }
        }

        private async void setLocalNotifyAsync(string message)
        {
            id = message;
            var notification = new NotificationRequest
            {

                NotificationId = new Random().Next(0, 5),
                Title = "Alerta",
                Description = "Se necesita tu atención",
                ReturningData = message//, // Returning data when tapped on notification.
                                       // Schedule = { NotifyTime = DateTime.Now.AddSeconds(5) } // Used for Scheduling local notification, if not specified notification will show immediately }
            };
            await NotificationCenter.Current.Show(notification);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            SetNotifyAsync();
        }
    }
}