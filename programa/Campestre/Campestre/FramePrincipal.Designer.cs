
namespace Campestre
{
    partial class FramePrincipal
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
            this.btnTenis = new System.Windows.Forms.Button();
            this.btnAlimentos = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnKits = new System.Windows.Forms.Button();
            this.btnAmstel = new System.Windows.Forms.Button();
            this.btnClausura = new System.Windows.Forms.Button();
            this.btnGolf = new System.Windows.Forms.Button();
            this.btnConcierto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTenis
            // 
            this.btnTenis.Location = new System.Drawing.Point(67, 78);
            this.btnTenis.Name = "btnTenis";
            this.btnTenis.Size = new System.Drawing.Size(198, 53);
            this.btnTenis.TabIndex = 0;
            this.btnTenis.Text = "Tenis";
            this.btnTenis.UseVisualStyleBackColor = true;
            this.btnTenis.Click += new System.EventHandler(this.btnTenis_Click);
            // 
            // btnAlimentos
            // 
            this.btnAlimentos.Location = new System.Drawing.Point(439, 245);
            this.btnAlimentos.Name = "btnAlimentos";
            this.btnAlimentos.Size = new System.Drawing.Size(198, 53);
            this.btnAlimentos.TabIndex = 1;
            this.btnAlimentos.Text = "Alimentos";
            this.btnAlimentos.UseVisualStyleBackColor = true;
            this.btnAlimentos.Click += new System.EventHandler(this.btnAlimentos_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(156, 245);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(198, 53);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnKits
            // 
            this.btnKits.Location = new System.Drawing.Point(301, 162);
            this.btnKits.Name = "btnKits";
            this.btnKits.Size = new System.Drawing.Size(198, 53);
            this.btnKits.TabIndex = 3;
            this.btnKits.Text = "Kit´s";
            this.btnKits.UseVisualStyleBackColor = true;
            this.btnKits.Click += new System.EventHandler(this.btnKits_Click);
            // 
            // btnAmstel
            // 
            this.btnAmstel.Location = new System.Drawing.Point(301, 78);
            this.btnAmstel.Name = "btnAmstel";
            this.btnAmstel.Size = new System.Drawing.Size(198, 53);
            this.btnAmstel.TabIndex = 4;
            this.btnAmstel.Text = "Amstel";
            this.btnAmstel.UseVisualStyleBackColor = true;
            this.btnAmstel.Click += new System.EventHandler(this.btnAmstel_Click);
            // 
            // btnClausura
            // 
            this.btnClausura.Location = new System.Drawing.Point(537, 78);
            this.btnClausura.Name = "btnClausura";
            this.btnClausura.Size = new System.Drawing.Size(198, 53);
            this.btnClausura.TabIndex = 5;
            this.btnClausura.Text = "Clausura";
            this.btnClausura.UseVisualStyleBackColor = true;
            this.btnClausura.Click += new System.EventHandler(this.btnClausura_Click);
            // 
            // btnGolf
            // 
            this.btnGolf.Location = new System.Drawing.Point(67, 162);
            this.btnGolf.Name = "btnGolf";
            this.btnGolf.Size = new System.Drawing.Size(198, 53);
            this.btnGolf.TabIndex = 6;
            this.btnGolf.Text = "Golf";
            this.btnGolf.UseVisualStyleBackColor = true;
            this.btnGolf.Click += new System.EventHandler(this.btnGolf_Click);
            // 
            // btnConcierto
            // 
            this.btnConcierto.Location = new System.Drawing.Point(537, 162);
            this.btnConcierto.Name = "btnConcierto";
            this.btnConcierto.Size = new System.Drawing.Size(198, 53);
            this.btnConcierto.TabIndex = 7;
            this.btnConcierto.Text = "Concierto";
            this.btnConcierto.UseVisualStyleBackColor = true;
            this.btnConcierto.Click += new System.EventHandler(this.btnConcierto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 413);
            this.Controls.Add(this.btnConcierto);
            this.Controls.Add(this.btnGolf);
            this.Controls.Add(this.btnClausura);
            this.Controls.Add(this.btnAmstel);
            this.Controls.Add(this.btnKits);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnAlimentos);
            this.Controls.Add(this.btnTenis);
            this.Name = "Form1";
            this.Text = "Campestre Torreon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTenis;
        private System.Windows.Forms.Button btnAlimentos;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnKits;
        private System.Windows.Forms.Button btnAmstel;
        private System.Windows.Forms.Button btnClausura;
        private System.Windows.Forms.Button btnGolf;
        private System.Windows.Forms.Button btnConcierto;
    }
}

