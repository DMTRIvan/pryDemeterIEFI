namespace pryDemeterIEFI
{
    partial class frmClienteSlado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClienteSlado));
            this.gbConsulta = new System.Windows.Forms.GroupBox();
            this.lblConsigna = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblPromedioDeSaldos = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCantidadDeClientes = new System.Windows.Forms.Label();
            this.lblTotaldeSaldos = new System.Windows.Forms.Label();
            this.dgvDuedas = new System.Windows.Forms.DataGridView();
            this.gbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuedas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConsulta
            // 
            this.gbConsulta.Controls.Add(this.lblConsigna);
            this.gbConsulta.Controls.Add(this.lblPromedio);
            this.gbConsulta.Controls.Add(this.lblClientes);
            this.gbConsulta.Controls.Add(this.lblPromedioDeSaldos);
            this.gbConsulta.Controls.Add(this.btnListar);
            this.gbConsulta.Controls.Add(this.lblTotal);
            this.gbConsulta.Controls.Add(this.lblCantidadDeClientes);
            this.gbConsulta.Controls.Add(this.lblTotaldeSaldos);
            this.gbConsulta.Controls.Add(this.dgvDuedas);
            this.gbConsulta.Location = new System.Drawing.Point(11, 11);
            this.gbConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Padding = new System.Windows.Forms.Padding(2);
            this.gbConsulta.Size = new System.Drawing.Size(411, 357);
            this.gbConsulta.TabIndex = 2;
            this.gbConsulta.TabStop = false;
            this.gbConsulta.Text = "En la siguiente grilla usted vera el usuario y su saldo";
            // 
            // lblConsigna
            // 
            this.lblConsigna.AutoSize = true;
            this.lblConsigna.Location = new System.Drawing.Point(28, 321);
            this.lblConsigna.Name = "lblConsigna";
            this.lblConsigna.Size = new System.Drawing.Size(60, 13);
            this.lblConsigna.TabIndex = 8;
            this.lblConsigna.Text = "Actividad 3";
            // 
            // lblPromedio
            // 
            this.lblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedio.Location = new System.Drawing.Point(268, 256);
            this.lblPromedio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(131, 25);
            this.lblPromedio.TabIndex = 7;
            // 
            // lblClientes
            // 
            this.lblClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClientes.Location = new System.Drawing.Point(268, 214);
            this.lblClientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(131, 25);
            this.lblClientes.TabIndex = 6;
            // 
            // lblPromedioDeSaldos
            // 
            this.lblPromedioDeSaldos.AutoSize = true;
            this.lblPromedioDeSaldos.Location = new System.Drawing.Point(152, 257);
            this.lblPromedioDeSaldos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPromedioDeSaldos.Name = "lblPromedioDeSaldos";
            this.lblPromedioDeSaldos.Size = new System.Drawing.Size(101, 13);
            this.lblPromedioDeSaldos.TabIndex = 5;
            this.lblPromedioDeSaldos.Text = "Promedio de Saldos";
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.Color.Black;
            this.btnListar.Location = new System.Drawing.Point(278, 303);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(121, 31);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(268, 173);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(131, 25);
            this.lblTotal.TabIndex = 3;
            // 
            // lblCantidadDeClientes
            // 
            this.lblCantidadDeClientes.AutoSize = true;
            this.lblCantidadDeClientes.Location = new System.Drawing.Point(152, 215);
            this.lblCantidadDeClientes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadDeClientes.Name = "lblCantidadDeClientes";
            this.lblCantidadDeClientes.Size = new System.Drawing.Size(103, 13);
            this.lblCantidadDeClientes.TabIndex = 2;
            this.lblCantidadDeClientes.Text = "Cantidad de clientes";
            // 
            // lblTotaldeSaldos
            // 
            this.lblTotaldeSaldos.AutoSize = true;
            this.lblTotaldeSaldos.Location = new System.Drawing.Point(152, 174);
            this.lblTotaldeSaldos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotaldeSaldos.Name = "lblTotaldeSaldos";
            this.lblTotaldeSaldos.Size = new System.Drawing.Size(79, 13);
            this.lblTotaldeSaldos.TabIndex = 1;
            this.lblTotaldeSaldos.Text = "Total de saldos";
            // 
            // dgvDuedas
            // 
            this.dgvDuedas.AllowUserToAddRows = false;
            this.dgvDuedas.AllowUserToDeleteRows = false;
            this.dgvDuedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuedas.Location = new System.Drawing.Point(15, 27);
            this.dgvDuedas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDuedas.Name = "dgvDuedas";
            this.dgvDuedas.ReadOnly = true;
            this.dgvDuedas.RowHeadersWidth = 51;
            this.dgvDuedas.RowTemplate.Height = 24;
            this.dgvDuedas.Size = new System.Drawing.Size(384, 129);
            this.dgvDuedas.TabIndex = 0;
            // 
            // frmClienteSlado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 383);
            this.Controls.Add(this.gbConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClienteSlado";
            this.Text = "Datos de clientes y saldo";
            this.gbConsulta.ResumeLayout(false);
            this.gbConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuedas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConsulta;
        private System.Windows.Forms.Label lblConsigna;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblPromedioDeSaldos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCantidadDeClientes;
        private System.Windows.Forms.Label lblTotaldeSaldos;
        private System.Windows.Forms.DataGridView dgvDuedas;
    }
}