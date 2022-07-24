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
        private Form activeForm = null;
        public Principal()
        {
            InitializeComponent();
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            openChildForm(new Inicio());
        }

        private void buttonSucursales_Click(object sender, EventArgs e)
        {
            openChildForm(new Sucursales());
        }

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new Usuarios());
        }

        private void buttonNotificaciones_Click(object sender, EventArgs e)
        {
            openChildForm(new Notificaciones());
        }
        private void openChildForm(Form childForm)
        {
            //cierro formulario abierto
            if (activeForm != null)
            {
                activeForm.Close();
            }
            //instanciar nuevo formulario
            activeForm = childForm;
            //no es lvl superior al padre, para que sea un objeto mas del formulario inicio
            childForm.TopLevel = false;
            //eliminamos bordes y cierre minimizar maximizar
            childForm.FormBorderStyle = FormBorderStyle.None;
            //para que llene todo el formulario padre
            childForm.Dock = DockStyle.Fill;
            //agregamos el formulario hijo como un objeto del padre
            panelChild.Controls.Add(childForm);
            //asociamos el formulario con el panel
            panelChild.Tag = childForm;
            //lo superposcionamos al frente para mostrar el formulario hijo en caso que existan logos o objetos en el formulario padre
            childForm.BringToFront();
            //mostramos el formulario
            childForm.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            openChildForm(new Inicio());
        }
    }

}
