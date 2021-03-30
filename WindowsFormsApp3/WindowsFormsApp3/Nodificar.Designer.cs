
namespace WindowsFormsApp3
{
    partial class Nodificar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nodificar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.videoCapture1 = new VisioForge.Controls.UI.WinForms.VideoCapture();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltTitulo = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblGolf = new System.Windows.Forms.Label();
            this.cmbGolf = new System.Windows.Forms.ComboBox();
            this.lblTenis = new System.Windows.Forms.Label();
            this.cmbTenis = new System.Windows.Forms.ComboBox();
            this.chkGolf = new System.Windows.Forms.CheckBox();
            this.chkTenis = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnRegistar = new System.Windows.Forms.Button();
            this.btnHuella = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCamara = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtClub = new System.Windows.Forms.TextBox();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(808, 407);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 67);
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // videoCapture1
            // 
            this.videoCapture1.Additional_Audio_CaptureDevice_MixChannels = false;
            this.videoCapture1.Audio_CaptureDevice = "";
            this.videoCapture1.Audio_CaptureDevice_CustomLatency = 0;
            this.videoCapture1.Audio_CaptureDevice_Format = "";
            this.videoCapture1.Audio_CaptureDevice_Format_UseBest = true;
            this.videoCapture1.Audio_CaptureDevice_Line = "";
            this.videoCapture1.Audio_CaptureDevice_MasterDevice = null;
            this.videoCapture1.Audio_CaptureDevice_MasterDevice_Format = null;
            this.videoCapture1.Audio_CaptureDevice_Path = null;
            this.videoCapture1.Audio_CaptureSourceFilter = null;
            this.videoCapture1.Audio_Channel_Mapper = null;
            this.videoCapture1.Audio_Decoder = null;
            this.videoCapture1.Audio_Effects_Enabled = false;
            this.videoCapture1.Audio_Effects_UseLegacyEffects = false;
            this.videoCapture1.Audio_Enhancer_Enabled = false;
            this.videoCapture1.Audio_OutputDevice = "Default DirectSound Device";
            this.videoCapture1.Audio_PCM_Converter = null;
            this.videoCapture1.Audio_PlayAudio = true;
            this.videoCapture1.Audio_RecordAudio = true;
            this.videoCapture1.Audio_Sample_Grabber_Enabled = false;
            this.videoCapture1.Audio_VUMeter_Enabled = false;
            this.videoCapture1.Audio_VUMeter_Pro_Enabled = false;
            this.videoCapture1.Audio_VUMeter_Pro_Volume = 100;
            this.videoCapture1.BackColor = System.Drawing.Color.Black;
            this.videoCapture1.Barcode_Reader_Enabled = false;
            this.videoCapture1.Barcode_Reader_Type = VisioForge.Types.VFBarcodeType.Auto;
            this.videoCapture1.BDA_Source = null;
            this.videoCapture1.ChromaKey = null;
            this.videoCapture1.Custom_Source = null;
            this.videoCapture1.CustomRedist_Auto = true;
            this.videoCapture1.CustomRedist_Enabled = false;
            this.videoCapture1.CustomRedist_Path = null;
            this.videoCapture1.Debug_Dir = "";
            this.videoCapture1.Debug_DisableMessageDialogs = false;
            this.videoCapture1.Debug_Mode = false;
            this.videoCapture1.Debug_Telemetry = true;
            this.videoCapture1.Decklink_Input = VisioForge.Types.DecklinkInput.Auto;
            this.videoCapture1.Decklink_Input_Capture_Timecode_Source = VisioForge.Types.DecklinkCaptureTimecodeSource.Auto;
            this.videoCapture1.Decklink_Input_IREUSA = false;
            this.videoCapture1.Decklink_Input_SMPTE = false;
            this.videoCapture1.Decklink_Output = null;
            this.videoCapture1.Decklink_Source = null;
            this.videoCapture1.DirectCapture_Muxer = null;
            this.videoCapture1.DV_Decoder_Video_Resolution = VisioForge.Types.VFDVVideoResolution.Full;
            this.videoCapture1.Face_Tracking = null;
            this.videoCapture1.IP_Camera_Source = null;
            this.videoCapture1.Location = new System.Drawing.Point(661, 77);
            this.videoCapture1.Margin = new System.Windows.Forms.Padding(4);
            this.videoCapture1.Mode = VisioForge.Types.VFVideoCaptureMode.VideoPreview;
            this.videoCapture1.Motion_Detection = null;
            this.videoCapture1.Motion_DetectionEx = null;
            this.videoCapture1.MPEG_Audio_Decoder = "";
            this.videoCapture1.MPEG_Demuxer = null;
            this.videoCapture1.MPEG_Video_Decoder = "";
            this.videoCapture1.MultiScreen_Enabled = false;
            this.videoCapture1.Name = "videoCapture1";
            this.videoCapture1.Network_Streaming_Audio_Enabled = false;
            this.videoCapture1.Network_Streaming_Enabled = false;
            this.videoCapture1.Network_Streaming_Format = VisioForge.Types.VFNetworkStreamingFormat.WMV;
            this.videoCapture1.Network_Streaming_Network_Port = 100;
            this.videoCapture1.Network_Streaming_Output = null;
            this.videoCapture1.Network_Streaming_URL = "";
            this.videoCapture1.Network_Streaming_WMV_Maximum_Clients = 10;
            this.videoCapture1.OSD_Enabled = false;
            this.videoCapture1.Output_Filename = "C:\\Users\\jessa\\Documents\\VisioForge\\output.avi";
            this.videoCapture1.Output_Format = null;
            this.videoCapture1.PIP_AddSampleGrabbers = false;
            this.videoCapture1.PIP_ChromaKeySettings = null;
            this.videoCapture1.PIP_Mode = VisioForge.Types.VFPIPMode.Custom;
            this.videoCapture1.PIP_ResizeQuality = VisioForge.Types.VFPIPResizeQuality.RQ_NN;
            this.videoCapture1.Push_Source = null;
            this.videoCapture1.Screen_Capture_Source = null;
            this.videoCapture1.SeparateCapture_AutostartCapture = false;
            this.videoCapture1.SeparateCapture_Enabled = false;
            this.videoCapture1.SeparateCapture_Filename_Mask = "output %yyyy-%MM-%dd %hh-%mm-%ss.%ext";
            this.videoCapture1.SeparateCapture_FileSizeThreshold = ((long)(0));
            this.videoCapture1.SeparateCapture_GMFMode = true;
            this.videoCapture1.SeparateCapture_Mode = VisioForge.Types.VFSeparateCaptureMode.Normal;
            this.videoCapture1.SeparateCapture_TimeThreshold = System.TimeSpan.Parse("00:00:00");
            this.videoCapture1.Size = new System.Drawing.Size(315, 249);
            this.videoCapture1.Start_DelayEnabled = false;
            this.videoCapture1.TabIndex = 85;
            this.videoCapture1.Tags = null;
            this.videoCapture1.Timeshift_Settings = null;
            this.videoCapture1.TVTuner_Channel = 0;
            this.videoCapture1.TVTuner_Country = "";
            this.videoCapture1.TVTuner_FM_Tuning_StartFrequency = 80000000;
            this.videoCapture1.TVTuner_FM_Tuning_Step = 160000000;
            this.videoCapture1.TVTuner_FM_Tuning_StopFrequency = 0;
            this.videoCapture1.TVTuner_Frequency = 0;
            this.videoCapture1.TVTuner_InputType = "";
            this.videoCapture1.TVTuner_Mode = VisioForge.Types.VFTVTunerMode.Default;
            this.videoCapture1.TVTuner_Name = "";
            this.videoCapture1.TVTuner_TVFormat = VisioForge.Types.VFTVTunerVideoFormat.PAL_D;
            this.videoCapture1.Video_CaptureDevice = "";
            this.videoCapture1.Video_CaptureDevice_Format = "";
            this.videoCapture1.Video_CaptureDevice_Format_UseBest = true;
            this.videoCapture1.Video_CaptureDevice_FrameRate = 25D;
            this.videoCapture1.Video_CaptureDevice_InternalMPEGEncoder_Name = "";
            this.videoCapture1.Video_CaptureDevice_IsAudioSource = false;
            this.videoCapture1.Video_CaptureDevice_Path = null;
            this.videoCapture1.Video_CaptureDevice_UseClosedCaptions = false;
            this.videoCapture1.Video_CaptureDevice_UseRAWSampleGrabber = false;
            this.videoCapture1.Video_Crop = null;
            this.videoCapture1.Video_Decoder = null;
            this.videoCapture1.Video_Effects_AllowMultipleStreams = false;
            this.videoCapture1.Video_Effects_Enabled = false;
            this.videoCapture1.Video_Effects_GPU_Enabled = false;
            this.videoCapture1.Video_Effects_MergeImageLogos = false;
            this.videoCapture1.Video_Effects_MergeTextLogos = false;
            this.videoCapture1.Video_Resize = null;
            this.videoCapture1.Video_ResizeOrCrop_Enabled = false;
            this.videoCapture1.Video_Rotation = VisioForge.Types.VFRotateMode.RotateNone;
            this.videoCapture1.Video_Sample_Grabber_Enabled = true;
            this.videoCapture1.Video_Sample_Grabber_UseForVideoEffects = true;
            this.videoCapture1.Video_Still_Frames_Grabber_Enabled = false;
            this.videoCapture1.Virtual_Camera_Output_Enabled = false;
            this.videoCapture1.Virtual_Camera_Output_LicenseKey = null;
            this.videoCapture1.VLC_Path = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbltTitulo);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 69);
            this.panel1.TabIndex = 84;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(3, 59);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1059, 10);
            this.panel2.TabIndex = 39;
            // 
            // lbltTitulo
            // 
            this.lbltTitulo.AutoSize = true;
            this.lbltTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltTitulo.Location = new System.Drawing.Point(307, 8);
            this.lbltTitulo.Name = "lbltTitulo";
            this.lbltTitulo.Size = new System.Drawing.Size(391, 39);
            this.lbltTitulo.TabIndex = 0;
            this.lbltTitulo.Text = "MODIFICAR/ ELIMINAR";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(808, 525);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(81, 80);
            this.btnLimpiar.TabIndex = 83;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Image = ((System.Drawing.Image)(resources.GetObject("btnCapturar.Image")));
            this.btnCapturar.Location = new System.Drawing.Point(841, 333);
            this.btnCapturar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(65, 48);
            this.btnCapturar.TabIndex = 82;
            this.btnCapturar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblGolf);
            this.groupBox2.Controls.Add(this.cmbGolf);
            this.groupBox2.Controls.Add(this.lblTenis);
            this.groupBox2.Controls.Add(this.cmbTenis);
            this.groupBox2.Controls.Add(this.chkGolf);
            this.groupBox2.Controls.Add(this.chkTenis);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(68, 333);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(419, 199);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Categoria";
            // 
            // lblGolf
            // 
            this.lblGolf.AutoSize = true;
            this.lblGolf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGolf.Location = new System.Drawing.Point(37, 140);
            this.lblGolf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGolf.Name = "lblGolf";
            this.lblGolf.Size = new System.Drawing.Size(36, 16);
            this.lblGolf.TabIndex = 42;
            this.lblGolf.Text = "Golf";
            // 
            // cmbGolf
            // 
            this.cmbGolf.Enabled = false;
            this.cmbGolf.FormattingEnabled = true;
            this.cmbGolf.Location = new System.Drawing.Point(116, 142);
            this.cmbGolf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGolf.Name = "cmbGolf";
            this.cmbGolf.Size = new System.Drawing.Size(163, 24);
            this.cmbGolf.TabIndex = 41;
            // 
            // lblTenis
            // 
            this.lblTenis.AutoSize = true;
            this.lblTenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenis.Location = new System.Drawing.Point(37, 101);
            this.lblTenis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenis.Name = "lblTenis";
            this.lblTenis.Size = new System.Drawing.Size(47, 16);
            this.lblTenis.TabIndex = 40;
            this.lblTenis.Text = "Tenis";
            // 
            // cmbTenis
            // 
            this.cmbTenis.Enabled = false;
            this.cmbTenis.FormattingEnabled = true;
            this.cmbTenis.Location = new System.Drawing.Point(116, 101);
            this.cmbTenis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTenis.Name = "cmbTenis";
            this.cmbTenis.Size = new System.Drawing.Size(163, 24);
            this.cmbTenis.TabIndex = 4;
            // 
            // chkGolf
            // 
            this.chkGolf.AutoSize = true;
            this.chkGolf.Location = new System.Drawing.Point(179, 28);
            this.chkGolf.Margin = new System.Windows.Forms.Padding(4);
            this.chkGolf.Name = "chkGolf";
            this.chkGolf.Size = new System.Drawing.Size(51, 20);
            this.chkGolf.TabIndex = 3;
            this.chkGolf.Text = "Golf";
            this.chkGolf.UseVisualStyleBackColor = true;
            // 
            // chkTenis
            // 
            this.chkTenis.AutoSize = true;
            this.chkTenis.Location = new System.Drawing.Point(43, 28);
            this.chkTenis.Margin = new System.Windows.Forms.Padding(4);
            this.chkTenis.Name = "chkTenis";
            this.chkTenis.Size = new System.Drawing.Size(61, 20);
            this.chkTenis.TabIndex = 2;
            this.chkTenis.Text = "Tenis";
            this.chkTenis.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 74);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Categoria";
            // 
            // BtnRegistar
            // 
            this.BtnRegistar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistar.Image")));
            this.BtnRegistar.Location = new System.Drawing.Point(895, 525);
            this.BtnRegistar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRegistar.Name = "BtnRegistar";
            this.BtnRegistar.Size = new System.Drawing.Size(81, 78);
            this.BtnRegistar.TabIndex = 80;
            this.BtnRegistar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRegistar.UseVisualStyleBackColor = true;
            // 
            // btnHuella
            // 
            this.btnHuella.Image = ((System.Drawing.Image)(resources.GetObject("btnHuella.Image")));
            this.btnHuella.Location = new System.Drawing.Point(719, 525);
            this.btnHuella.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuella.Name = "btnHuella";
            this.btnHuella.Size = new System.Drawing.Size(81, 80);
            this.btnHuella.TabIndex = 79;
            this.btnHuella.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(735, 434);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 78;
            this.label8.Text = "Huella";
            // 
            // btnCamara
            // 
            this.btnCamara.Image = ((System.Drawing.Image)(resources.GetObject("btnCamara.Image")));
            this.btnCamara.Location = new System.Drawing.Point(756, 333);
            this.btnCamara.Margin = new System.Windows.Forms.Padding(4);
            this.btnCamara.Name = "btnCamara";
            this.btnCamara.Size = new System.Drawing.Size(65, 48);
            this.btnCamara.TabIndex = 77;
            this.btnCamara.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(68, 368);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(412, 134);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(199, 23);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(93, 20);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(36, 23);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 20);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoria";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(195, 273);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(332, 22);
            this.txtCorreo.TabIndex = 75;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(195, 237);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(332, 22);
            this.txtCelular.TabIndex = 74;
            // 
            // txtClub
            // 
            this.txtClub.Location = new System.Drawing.Point(195, 207);
            this.txtClub.Margin = new System.Windows.Forms.Padding(4);
            this.txtClub.Name = "txtClub";
            this.txtClub.Size = new System.Drawing.Size(332, 22);
            this.txtClub.TabIndex = 73;
            // 
            // txtMaterno
            // 
            this.txtMaterno.Location = new System.Drawing.Point(195, 175);
            this.txtMaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(332, 22);
            this.txtMaterno.TabIndex = 72;
            // 
            // txtPaterno
            // 
            this.txtPaterno.Location = new System.Drawing.Point(195, 143);
            this.txtPaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(332, 22);
            this.txtPaterno.TabIndex = 71;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(195, 111);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(332, 22);
            this.txtNombre.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 147);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 69;
            this.label7.Text = "A. Paterno:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 179);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 68;
            this.label6.Text = "A. Materno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 67;
            this.label5.Text = "Club:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 66;
            this.label4.Text = "Celular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 273);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "Correo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "Nombre:";
            // 
            // Nodificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 612);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.videoCapture1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnRegistar);
            this.Controls.Add(this.btnHuella);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCamara);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtClub);
            this.Controls.Add(this.txtMaterno);
            this.Controls.Add(this.txtPaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Nodificar";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private VisioForge.Controls.UI.WinForms.VideoCapture videoCapture1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbltTitulo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblGolf;
        private System.Windows.Forms.ComboBox cmbGolf;
        private System.Windows.Forms.Label lblTenis;
        private System.Windows.Forms.ComboBox cmbTenis;
        private System.Windows.Forms.CheckBox chkGolf;
        private System.Windows.Forms.CheckBox chkTenis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnRegistar;
        private System.Windows.Forms.Button btnHuella;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCamara;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtClub;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}