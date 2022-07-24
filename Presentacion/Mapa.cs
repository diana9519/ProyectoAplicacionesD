using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Newtonsoft.Json;
using System.Globalization;

namespace Presentacion
{
    public partial class Mapa : Form
    {

        GMapOverlay marcadorOverlay;
        GMarkerGoogle marcador;
        GMarkerGoogle marcador1;

        WebServiceClient clienteJSON = new WebServiceClient();

        public Mapa(int id)
        {
            InitializeComponent();
            makeMap();
            iniciarDatos(id);
        }

        private void iniciarDatos(int id)
        {
            string responseServer = clienteJSON.makeGet(Properties.Settings.Default.Url + "/searchNotify", "id", id.ToString());
            var notify = JsonConvert.DeserializeObject<DetailEntidad>(responseServer);

            var user = notify.USER_DETAIL;
            var office = notify.USER_SUCURSAL_DETAIL;
            var date = notify.DATE_DETAIL;
            var id_sucursal = notify.USER_SUCURSAL_ID_DETAIL;

            var responseServerSucursal = clienteJSON.makeGet(Properties.Settings.Default.Url + "/searchOffice", "id", id_sucursal.ToString());
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

            makeMarker(latitud, longitud, latitudSucursal, longitudSucursal);

            labelFecha.Text += date;
            labelSucursal.Text += office;
            labelUsuario.Text += user;
        }

        /// <summary>
        /// gmap
        /// </summary>
        private void makeMap()
        {
            //para mapa
            double latitud = -1.2676797;
            double longitud = -78.6242556;
            mapControl.MapProvider = GMapProviders.GoogleMap;
            mapControl.DragButton = MouseButtons.Left;
           mapControl.ShowCenter = false;
            mapControl.Position = new PointLatLng(latitud, longitud);
            //para marcador
            marcadorOverlay = new GMapOverlay("Marcador");

            marcador = new GMarkerGoogle(new PointLatLng(), GMarkerGoogleType.blue);
            marcador.ToolTipMode = MarkerTooltipMode.Always;
            marcador.ToolTipText = "";
            marcador1 = new GMarkerGoogle(new PointLatLng(), GMarkerGoogleType.green);
            marcador1.ToolTipMode = MarkerTooltipMode.Always;
            marcador1.ToolTipText = "";
            //agregando marcadores al map
            marcadorOverlay.Markers.Add(marcador);
            marcadorOverlay.Markers.Add(marcador1);
            mapControl.Overlays.Add(marcadorOverlay);
        }

        private void makeMarker(double latitudNotify, double longitudNotify, double latitudSucursal, double longitudSucursal)
        {
            marcador.ToolTipText = String.Format("Notificación:\n Latitud:{0}\n Longitud:{1}", latitudNotify, longitudNotify);
            marcador.Position = new PointLatLng(latitudNotify, longitudNotify);

            marcador1.ToolTipText = String.Format("Sucursal:\n Latitud:{0}\n Longitud:{1}", latitudSucursal, longitudSucursal);
            marcador1.Position = new PointLatLng(latitudSucursal, longitudSucursal);
           
            mapControl.Position = new PointLatLng(latitudNotify, longitudNotify);

            //marcador1.Position = new PointLatLng(latitud, longitud);
        }


        private void buttonLocation_Click(object sender, EventArgs e)
        {
            mapControl.Position = marcador.Position;

        }
    }
}
