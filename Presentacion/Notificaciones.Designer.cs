namespace Presentacion
{
    partial class Notificaciones
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
            this.dataGridViewNotificaciones = new System.Windows.Forms.DataGridView();
            this.textBoxSucursal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNotificaciones
            // 
            this.dataGridViewNotificaciones.AllowUserToAddRows = false;
            this.dataGridViewNotificaciones.AllowUserToDeleteRows = false;
            this.dataGridViewNotificaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNotificaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNotificaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewNotificaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.dataGridViewNotificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotificaciones.Location = new System.Drawing.Point(13, 64);
            this.dataGridViewNotificaciones.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewNotificaciones.Name = "dataGridViewNotificaciones";
            this.dataGridViewNotificaciones.ReadOnly = true;
            this.dataGridViewNotificaciones.RowHeadersWidth = 51;
            this.dataGridViewNotificaciones.RowTemplate.Height = 24;
            this.dataGridViewNotificaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNotificaciones.Size = new System.Drawing.Size(780, 375);
            this.dataGridViewNotificaciones.TabIndex = 37;
            // 
            // textBoxSucursal
            // 
            this.textBoxSucursal.Location = new System.Drawing.Point(117, 29);
            this.textBoxSucursal.Name = "textBoxSucursal";
            this.textBoxSucursal.Size = new System.Drawing.Size(277, 22);
            this.textBoxSucursal.TabIndex = 38;
            this.textBoxSucursal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSucursal_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(27, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Buscar";
            // 
            // buttonClear
            // 
            this.buttonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.buttonClear.Location = new System.Drawing.Point(411, 25);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(94, 29);
            this.buttonClear.TabIndex = 48;
            this.buttonClear.Text = "Limpiar";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrint.BackgroundImage = global::Presentacion.Properties.Resources.printer;
            this.buttonPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPrint.FlatAppearance.BorderSize = 0;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Location = new System.Drawing.Point(761, 25);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(32, 32);
            this.buttonPrint.TabIndex = 47;
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // Notificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(830, 463);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSucursal);
            this.Controls.Add(this.dataGridViewNotificaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notificaciones";
            this.Text = "Notificaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNotificaciones;
        private System.Windows.Forms.TextBox textBoxSucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonClear;
    }
}