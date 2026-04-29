using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace projektni_zadatak
{
    internal class DBKonekcija
    {
        private MySqlConnection konekcija;
        private string server;
        private string port;
        private string baza;
        private string user;
        private string pass;
        private string konekcioniString;

        public DBKonekcija()
        {
            InicijalizirajKonekciju();
        }

        private void InicijalizirajKonekciju()
        {
            server = "localhost"; 
            port = "3306";
            baza = "projektni_zadatak";
            user = "root";
            pass = "";

            konekcioniString = "SERVER=" + server + ";" + "DATABASE=" + baza + ";" +
                "PORT=" + port + ";" + "UID=" + user + ";" + "PASSWORD=" + pass + ";";

           
            konekcija = new MySqlConnection(konekcioniString);
        }

        public MySqlConnection OtvoriKonekciju()
        {
            try
            {
                if (konekcija.State == ConnectionState.Closed)
                    konekcija.Open();
                return konekcija;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return konekcija;
            }
        }

        public void ZatvoriKonekciju()
        {
            try
            {
                if (konekcija.State == ConnectionState.Open)
                    konekcija.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
