
namespace WindowsFormsApp3
{
    partial class Registro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltTitulo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblGolf = new System.Windows.Forms.Label();
            this.cmbGolf = new System.Windows.Forms.ComboBox();
            this.lblTenis = new System.Windows.Forms.Label();
            this.cmbTenis = new System.Windows.Forms.ComboBox();
            this.chkGolf = new System.Windows.Forms.CheckBox();
            this.chkTenis = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.BtnRegistar = new System.Windows.Forms.Button();
            this.btnHuella = new System.Windows.Forms.Button();
            this.btnCamara = new System.Windows.Forms.Button();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbltTitulo);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 69);
            this.panel1.TabIndex = 61;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(3, 59);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 10);
            this.panel2.TabIndex = 39;
            // 
            // lbltTitulo
            // 
            this.lbltTitulo.AutoSize = true;
            this.lbltTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltTitulo.Location = new System.Drawing.Point(420, 7);
            this.lbltTitulo.Name = "lbltTitulo";
            this.lbltTitulo.Size = new System.Drawing.Size(196, 39);
            this.lbltTitulo.TabIndex = 0;
            this.lbltTitulo.Text = "REGISTRO";
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
            this.groupBox2.Location = new System.Drawing.Point(78, 419);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(419, 199);
            this.groupBox2.TabIndex = 56;
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
            this.chkGolf.CheckedChanged += new System.EventHandler(this.chkGolf_CheckedChanged);
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
            this.chkTenis.CheckedChanged += new System.EventHandler(this.chkTenis_CheckedChanged);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(781, 465);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 53;
            this.label8.Text = "Huella";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(194, 341);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(332, 22);
            this.txtCorreo.TabIndex = 50;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(193, 290);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(332, 22);
            this.txtCelular.TabIndex = 49;
            // 
            // txtClub
            // 
            this.txtClub.Location = new System.Drawing.Point(195, 242);
            this.txtClub.Margin = new System.Windows.Forms.Padding(4);
            this.txtClub.Name = "txtClub";
            this.txtClub.Size = new System.Drawing.Size(332, 22);
            this.txtClub.TabIndex = 48;
            // 
            // txtMaterno
            // 
            this.txtMaterno.Location = new System.Drawing.Point(195, 192);
            this.txtMaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(332, 22);
            this.txtMaterno.TabIndex = 47;
            // 
            // txtPaterno
            // 
            this.txtPaterno.Location = new System.Drawing.Point(195, 151);
            this.txtPaterno.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(332, 22);
            this.txtPaterno.TabIndex = 46;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(195, 112);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(332, 22);
            this.txtNombre.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "A. Paterno:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "A. Materno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Club:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 294);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Celular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 347);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Correo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(854, 438);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 67);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(897, 561);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(81, 80);
            this.btnLimpiar.TabIndex = 60;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Image = ((System.Drawing.Image)(resources.GetObject("btnCapturar.Image")));
            this.btnCapturar.Location = new System.Drawing.Point(908, 377);
            this.btnCapturar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(65, 48);
            this.btnCapturar.TabIndex = 57;
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // BtnRegistar
            // 
            this.BtnRegistar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistar.Image")));
            this.BtnRegistar.Location = new System.Drawing.Point(984, 561);
            this.BtnRegistar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRegistar.Name = "BtnRegistar";
            this.BtnRegistar.Size = new System.Drawing.Size(81, 78);
            this.BtnRegistar.TabIndex = 55;
            this.BtnRegistar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRegistar.UseVisualStyleBackColor = true;
            this.BtnRegistar.Click += new System.EventHandler(this.btnRegistar_Click_1);
            // 
            // btnHuella
            // 
            this.btnHuella.Image = ((System.Drawing.Image)(resources.GetObject("btnHuella.Image")));
            this.btnHuella.Location = new System.Drawing.Point(808, 561);
            this.btnHuella.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuella.Name = "btnHuella";
            this.btnHuella.Size = new System.Drawing.Size(81, 80);
            this.btnHuella.TabIndex = 54;
            this.btnHuella.UseVisualStyleBackColor = true;
            // 
            // btnCamara
            // 
            this.btnCamara.Image = ((System.Drawing.Image)(resources.GetObject("btnCamara.Image")));
            this.btnCamara.Location = new System.Drawing.Point(824, 377);
            this.btnCamara.Margin = new System.Windows.Forms.Padding(4);
            this.btnCamara.Name = "btnCamara";
            this.btnCamara.Size = new System.Drawing.Size(65, 48);
            this.btnCamara.TabIndex = 52;
            this.btnCamara.UseVisualStyleBackColor = true;
            this.btnCamara.Click += new System.EventHandler(this.btnCamara_Click);
            // 
            // picFoto
            // 
            this.picFoto.ErrorImage = null;
            this.picFoto.Image = ((System.Drawing.Image)(resources.GetObject("picFoto.Image")));
            this.picFoto.InitialImage = null;
            this.picFoto.Location = new System.Drawing.Point(751, 93);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(347, 277);
            this.picFoto.TabIndex = 64;
            this.picFoto.TabStop = false;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 673);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnRegistar);
            this.Controls.Add(this.btnHuella);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCamara);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Registro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picFoto;
    }
}

