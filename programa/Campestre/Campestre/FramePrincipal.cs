using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campestre
{
    public partial class FramePrincipal : Form
    {
        public FramePrincipal()
        {
            InitializeComponent();
        }

        private void btnTenis_Click(object sender, EventArgs e)
        {
            FrameRegistro tenis = new FrameRegistro();
            tenis.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrameRegistro registrar = new FrameRegistro();
            registrar.Show();
        }

        private void btnAlimentos_Click(object sender, EventArgs e)
        {
            Form4 Alimentos = new Form4();
            Alimentos.Show();
        }

        private void btnClausura_Click(object sender, EventArgs e)
        {
            Form5 Clausura = new Form5();
            Clausura.Show();
        }

        private void btnGolf_Click(object sender, EventArgs e)
        {
            Form6 Golf = new Form6();
            Golf.Show();
        }

        private void btnAmstel_Click(object sender, EventArgs e)
        {
            Form7 Amstel = new Form7();
            Amstel.Show();
        }

        private void btnKits_Click(object sender, EventArgs e)
        {
            Kits kit = new Kits();
            kit.Show();
        }

        private void btnConcierto_Click(object sender, EventArgs e)
        {
            Form9 concierto = new Form9();
            concierto.Show();
        }
    }
}