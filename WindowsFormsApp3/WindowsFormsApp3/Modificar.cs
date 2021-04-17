using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class Modificar : Form
    {
        SqlConnection cadena = new SqlConnection(@"Data Source= DESKTOP-JH5TK9P;Initial Catalog=PRUEBA; Integrated Security= True");
        public Modificar()
        {
            InitializeComponent();
        }

        //--------------------------------------------------------------------------------------------------------
        //Limpia los campos de texto despues de hacer una consulta
        //--------------------------------------------------------------------------------------------------------

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtCorreo.Text = "";
            txtClub.Text = "";
            txtCelular.Text = "";

            cmbGolf.Text = "";
            cmbTenis.Text = "";
            cmbTenis.Enabled = false;
            cmbGolf.Enabled = false;
        }

        //--------------------------------------------------------------------------------------------------------
        //Actualiza los datos de la BD USUARIOS
        //--------------------------------------------------------------------------------------------------------
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            cadena.Open();
            SqlCommand cmd = cadena.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update dbo.Usuario SET (Nombre= nombre)";

            cmd.Parameters.Add("nombre", txtNombre.Text);
            cmd.ExecuteNonQuery();
            cadena.Close();

            MessageBox.Show("Se actualizo corectamente");
        }

        //--------------------------------------------------------------------------------------------------------
        //Borra los registros de la tabla 
        //--------------------------------------------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            cadena.Open();
            SqlCommand cmd = cadena.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from dbo.Usuario where Nombre = '" + txtNombre.Text + "'";
            cmd.ExecuteNonQuery();
            cadena.Close();
            MessageBox.Show("Borrado Exitosamente");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cadena.Open();
            SqlCommand cmd = cadena.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM dbo.Usuario where Nombre = ('"+ textBox1.Text +"')";


        }
    }
}
