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
    public partial class frmClientesBarrio : Form
    {
        string ruta = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Clientes.mdb";
        OleDbConnection conexion = new OleDbConnection();
        public frmClientesBarrio()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string barrio = lstBarrio.Text;
            string codBarrio = null;

            conexion.ConnectionString = ruta;
            conexion.Open();

            //Buscar Código Barrio

            string selectBarrio = "SELECT * FROM Barrio";
            // q quiero traer desde la base de datos
            OleDbCommand commandBarrio = new OleDbCommand(selectBarrio, conexion);
            OleDbDataReader lectorBarrio = commandBarrio.ExecuteReader();

            while (lectorBarrio.Read())
            {
                if (Convert.ToString(lectorBarrio["Detalle_Barrio"]) == barrio)
                {
                    codBarrio = Convert.ToString(lectorBarrio["Codigo_Barrio"]);
                }
            }


            //Mover a la Grilla

            DataTable dt = new DataTable();
            string selectdgv = "SELECT Dni_Socio, Nombre_Apellido FROM Socio WHERE Codigo_Barrio=" + codBarrio;
            // q quiero traer desde la base de datos
            OleDbCommand cmd = new OleDbCommand(selectdgv, conexion);
            //Adaptador: Convierte los datos que estan en la base de dato en un conjunto de valores entendibles por .net
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.SelectCommand = cmd;
            da.Fill(dt);
            dgvClientes.DataSource = dt;

            conexion.Close();
        }

        private void listarBarrio()
        {
            conexion.ConnectionString = ruta;
            conexion.Open();
            DataTable Barrio = new DataTable();
            string selectBarrio = "Select * From Barrio";
            // q quiero traer desde la base de datos
            OleDbCommand cmdBarrio = new OleDbCommand(selectBarrio, conexion);
            //Adaptador: Convierte los datos que estan en la base de dato en un conjunto de valores entendibles por .net
            OleDbDataAdapter daBarrio = new OleDbDataAdapter(cmdBarrio);
            daBarrio.SelectCommand = cmdBarrio;
            daBarrio.Fill(Barrio);
            lstBarrio.DisplayMember = "Detalle_Barrio";
            lstBarrio.ValueMember = "Codigo_Barrio";
            lstBarrio.DataSource = Barrio;
            conexion.Close();
        }

        private void frmClientesBarrio_Load(object sender, EventArgs e)
        {
            listarBarrio();
            lstBarrio.SelectedIndex = -1;
            btnListar.Enabled = false;
        }

        private void lstBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstBarrio_TextChanged(object sender, EventArgs e)
        {
            if (lstBarrio.Text != string.Empty)
            {
                btnListar.Enabled = true;
            }
            else
            {
                btnListar.Enabled = false;
            }
        }

        private void lstBarrio_TextChanged_1(object sender, EventArgs e)
        {
            if (lstBarrio.Text != string.Empty)
            {
                btnListar.Enabled = true;
            }
            else
            {
                btnListar.Enabled = false;
            }
        }
    }
}
