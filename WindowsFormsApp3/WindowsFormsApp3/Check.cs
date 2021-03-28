using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Check : Form
    {
        public Check()
        {
            InitializeComponent();
            
            //El siguiente metodo ubicara nuestro Form en medio de la pantalla del usuario
            this.CenterToScreen();
            //Ocultamos el boton con el cual se registrara una entrega
            btnEntregado.Visible = false;
        }

        private void btnInaguracion_Click(object sender, EventArgs e)
        {
            //Intercambiamos el texto del titulo por el texto del boton btnInaguracion
            lblTitulo.Text = btnInaguracion.Text;
        }

        private void btnAlimentos_Click(object sender, EventArgs e)
        {
            //Intercambiamos el texto del titulo por el texto del boton btnAlimentos
            lblTitulo.Text = btnAlimentos.Text;
        }

        private void btnCerveza_Click(object sender, EventArgs e)
        {
            //Intercambiamos el texto del titulo por el texto del boton btnCerveza
            lblTitulo.Text = btnCerveza.Text;
        }

        private void btnTennis_Click(object sender, EventArgs e)
        {
            //Intercambiamos el texto del titulo por el texto del boton btnTennis
            lblTitulo.Text = btnTennis.Text;
        }

        private void btnGolf_Click(object sender, EventArgs e)
        {
            //Intercambiamos el texto del titulo por el texto del boton btnGolf
            lblTitulo.Text = btnGolf.Text;
        }

        private void btnConcierto_Click(object sender, EventArgs e)
        {
            //Intercambiamos el texto del titulo por el texto del boton btnConcierto
            lblTitulo.Text = btnConcierto.Text;
        }

        private void btnClausura_Click(object sender, EventArgs e)
        {
            //Intercambiamos el texto del titulo por el texto del boton btnClausura
            lblTitulo.Text = btnClausura.Text;
        }
    }
}
