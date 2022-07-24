
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Newtonsoft.Json;
using Entidades;

namespace Presentacion
{
    public partial class Notificaciones : Form
    {
        WebServiceClient clienteJSON = new WebServiceClient();
        public Notificaciones()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void textBoxSucursal_KeyUp(object sender, KeyEventArgs e)
        {
            (dataGridViewNotificaciones.DataSource as DataTable).DefaultView.RowFilter = string.Format("SUCURSAL LIKE '%{0}%' OR USUARIO LIKE '%{0}%' ", textBoxSucursal.Text.ToString());

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            generatePdf();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSucursal.Text = "";
            (dataGridViewNotificaciones.DataSource as DataTable).DefaultView.RowFilter = "";
        }

        private void dataGridViewNotificaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewNotificaciones.Columns["VER"].Index && e.RowIndex >= 0)
            {
                var row = dataGridViewNotificaciones.Rows[e.RowIndex].Cells;
                var id = Convert.ToInt32(row["ID"].Value.ToString());
                var mapa = new Mapa(id);
                mapa.ShowDialog();

            }
        }

        /// <summary>
        /// crud
        /// </summary>
        private void cargarDatos()
        {
            string responseServer = clienteJSON.makeGet(Properties.Settings.Default.Url + "/notifications");
            var dataTableNotify = JsonConvert.DeserializeObject<DataTable>(responseServer);
            if (dataTableNotify.Rows.Count > 0)
            {
                dataTableNotify.Columns["ID_DETAIL"].SetOrdinal(0);

                dataTableNotify.Columns["ID_DETAIL"].ColumnName = "ID";
                dataTableNotify.Columns["LOCATION_DETAIL"].ColumnName = "UBICACIÓN";
                dataTableNotify.Columns["USER_DETAIL"].ColumnName = "USUARIO";
                dataTableNotify.Columns["DATE_DETAIL"].ColumnName = "FECHA";
                dataTableNotify.Columns["USER_SUCURSAL_DETAIL"].ColumnName = "SUCURSAL";

                dataTableNotify.Columns.Remove("ID_USER_DETAIL");
                dataTableNotify.Columns.Remove("USER_SUCURSAL_ID_DETAIL");

                dataGridViewNotificaciones.DataSource = dataTableNotify;
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.HeaderText = "VER";
                buttonColumn.Name = "VER";
                buttonColumn.Text = "ver";
                buttonColumn.UseColumnTextForButtonValue = true;
                dataGridViewNotificaciones.Columns.Add(buttonColumn);
                dataGridViewNotificaciones.CellClick += new DataGridViewCellEventHandler(dataGridViewNotificaciones_CellClick);
            }
            else
            {
                dataGridViewNotificaciones.DataSource = null;
            }
        }
        /// <summary>
        /// functions
        /// </summary>
        private void generatePdf()
        {
            //string de ubicacion de los archivos
            string pdfPath = Application.StartupPath + "/archivo.pdf";

            //instancenado constructores para generar docuemnto
            PdfWriter writer = new PdfWriter(pdfPath);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            //saltos de linea
            Paragraph newline = new Paragraph(new Text("\n"));
            // elemento de linea separadora
            // LineSeparator ls = new LineSeparator(new SolidLine());

            //crear encabezado del documento
            Paragraph header = new Paragraph("Reporte de Notificaciones").SetTextAlignment(TextAlignment.CENTER).SetFontSize(20).SetBold();

            //crear fecha
            Paragraph fecha = new Paragraph("Fecha de Emisión: " + DateTime.Now.ToString()).SetTextAlignment(TextAlignment.RIGHT).SetFontSize(11);

            //obteniendo datos de vista
            var d = (dataGridViewNotificaciones.DataSource as DataTable).DefaultView.ToTable();

            //creando tabla
            Table table = new Table(5, false);
            table.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

            //creando headers de la tabla
            table.SetTextAlignment(TextAlignment.CENTER);
            Cell cell11 = new Cell(1, 1).SetBackgroundColor(ColorConstants.GRAY).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("ID"));
            Cell cell12 = new Cell(1, 1).SetBackgroundColor(ColorConstants.GRAY).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("FECHA"));
            Cell cell13 = new Cell(1, 1).SetBackgroundColor(ColorConstants.GRAY).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("UBICACIÓN"));
            Cell cell14 = new Cell(1, 1).SetBackgroundColor(ColorConstants.GRAY).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("USUARIO"));
            Cell cell15 = new Cell(1, 1).SetBackgroundColor(ColorConstants.GRAY).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("SUCURSAL"));
            table.AddCell(cell11);
            table.AddCell(cell12);
            table.AddCell(cell13);
            table.AddCell(cell14);
            table.AddCell(cell15);

            //creando filas desde la tabla vista
            for (int i = 0; i < d.Rows.Count; i++)
            {
                for (int j = 0; j < d.Columns.Count; j++)
                {
                    var cell = d.Rows[i][j].ToString();
                    Cell cellTable = new Cell(1, 1).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(cell));
                    table.AddCell(cellTable);
                }
            }

            // agregando header al documento
            document.Add(header);

            //agregando y creando dato si hay filtro en la base para el documento
            if (textBoxSucursal.Text != "")
            {
                string filtro = textBoxSucursal.Text;
                Paragraph usuario = new Paragraph("Reporte para " + filtro).SetTextAlignment(TextAlignment.CENTER).SetFontSize(12);
                document.Add(usuario);
            }

            //agregando fecha al documento
            document.Add(fecha);

            //agregando salto de linea
            document.Add(newline);

            //agregando tabla
            document.Add(table);

            //necesario cerrar la escritura
            document.Close();
            //abriendo el documento creado
            Process.Start(pdfPath);

        }
    }
}
