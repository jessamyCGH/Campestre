using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //Creamos un objeto del Form check para despues modificar sus propiedades
            Check check = new Check(this);
            //Al objeto anterior le damos un titulo
            check.Text = "Menu";
            //Un tipo de borde para el objeto check
            check.FormBorderStyle = FormBorderStyle.FixedDialog;
            //Le removemos el boton de minimizar al objeto check
            check.MinimizeBox = false;
            //Le removemos el boton de maximizar al objeto check
            check.MaximizeBox = false;

            //Mostramos el Form check
            check.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //Creamos un objeto del Form check para despues modificar sus propiedades
            Registro registro = new Registro(this);
            //Al objeto anterior le damos un titulo
            registro.Text = "Menu";
            //Un tipo de borde para el objeto check
            registro.FormBorderStyle = FormBorderStyle.FixedDialog;
            //Le removemos el boton de minimizar al objeto check
            registro.MinimizeBox = false;
            //Le removemos el boton de maximizar al objeto check
            registro.MaximizeBox = false;

            //Mostramos el Form check
            registro.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Modificar modificar = new Modificar();
            modificar.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
