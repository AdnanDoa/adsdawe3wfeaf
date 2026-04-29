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
    public partial class Form_Admin_KreiranjeAzuriranjeKupca : Form
    {
        DBKonekcija db = new DBKonekcija();

        public Form_Admin_KreiranjeAzuriranjeKupca()
        {
            InitializeComponent();
            PrikaziSveKupce();
        }

        
        private void PrikaziSveKupce()
        {
            try
            {
                string upit = "SELECT kupac_id, ime, prezime, grad, adresa, telefon, user FROM KUPAC ORDER BY kupac_id";

                db.OtvoriKonekciju();
                MySqlCommand cmd = new MySqlCommand(upit, db.OtvoriKonekciju());
                MySqlDataReader reader = cmd.ExecuteReader();

                DataGridViewKorisnici.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewKorisnici.Rows.Add(
                        reader["kupac_id"].ToString(),
                        reader["ime"].ToString(),
                        reader["prezime"].ToString(),
                        reader["grad"].ToString(),
                        reader["adresa"].ToString(),
                        reader["telefon"].ToString(),
                        reader["user"].ToString()
                    );
                }

                reader.Close();
                db.ZatvoriKonekciju();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }



        private void dataGridViewKorisnici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridViewKorisnici.Rows[e.RowIndex];

                textBoxID.Text = row.Cells[0].Value.ToString();
                textBoxIme.Text = row.Cells[1].Value.ToString();
                textBoxPrezime.Text = row.Cells[2].Value.ToString();
                textBoxGrad.Text = row.Cells[3].Value.ToString();
                textBoxAdresa.Text = row.Cells[4].Value.ToString();
                textBoxTelefon.Text = row.Cells[5].Value.ToString();
                textBoxKorisnickoIme.Text = row.Cells[6].Value.ToString();
                textBoxSifra.Text = "";
            }
        }

    

     

        private void OcistiPolja()
        {
            textBoxID.Text = "";
            textBoxIme.Text = "";
            textBoxPrezime.Text = "";
            textBoxGrad.Text = "";
            textBoxAdresa.Text = "";
            textBoxTelefon.Text = "";
            textBoxKorisnickoIme.Text = "";
            textBoxSifra.Text = "";
        }

        private string NapraviMD5(string unos)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] ulazniBajtovi = System.Text.Encoding.ASCII.GetBytes(unos);
                byte[] hashBajtovi = md5.ComputeHash(ulazniBajtovi);
                return BitConverter.ToString(hashBajtovi).Replace("-", "").ToLower();
            }
        }

        private void buttonTrazi_Click_1(object sender, EventArgs e)
        {
            string ime = textBoxIme1.Text.Trim();
            string prezime = textBoxPrezime1.Text.Trim();

            if (string.IsNullOrEmpty(ime) && string.IsNullOrEmpty(prezime))
            {
                PrikaziSveKupce();
                return;
            }

            try
            {
                string upit = "SELECT kupac_id, ime, prezime, grad, adresa, telefon, user FROM KUPAC WHERE 1=1";

                if (!string.IsNullOrEmpty(ime))
                    upit += " AND ime LIKE @ime";
                if (!string.IsNullOrEmpty(prezime))
                    upit += " AND prezime LIKE @prezime";

                upit += " ORDER BY kupac_id";

                db.OtvoriKonekciju();
                MySqlCommand cmd = new MySqlCommand(upit, db.OtvoriKonekciju());

                if (!string.IsNullOrEmpty(ime))
                    cmd.Parameters.AddWithValue("@ime", "%" + ime + "%");
                if (!string.IsNullOrEmpty(prezime))
                    cmd.Parameters.AddWithValue("@prezime", "%" + prezime + "%");

                MySqlDataReader reader = cmd.ExecuteReader();

                DataGridViewKorisnici.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewKorisnici.Rows.Add(
                        reader["kupac_id"].ToString(),
                        reader["ime"].ToString(),
                        reader["prezime"].ToString(),
                        reader["grad"].ToString(),
                        reader["adresa"].ToString(),
                        reader["telefon"].ToString(),
                        reader["user"].ToString()
                    );
                }

                reader.Close();
                db.ZatvoriKonekciju();

                if (DataGridViewKorisnici.Rows.Count == 0)
                {
                    MessageBox.Show("Nema korisnika koji odgovaraju pretrazi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void buttonKreiraj_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIme.Text) ||
              string.IsNullOrEmpty(textBoxPrezime.Text) ||
              string.IsNullOrEmpty(textBoxKorisnickoIme.Text) ||
              string.IsNullOrEmpty(textBoxSifra.Text))
            {
                MessageBox.Show("Popunite obavezna polja: Ime, Prezime, Korisničko ime i Šifra!");
                return;
            }

            try
            {
                string md5Lozinka = NapraviMD5(textBoxSifra.Text);

                string upit = @"INSERT INTO KUPAC (ime, prezime, grad, adresa, telefon, user, pass) 
                                VALUES (@ime, @prezime, @grad, @adresa, @telefon, @user, @pass)";

                db.OtvoriKonekciju();
                MySqlCommand cmd = new MySqlCommand(upit, db.OtvoriKonekciju());
                cmd.Parameters.AddWithValue("@ime", textBoxIme.Text);
                cmd.Parameters.AddWithValue("@prezime", textBoxPrezime.Text);
                cmd.Parameters.AddWithValue("@grad", textBoxGrad.Text);
                cmd.Parameters.AddWithValue("@adresa", textBoxAdresa.Text);
                cmd.Parameters.AddWithValue("@telefon", textBoxTelefon.Text);
                cmd.Parameters.AddWithValue("@user", textBoxKorisnickoIme.Text);
                cmd.Parameters.AddWithValue("@pass", md5Lozinka);

                cmd.ExecuteNonQuery();
                db.ZatvoriKonekciju();

                MessageBox.Show("Kupac uspješno kreiran!");
                OcistiPolja();
                PrikaziSveKupce();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void buttonAzuriraj_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxID.Text))
            {
                MessageBox.Show("Prvo kliknite na kupca u tabeli kojeg želite ažurirati!");
                return;
            }

            if (string.IsNullOrEmpty(textBoxIme.Text) ||
                string.IsNullOrEmpty(textBoxPrezime.Text) ||
                string.IsNullOrEmpty(textBoxKorisnickoIme.Text))
            {
                MessageBox.Show("Popunite obavezna polja: Ime, Prezime, Korisničko ime!");
                return;
            }

            try
            {
                string upit = @"UPDATE KUPAC SET 
                                ime = @ime, 
                                prezime = @prezime, 
                                grad = @grad, 
                                adresa = @adresa, 
                                telefon = @telefon, 
                                user = @user
                                WHERE kupac_id = @id";

                db.OtvoriKonekciju();
                MySqlCommand cmd = new MySqlCommand(upit, db.OtvoriKonekciju());
                cmd.Parameters.AddWithValue("@ime", textBoxIme.Text);
                cmd.Parameters.AddWithValue("@prezime", textBoxPrezime.Text);
                cmd.Parameters.AddWithValue("@grad", textBoxGrad.Text);
                cmd.Parameters.AddWithValue("@adresa", textBoxAdresa.Text);
                cmd.Parameters.AddWithValue("@telefon", textBoxTelefon.Text);
                cmd.Parameters.AddWithValue("@user", textBoxKorisnickoIme.Text);
                cmd.Parameters.AddWithValue("@id", textBoxID.Text);


                if (!string.IsNullOrEmpty(textBoxSifra.Text))
                {
                    string md5Lozinka = NapraviMD5(textBoxSifra.Text);
                    cmd.CommandText = "UPDATE KUPAC SET ime = @ime, prezime = @prezime, grad = @grad, adresa = @adresa, telefon = @telefon, user = @user, pass = @pass WHERE kupac_id = @id";
                    cmd.Parameters.AddWithValue("@pass", md5Lozinka);
                }

                int azurirano = cmd.ExecuteNonQuery();
                db.ZatvoriKonekciju();

                if (azurirano > 0)
                {
                    MessageBox.Show("Kupac uspješno ažuriran!");
                    OcistiPolja();
                    PrikaziSveKupce();
                }
                else
                {
                    MessageBox.Show("Kupac sa ID " + textBoxID.Text + " nije pronađen!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }
    }
}
