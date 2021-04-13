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
using System.Data.Common;


namespace WindowsFormsApp3
{
    public partial class Registro : Form
    {
        Camera camara;

        Usuario usuario = new Usuario();
        Conexion conexion = new Conexion();

        private EnrollmentForm Enroller;
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

        Menu MenuAnterior;

       // int id_cat ;
        string huella =  null;
        string imagen = null;

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
        /* private void btnRegistar_Click_1(object sender, EventArgs e)
         {
             int id_cat = Convert.ToInt32(cmbTenis.SelectedValue);
             int id_torneo = Convert.ToInt32(cmbTorneo.SelectedValue);


             // huella();

             if (!string.IsNullOrEmpty(txtNombre.Text))
             {
                 usuario.nombre = txtNombre.Text;
                 if (!string.IsNullOrEmpty(txtPaterno.Text))
                 {
                     usuario.apellidoP = txtPaterno.Text;
                     if (!string.IsNullOrEmpty(txtMaterno.Text))
                     {
                         usuario.apellidoM = txtMaterno.Text;
                         if (!string.IsNullOrEmpty(txtClub.Text))
                         {
                             usuario.club = txtClub.Text;
                             if (!string.IsNullOrEmpty(txtCelular.Text) && txtCelular.Text.Length == 10)
                             {
                                 usuario.tel = txtCelular.Text;
                                 if (!string.IsNullOrEmpty(txtCorreo.Text))
                                 {
                                     usuario.correo = txtCorreo.Text;
                                     usuario.Fecha = DateTime.Now + "";

                                     // conexion.Insertar(txtNombre.Text, txtPaterno.Text, txtMaterno.Text, txtCorreo.Text,txtCelular.Text, txtCorreo.Text, cmbTenis.SelectedIndex, huella, imagen,cmbTorneo.SelectedIndex );

                                     /* usuario.Nombre = txtNombre.Text.;
                                       usuario.apellidoP = txtPaterno.Text;
                                       usuario.apellidoM = txtMaterno.Text;
                                       usuario.club = txtClub.Text;
                                       usuario.celular = txtClub.Text;
                                       usuario.correo = txtCorreo.Text;
                                       usuario.CategoriaDescripcion = Convert.ToString(cmbTenis);
                                       usuario.Torneo = Convert.ToString(cmbTorneo);
                                     try { 

                                     usuario.nombre = txtNombre.Text;
                                     usuario.apellidoP = txtPaterno.Text;
                                     usuario.apellidoM = txtMaterno.Text;
                                     usuario.correo = txtCorreo.Text;
                                     usuario.tel = txtCelular.Text;
                                     usuario.club = txtClub.Text;
                                     usuario.huella = null;

                                     int Id = Conexion.Alta(usuario);


                                     if (Id > 0)
                                     {
                                         MessageBox.Show("Empleado guardado correctamente", "Guardar");

                                         txtNombre.Text = "";
                                         txtPaterno.Text = "";
                                         txtMaterno.Text = "";
                                         txtCorreo.Text = "";
                                         txtCelular.Text = "";
                                             txtClub.Text = "";

                                        // dgEmpleados.DataContext = DatoEmpleado.MuestraEmpleados();

                                     }

                                 }
             catch (Exception ex)
                                 {
                                     MessageBox.Show("No fue posible guardar el empleado: " + ex.Message, "Error en Guardar");
                                 }
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
             conexion.conectarBDT.Close();

          if(tbNombre.Text =="")
            {
                 MessageBox.Show("El campo Nombre debe ser especificado", "Error");
                 return;
            }

             if (tbApellidos.Text == "")
             {
                 MessageBox.Show("El campo Apellidos debe ser especificado", "Error");
                 return;
             }

             if (tbNumero.Text == "")
             {
                 MessageBox.Show("El campo Número de empleado debe ser especificado", "Error");
                 return;
             }

             if (Template == null)
             {
                 MessageBox.Show("La huella del empleado debe ser capturada", "Error");
                 return;
             }

             try
             {
                 Empleado empleado = new Empleado();
                 empleado.Nombre = tbNombre.Text;
                 empleado.Apellidos = tbApellidos.Text;
                 empleado.Numero = tbNumero.Text;
                 empleado.Foto = tbUrlFoto.Text;
                 empleado.Huella = Template.Bytes;

                 string destino = @"C:\Checador\";

               //  string recurso = imgFoto.Source.ToString().Replace("file:///", "");

               //  File.Copy(recurso, destino + tbUrlFoto.Text, true);

                 int id = DatoEmpleado.AltaEmpleado(empleado);

                 if(id > 0)
                 {
                     MessageBox.Show("Empleado guardado correctamente", "Guardar");

                     tbNombre.Text = "";
                     tbApellidos.Text = "";
                     tbNumero.Text = "";
                     tbUrlFoto.Text = "";
                     imgFoto.Source = null;
                     dgEmpleados.DataContext = DatoEmpleado.MuestraEmpleados();

                 }

             }
             catch (Exception ex)
             {
                 MessageBox.Show("No fue posible guardar el empleado: " + ex.Message, "Error en Guardar");
             }
         }


         }*/
        private void btnRegistar_Click_1(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("El campo Nombre debe ser especificado", "Error");
                return;
            }

