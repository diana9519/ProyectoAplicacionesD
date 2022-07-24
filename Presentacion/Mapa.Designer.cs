namespace Presentacion
{
    partial class Mapa
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
            this.labelSucursal = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.mapControl = new GMap.NET.WindowsForms.GMapControl();
            this.buttonLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSucursal
            // 
            this.labelSucursal.AutoSize = true;
            this.labelSucursal.BackColor = System.Drawing.Color.White;
            this.labelSucursal.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSucursal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelSucursal.Location = new System.Drawing.Point(24, 9);
            this.labelSucursal.Name = "labelSucursal";
            this.labelSucursal.Size = new System.Drawing.Size(85, 20);
            this.labelSucursal.TabIndex = 1;
            this.labelSucursal.Text = "Sucursal: ";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.Color.White;
            this.labelUsuario.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelUsuario.Location = new System.Drawing.Point(24, 33);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(79, 20);
            this.labelUsuario.TabIndex = 2;
            this.labelUsuario.Text = "Usuario: ";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.BackColor = System.Drawing.Color.White;
            this.labelFecha.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelFecha.Location = new System.Drawing.Point(24, 58);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(121, 20);
            this.labelFecha.TabIndex = 3;
            this.labelFecha.Text = "Fecha y Hora: ";
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
            this.mapControl.Location = new System.Drawing.Point(12, 91);
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
            this.mapControl.Size = new System.Drawing.Size(776, 347);
            this.mapControl.TabIndex = 51;
            this.mapControl.Zoom = 13D;
            // 
            // buttonLocation
            // 
            this.buttonLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLocation.BackColor = System.Drawing.Color.White;
            this.buttonLocation.BackgroundImage = global::Presentacion.Properties.Resources.ubicacion;
            this.buttonLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLocation.FlatAppearance.BorderSize = 0;
            this.buttonLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLocation.Location = new System.Drawing.Point(756, 53);
            this.buttonLocation.Name = "buttonLocation";
            this.buttonLocation.Size = new System.Drawing.Size(32, 32);
            this.buttonLocation.TabIndex = 52;
            this.buttonLocation.UseVisualStyleBackColor = false;
            this.buttonLocation.Click += new System.EventHandler(this.buttonLocation_Click);
            // 
            // Mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLocation);
            this.Controls.Add(this.mapControl);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelSucursal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Mapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mapa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSucursal;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelFecha;
        private GMap.NET.WindowsForms.GMapControl mapControl;
        private System.Windows.Forms.Button buttonLocation;
    }
}