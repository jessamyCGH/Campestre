using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;



namespace Campestre
{
    public partial class FrameRegistro : Form
    {
        //private string path = @"C:\Users\jessa\Desktop\Imagenes";



        public FrameRegistro()
        {
            InitializeComponent();
            Conexion conexion = new Conexion();
            conexion.abrir();
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCelular.Text = "";
            txtClub.Text = "";
            txtCorreo.Text = "";
            txtMaterno.Text = "";
            txtNombre.Text = "";
            txtPaterno.Text = "";
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now + " ");
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice
        private void btnCamara_Click(object sender, EventArgs e)
        {

            videoCaptureDevice.Start();


        }
    }
}
