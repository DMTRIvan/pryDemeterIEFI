using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryDemeterIEFI
{
    public partial class frmClienteSlado : Form
    {
        string ruta = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Clientes.mdb";
        OleDbConnection conexion = new OleDbConnection();
        public frmClienteSlado()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listar();
            totalSaldos();
            cantidadDeClientes();


            string promedio;
            int total = Convert.ToInt32(lblTotal.Text);
            int clientes = Convert.ToInt32(lblClientes.Text);


            promedio = Convert.ToString(total / clientes);

            lblPromedio.Text = promedio;
        }

        private void listar()
        {
            conexion.ConnectionString = ruta;

            conexion.Open();

            DataTable dt = new DataTable();

            string select = "SELECT Dni_Socio, Nombre_Apellido, Saldo FROM Socio";
            // q quiero traer desde la base de datos
            OleDbCommand cmd = new OleDbCommand(select, conexion);
            //Adaptador: Convierte los datos que estan en la base de dato en un conjunto de valores entendibles por .net
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);

            da.SelectCommand = cmd;

            da.Fill(dt);

            dgvDuedas.DataSource = dt;

            conexion.Close();

        }

        private void totalSaldos()
        {
            //toma la grilla y cuenta los saldos
            double total = 0;

            foreach (DataGridViewRow row in dgvDuedas.Rows)
            {
                total += Convert.ToDouble(row.Cells["Saldo"].Value);
            }

            lblTotal.Text = Convert.ToString(total);
        }

        private void cantidadDeClientes()
        {
            int cantidadRegistros = dgvDuedas.Rows.Count;
            lblClientes.Text = cantidadRegistros.ToString();
        }


    }
}
