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
    public partial class frmConsultaUnCliente : Form
    {
        string ruta = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Clientes.mdb";
        OleDbConnection conexion = new OleDbConnection();
        public frmConsultaUnCliente()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombre = lstNombre.Text;

            conexion.ConnectionString = ruta;

            string select = "SELECT * FROM Socio";

            conexion.Open();
            // q quiero traer desde la base de datos
            OleDbCommand cmd = new OleDbCommand(select, conexion);
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (Convert.ToString(reader["Nombre_Apellido"]) == nombre)
                {
                    lblActividad.Text = Convert.ToString(reader["Codigo_Actividad"]);
                    buscarActividad();
                    lblSaldo.Text = Convert.ToString(reader["Saldo"]);
                }
            }

            conexion.Close();
        }
        private void listarNombre()
        {
            conexion.ConnectionString = ruta;

            DataTable dt = new DataTable();
            string selectBarrio = "Select * From Socio";
            // q quiero traer desde la base de datos
            OleDbCommand cmdBarrio = new OleDbCommand(selectBarrio, conexion);
            //Adaptador: Convierte los datos que estan en la base de dato en un conjunto de valores entendibles por .net
            OleDbDataAdapter daBarrio = new OleDbDataAdapter(cmdBarrio);
            daBarrio.SelectCommand = cmdBarrio;
            conexion.Open();
            daBarrio.Fill(dt);
            conexion.Close();
            lstNombre.DisplayMember = "Nombre_Apellido";
            lstNombre.ValueMember = "Dni_Socio";
            lstNombre.DataSource = dt;

        }

        private void frmConsultaUnCliente_Load(object sender, EventArgs e)
        {
            listarNombre();
            lstNombre.SelectedIndex = -1;
        }

        private void buscarActividad()
        {
            string actividad = lblActividad.Text;
            string cadenaActividad = "Select * From Actividad";
            //Lo que quiero traer desde la base de datos
            OleDbCommand commandActividad = new OleDbCommand(cadenaActividad, conexion);
            OleDbDataReader lectorActividad = commandActividad.ExecuteReader();

            while (lectorActividad.Read())
            {
                if (Convert.ToString(lectorActividad["Codigo_Actividad"]) == actividad)
                {
                    lblActividad.Text = Convert.ToString(lectorActividad["Detalle_Actividad"]);
                }
            }
        }

        private void lstNombre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
