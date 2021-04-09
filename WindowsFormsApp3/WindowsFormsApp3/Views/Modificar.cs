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
using AForge.Video.DirectShow;
using AForge.Video;
using WindowsFormsApp3.Modelos;

namespace WindowsFormsApp3
{
    public partial class Modificar : Form
    {
        
     
        Conexion conexion = new Conexion();
       

        private bool existenDispositivos = false;
        private bool fotografiaHecha = false;
        private FilterInfoCollection dispositivosDeVideo;
        private VideoCaptureDevice fuenteDeVideo = null;
        public PictureBox pbFotoSocio = null;
        public Modificar()
        {
            InitializeComponent();
            BuscarDispositivos();
        }

        
        //Limpia los campos de texto despues de hacer una consulta
        

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

        
        //Actualiza los datos de la BD USUARIOS
       
        private void BtnModificar_Click(object sender, EventArgs e)
        {

         /*   cadena.Open();
           
         
            SqlCommand cmd = cadena.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update dbo.Usuario SET (Nombre= nombre)";

           
            cmd.ExecuteNonQuery();
            
            cadena.Close();

            MessageBox.Show("Se actualizo corectamente");*/
        }

       
        //Borra los registros de la tabla 
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            
            /*cadena.Open();
           
            SqlCommand cmd = cadena.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from dbo.Usuario where Nombre = '" + txtNombre.Text + "'";
            cmd.ExecuteNonQuery();
            cadena.Close();
            MessageBox.Show("Borrado Exitosamente");*/
        }



        private void btnCamara_Click(object sender, EventArgs e)
        {

            if (existenDispositivos)
            {
                fuenteDeVideo = new VideoCaptureDevice(dispositivosDeVideo[0].MonikerString);
                fuenteDeVideo.NewFrame += new NewFrameEventHandler(MostrarImagen);
                fuenteDeVideo.Start();
            }
            else
            {
                MessageBox.Show("No se encuentra ningún dispositivo de vídeo en el sistema", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

   
        // Boton Captura la fotografia 
        private void btnCapturar_Click(object sender, EventArgs e)
        {
            Capturar();
            fotografiaHecha = true;

        }
  
        //Busca Si algun dispostivo esta conectado 
        private void BuscarDispositivos()
        {
            dispositivosDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (dispositivosDeVideo.Count == 0)
                existenDispositivos = false;
            else
                existenDispositivos = true;

        }

        //Metodo para captura la imagen 
        private void Capturar()
        {
            if (fuenteDeVideo != null)
            {
                if (fuenteDeVideo.IsRunning)
                {
                    picFoto.Image = picFoto.Image;

                }
            }
            if (fuenteDeVideo != null)
                fuenteDeVideo.Stop();
        }

      
        //Se muestra la imagen en el pictureBox
        private void MostrarImagen(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();
            picFoto.Image = imagen;

        }

        private void btnCapturar_Click_1(object sender, EventArgs e)
        {
            Capturar();
            fotografiaHecha = true;

        }

      


       /* public void Info ()
        {
            cadena.Open();
            SqlCommand cmd = cadena.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Nombre from dbo.Usuario VALUES (@Nombre) ";
           // cmd.Parameters.Add("@Nombre", txtNombre.Text);
            cmd.ExecuteNonQuery();
            Console.WriteLine(cmd);
            cadena.Close();
           // MessageBox.Show("Borrado Exitosamente");
        }*/





        private void btnBusca_Click(object sender, EventArgs e)
        {
          

        }

        private void btnHuella_Click(object sender, EventArgs e)
        {

        }
       
    }

}
