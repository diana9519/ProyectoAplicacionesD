using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Presentacion
{
    public partial class Usuarios : Form
    {
        WebServiceClient clienteJSON = new WebServiceClient();
        UserEntidad newUser = new UserEntidad();
       
        public Usuarios()
        {
            InitializeComponent();
            cargarDatos();
            llenarSelect();
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

        private void dataGridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex != 0)
            {
                var id = dataGridViewUsuarios.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                llenarInputs(id);
            }
        }

        /// <summary>
        ///crud 
        /// </summary>
        private void eliminar()
        {
            string id = textBoxId.Text;

            string responseServer = clienteJSON.makeGet(Properties.Settings.Default.Url + "/deleteUser", "id", id);
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
        private void crear()
        {
            newUser.USER_USER = textBoxUser.Text.Trim();
            newUser.PASSWORD_USER = textBoxPass.Text.Trim();
            newUser.ID_OFFICE_USER = Convert.ToInt32(comboBoxOffice.SelectedValue);
            newUser.LAST_USER = textBoxLast.Text.Trim();
            newUser.NAME_USER = textBoxName.Text.Trim();

            var user = JsonConvert.SerializeObject(newUser);
            var responseServer = clienteJSON.makePost(Properties.Settings.Default.Url + "/makeUser", user);
            var userResponse = JsonConvert.DeserializeObject<UserEntidad>(responseServer);

            if (userResponse != null)
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
            newUser.ID_USER = Convert.ToInt32(textBoxId.Text);
            newUser.USER_USER = textBoxUser.Text.Trim();
            newUser.PASSWORD_USER = textBoxPass.Text.Trim();
            newUser.ID_OFFICE_USER = Convert.ToInt32(comboBoxOffice.SelectedValue);
            newUser.LAST_USER = textBoxLast.Text.Trim();
            newUser.NAME_USER = textBoxName.Text.Trim();

            var user = JsonConvert.SerializeObject(newUser);
            var responseServer = clienteJSON.makePost(Properties.Settings.Default.Url + "/editUser", user);
            var userResponse = JsonConvert.DeserializeObject<UserEntidad>(responseServer);

            if (userResponse != null)
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
        private void llenarInputs(string id)
        {
            string responseServer = clienteJSON.makeGet(Properties.Settings.Default.Url + "/searchUser", "id", id);
            var user = JsonConvert.DeserializeObject<UserEntidad>(responseServer);

            textBoxId.Text = Convert.ToString(user.ID_USER);
            textBoxName.Text = user.NAME_USER;
            textBoxLast.Text = user.LAST_USER;
            textBoxUser.Text = user.USER_USER;
            textBoxPass.Text = user.PASSWORD_USER;
            comboBoxOffice.SelectedValue = user.ID_OFFICE_USER;

            blockButtons("otro");
        }
        private void llenarSelect()
        {
            string responseServer = clienteJSON.makeGet(Properties.Settings.Default.Url + "/offices");
            var sucursales = JsonConvert.DeserializeObject<List<OfficeEntidad>>(responseServer);
            comboBoxOffice.DataSource = sucursales;
            comboBoxOffice.DisplayMember = "NAME_OFFICE";
            comboBoxOffice.ValueMember = "ID_OFFICE";
        }
        private void cargarDatos()
        {
            string responseServer = clienteJSON.makeGet(Properties.Settings.Default.Url + "/users");
            var dataTableUser = JsonConvert.DeserializeObject<DataTable>(responseServer);
            if (dataTableUser.Rows.Count > 0)
            {
                dataTableUser.Columns["ID_USER"].ColumnName = "ID";
                dataTableUser.Columns["LAST_USER"].ColumnName = "APELLIDO";
                dataTableUser.Columns["NAME_USER"].ColumnName = "NOMBRE";
                dataTableUser.Columns["PASSWORD_USER"].ColumnName = "CONTRASEÑA";
                dataTableUser.Columns["USER_USER"].SetOrdinal(5);
                dataTableUser.Columns["USER_USER"].ColumnName = "USUARIO";
                dataTableUser.Columns["OFFICE_USER"].ColumnName = "SUCURSAL";
                dataTableUser.Columns.Remove("ID_OFFICE_USER");
                dataGridViewUsuarios.DataSource = dataTableUser;
            }
            else
            {
                dataGridViewUsuarios.DataSource = null;
            }

        }

        /// <summary>
        /// funciones
        /// </summary>
        private void limpiarInputs()
        {
            textBoxId.Text = "";
            textBoxName.Text = "";
            textBoxLast.Text = "";
            textBoxUser.Text = "";
            textBoxPass.Text = "";
            comboBoxOffice.SelectedIndex = 0;
            blockButtons("inicio");
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

    }
}
