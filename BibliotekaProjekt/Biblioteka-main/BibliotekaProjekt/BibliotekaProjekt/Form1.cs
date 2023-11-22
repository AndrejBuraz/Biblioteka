using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotekaProjekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KnjigeUnos novaForma = new KnjigeUnos();
            novaForma.Show();
        }

        private void btnKoUnos_Click(object sender, EventArgs e)
        {
            KorisnikUnos novaForma = new KorisnikUnos();
            novaForma.Show();
        }

        private void btnEvZad_Click(object sender, EventArgs e)
        {
            UnosEvidencija novaForma = new UnosEvidencija();
            novaForma.Show();
        }

        private void btnKnPopis_Click(object sender, EventArgs e)
        {
            FormKnjigePopis novaForma = new FormKnjigePopis();
            novaForma.Show();
        }

        private void btnKoPopis_Click(object sender, EventArgs e)
        {
            FormKorisniciPopis novaForma = new FormKorisniciPopis();
            novaForma.Show();
        }

        private void btnEvPov_Click(object sender, EventArgs e)
        {
            EvidencijaPovijest novaForma = new EvidencijaPovijest();
            novaForma.Show();

        }
    }
}
