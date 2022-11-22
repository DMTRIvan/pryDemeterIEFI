namespace pryDemeterIEFI
{
    partial class frmConsultaUnCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaUnCliente));
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblSaldoCliente = new System.Windows.Forms.Label();
            this.lblActividadCliente = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lstNombre = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblConsigna = new System.Windows.Forms.Label();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.lblActividad);
            this.gbCliente.Controls.Add(this.lblSaldo);
            this.gbCliente.Controls.Add(this.lblSaldoCliente);
            this.gbCliente.Controls.Add(this.lblActividadCliente);
            this.gbCliente.Location = new System.Drawing.Point(269, 11);
            this.gbCliente.Margin = new System.Windows.Forms.Padding(2);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Padding = new System.Windows.Forms.Padding(2);
            this.gbCliente.Size = new System.Drawing.Size(234, 110);
            this.gbCliente.TabIndex = 8;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Datos del cliente";
            // 
            // lblActividad
            // 
            this.lblActividad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblActividad.Location = new System.Drawing.Point(78, 29);
            this.lblActividad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(138, 26);
            this.lblActividad.TabIndex = 16;
            // 
            // lblSaldo
            // 
            this.lblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSaldo.Location = new System.Drawing.Point(78, 67);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(138, 26);
            this.lblSaldo.TabIndex = 15;
            // 
            // lblSaldoCliente
            // 
            this.lblSaldoCliente.AutoSize = true;
            this.lblSaldoCliente.Location = new System.Drawing.Point(16, 68);
            this.lblSaldoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaldoCliente.Name = "lblSaldoCliente";
            this.lblSaldoCliente.Size = new System.Drawing.Size(34, 13);
            this.lblSaldoCliente.TabIndex = 13;
            this.lblSaldoCliente.Text = "Saldo";
            // 
            // lblActividadCliente
            // 
            this.lblActividadCliente.AutoSize = true;
            this.lblActividadCliente.Location = new System.Drawing.Point(16, 30);
            this.lblActividadCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActividadCliente.Name = "lblActividadCliente";
            this.lblActividadCliente.Size = new System.Drawing.Size(51, 13);
            this.lblActividadCliente.TabIndex = 14;
            this.lblActividadCliente.Text = "Actividad";
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.Black;
            this.btnMostrar.Location = new System.Drawing.Point(162, 52);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(85, 30);
            this.btnMostrar.TabIndex = 7;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lstNombre
            // 
            this.lstNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstNombre.FormattingEnabled = true;
            this.lstNombre.Location = new System.Drawing.Point(114, 16);
            this.lstNombre.Margin = new System.Windows.Forms.Padding(2);
            this.lstNombre.Name = "lstNombre";
            this.lstNombre.Size = new System.Drawing.Size(134, 21);
            this.lstNombre.TabIndex = 6;
            this.lstNombre.SelectedIndexChanged += new System.EventHandler(this.lstNombre_SelectedIndexChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 19);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(95, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre del cliente";
            // 
            // lblConsigna
            // 
            this.lblConsigna.AutoSize = true;
            this.lblConsigna.Location = new System.Drawing.Point(11, 108);
            this.lblConsigna.Name = "lblConsigna";
            this.lblConsigna.Size = new System.Drawing.Size(60, 13);
            this.lblConsigna.TabIndex = 9;
            this.lblConsigna.Text = "Actividad 7";
            // 
            // frmConsultaUnCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 138);
            this.Controls.Add(this.lblConsigna);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lstNombre);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaUnCliente";
            this.Text = "Datos de un cliente";
            this.Load += new System.EventHandler(this.frmConsultaUnCliente_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblSaldoCliente;
        private System.Windows.Forms.Label lblActividadCliente;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ComboBox lstNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblConsigna;
    }
}