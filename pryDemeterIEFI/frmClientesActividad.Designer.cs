namespace pryDemeterIEFI
{
    partial class frmClientesActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientesActividad));
            this.gbEtiquetas = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblMenor = new System.Windows.Forms.Label();
            this.lblTotalSaldo = new System.Windows.Forms.Label();
            this.lblMayor = new System.Windows.Forms.Label();
            this.lblMayorSaldo = new System.Windows.Forms.Label();
            this.lblPromedioSaldo = new System.Windows.Forms.Label();
            this.lblMenorSaldo = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lstActividad = new System.Windows.Forms.ComboBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblConsigna = new System.Windows.Forms.Label();
            this.gbEtiquetas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEtiquetas
            // 
            this.gbEtiquetas.Controls.Add(this.lblTotal);
            this.gbEtiquetas.Controls.Add(this.lblPromedio);
            this.gbEtiquetas.Controls.Add(this.lblMenor);
            this.gbEtiquetas.Controls.Add(this.lblTotalSaldo);
            this.gbEtiquetas.Controls.Add(this.lblMayor);
            this.gbEtiquetas.Controls.Add(this.lblMayorSaldo);
            this.gbEtiquetas.Controls.Add(this.lblPromedioSaldo);
            this.gbEtiquetas.Controls.Add(this.lblMenorSaldo);
            this.gbEtiquetas.Location = new System.Drawing.Point(14, 260);
            this.gbEtiquetas.Margin = new System.Windows.Forms.Padding(2);
            this.gbEtiquetas.Name = "gbEtiquetas";
            this.gbEtiquetas.Padding = new System.Windows.Forms.Padding(2);
            this.gbEtiquetas.Size = new System.Drawing.Size(411, 141);
            this.gbEtiquetas.TabIndex = 19;
            this.gbEtiquetas.TabStop = false;
            this.gbEtiquetas.Text = "Datos";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(287, 90);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 26);
            this.lblTotal.TabIndex = 13;
            // 
            // lblPromedio
            // 
            this.lblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedio.Location = new System.Drawing.Point(88, 90);
            this.lblPromedio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(100, 26);
            this.lblPromedio.TabIndex = 12;
            // 
            // lblMenor
            // 
            this.lblMenor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMenor.Location = new System.Drawing.Point(287, 32);
            this.lblMenor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(100, 26);
            this.lblMenor.TabIndex = 11;
            // 
            // lblTotalSaldo
            // 
            this.lblTotalSaldo.AutoSize = true;
            this.lblTotalSaldo.Location = new System.Drawing.Point(218, 91);
            this.lblTotalSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalSaldo.Name = "lblTotalSaldo";
            this.lblTotalSaldo.Size = new System.Drawing.Size(61, 13);
            this.lblTotalSaldo.TabIndex = 10;
            this.lblTotalSaldo.Text = "Total Saldo";
            // 
            // lblMayor
            // 
            this.lblMayor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMayor.Location = new System.Drawing.Point(88, 32);
            this.lblMayor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(100, 26);
            this.lblMayor.TabIndex = 6;
            // 
            // lblMayorSaldo
            // 
            this.lblMayorSaldo.AutoSize = true;
            this.lblMayorSaldo.Location = new System.Drawing.Point(20, 33);
            this.lblMayorSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMayorSaldo.Name = "lblMayorSaldo";
            this.lblMayorSaldo.Size = new System.Drawing.Size(36, 13);
            this.lblMayorSaldo.TabIndex = 4;
            this.lblMayorSaldo.Text = "Mayor";
            // 
            // lblPromedioSaldo
            // 
            this.lblPromedioSaldo.AutoSize = true;
            this.lblPromedioSaldo.Location = new System.Drawing.Point(20, 91);
            this.lblPromedioSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPromedioSaldo.Name = "lblPromedioSaldo";
            this.lblPromedioSaldo.Size = new System.Drawing.Size(51, 13);
            this.lblPromedioSaldo.TabIndex = 5;
            this.lblPromedioSaldo.Text = "Promedio";
            // 
            // lblMenorSaldo
            // 
            this.lblMenorSaldo.AutoSize = true;
            this.lblMenorSaldo.Location = new System.Drawing.Point(218, 33);
            this.lblMenorSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenorSaldo.Name = "lblMenorSaldo";
            this.lblMenorSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblMenorSaldo.TabIndex = 9;
            this.lblMenorSaldo.Text = "Menor";
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.Black;
            this.btnExportar.Location = new System.Drawing.Point(14, 210);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(97, 29);
            this.btnExportar.TabIndex = 18;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.Black;
            this.btnImprimir.Location = new System.Drawing.Point(325, 210);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(97, 30);
            this.btnImprimir.TabIndex = 17;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.Color.Black;
            this.btnListar.Location = new System.Drawing.Point(355, 16);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(70, 29);
            this.btnListar.TabIndex = 14;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(13, 54);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(412, 152);
            this.dgvClientes.TabIndex = 16;
            // 
            // lstActividad
            // 
            this.lstActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstActividad.FormattingEnabled = true;
            this.lstActividad.Location = new System.Drawing.Point(70, 16);
            this.lstActividad.Margin = new System.Windows.Forms.Padding(2);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(270, 21);
            this.lstActividad.TabIndex = 15;
            this.lstActividad.SelectedIndexChanged += new System.EventHandler(this.lstActividad_SelectedIndexChanged);
            this.lstActividad.TextChanged += new System.EventHandler(this.lstActividad_TextChanged);
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(11, 19);
            this.lblActividad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(51, 13);
            this.lblActividad.TabIndex = 13;
            this.lblActividad.Text = "Actividad";
            // 
            // lblConsigna
            // 
            this.lblConsigna.AutoSize = true;
            this.lblConsigna.Location = new System.Drawing.Point(37, 407);
            this.lblConsigna.Name = "lblConsigna";
            this.lblConsigna.Size = new System.Drawing.Size(60, 13);
            this.lblConsigna.TabIndex = 20;
            this.lblConsigna.Text = "Actividad 4";
            // 
            // frmClientesActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 433);
            this.Controls.Add(this.lblConsigna);
            this.Controls.Add(this.gbEtiquetas);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.lstActividad);
            this.Controls.Add(this.lblActividad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClientesActividad";
            this.Text = "Listado de clientes por una actividad seleccionada";
            this.Load += new System.EventHandler(this.frmClientesActividad_Load);
            this.gbEtiquetas.ResumeLayout(false);
            this.gbEtiquetas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEtiquetas;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Label lblTotalSaldo;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.Label lblMayorSaldo;
        private System.Windows.Forms.Label lblPromedioSaldo;
        private System.Windows.Forms.Label lblMenorSaldo;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.ComboBox lstActividad;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblConsigna;
    }
}