using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Movil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        public MapPage(string id)
        {
            InitializeComponent();
            SetPositionMap(id);

        }

        private void SetPositionMap(string id)
        {
            WebServiceClient clienteJSON = new WebServiceClient();

            string responseServer = clienteJSON.makeGet(Config.Url + "/searchNotify", "id", id.ToString());
            var notify = JsonConvert.DeserializeObject<DetailEntidad>(responseServer);


            var user = notify.USER_DETAIL;
            var office = notify.USER_SUCURSAL_DETAIL;
            var date = notify.DATE_DETAIL;
            var id_sucursal = notify.USER_SUCURSAL_ID_DETAIL;

            labelSucursal.Text += notify.USER_SUCURSAL_DETAIL;
            labelUbicacion.Text += notify.LOCATION_DETAIL;
            //  DisplayAlert("oki", id_sucursal.ToString(), "OK");
            var responseServerSucursal = clienteJSON.makeGet(Config.Url + "/searchOffice", "id", id_sucursal.ToString());
            var sucursal = JsonConvert.DeserializeObject<OfficeEntidad>(responseServerSucursal);



            if (CultureInfo.CurrentCulture.Name == "en-US")
            {
                sucursal.DIR_OFFICE = sucursal.DIR_OFFICE.Replace(",", ".");
                notify.LOCATION_DETAIL = notify.LOCATION_DETAIL.Replace(",", ".");
            }
            else
            {
                sucursal.DIR_OFFICE = sucursal.DIR_OFFICE.Replace(".", ",");
                notify.LOCATION_DETAIL = notify.LOCATION_DETAIL.Replace(".", ",");
            }
            var locationSucursal = sucursal.DIR_OFFICE.Split(';');
            var location = notify.LOCATION_DETAIL.Split(';');
            var latitud = Double.Parse(location[0]);
            var longitud = Double.Parse(location[1]);
            var latitudSucursal = Double.Parse(locationSucursal[0]);
            var longitudSucursal = Double.Parse(locationSucursal[1]);



            Position position = new Position(latitud, longitud);
            Position position2 = new Position(latitudSucursal, longitudSucursal);
            Pin pin = new Pin
            {
                Label = "Notificación",
                Address = "",
                Type = PinType.Place,
                Position = position
            };
            Pin pin2 = new Pin
            {
                Label = "Sucursal",
                Address = "",
                Type = PinType.Place,
                Position = position2
            };
            mapa.Pins.Add(pin);
            mapa.Pins.Add(pin2);

            MapSpan mapSpan = MapSpan.FromCenterAndRadius(position, Distance.FromKilometers(0.85));
            mapa.MoveToRegion(mapSpan);

        }
    }
}