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
    public partial class Form_Admin_DodavanjeAzuriranjeArtikala : Form
    {
        DBKonekcija db = new DBKonekcija();

        public Form_Admin_DodavanjeAzuriranjeArtikala()
        {
            InitializeComponent();
            PrikaziSveArtikle();
        }

       
        private void PrikaziSveArtikle()
        {
            try
            {
                string upit = @"SELECT a.artikal_id, a.naziv_artikla, a.vrsta_artikla, a.cijena, s.kolicina_stanje 
                                FROM ARTIKAL a
                                LEFT JOIN SKLADISTE s ON a.artikal_id = s.artikal_id
                                ORDER BY a.artikal_id";

                db.OtvoriKonekciju();
                MySqlCommand cmd = new MySqlCommand(upit, db.OtvoriKonekciju());
                MySqlDataReader reader = cmd.ExecuteReader();

                DataGridViewArtikli.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewArtikli.Rows.Add(
                        reader["artikal_id"].ToString(),
                        reader["naziv_artikla"].ToString(),
                        reader["vrsta_artikla"].ToString(),
                        reader["cijena"].ToString(),
                        reader["kolicina_stanje"].ToString()
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



        
        private void dataGridViewArtikli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridViewArtikli.Rows[e.RowIndex];

                textBoxIDArt.Text = row.Cells[0].Value.ToString();
                textBoxNazivArt.Text = row.Cells[1].Value.ToString();
                textBoxVrstaArt.Text = row.Cells[2].Value.ToString();
                textBoxCijena.Text = row.Cells[3].Value.ToString();
                textBoxKolicina.Text = row.Cells[4].Value.ToString();
                numericUpDownDodajKol.Value = 0;
            }
        }
       
        private void OcistiPolja()
        {
            textBoxIDArt.Text = "";
            textBoxNazivArt.Text = "";
            textBoxVrstaArt.Text = "";
            textBoxCijena.Text = "";
            textBoxKolicina.Text = "";
            numericUpDownDodajKol.Value = 0;
        }

        private void buttonTrazi_Click_1(object sender, EventArgs e)
        {
            string sifra = textBoxSifraArtikla.Text.Trim();
            string naziv = textBoxNazivArtikla.Text.Trim();

            if (string.IsNullOrEmpty(sifra) && string.IsNullOrEmpty(naziv))
            {
                PrikaziSveArtikle();
                return;
            }

            try
            {
                string upit = @"SELECT a.artikal_id, a.naziv_artikla, a.vrsta_artikla, a.cijena, s.kolicina_stanje 
                                FROM ARTIKAL a
                                LEFT JOIN SKLADISTE s ON a.artikal_id = s.artikal_id
                                WHERE 1=1";

                if (!string.IsNullOrEmpty(sifra))
                    upit += " AND a.artikal_id LIKE @sifra";
                if (!string.IsNullOrEmpty(naziv))
                    upit += " AND a.naziv_artikla LIKE @naziv";

                upit += " ORDER BY a.artikal_id";

                db.OtvoriKonekciju();
                MySqlCommand cmd = new MySqlCommand(upit, db.OtvoriKonekciju());

                if (!string.IsNullOrEmpty(sifra))
                    cmd.Parameters.AddWithValue("@sifra", "%" + sifra + "%");
                if (!string.IsNullOrEmpty(naziv))
                    cmd.Parameters.AddWithValue("@naziv", "%" + naziv + "%");

                MySqlDataReader reader = cmd.ExecuteReader();

                DataGridViewArtikli.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewArtikli.Rows.Add(
                        reader["artikal_id"].ToString(),
                        reader["naziv_artikla"].ToString(),
                        reader["vrsta_artikla"].ToString(),
                        reader["cijena"].ToString(),
                        reader["kolicina_stanje"].ToString()
                    );
                }

                reader.Close();
                db.ZatvoriKonekciju();

                if (DataGridViewArtikli.Rows.Count == 0)
                {
                    MessageBox.Show("Nema artikala koji odgovaraju pretrazi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void buttonDodaj_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNazivArt.Text) ||
               string.IsNullOrEmpty(textBoxVrstaArt.Text) ||
               string.IsNullOrEmpty(textBoxCijena.Text))
            {
                MessageBox.Show("Popunite sva polja (naziv, vrsta, cijena)!");
                return;
            }

            try
            {
                double cijena = Convert.ToDouble(textBoxCijena.Text);
                int kolicina = string.IsNullOrEmpty(textBoxKolicina.Text) ? 0 : Convert.ToInt32(textBoxKolicina.Text);

                db.OtvoriKonekciju();

                
                string upit = @"INSERT INTO ARTIKAL (naziv_artikla, vrsta_artikla, cijena) 
                                VALUES (@naziv, @vrsta, @cijena)";

                MySqlCommand cmd = new MySqlCommand(upit, db.OtvoriKonekciju());
                cmd.Parameters.AddWithValue("@naziv", textBoxNazivArt.Text);
                cmd.Parameters.AddWithValue("@vrsta", textBoxVrstaArt.Text);
                cmd.Parameters.AddWithValue("@cijena", cijena);
                cmd.ExecuteNonQuery();

                
                long artikalID = cmd.LastInsertedId;

                
                string upitSkladiste = @"INSERT INTO SKLADISTE (artikal_id, kolicina_stanje) 
                                         VALUES (@artikal_id, @kolicina)";
                MySqlCommand cmdSkladiste = new MySqlCommand(upitSkladiste, db.OtvoriKonekciju());
                cmdSkladiste.Parameters.AddWithValue("@artikal_id", artikalID);
                cmdSkladiste.Parameters.AddWithValue("@kolicina", kolicina);
                cmdSkladiste.ExecuteNonQuery();

                db.ZatvoriKonekciju();

                MessageBox.Show("Artikal uspješno kreiran!");
                OcistiPolja();
                PrikaziSveArtikle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIDArt.Text))
            {
                MessageBox.Show("Prvo kliknite na artikal u tabeli!");
                return;
            }

            try
            {
                int artikalID = Convert.ToInt32(textBoxIDArt.Text);
                bool azurirajPodatke = false;
                bool azurirajKolicinu = false;

                MySqlConnection konekcija = db.OtvoriKonekciju();

                if (!string.IsNullOrEmpty(textBoxNazivArt.Text) &&
                    !string.IsNullOrEmpty(textBoxVrstaArt.Text) &&
                    !string.IsNullOrEmpty(textBoxCijena.Text))
                {
                    azurirajPodatke = true;
                }

               
                int dodajKolicinu = (int)numericUpDownDodajKol.Value;
                int novaKolicinaZaUnos = 0;

                if (dodajKolicinu > 0)
                {
                    azurirajKolicinu = true;
                    string upitDohvatiKolicinu = "SELECT kolicina_stanje FROM SKLADISTE WHERE artikal_id = @id";
                    MySqlCommand cmdDohvati = new MySqlCommand(upitDohvatiKolicinu, konekcija);
                    cmdDohvati.Parameters.AddWithValue("@id", artikalID);
                    int trenutnaKolicina = Convert.ToInt32(cmdDohvati.ExecuteScalar());
                    novaKolicinaZaUnos = trenutnaKolicina + dodajKolicinu;
                }
                else if (!string.IsNullOrEmpty(textBoxKolicina.Text))
                {
                    azurirajKolicinu = true;
                    novaKolicinaZaUnos = Convert.ToInt32(textBoxKolicina.Text);
                }

                if (!azurirajPodatke && !azurirajKolicinu)
                {
                    MessageBox.Show("Niste unijeli ništa za ažuriranje!\n- Popunite polja za ažuriranje podataka ILI\n- Povećajte količinu ILI\n- Izmijenite količinu direktno");
                    db.ZatvoriKonekciju();
                    return;
                }

                
                if (azurirajPodatke)
                {
                    double cijena = Convert.ToDouble(textBoxCijena.Text);
                    string upit = @"UPDATE ARTIKAL SET 
                            naziv_artikla = @naziv, 
                            vrsta_artikla = @vrsta, 
                            cijena = @cijena
                            WHERE artikal_id = @id";

                    MySqlCommand cmd = new MySqlCommand(upit, konekcija);
                    cmd.Parameters.AddWithValue("@naziv", textBoxNazivArt.Text);
                    cmd.Parameters.AddWithValue("@vrsta", textBoxVrstaArt.Text);
                    cmd.Parameters.AddWithValue("@cijena", cijena);
                    cmd.Parameters.AddWithValue("@id", artikalID);
                    cmd.ExecuteNonQuery();
                }

                
                if (azurirajKolicinu)
                {
                    string upitSkladiste = @"UPDATE SKLADISTE SET kolicina_stanje = @novaKolicina 
                                     WHERE artikal_id = @artikalID";
                    MySqlCommand cmdSkladiste = new MySqlCommand(upitSkladiste, konekcija);
                    cmdSkladiste.Parameters.AddWithValue("@novaKolicina", novaKolicinaZaUnos);
                    cmdSkladiste.Parameters.AddWithValue("@artikalID", artikalID);
                    cmdSkladiste.ExecuteNonQuery();
                }

                db.ZatvoriKonekciju();

               
                string poruka = "";
                if (azurirajPodatke && azurirajKolicinu)
                    poruka = "Podaci artikla i količina uspješno ažurirani!";
                else if (azurirajPodatke)
                    poruka = "Podaci artikla uspješno ažurirani!";
                else if (azurirajKolicinu)
                {
                    if ((int)numericUpDownDodajKol.Value > 0)
                        poruka = "Dodano " + numericUpDownDodajKol.Value + " kom. artikla! Nova količina: " + novaKolicinaZaUnos;
                    else
                        poruka = "Količina artikla uspješno ažurirana na " + novaKolicinaZaUnos + " kom!";
                }

                MessageBox.Show(poruka);

                OcistiPolja();
                PrikaziSveArtikle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }
    }
}
