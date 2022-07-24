using Newtonsoft.Json;
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
using Microsoft.AspNetCore.SignalR.Client;

namespace Presentacion
{
    public partial class Inicio : Form
    {
        private HubConnection hubConnection;
        WebServiceClient clienteJSON = new WebServiceClient();

        public Inicio()
        {
            InitializeComponent();
            hubConnection = new HubConnectionBuilder().WithUrl(Properties.Settings.Default.signalr).Build();
            hubConnection.Closed += HubConnection_Closed;
        }

        private async Task HubConnection_Closed(Exception arg)
        {
            await Task.Delay(new Random().Next(0, 5) * 1000);
            await hubConnection.StartAsync();
        }

        private void buttonOffice_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            var a = clickedButton.Name;
            var id = Convert.ToInt32(a);
            var mapa = new Mapa(id);
            mapa.ShowDialog();

        }


        public Button addButton(string id)
        {
            string responseServer = clienteJSON.makeGet(Properties.Settings.Default.Url + "/searchNotify", "id", id);
            var notify = JsonConvert.DeserializeObject<DetailEntidad>(responseServer);
            Button boton = new Button();
            PanelSucursal.Controls.Add(boton);
            boton.Margin = new Padding(8, 5, 0, 0);
            boton.Size = new Size(145, 150);
            boton.FlatStyle = FlatStyle.Standard;
            boton.BackColor = Color.White;
            boton.Font = new Font(new FontFamily("Rockwell"), 13);
            boton.BackColor = Color.Red;
            boton.Text = notify.USER_SUCURSAL_DETAIL;
            boton.Name = id;
            boton.Click += new EventHandler(buttonOffice_Click);
            return boton;
        }

        private async void Inicio_Load(object sender, EventArgs e)
        {
            hubConnection.On<string, string>("broadcastMessage", (name, message) =>
            {
             
                addButton(message);
            });
            try
            {
                await hubConnection.StartAsync();
                // MessageBox.Show("test conect");
            }
            catch (Exception)
            {
              //  MessageBox.Show("Test fail");
            }
        }

    }
}
