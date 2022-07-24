namespace Presentacion
{
    partial class Sucursales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLocation = new System.Windows.Forms.Button();
            this.mapControl = new GMap.NET.WindowsForms.GMapControl();
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dataGridViewSucursales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLocation
            // 
            this.buttonLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLocation.BackColor = System.Drawing.Color.White;
            this.buttonLocation.BackgroundImage = global::Presentacion.Properties.Resources.ubicacion;
            this.buttonLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLocation.FlatAppearance.BorderSize = 0;
            this.buttonLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLocation.Location = new System.Drawing.Point(786, 186);
            this.buttonLocation.Name = "buttonLocation";
            this.buttonLocation.Size = new System.Drawing.Size(32, 32);
            this.buttonLocation.TabIndex = 51;
            this.buttonLocation.UseVisualStyleBackColor = false;
            this.buttonLocation.Click += new System.EventHandler(this.buttonLocation_Click);
            // 
            // mapControl
            // 
            this.mapControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapControl.AutoScroll = true;
            this.mapControl.Bearing = 0F;
            this.mapControl.CanDragMap = true;
            this.mapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapControl.GrayScaleMode = false;
            this.mapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapControl.LevelsKeepInMemmory = 5;
            this.mapControl.Location = new System.Drawing.Point(313, 12);
            this.mapControl.MarkersEnabled = true;
            this.mapControl.MaxZoom = 30;
            this.mapControl.MinZoom = 2;
            this.mapControl.MouseWheelZoomEnabled = true;
            this.mapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapControl.Name = "mapControl";
            this.mapControl.NegativeMode = false;
            this.mapControl.PolygonsEnabled = true;
            this.mapControl.RetryLoadTile = 0;
            this.mapControl.RoutesEnabled = true;
            this.mapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapControl.ShowTileGridLines = false;
            this.mapControl.Size = new System.Drawing.Size(505, 206);
            this.mapControl.TabIndex = 50;
            this.mapControl.Zoom = 17D;
            this.mapControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mapControl_MouseDoubleClick);
            // 
            // textBoxDir
            // 
            this.textBoxDir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDir.Location = new System.Drawing.Point(109, 106);
            this.textBoxDir.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.ReadOnly = true;
            this.textBoxDir.Size = new System.Drawing.Size(196, 23);
            this.textBoxDir.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(13, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Ubicación";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(109, 75);
            this.textBoxTel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(196, 23);
            this.textBoxTel.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(13, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Teléfono";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(109, 44);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(196, 23);
            this.textBoxName.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Nombre";
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxId.Enabled = false;
            this.textBoxId.ForeColor = System.Drawing.Color.White;
            this.textBoxId.Location = new System.Drawing.Point(109, 13);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(196, 23);
            this.textBoxId.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Id";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEliminar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.buttonEliminar.Location = new System.Drawing.Point(210, 169);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(94, 26);
            this.buttonEliminar.TabIndex = 54;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEditar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.buttonEditar.Location = new System.Drawing.Point(109, 169);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(94, 26);
            this.buttonEditar.TabIndex = 53;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonCrear
            // 
            this.buttonCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.buttonCrear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCrear.Font = new System.Drawing.Font("Rockwell", 10F);
            this.buttonCrear.Location = new System.Drawing.Point(109, 137);
            this.buttonCrear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(94, 26);
            this.buttonCrear.TabIndex = 52;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = false;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCancel.Font = new System.Drawing.Font("Rockwell", 10F);
            this.buttonCancel.Location = new System.Drawing.Point(210, 136);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 26);
            this.buttonCancel.TabIndex = 61;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dataGridViewSucursales
            // 
            this.dataGridViewSucursales.AllowUserToAddRows = false;
            this.dataGridViewSucursales.AllowUserToDeleteRows = false;
            this.dataGridViewSucursales.AllowUserToResizeRows = false;
            this.dataGridViewSucursales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSucursales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSucursales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSucursales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dataGridViewSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSucursales.Location = new System.Drawing.Point(12, 224);
            this.dataGridViewSucursales.MultiSelect = false;
            this.dataGridViewSucursales.Name = "dataGridViewSucursales";
            this.dataGridViewSucursales.ReadOnly = true;
            this.dataGridViewSucursales.RowHeadersWidth = 51;
            this.dataGridViewSucursales.RowTemplate.Height = 24;
            this.dataGridViewSucursales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSucursales.Size = new System.Drawing.Size(806, 433);
            this.dataGridViewSucursales.TabIndex = 62;
            this.dataGridViewSucursales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSucursales_CellClick);
            // 
            // Sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(830, 669);
            this.Controls.Add(this.dataGridViewSucursales);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.buttonLocation);
            this.Controls.Add(this.mapControl);
            this.Controls.Add(this.textBoxDir);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sucursales";
            this.Text = "Sucursales";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSucursales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLocation;
        private GMap.NET.WindowsForms.GMapControl mapControl;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridView dataGridViewSucursales;
    }
}