            if (txtPaterno.Text == "")
            {
                MessageBox.Show("El campo apellido Paterno debe de ser llenado", "Error");
                return;
            }

            if (txtMaterno.Text == "")
            {
                MessageBox.Show("El campo Número de empleado debe ser especificado", "Error");
                return;
            }
            if (txtCorreo.Text == "")
            {
                MessageBox.Show("El campo Número de empleado debe ser especificado", "Error");
                return;
            }
            if (txtClub.Text == "")
            {
                MessageBox.Show("El campo Número de empleado debe ser especificado", "Error");
                return;
            }
            if (txtCelular.Text == "")
            {
                MessageBox.Show("El campo Número de empleado debe ser especificado", "Error");
                return;
            }


            if (Template == null)
            {
                MessageBox.Show("La huella del empleado debe ser capturada", "Error");
                return;
            }

            try
            {
                Usuario usuario = new Usuario();
                usuario.nombre = txtNombre.Text;
                usuario.apellidoP = txtPaterno.Text;
                usuario.apellidoM = txtMaterno.Text;
                usuario.correo = txtCorreo.Text;
                usuario.club = txtClub.Text;
                usuario.tel = txtCelular.Text;
                usuario.huella = Template.Bytes;

                string destino = @"C:\Checador\";

                //  string recurso = imgFoto.Source.ToString().Replace("file:///", "");

                //  File.Copy(recurso, destino + tbUrlFoto.Text, true);

                int id = Conexion.Alta(usuario);

                if (id > 0)
                {
                    MessageBox.Show("Empleado guardado correctamente", "Guardar");

                    txtNombre.Text = "";
                    txtPaterno.Text = "";
                    txtMaterno.Text = "";
                    txtCorreo.Text = "";
                    txtCelular.Text = "";
                    txtClub.Text = "";
                    
                    

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No fue posible guardar el empleado: " + ex.Message, "Error en Guardar");
            }
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

            EnrollmentForm Enroller = new EnrollmentForm();
            Enroller.OnTemplate += this.OnTemplate;
            Enroller.ShowDialog();

            // ExchangeData(true); 
            // transfer values from the main form to the data object

            //  Enroller.ShowDialog();	// process enrollment*/

        }
        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
                //VerifyButton.Enabled = SaveButton.Enabled = (Template != null);
                if (Template != null)
                {
                    MessageBox.Show("La huella ha sido capturada correctamente", "Capturar huella.");
                    //imgVerHuella.Visibility = Visibility.Visible;
                }
                else
                    MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment");
            }));
        }

        private DPFP.Template Template;

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
