using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektni_zadatak
{
    public partial class Form_Admin_Glavna : Form
    {
        public Form_Admin_Glavna()
        {
            InitializeComponent();
        }



        private void prikazBrisanjeNarudžbiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Admin_PrikazBrisanje forma = new Form_Admin_PrikazBrisanje();
            forma.ShowDialog();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Prijava frmPrijava = new Form_Prijava();
            this.Hide();
            frmPrijava.Show();
        }

        private void dodavanjeAzuriranjeArtikalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Admin_DodavanjeAzuriranjeArtikala forma = new Form_Admin_DodavanjeAzuriranjeArtikala();
            forma.ShowDialog();
        }

        private void kreiranjeAzuriranjeKupacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Admin_KreiranjeAzuriranjeKupca forma = new Form_Admin_KreiranjeAzuriranjeKupca();
            forma.ShowDialog();
        }
    }
}
