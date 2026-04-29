using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projektni_zadatak
{
    public partial class Form_Admin_PrikazBrisanje : Form
    {
        DBKonekcija db = new DBKonekcija();

        public Form_Admin_PrikazBrisanje()
        {
            InitializeComponent();
            PrikaziSveNarudzbe();
        }
        private void PrikaziSveNarudzbe()
        {
            try
            {
                string upit = @"SELECT n.narudzbenica_id, 
                                       CONCAT(k.ime, ' ', k.prezime) AS kupac, 
                                       n.datum_narudzbe
                                FROM NARUDZBENICA n
                                INNER JOIN KUPAC k ON n.kupac_id = k.kupac_id
                                ORDER BY n.datum_narudzbe DESC";

                db.OtvoriKonekciju();
                MySqlCommand cmd = new MySqlCommand(upit, db.OtvoriKonekciju());
                MySqlDataReader reader = cmd.ExecuteReader();

                DataGridViewNarudzbe.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewNarudzbe.Rows.Add(
                        reader["narudzbenica_id"].ToString(),
                        reader["kupac"].ToString(),
                        Convert.ToDateTime(reader["datum_narudzbe"]).ToString("dd.MM.yyyy")
                    );
                }

                reader.Close();
                db.ZatvoriKonekciju();

                if (DataGridViewNarudzbe.Rows.Count == 0)
                {
                    MessageBox.Show("Nema evidentiranih narudžbi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void DataGridViewNarudzbe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridViewNarudzbe.Rows[e.RowIndex];
                textBoxIDnarudzbe.Text = row.Cells[0].Value.ToString();
            }
        }

        private void ObrisiNarudzbu()
        {
            string narudzbaID = textBoxIDnarudzbe.Text.Trim();

            if (string.IsNullOrEmpty(narudzbaID))
            {
                MessageBox.Show("Unesite ID narudžbe ili kliknite na red u tabeli!");
                return;
            }

            DialogResult odgovor = MessageBox.Show("Da li ste sigurni da želite obrisati narudžbu " + narudzbaID + " i sve njene stavke?",
                                                    "Potvrda brisanja",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

            if (odgovor == DialogResult.Yes)
            {
                try
                {
                    db.OtvoriKonekciju();

                    string brisanjeStavki = "DELETE FROM STAVKA_NARUDZBENICE WHERE narudzbenica_id = @id";
                    MySqlCommand cmdStavke = new MySqlCommand(brisanjeStavki, db.OtvoriKonekciju());
                    cmdStavke.Parameters.AddWithValue("@id", narudzbaID);
                    cmdStavke.ExecuteNonQuery();

                    string brisanjeNarudzbe = "DELETE FROM NARUDZBENICA WHERE narudzbenica_id = @id";
                    MySqlCommand cmdNarudzba = new MySqlCommand(brisanjeNarudzbe, db.OtvoriKonekciju());
                    cmdNarudzba.Parameters.AddWithValue("@id", narudzbaID);
                    int redova = cmdNarudzba.ExecuteNonQuery();

                    db.ZatvoriKonekciju();

                    if (redova > 0)
                    {
                        MessageBox.Show("Narudžba " + narudzbaID + " je uspješno obrisana.");
                        textBoxIDnarudzbe.Text = "";
                        PrikaziSveNarudzbe();
                    }
                    else
                    {
                        MessageBox.Show("Narudžba nije pronađena!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri brisanju: " + ex.Message);
                }
            }
        }

        private void buttonOsvezi_Click(object sender, EventArgs e)
        {
            textBoxIDnarudzbe.Text = "";
            PrikaziSveNarudzbe();
        }

    

        private void buttonObrisi_Click_1(object sender, EventArgs e)
        {
            ObrisiNarudzbu();
        }
    }
}
