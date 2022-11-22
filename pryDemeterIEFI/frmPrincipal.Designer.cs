namespace pryDemeterIEFI
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.socioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeTodosLosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeSaldoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesPorBarrioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesPorActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.consultaDeUnClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.socioToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(303, 24);
            this.menu.TabIndex = 15;
            this.menu.Text = "menuStrip1";
            // 
            // socioToolStripMenuItem
            // 
            this.socioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.darDeBajaToolStripMenuItem});
            this.socioToolStripMenuItem.Name = "socioToolStripMenuItem";
            this.socioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.socioToolStripMenuItem.Text = "Socio";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // darDeBajaToolStripMenuItem
            // 
            this.darDeBajaToolStripMenuItem.Name = "darDeBajaToolStripMenuItem";
            this.darDeBajaToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.darDeBajaToolStripMenuItem.Text = "Dar de baja";
            this.darDeBajaToolStripMenuItem.Click += new System.EventHandler(this.darDeBajaToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeTodosLosClientesToolStripMenuItem,
            this.listadoDeSaldoDeClientesToolStripMenuItem,
            this.listadoDeClientesPorBarrioToolStripMenuItem,
            this.listadoDeClientesPorActividadToolStripMenuItem,
            this.toolStripSeparator1,
            this.consultaDeUnClienteToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // listadoDeTodosLosClientesToolStripMenuItem
            // 
            this.listadoDeTodosLosClientesToolStripMenuItem.Name = "listadoDeTodosLosClientesToolStripMenuItem";
            this.listadoDeTodosLosClientesToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.listadoDeTodosLosClientesToolStripMenuItem.Text = "Listado de todos los clientes...";
            this.listadoDeTodosLosClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeTodosLosClientesToolStripMenuItem_Click);
            // 
            // listadoDeSaldoDeClientesToolStripMenuItem
            // 
            this.listadoDeSaldoDeClientesToolStripMenuItem.Name = "listadoDeSaldoDeClientesToolStripMenuItem";
            this.listadoDeSaldoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.listadoDeSaldoDeClientesToolStripMenuItem.Text = "Listado de saldo de clientes...";
            this.listadoDeSaldoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeSaldoDeClientesToolStripMenuItem_Click);
            // 
            // listadoDeClientesPorBarrioToolStripMenuItem
            // 
            this.listadoDeClientesPorBarrioToolStripMenuItem.Name = "listadoDeClientesPorBarrioToolStripMenuItem";
            this.listadoDeClientesPorBarrioToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.listadoDeClientesPorBarrioToolStripMenuItem.Text = "Listado de clientes por barrio...";
            this.listadoDeClientesPorBarrioToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesPorBarrioToolStripMenuItem_Click);
            // 
            // listadoDeClientesPorActividadToolStripMenuItem
            // 
            this.listadoDeClientesPorActividadToolStripMenuItem.Name = "listadoDeClientesPorActividadToolStripMenuItem";
            this.listadoDeClientesPorActividadToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.listadoDeClientesPorActividadToolStripMenuItem.Text = "Listado de clientes por actividad...";
            this.listadoDeClientesPorActividadToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesPorActividadToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(249, 6);
            // 
            // consultaDeUnClienteToolStripMenuItem
            // 
            this.consultaDeUnClienteToolStripMenuItem.Name = "consultaDeUnClienteToolStripMenuItem";
            this.consultaDeUnClienteToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.consultaDeUnClienteToolStripMenuItem.Text = "Consulta de un cliente...";
            this.consultaDeUnClienteToolStripMenuItem.Click += new System.EventHandler(this.consultaDeUnClienteToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 196);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Bienvenido!!";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem socioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeBajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeTodosLosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeSaldoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesPorBarrioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesPorActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem consultaDeUnClienteToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

