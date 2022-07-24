using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Entidades;
using Newtonsoft.Json;
using System.Globalization;

namespace Presentacion
{
    public partial class Sucursales : Form
    {
        OfficeEntidad newSucursal = new OfficeEntidad();
        WebServiceClient clienteJSON = new WebServiceClient();

        GMapOverlay marcadorOverlay;
        GMarkerGoogle marcador;

        public Sucursales()
        {
            InitializeComponent();
            cargarDatos();
            makeMap();
            blockButtons("inicio");

        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            crear();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            limpiarInputs();
        }

        private void buttonLocation_Click(object sender, EventArgs e)
        {
            mapControl.Position = marcador.Position;
        }

        private void mapControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var latitud = mapControl.FromLocalToLatLng(e.X, e.Y).Lat;
            var longitud = mapControl.FromLocalToLatLng(e.X, e.Y).Lng;

            makeMarker(latitud, longitud);
            var location = mapControl.Position;
            textBoxDir.Text = location.Lat.ToString() + ";" + location.Lng.ToString();

        }

        private void dataGridViewSucursales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex != 0)
            {
                var id = dataGridViewSucursales.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                llenarInputs(id);
            }
        }

        /// <summary>
        /// crud
        /// </summary>
        private void crear()
        {
            newSucursal.NAME_OFFICE = textBoxName.Text.Trim();
            newSucursal.PHONE_OFFICE = textBoxTel.Text.Trim();
            newSucursal.DIR_OFFICE = textBoxDir.Text.Trim();

            var sucursal = JsonConvert.SerializeObject(newSucursal);
            var responseServer = clienteJSON.makePost(Properties.Settings.Default.Url + "/makeOffice", sucursal);
            var officeResponse = JsonConvert.DeserializeObject<OfficeEntidad>(responseServer);

            if (officeResponse != null)
            {
                limpiarInputs();
                MessageBox.Show("Se creo correctamente.", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrio un error en la creación, vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cargarDatos();
        }
        private void editar()
        {
            newSucursal.ID_OFFICE = Convert.ToInt32(textBoxId.Text);
            newSucursal.NAME_OFFICE = textBoxName.Text.Trim();
            newSucursal.PHONE_OFFICE = textBoxTel.Text.Trim();
            newSucursal.DIR_OFFICE = textBoxDir.Text.Trim();

            var office = JsonConvert.SerializeObject(newSucursal);
            var responseServer = clienteJSON.makePost(Properties.Settings.Default.Url + "/editOffice", office);
            var officeResponse = JsonConvert.DeserializeObject<UserEntidad>(responseServer);

            if (officeResponse != null)
            {
                limpiarInputs();
                MessageBox.Show("Se editó correctamente.", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrio un error en la edición, vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cargarDatos();
        }
        private void eliminar()
        {
            string id = textBoxId.Text;

            string responseServer = clienteJSON.makeGet(Properties.Settings.Default.Url + "/deleteOffice", "id", id);
            var response = JsonConvert.DeserializeObject<bool>(responseServer);

            if (response == true)
            {
                limpiarInputs();
                MessageBox.Show("Se eliminó correctamente.", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrio un error en la eliminación, vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cargarDatos();
        }
        private void cargarDatos()
        {
            string responseServer = clienteJSON.makeGet(Properties.Settings.Default.Url + "/offices");
            var dataTableOffice = JsonConvert.DeserializeObject<DataTable>(responseServer);
            if (dataTableOffice.Rows.Count > 0)
            {
                dataTableOffice.Columns["ID_OFFICE"].SetOrdinal(0);
                dataTableOffice.Columns["ID_OFFICE"].ColumnName = "ID";
                dataTableOffice.Columns["DIR_OFFICE"].ColumnName = "UBICACIÓN";
                dataTableOffice.Columns["NAME_OFFICE"].ColumnName = "NOMBRE";
                dataTableOffice.Columns["PHONE_OFFICE"].ColumnName = "TELÉFONO";

                dataGridViewSucursales.DataSource = dataTableOffice;
            }
            else
            {
                dataGridViewSucursales.DataSource = null;
            }
        }

        /// <summary>
        /// functions
        /// </summary>
        private void limpiarInputs()
        {
            textBoxId.Text = "";
            textBoxName.Text = "";
            textBoxDir.Text = "";
            textBoxTel.Text = "";
            setLocationDefault();
            blockButtons("inicio");
        }
        private void llenarInputs(string id)
        {
            string responseServer = clienteJSON.makeGet(Properties.Settings.Default.Url + "/searchOffice", "id", id);
            var office = JsonConvert.DeserializeObject<OfficeEntidad>(responseServer);

            textBoxId.Text = Convert.ToString(office.ID_OFFICE);
            textBoxName.Text = office.NAME_OFFICE;
            textBoxTel.Text = office.PHONE_OFFICE;
            textBoxDir.Text = office.DIR_OFFICE;


            if (CultureInfo.CurrentCulture.Name == "en-US")
            {
                office.DIR_OFFICE = office.DIR_OFFICE.Replace(",", ".");
            }
            else
            {
                office.DIR_OFFICE = office.DIR_OFFICE.Replace(".", ",");
            }
            var latLng = office.DIR_OFFICE.Split(';');
            var latitud = Double.Parse(latLng[0]);
            var longitud = Double.Parse(latLng[1]);
            makeMarker(latitud, longitud);
            blockButtons("otro");
        }
        private void blockButtons(string lugar)
        {
            if (lugar == "inicio")
            {
                //  buttonCancel.Enabled = false;

                buttonCrear.Visible = true;
                buttonEditar.Visible = false;
                buttonEliminar.Visible = false;

            }
            else
            {
                buttonCancel.Visible = true;
                buttonEditar.Visible = true;
                buttonEliminar.Visible = true;
                buttonCrear.Visible = false;

            }
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
            //agregando marcadores al map
            marcadorOverlay.Markers.Add(marcador);
            mapControl.Overlays.Add(marcadorOverlay);
        }

        private void makeMarker(double latitud, double longitud)
        {
            marcador.ToolTipText = String.Format("Ubicacion:\n Latitud:{0}\n Longitud:{1}", latitud, longitud);
            mapControl.Position = new PointLatLng(latitud, longitud);
            marcador.Position = new PointLatLng(latitud, longitud);
        }

        private void setLocationDefault()
        {
            double latitud = -1.2676797;
            double longitud = -78.6242556;
            makeMarker(latitud, longitud);
            marcador.Position = new PointLatLng();
        }
    }
}
