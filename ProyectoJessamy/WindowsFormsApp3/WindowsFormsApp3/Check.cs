using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Check : Form
    {
        //La variable menuAnterior guardara el menu el cual pasamos para llegar a esta pantalla
        Menu menuAnterior;

        //El valor menu sera el form anterior
        public Check(Menu menu)
        {
            InitializeComponent();
            
            //El siguiente metodo ubicara nuestro Form en medio de la pantalla del usuario
            this.CenterToScreen();
            //Ocultamos el boton con el cual se registrara una entrega
            btnEntregado.Visible = false;
            //menuAnterior guarda el menu el cual pasamos para llegar a esta pantalla
            menuAnterior = menu;
            //Creamos el evento de cierre del Form
            this.FormClosing += Check_FormClosing;
        }

        private void Check_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Mostramos el menu que anteriormente pasamos
            menuAnterior.Visible = true;
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
