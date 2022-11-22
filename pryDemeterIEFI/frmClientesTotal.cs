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
    public partial class frmClientesTotal : Form
    {
        string ruta = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Clientes.mdb";
        OleDbConnection conexion = new OleDbConnection();
        public frmClientesTotal()
        {
            InitializeComponent();
        }
        //muestra en una grilla todos los clientes que estan en la base de dato
        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.ConnectionString = ruta;
                conexion.Open();

                //@ es el parametro y el * te dice que traiga toda la tabla
                string select = @"SELECT * FROM Socio";
                // q quiero traer desde la base de datos
                OleDbCommand cmd = new OleDbCommand(select, conexion);
                OleDbDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Dni_Socio");
                dt.Columns.Add("Nombre_Apellido");

                while (reader.Read())
                {
                    DataRow row = dt.NewRow();
                    row["Dni_Socio"] = reader["Dni_Socio"];
                    row["Nombre_Apellido"] = reader["Nombre_Apellido"];
                    dt.Rows.Add(row);
                }

                dgvClientes.DataSource = dt;

                conexion.Close();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
