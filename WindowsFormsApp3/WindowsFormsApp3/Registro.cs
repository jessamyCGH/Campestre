using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Modelos;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using AForge.Video;
using AForge.Video.DirectShow;
using DarrenLee.Media;

namespace WindowsFormsApp3
{
    public partial class Registro : Form
    {
        Camera camara = new Camera();

        Usuario usuario = new Usuario();
        Conexion conexion = new Conexion();


        ObservableCollection<string> TipoGolf = new ObservableCollection<string>();
        ObservableCollection<string> TipoTenis = new ObservableCollection<string>();


        SqlConnection con = new SqlConnection(@"Data Source= DESKTOP-JH5TK9P;Initial Catalog=PRUEBA; Integrated Security= True");
        Menu MenuAnterior;

        public Registro( Menu menu)
        {

            InitializeComponent();

           
            //-------------------------------------------------------------------------
            //CAMARA
            GetInfo();
            camara.OnFrameArrived += camara_onFArameArrived;


           // ------------------------------------------------------------------------------
            this.CenterToScreen();
            SqlDataReader reader = conexion.obtenerCategorias();

            MenuAnterior = menu;
            this.FormClosing += Registro_FormClosing;

            while (reader.Read())
            {

                // if (reader["Descripcion"].Equals("Golf"))
                if (reader["Tipo"].Equals("G"))
                {
                    TipoGolf.Add(reader["Descripcion"] + " ");

                }
                else
                {
                    TipoTenis.Add(reader["Descripcion"] + " ");
                }
            }


            cmbGolf.Items.AddRange(TipoGolf.ToArray());
            cmbTenis.Items.AddRange(TipoTenis.ToArray());
                }

        //-------------------------------------------------------------------------------------------
        //Metodo para la camara 
        private void camara_onFArameArrived(object source, FrameArrivedEventArgs e)
        {
            Image img = e.GetFrame();
            pictureBox1.Image = img;

        }

        //--------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------
        private void GetInfo()
        {
            var camaraDevices = camara.GetCameraSources();
            var cameraResolution = camara.GetSupportedResolutions();

        }


        //--------------------------------------------------------------------------------------------
         

        private void Registro_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuAnterior.Visible = true;
        }

        private void BtnRegistar_Click(object sender, EventArgs e)
        {

            MessageBox.Show(DateTime.Now + " ");
        }
        private void btnRegistar_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert INTO dbo.Usuario VALUES ('" + txtNombre.Text + "', '" + txtClub.Text + "', '" + txtCelular.Text + "',  '" + txtCorreo.Text + "', '" + txtPaterno.Text + "', '" + txtMaterno.Text + "' )";
           
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                usuario.Nombre = txtNombre.Text;
                if (!string.IsNullOrEmpty(txtPaterno.Text))
                {
                    usuario.Apaterno = txtPaterno.Text;
                    if (!string.IsNullOrEmpty(txtMaterno.Text))
                    {
                        usuario.Amaterno = txtMaterno.Text;
                        if (!string.IsNullOrEmpty(txtClub.Text))
                        {
                            usuario.Club = txtClub.Text;
                            if (!string.IsNullOrEmpty(txtCelular.Text) && txtCelular.Text.Length == 10)
                            {
                                usuario.Celular = txtCelular.Text;
                                if (!string.IsNullOrEmpty(txtCorreo.Text))
                                {
                                    usuario.Correo = txtCorreo.Text;
                                    usuario.Fecha = DateTime.Now + "";
                                }
                                else
                                {
                                    MessageBox.Show("El correo ingresado es incorrecto");
                                }
                            }
                            else
                            {
                                MessageBox.Show("El celular ingresado es incorrecto");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El club ingresado es incorrecto");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El apellido materno ingresado es incorrecto");
                    }
                }
                else
                {
                    MessageBox.Show("El apellido paterno ingresado es incorrecto");
                }
            }
            else
            {
                MessageBox.Show("El nombre ingresado es incorrecto");
            }

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Se actualizo corectamente");


        }



        private void chkTenis_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTenis.Checked)
            {
                cmbTenis.Enabled = true;
                cmbGolf.Enabled = false;
                usuario.CategoriaDescripcion = chkTenis.Text;
                chkGolf.Checked = false;
            }
        }

        private void chkGolf_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGolf.Checked)
            {
                cmbGolf.Enabled = true;
                cmbTenis.Enabled = false;
                usuario.CategoriaDescripcion = chkGolf.Text;
                chkTenis.Checked = false;
            }
        }


        private void btnCamara_Click(object sender, EventArgs e)
        {
            videoCapture1.Video_CaptureDevice = videoCapture1.Video_CaptureDevicesInfo[0].Name;
            videoCapture1.Audio_CaptureDevice = videoCapture1.Audio_CaptureDevicesInfo[0].Name;
            videoCapture1.Mode = VisioForge.Types.VFVideoCaptureMode.VideoPreview;
            videoCapture1.Start();

        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            string path = @"Campestre\Fotos";
            videoCapture1.BackgroundImage.Save(path + @"\" + txtNombre.Text + ".jpg");
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtPaterno.Text = "";
            txtMaterno.Text = "";
            txtCorreo.Text = "";
            txtClub.Text = "";
            txtCelular.Text = "";
                
            cmbGolf.Text = "";
            cmbGolf.Enabled = false;
            cmbTenis.Text = "";
            cmbTenis.Enabled = false;


            



           

        }

        private void videoCapture1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
