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
    public partial class Nodificar : Form
    {
        public Nodificar()
        {
            InitializeComponent();
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
            cmbTenis.Text = "";
            cmbTenis.Enabled = false;
            cmbGolf.Enabled = false;
        }
    }
}
