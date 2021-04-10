using System;
using System.Drawing;
using System.Linq;
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
        Camera camara;

        Usuario usuario = new Usuario();
        Conexion conexion = new Conexion();

        private HuellaFrom Enroller;
       // private VerificationForm Verifier;


        private bool existenDispositivos = false;
        private bool fotografiaHecha = false;
        private FilterInfoCollection dispositivosDeVideo;
        private VideoCaptureDevice fuenteDeVideo = null;
        public PictureBox pbFotoSocio = null;
                         // keeps application-wide data
      //  private EnrollmentForm Enroller;
      //  private VerificationForm Verifier;

        ObservableCollection<string> TipoGolf = new ObservableCollection<string>();
        ObservableCollection<string> TipoTenis = new ObservableCollection<string>();
        ObservableCollection<string> Torneo = new ObservableCollection<string>();


        SqlConnection con = new SqlConnection(@"Data Source= DESKTOP-JH5TK9P;Initial Catalog=PRUEBA; Integrated Security= True");
        Menu MenuAnterior;

        public Registro( Menu menu)
        {

            InitializeComponent();
            BuscarDispositivos();

            try
            {
               // camara = new Camera();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Por favor conecte una camara y reinicie el programa.");
                Environment.Exit(1);
            }

            //-------------------------------------------------------------------------
            //CAMARA
            //GetInfo();
            //camara.OnFrameArrived += camara_onFArameArrived;
           // ------------------------------------------------------------------------------
            //pantalla en el centro
            this.CenterToScreen();

            //------------------------------------------------------------------------------
            //SQLDATAREADER muestra la informacion de categorias tenis o golf
            //------------------------------------------------------------------------------
            
                 

            MenuAnterior = menu;
            this.FormClosing += Registro_FormClosing;

           
            //lee las categorias
            cmbGolf.Items.AddRange(conexion.obtenerCategoriasGolf().ToArray());
            cmbTenis.Items.AddRange(conexion.obtenerCategoriasTennis().ToArray());
            cmbTorneo.Items.AddRange(conexion.obtenerTorneosActuales().ToArray());
            }
      
        //Metodo para la camara 
        private void camara_onFArameArrived(object source, FrameArrivedEventArgs e)
        {
            Image img = e.GetFrame();
            pictureBox1.Image = img;

        }

    
      /* private void GetInfo()
        {
            var camaraDevices = camara.GetCameraSources();
            var cameraResolution = camara.GetSupportedResolutions();

        }*/

        private void Registro_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuAnterior.Visible = true;
        }

        private void BtnRegistar_Click(object sender, EventArgs e)
        {

            MessageBox.Show(DateTime.Now + " ");
        }

        
        //Se registran los usuarios y se verifica si todos los campos este completos y correctos
        private void btnRegistar_Click_1(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "insert INTO dbo.Usuario VALUES ('" + txtNombre.Text + "', '" + txtClub.Text + "', '" + txtCelular.Text + "',  '" + txtCorreo.Text + "', '" + txtPaterno.Text + "', '" + txtMaterno.Text + "' )";
            // huella();

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


            MessageBox.Show("Se Inserto Corectamente");
        }
        
        //Desahbilita/ hablita el chkTenis, dependiendo del evento recibido

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
      
        //Desahbilita/ habilita el chkTenis, dependiendo del evento recibido
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
      
        private void btnCamara_Click(object sender, EventArgs eventArgs)
        {
            /*videoCapture1.Video_CaptureDevice = videoCapture1.Video_CaptureDevicesInfo[0].Name;
              videoCapture1.Audio_CaptureDevice = videoCapture1.Audio_CaptureDevicesInfo[0].Name;
              videoCapture1.Mode = VisioForge.Types.VFVideoCaptureMode.VideoPreview;
              videoCapture1.Start();*/

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


        private void btnReporte_Click(object sender, EventArgs e)
        {
            conexion.obtenerTorneosActuales();
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

        private void btnHuella_Click(object sender, EventArgs e)
        {

            // ExchangeData(true); 
            // transfer values from the main form to the data object
           
             Enroller.ShowDialog();	// process enrollment*/
           
        }


        // Simple dialog data exchange (DDX) implementation.
       /* private void ExchangeData(bool read)
        {
            if (read)
            {   // read values from the form's controls to the data object
                
                Data.Update();
            }
            else
            {   // read valuse from the data object to the form's controls
             
            }
        }*/


    }

}
