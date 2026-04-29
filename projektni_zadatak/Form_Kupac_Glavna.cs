using MySql.Data.MySqlClient;
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
    public partial class Form_Kupac_Glavna : Form
    {
        private int trenutnaNarudzbenicaID = -1;
        private DataTable korpaTable;
        public Form_Kupac_Glavna()
        {
            InitializeComponent();
            this.Text = "Kupac - Glavna forma";
        }

        private void Form_Kupac_Glavna_Load(object sender, EventArgs e)
        {
            korpaTable = new DataTable();
            korpaTable.Columns.Add("artikal_id", typeof(int));
            korpaTable.Columns.Add("naziv_artikla", typeof(string));
            korpaTable.Columns.Add("cijena", typeof(decimal));
            korpaTable.Columns.Add("kolicina", typeof(int));
            korpaTable.Columns.Add("ukupno", typeof(decimal));

            dataGridView2.DataSource = korpaTable;

            if (dataGridView2.Columns["artikal_id"] != null)
                dataGridView2.Columns["artikal_id"].HeaderText = "ID";
            if (dataGridView2.Columns["naziv_artikla"] != null)
                dataGridView2.Columns["naziv_artikla"].HeaderText = "Naziv";
            if (dataGridView2.Columns["cijena"] != null)
                dataGridView2.Columns["cijena"].HeaderText = "Cijena";
            if (dataGridView2.Columns["kolicina"] != null)
                dataGridView2.Columns["kolicina"].HeaderText = "Količina";
            if (dataGridView2.Columns["ukupno"] != null)
                dataGridView2.Columns["ukupno"].HeaderText = "Ukupno";

            UcitajArtikle();
        }

        private void UcitajArtikle()
        {
            DBKonekcija db = new DBKonekcija();
            MySqlConnection conn = db.OtvoriKonekciju();
            string upit = @"SELECT a.artikal_id as ID, 
                               a.naziv_artikla as Naziv, 
                               a.vrsta_artikla as Vrsta, 
                               a.cijena as Cijena,
                               COALESCE(s.kolicina_stanje, 0) as Stanje
                        FROM ARTIKAL a
                        LEFT JOIN SKLADISTE s ON a.artikal_id = s.artikal_id";

            MySqlDataAdapter adapter = new MySqlDataAdapter(upit, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            db.ZatvoriKonekciju();
        }

        private void IzracunajTotal()
        {
            decimal total = 0;
            foreach (DataRow row in korpaTable.Rows)
            {
                total += Convert.ToDecimal(row["ukupno"]);
            }
            txtTotal.Text = total.ToString("0.00") + " KM";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdArtikla.Text))
            {
                MessageBox.Show("Unesite ID artikla!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtKolicina.Text))
            {
                MessageBox.Show("Unesite količinu!");
                return;
            }

            int artikalID = Convert.ToInt32(txtIdArtikla.Text);
            int kolicina = Convert.ToInt32(txtKolicina.Text);

            DBKonekcija db = new DBKonekcija();
            MySqlConnection conn = db.OtvoriKonekciju();

            string upit = @"SELECT a.naziv_artikla, a.cijena, COALESCE(s.kolicina_stanje, 0) as stanje 
                    FROM ARTIKAL a 
                    LEFT JOIN SKLADISTE s ON a.artikal_id = s.artikal_id 
                    WHERE a.artikal_id = @id";

            MySqlCommand cmd = new MySqlCommand(upit, conn);
            cmd.Parameters.AddWithValue("@id", artikalID);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                int stanje = Convert.ToInt32(reader["stanje"]);
                string naziv = reader["naziv_artikla"].ToString();
                decimal cijena = Convert.ToDecimal(reader["cijena"]);

                reader.Close();

                if (kolicina > stanje)
                {
                    MessageBox.Show($"Nema dovoljno na stanju! Stanje: {stanje}");
                    db.ZatvoriKonekciju();
                    return;
                }

                decimal ukupno = cijena * kolicina;

                DataRow[] postojeci = korpaTable.Select($"artikal_id = {artikalID}");
                if (postojeci.Length > 0)
                {
                    int novaKolicina = Convert.ToInt32(postojeci[0]["kolicina"]) + kolicina;
                    decimal novoUkupno = cijena * novaKolicina;
                    postojeci[0]["kolicina"] = novaKolicina;
                    postojeci[0]["ukupno"] = novoUkupno;
                }
                else
                {
                    korpaTable.Rows.Add(artikalID, naziv, cijena, kolicina, ukupno);
                }

                string updateStanje = "UPDATE SKLADISTE SET kolicina_stanje = kolicina_stanje - @kol WHERE artikal_id = @id";
                MySqlCommand cmdUpdate = new MySqlCommand(updateStanje, conn);
                cmdUpdate.Parameters.AddWithValue("@kol", kolicina);
                cmdUpdate.Parameters.AddWithValue("@id", artikalID);
                cmdUpdate.ExecuteNonQuery();

                UcitajArtikle();
                IzracunajTotal();
                txtIdArtikla.Text = "";
                txtKolicina.Text = "";

                MessageBox.Show("Artikal dodat u korpu!");
            }
            else
            {
                reader.Close();
                MessageBox.Show("Artikal sa tim ID ne postoji!");
            }

            db.ZatvoriKonekciju();
            IzracunajTotal();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selektujte artikal koji zelite obrisati!");
                return;
            }

            int artikalID = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["artikal_id"].Value);
            int kolicina = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["kolicina"].Value);

            DBKonekcija db = new DBKonekcija();
            MySqlConnection conn = db.OtvoriKonekciju();

            string sql = "UPDATE SKLADISTE SET kolicina_stanje = kolicina_stanje + @kol WHERE artikal_id = @id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@kol", kolicina);
            cmd.Parameters.AddWithValue("@id", artikalID);
            cmd.ExecuteNonQuery();

            db.ZatvoriKonekciju();

            dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
            UcitajArtikle();
            IzracunajTotal();

            MessageBox.Show("Artikal obrisan iz korpe!");
        }

        private void btnKreirajNarudzbu_Click(object sender, EventArgs e)
        {
            if (korpaTable.Rows.Count == 0)
            {
                MessageBox.Show("Korpa je prazna!");
                return;
            }

            int logovaniKupacID = Convert.ToInt32(Form_Prijava.prijavljeniKupacID);

            DBKonekcija db = new DBKonekcija();
            MySqlConnection conn = db.OtvoriKonekciju();

            string insertNarudzba = "INSERT INTO NARUDZBENICA (kupac_id, datum_narudzbe) VALUES (@kupac_id, CURDATE())";
            MySqlCommand cmdNarudzba = new MySqlCommand(insertNarudzba, conn);
            cmdNarudzba.Parameters.AddWithValue("@kupac_id", logovaniKupacID);
            cmdNarudzba.ExecuteNonQuery();

            int narudzbenicaID = (int)cmdNarudzba.LastInsertedId;

            foreach (DataRow row in korpaTable.Rows)
            {
                int artikalID = Convert.ToInt32(row["artikal_id"]);
                int kolicina = Convert.ToInt32(row["kolicina"]);

                string insertStavka = "INSERT INTO STAVKA_NARUDZBENICE (narudzbenica_id, artikal_id, kolicina) VALUES (@narudzbenica_id, @artikal_id, @kolicina)";
                MySqlCommand cmdStavka = new MySqlCommand(insertStavka, conn);
                cmdStavka.Parameters.AddWithValue("@narudzbenica_id", narudzbenicaID);
                cmdStavka.Parameters.AddWithValue("@artikal_id", artikalID);
                cmdStavka.Parameters.AddWithValue("@kolicina", kolicina);
                cmdStavka.ExecuteNonQuery();
            }

            korpaTable.Clear();
            IzracunajTotal();
            UcitajArtikle();

            MessageBox.Show("Narudžba uspješno kreirana!");
            db.ZatvoriKonekciju();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}