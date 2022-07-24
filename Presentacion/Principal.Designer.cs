namespace Presentacion
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panelChild = new System.Windows.Forms.Panel();
            this.panelSlider = new System.Windows.Forms.Panel();
            this.buttonNotificaciones = new System.Windows.Forms.Button();
            this.buttonUsuarios = new System.Windows.Forms.Button();
            this.buttonSucursales = new System.Windows.Forms.Button();
            this.buttonInicio = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSlider.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChild
            // 
            this.panelChild.AutoScroll = true;
            this.panelChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(250, 0);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(830, 669);
            this.panelChild.TabIndex = 3;
            // 
            // panelSlider
            // 
            this.panelSlider.AutoScroll = true;
            this.panelSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSlider.Controls.Add(this.buttonNotificaciones);
            this.panelSlider.Controls.Add(this.buttonUsuarios);
            this.panelSlider.Controls.Add(this.buttonSucursales);
            this.panelSlider.Controls.Add(this.buttonInicio);
            this.panelSlider.Controls.Add(this.panelLogo);
            this.panelSlider.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlider.Location = new System.Drawing.Point(0, 0);
            this.panelSlider.Name = "panelSlider";
            this.panelSlider.Size = new System.Drawing.Size(250, 669);
            this.panelSlider.TabIndex = 2;
            // 
            // buttonNotificaciones
            // 
            this.buttonNotificaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNotificaciones.FlatAppearance.BorderSize = 0;
            this.buttonNotificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotificaciones.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNotificaciones.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonNotificaciones.Location = new System.Drawing.Point(0, 244);
            this.buttonNotificaciones.Name = "buttonNotificaciones";
            this.buttonNotificaciones.Size = new System.Drawing.Size(250, 40);
            this.buttonNotificaciones.TabIndex = 4;
            this.buttonNotificaciones.Text = "Notificaciones";
            this.buttonNotificaciones.UseVisualStyleBackColor = true;
            this.buttonNotificaciones.Click += new System.EventHandler(this.buttonNotificaciones_Click);
            // 
            // buttonUsuarios
            // 
            this.buttonUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUsuarios.FlatAppearance.BorderSize = 0;
            this.buttonUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsuarios.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsuarios.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonUsuarios.Location = new System.Drawing.Point(0, 204);
            this.buttonUsuarios.Name = "buttonUsuarios";
            this.buttonUsuarios.Size = new System.Drawing.Size(250, 40);
            this.buttonUsuarios.TabIndex = 3;
            this.buttonUsuarios.Text = "Usuarios";
            this.buttonUsuarios.UseVisualStyleBackColor = true;
            this.buttonUsuarios.Click += new System.EventHandler(this.buttonUsuarios_Click);
            // 
            // buttonSucursales
            // 
            this.buttonSucursales.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSucursales.FlatAppearance.BorderSize = 0;
            this.buttonSucursales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSucursales.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSucursales.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSucursales.Location = new System.Drawing.Point(0, 164);
            this.buttonSucursales.Name = "buttonSucursales";
            this.buttonSucursales.Size = new System.Drawing.Size(250, 40);
            this.buttonSucursales.TabIndex = 2;
            this.buttonSucursales.Text = "Sucursales";
            this.buttonSucursales.UseVisualStyleBackColor = true;
            this.buttonSucursales.Click += new System.EventHandler(this.buttonSucursales_Click);
            // 
            // buttonInicio
            // 
            this.buttonInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInicio.FlatAppearance.BorderSize = 0;
            this.buttonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInicio.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInicio.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonInicio.Location = new System.Drawing.Point(0, 124);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(250, 40);
            this.buttonInicio.TabIndex = 1;
            this.buttonInicio.Text = "Inicio";
            this.buttonInicio.UseVisualStyleBackColor = true;
            this.buttonInicio.Click += new System.EventHandler(this.buttonInicio_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(9);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(12);
            this.panelLogo.Size = new System.Drawing.Size(250, 124);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1080, 669);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panelSlider);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panelSlider.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.Panel panelSlider;
        private System.Windows.Forms.Button buttonNotificaciones;
        private System.Windows.Forms.Button buttonUsuarios;
        private System.Windows.Forms.Button buttonSucursales;
        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}