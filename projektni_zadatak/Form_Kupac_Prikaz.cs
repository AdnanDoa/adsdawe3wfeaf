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
    public partial class Form_Kupac_PregledNarudzbi : Form
    {
        public Form_Kupac_PregledNarudzbi()
        {
            InitializeComponent();
            UcitajNarudzbe();
        }

        private void Prikazi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDNarudzbe.Text))
            {
                MessageBox.Show("Unesite ID narudžbe!");
                return;
            }

            int narudzbenicaID = Convert.ToInt32(txtIDNarudzbe.Text);
            int logovaniKupacID = Convert.ToInt32(Form_Prijava.prijavljeniKupacID);

            DBKonekcija db = new DBKonekcija();
            MySqlConnection conn = db.OtvoriKonekciju();

            string provjeraUpit = @"SELECT COUNT(*) FROM NARUDZBENICA 
                                    WHERE narudzbenica_id = @narudzbenica_id 
                                    AND kupac_id = @kupac_id";

            MySqlCommand cmdProvjera = new MySqlCommand(provjeraUpit, conn);
            cmdProvjera.Parameters.AddWithValue("@narudzbenica_id", narudzbenicaID);
            cmdProvjera.Parameters.AddWithValue("@kupac_id", logovaniKupacID);

            int postoji = Convert.ToInt32(cmdProvjera.ExecuteScalar());

            if (postoji == 0)
            {
                MessageBox.Show("Narudžba sa tim ID ne postoji ili nije vaša!");
                db.ZatvoriKonekciju();
                return;
            }

            string upit = @"SELECT sk.artikal_id as ID,
                                   a.naziv_artikla as Naziv,
                                   sk.kolicina as Kolicina,
                                   a.cijena as Cijena,
                                   (sk.kolicina * a.cijena) as Ukupno
                            FROM STAVKA_NARUDZBENICE sk
                            JOIN ARTIKAL a ON sk.artikal_id = a.artikal_id
                            WHERE sk.narudzbenica_id = @narudzbenica_id";

            MySqlCommand cmd = new MySqlCommand(upit, conn);
            cmd.Parameters.AddWithValue("@narudzbenica_id", narudzbenicaID);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;

            decimal total = 0;
            foreach (DataRow row in dt.Rows)
            {
                total += Convert.ToDecimal(row["Ukupno"]);
            }
            txtTotal.Text = total.ToString("0.00") + " KM";

            db.ZatvoriKonekciju();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form_Kupac_PregledNarudzbi));
            groupBox1 = new GroupBox();
            Prikazi = new Button();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            txtTotal = new MaskedTextBox();
            txtIDNarudzbe = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)dataGridView2).BeginInit();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(Prikazi);
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(txtIDNarudzbe);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            groupBox1.Location = new Point(-3, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(640, 490);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prikaz narudžbi i stavki";
            // 
            // Prikazi
            // 
            Prikazi.BackColor = Color.FromArgb(154, 189, 220);
            Prikazi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Prikazi.Location = new Point(427, 334);
            Prikazi.Name = "Prikazi";
            Prikazi.Size = new Size(75, 23);
            Prikazi.TabIndex = 9;
            Prikazi.Text = "Prikaži";
            Prikazi.UseVisualStyleBackColor = false;
            Prikazi.Click += Prikazi_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(220, 56);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(264, 234);
            dataGridView2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(181, 234);
            dataGridView1.TabIndex = 7;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(334, 364);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(87, 29);
            txtTotal.TabIndex = 6;
            // 
            // txtIDNarudzbe
            // 
            txtIDNarudzbe.Location = new Point(334, 335);
            txtIDNarudzbe.Name = "txtIDNarudzbe";
            txtIDNarudzbe.Size = new Size(87, 29);
            txtIDNarudzbe.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(174, 204, 228);
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(427, 367);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 4;
            label5.Text = "KM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(174, 204, 228);
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(294, 367);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 3;
            label4.Text = "Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(174, 204, 228);
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(256, 338);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 2;
            label3.Text = "ID narudžbe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(174, 204, 228);
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(9, 29);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Narudžbe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(174, 204, 228);
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(220, 29);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "Stavke narudžbe";
            // 
            // Form_Kupac_PregledNarudzbi
            // 
            ClientSize = new Size(511, 406);
            Controls.Add(groupBox1);
            Name = "Form_Kupac_PregledNarudzbi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((ISupportInitialize)dataGridView2).EndInit();
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }

        private GroupBox groupBox1;
        private Label label1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private MaskedTextBox txtTotal;
        private MaskedTextBox txtIDNarudzbe;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button Prikazi;



        private void UcitajNarudzbe()
        {
            DBKonekcija db = new DBKonekcija();
            MySqlConnection conn = db.OtvoriKonekciju();

            int logovaniKupacID = Convert.ToInt32(Form_Prijava.prijavljeniKupacID);

            string upit = @"SELECT narudzbenica_id as ID, datum_narudzbe as Datum
                    FROM NARUDZBENICA 
                    WHERE kupac_id = @kupac_id
                    ORDER BY narudzbenica_id DESC";

            MySqlCommand cmd = new MySqlCommand(upit, conn);
            cmd.Parameters.AddWithValue("@kupac_id", logovaniKupacID);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            db.ZatvoriKonekciju();

        }
    }
}