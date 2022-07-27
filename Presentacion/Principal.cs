using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Principal : Form
    {

        private Form inicio = new Inicio();
        private Form sucursal = new Sucursales();
        private Form usuarios = new Usuarios();
        private Form notificaciones = new Notificaciones();
        private Form activeForm = null;
        public Principal()
        {
            InitializeComponent();
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {

            openChildForm("inicio");

        }

        private void buttonSucursales_Click(object sender, EventArgs e)
        {

            openChildForm("sucursal");
        }

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm("usuarios");
        }

        private void buttonNotificaciones_Click(object sender, EventArgs e)
        {
            openChildForm("notify");
        }
        private void openChildForm(string data)
        {
            if (data == "sucursal")
            {
                activeForm = sucursal;
            }
            else if (data == "notify")
            {
                activeForm = notificaciones;
            }
            else if (data == "usuarios")
            {
                activeForm = usuarios;
            }
            else
            {
                activeForm = inicio;
            }
            //instanciar nuevo formulario
            //   activeForm.Dispose();
            //no es lvl superior al padre, para que sea un objeto mas del formulario inicio
            activeForm.TopLevel = false;
            //eliminamos bordes y cierre minimizar maximizar
            activeForm.FormBorderStyle = FormBorderStyle.None;
            //para que llene todo el formulario padre
            activeForm.Dock = DockStyle.Fill;
            //agregamos el formulario hijo como un objeto del padre
            panelChild.Controls.Add(activeForm);
            //asociamos el formulario con el panel
            panelChild.Tag = activeForm;
            //lo superposcionamos al frente para mostrar el formulario hijo en caso que existan logos o objetos en el formulario padre
            activeForm.BringToFront();
            //mostramos el formulario
            activeForm.Show();


        }
        private void Principal_Load(object sender, EventArgs e)
        {
            openChildForm("inicio");
        }
    }

}
