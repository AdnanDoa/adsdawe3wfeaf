using MySql.Data.MySqlClient;

namespace projektni_zadatak
{
    public partial class Form_Prijava : Form
    {

        public static string prijavljeniKupacID = "";
        public static string prijavljeniKupacIme = "";

        public Form_Prijava()
        {
            InitializeComponent();
        }

        private void buttonPrijaviSe_Click(object sender, EventArgs e)
        {
            string korisnickoIme = textBoxKorisnickoIme.Text.Trim();
            string lozinka = textBoxLozinka.Text.Trim();

            if (string.IsNullOrEmpty(korisnickoIme) || string.IsNullOrEmpty(lozinka))
            {
                MessageBox.Show("Unesite korisnièko ime i lozinku!");
                return;
            }

            string hashLozinke = NapraviMD5(lozinka);

            string upit = "SELECT kupac_id, ime, prezime, tip_korisnika FROM KUPAC WHERE user = @user AND pass = @pass";

            try
            {
                DBKonekcija db = new DBKonekcija();
                MySqlCommand cmd = new MySqlCommand(upit, db.OtvoriKonekciju());
                cmd.Parameters.AddWithValue("@user", korisnickoIme);
                cmd.Parameters.AddWithValue("@pass", hashLozinke);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    prijavljeniKupacID = reader["kupac_id"].ToString();
                    prijavljeniKupacIme = reader["ime"].ToString() + " " + reader["prezime"].ToString();
                    string tipKorisnika = reader["tip_korisnika"].ToString();

                    reader.Close();
                    db.ZatvoriKonekciju();

                    if (tipKorisnika == "1") 
                    {
                        MessageBox.Show("Dobrodošli, administratore " + prijavljeniKupacIme);
                        Form_Admin_Glavna adminForma = new Form_Admin_Glavna();
                        this.Hide();
                        adminForma.Show();
                    }
                    else 
                    {
                        MessageBox.Show("Dobrodošli, " + prijavljeniKupacIme);
                        Form_Kupac_Glavna kupacForma = new Form_Kupac_Glavna();
                        this.Hide();
                        kupacForma.Show();
                    }
                }
                else
                {
                    reader.Close();
                    db.ZatvoriKonekciju();
                    MessageBox.Show("Pogrešno korisnièko ime ili lozinka!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
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

        private void Form_Prijava_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
