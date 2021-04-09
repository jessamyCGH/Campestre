
namespace WindowsFormsApp3
{
    partial class Check
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.cbBoxNombre = new System.Windows.Forms.ComboBox();
            this.txtUsuario = new System.Windows.Forms.RichTextBox();
            this.lblEntregado = new System.Windows.Forms.Label();
            this.btnEntregado = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnFalse = new System.Windows.Forms.Button();
            this.btnTrue = new System.Windows.Forms.Button();
            this.pcBoxImagen = new System.Windows.Forms.PictureBox();
            this.btnClausura = new System.Windows.Forms.Button();
            this.btnInaguracion = new System.Windows.Forms.Button();
            this.btnGolf = new System.Windows.Forms.Button();
            this.btnTennis = new System.Windows.Forms.Button();
            this.btnCerveza = new System.Windows.Forms.Button();
            this.btnConcierto = new System.Windows.Forms.Button();
            this.btnAlimentos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(196, 211);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(208, 39);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Inaguracion";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(140, 282);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(177, 24);
            this.lblBuscar.TabIndex = 8;
            this.lblBuscar.Text = "Buscar por nombre:";
            // 
            // cbBoxNombre
            // 
            this.cbBoxNombre.FormattingEnabled = true;
            this.cbBoxNombre.Location = new System.Drawing.Point(144, 309);
            this.cbBoxNombre.Name = "cbBoxNombre";
            this.cbBoxNombre.Size = new System.Drawing.Size(349, 21);
            this.cbBoxNombre.TabIndex = 9;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(332, 381);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(238, 243);
            this.txtUsuario.TabIndex = 11;
            this.txtUsuario.Text = "";
            // 
            // lblEntregado
            // 
            this.lblEntregado.AutoSize = true;
            this.lblEntregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntregado.Location = new System.Drawing.Point(634, 223);
            this.lblEntregado.Name = "lblEntregado";
            this.lblEntregado.Size = new System.Drawing.Size(218, 25);
            this.lblEntregado.TabIndex = 12;
            this.lblEntregado.Text = "Verificando entrega";
            // 
            // btnEntregado
            // 
            this.btnEntregado.Enabled = false;
            this.btnEntregado.Location = new System.Drawing.Point(639, 381);
            this.btnEntregado.Name = "btnEntregado";
            this.btnEntregado.Size = new System.Drawing.Size(214, 23);
            this.btnEntregado.TabIndex = 15;
            this.btnEntregado.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReporte);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Location = new System.Drawing.Point(586, 422);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 234);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generar reportes";
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(53, 199);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(214, 23);
            this.btnReporte.TabIndex = 18;
            this.btnReporte.Text = "Generar reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(28, 25);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // btnFalse
            // 
            this.btnFalse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnFalse.Enabled = false;
            this.btnFalse.Image = global::WindowsFormsApp3.Properties.Resources._false;
            this.btnFalse.Location = new System.Drawing.Point(771, 262);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(111, 111);
            this.btnFalse.TabIndex = 14;
            this.btnFalse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFalse.UseVisualStyleBackColor = false;
            // 
            // btnTrue
            // 
            this.btnTrue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnTrue.Enabled = false;
            this.btnTrue.Image = global::WindowsFormsApp3.Properties.Resources._true;
            this.btnTrue.Location = new System.Drawing.Point(610, 262);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(111, 111);
            this.btnTrue.TabIndex = 13;
            this.btnTrue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTrue.UseVisualStyleBackColor = false;
            // 
            // pcBoxImagen
            // 
            this.pcBoxImagen.Location = new System.Drawing.Point(74, 381);
            this.pcBoxImagen.Name = "pcBoxImagen";
            this.pcBoxImagen.Size = new System.Drawing.Size(243, 243);
            this.pcBoxImagen.TabIndex = 10;
            this.pcBoxImagen.TabStop = false;
            // 
            // btnClausura
            // 
            this.btnClausura.Image = global::WindowsFormsApp3.Properties.Resources.Clausura;
            this.btnClausura.Location = new System.Drawing.Point(800, 40);
            this.btnClausura.Name = "btnClausura";
            this.btnClausura.Size = new System.Drawing.Size(111, 111);
            this.btnClausura.TabIndex = 6;
            this.btnClausura.Text = "Clausura";
            this.btnClausura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClausura.UseVisualStyleBackColor = true;
            this.btnClausura.Click += new System.EventHandler(this.btnClausura_Click);
            // 
            // btnInaguracion
            // 
            this.btnInaguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.btnInaguracion.Image = global::WindowsFormsApp3.Properties.Resources.Apertura;
            this.btnInaguracion.Location = new System.Drawing.Point(98, 40);
            this.btnInaguracion.Name = "btnInaguracion";
            this.btnInaguracion.Size = new System.Drawing.Size(111, 111);
            this.btnInaguracion.TabIndex = 5;
            this.btnInaguracion.Text = "Inaguracion";
            this.btnInaguracion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInaguracion.UseVisualStyleBackColor = false;
            this.btnInaguracion.Click += new System.EventHandler(this.btnInaguracion_Click);
            // 
            // btnGolf
            // 
            this.btnGolf.Image = global::WindowsFormsApp3.Properties.Resources.golf;
            this.btnGolf.Location = new System.Drawing.Point(566, 40);
            this.btnGolf.Name = "btnGolf";
            this.btnGolf.Size = new System.Drawing.Size(111, 111);
            this.btnGolf.TabIndex = 4;
            this.btnGolf.Text = "Golf";
            this.btnGolf.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGolf.UseVisualStyleBackColor = true;
            this.btnGolf.Click += new System.EventHandler(this.btnGolf_Click);
            // 
            // btnTennis
            // 
            this.btnTennis.Image = global::WindowsFormsApp3.Properties.Resources.tennis;
            this.btnTennis.Location = new System.Drawing.Point(449, 40);
            this.btnTennis.Name = "btnTennis";
            this.btnTennis.Size = new System.Drawing.Size(111, 111);
            this.btnTennis.TabIndex = 3;
            this.btnTennis.Text = "Tennis";
            this.btnTennis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTennis.UseVisualStyleBackColor = true;
            this.btnTennis.Click += new System.EventHandler(this.btnTennis_Click);
            // 
            // btnCerveza
            // 
            this.btnCerveza.Image = global::WindowsFormsApp3.Properties.Resources.cerveza;
            this.btnCerveza.Location = new System.Drawing.Point(332, 40);
            this.btnCerveza.Name = "btnCerveza";
            this.btnCerveza.Size = new System.Drawing.Size(111, 111);
            this.btnCerveza.TabIndex = 2;
            this.btnCerveza.Text = "Cerveza";
            this.btnCerveza.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerveza.UseVisualStyleBackColor = true;
            this.btnCerveza.Click += new System.EventHandler(this.btnCerveza_Click);
            // 
            // btnConcierto
            // 
            this.btnConcierto.Image = global::WindowsFormsApp3.Properties.Resources.concierto;
            this.btnConcierto.Location = new System.Drawing.Point(683, 40);
            this.btnConcierto.Name = "btnConcierto";
            this.btnConcierto.Size = new System.Drawing.Size(111, 111);
            this.btnConcierto.TabIndex = 1;
            this.btnConcierto.Text = "Concierto";
            this.btnConcierto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConcierto.UseVisualStyleBackColor = true;
            this.btnConcierto.Click += new System.EventHandler(this.btnConcierto_Click);
            // 
            // btnAlimentos
            // 
            this.btnAlimentos.Image = global::WindowsFormsApp3.Properties.Resources.alimentos;
            this.btnAlimentos.Location = new System.Drawing.Point(215, 40);
            this.btnAlimentos.Name = "btnAlimentos";
            this.btnAlimentos.Size = new System.Drawing.Size(111, 111);
            this.btnAlimentos.TabIndex = 0;
            this.btnAlimentos.Text = "Alimentos";
            this.btnAlimentos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlimentos.UseVisualStyleBackColor = true;
            this.btnAlimentos.Click += new System.EventHandler(this.btnAlimentos_Click);
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1020, 695);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEntregado);
            this.Controls.Add(this.btnFalse);
            this.Controls.Add(this.btnTrue);
            this.Controls.Add(this.lblEntregado);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pcBoxImagen);
            this.Controls.Add(this.cbBoxNombre);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnClausura);
            this.Controls.Add(this.btnInaguracion);
            this.Controls.Add(this.btnGolf);
            this.Controls.Add(this.btnTennis);
            this.Controls.Add(this.btnCerveza);
            this.Controls.Add(this.btnConcierto);
            this.Controls.Add(this.btnAlimentos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Check";
            this.Text = "Check";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlimentos;
        private System.Windows.Forms.Button btnConcierto;
        private System.Windows.Forms.Button btnCerveza;
        private System.Windows.Forms.Button btnInaguracion;
        private System.Windows.Forms.Button btnGolf;
        private System.Windows.Forms.Button btnTennis;
        private System.Windows.Forms.Button btnClausura;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox cbBoxNombre;
        private System.Windows.Forms.PictureBox pcBoxImagen;
        private System.Windows.Forms.RichTextBox txtUsuario;
        private System.Windows.Forms.Label lblEntregado;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.Button btnFalse;
        private System.Windows.Forms.Button btnEntregado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}