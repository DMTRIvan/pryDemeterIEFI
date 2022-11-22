namespace pryDemeterIEFI
{
    partial class frmClientesTotal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientesTotal));
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblConsigna = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.Color.Black;
            this.btnListar.Location = new System.Drawing.Point(199, 297);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(91, 33);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(11, 41);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(279, 241);
            this.dgvClientes.TabIndex = 3;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(13, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(236, 13);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Todos los clientes que estan en la base de dato:";
            // 
            // lblConsigna
            // 
            this.lblConsigna.AutoSize = true;
            this.lblConsigna.Location = new System.Drawing.Point(13, 308);
            this.lblConsigna.Name = "lblConsigna";
            this.lblConsigna.Size = new System.Drawing.Size(60, 13);
            this.lblConsigna.TabIndex = 6;
            this.lblConsigna.Text = "Actividad 5";
            // 
            // frmClientesTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 353);
            this.Controls.Add(this.lblConsigna);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClientesTotal";
            this.Text = "Total de clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblConsigna;
    }
}