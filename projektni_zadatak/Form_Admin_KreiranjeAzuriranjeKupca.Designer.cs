namespace projektni_zadatak
{
    partial class Form_Admin_KreiranjeAzuriranjeKupca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Admin_KreiranjeAzuriranjeKupca));
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonAzuriraj = new Button();
            buttonKreiraj = new Button();
            textBoxID = new TextBox();
            textBoxSifra = new TextBox();
            textBoxKorisnickoIme = new TextBox();
            textBoxTelefon = new TextBox();
            textBoxAdresa = new TextBox();
            textBoxGrad = new TextBox();
            textBoxPrezime = new TextBox();
            textBoxIme = new TextBox();
            buttonTrazi = new Button();
            textBoxPrezime1 = new TextBox();
            textBoxIme1 = new TextBox();
            DataGridViewKorisnici = new DataGridView();
            kupac_id = new DataGridViewTextBoxColumn();
            ime = new DataGridViewTextBoxColumn();
            prezime = new DataGridViewTextBoxColumn();
            grad = new DataGridViewTextBoxColumn();
            adresa = new DataGridViewTextBoxColumn();
            telefon = new DataGridViewTextBoxColumn();
            user = new DataGridViewTextBoxColumn();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewKorisnici).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightBlue;
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonAzuriraj);
            groupBox1.Controls.Add(buttonKreiraj);
            groupBox1.Controls.Add(textBoxID);
            groupBox1.Controls.Add(textBoxSifra);
            groupBox1.Controls.Add(textBoxKorisnickoIme);
            groupBox1.Controls.Add(textBoxTelefon);
            groupBox1.Controls.Add(textBoxAdresa);
            groupBox1.Controls.Add(textBoxGrad);
            groupBox1.Controls.Add(textBoxPrezime);
            groupBox1.Controls.Add(textBoxIme);
            groupBox1.Controls.Add(buttonTrazi);
            groupBox1.Controls.Add(textBoxPrezime1);
            groupBox1.Controls.Add(textBoxIme1);
            groupBox1.Controls.Add(DataGridViewKorisnici);
            groupBox1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            groupBox1.Location = new Point(21, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(659, 517);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kreiranje / Ažuriranje novog kupca";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.LightBlue;
            label8.Location = new Point(215, 489);
            label8.Name = "label8";
            label8.Size = new Size(66, 16);
            label8.TabIndex = 21;
            label8.Text = "ID kupca:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightBlue;
            label7.Location = new Point(237, 458);
            label7.Name = "label7";
            label7.Size = new Size(41, 16);
            label7.TabIndex = 20;
            label7.Text = "Šifra:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightBlue;
            label6.Location = new Point(176, 429);
            label6.Name = "label6";
            label6.Size = new Size(105, 16);
            label6.TabIndex = 19;
            label6.Text = "Korisničko ime:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightBlue;
            label5.Location = new Point(223, 400);
            label5.Name = "label5";
            label5.Size = new Size(58, 16);
            label5.TabIndex = 18;
            label5.Text = "Telefon:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightBlue;
            label4.Location = new Point(-6, 485);
            label4.Name = "label4";
            label4.Size = new Size(55, 16);
            label4.TabIndex = 17;
            label4.Text = "Adresa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightBlue;
            label3.Location = new Point(5, 456);
            label3.Name = "label3";
            label3.Size = new Size(42, 16);
            label3.TabIndex = 16;
            label3.Text = "Grad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightBlue;
            label2.Location = new Point(-12, 427);
            label2.Name = "label2";
            label2.Size = new Size(64, 16);
            label2.TabIndex = 15;
            label2.Text = "Prezime:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightBlue;
            label1.Location = new Point(10, 398);
            label1.Name = "label1";
            label1.Size = new Size(35, 16);
            label1.TabIndex = 14;
            label1.Text = "Ime:";
            // 
            // buttonAzuriraj
            // 
            buttonAzuriraj.BackColor = SystemColors.Info;
            buttonAzuriraj.Location = new Point(409, 485);
            buttonAzuriraj.Name = "buttonAzuriraj";
            buttonAzuriraj.Size = new Size(135, 23);
            buttonAzuriraj.TabIndex = 13;
            buttonAzuriraj.Text = "Ažuriranje kupca";
            buttonAzuriraj.UseVisualStyleBackColor = false;
            buttonAzuriraj.Click += buttonAzuriraj_Click_1;
            // 
            // buttonKreiraj
            // 
            buttonKreiraj.BackColor = SystemColors.Info;
            buttonKreiraj.Location = new Point(409, 452);
            buttonKreiraj.Name = "buttonKreiraj";
            buttonKreiraj.Size = new Size(135, 23);
            buttonKreiraj.TabIndex = 12;
            buttonKreiraj.Text = "Kreiranje kupca";
            buttonKreiraj.UseVisualStyleBackColor = false;
            buttonKreiraj.Click += buttonKreiraj_Click_1;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(287, 486);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(103, 22);
            textBoxID.TabIndex = 11;
            // 
            // textBoxSifra
            // 
            textBoxSifra.Location = new Point(287, 455);
            textBoxSifra.Name = "textBoxSifra";
            textBoxSifra.Size = new Size(103, 22);
            textBoxSifra.TabIndex = 10;
            // 
            // textBoxKorisnickoIme
            // 
            textBoxKorisnickoIme.Location = new Point(287, 427);
            textBoxKorisnickoIme.Name = "textBoxKorisnickoIme";
            textBoxKorisnickoIme.Size = new Size(103, 22);
            textBoxKorisnickoIme.TabIndex = 9;
            // 
            // textBoxTelefon
            // 
            textBoxTelefon.Location = new Point(287, 397);
            textBoxTelefon.Name = "textBoxTelefon";
            textBoxTelefon.Size = new Size(103, 22);
            textBoxTelefon.TabIndex = 8;
            // 
            // textBoxAdresa
            // 
            textBoxAdresa.Location = new Point(55, 481);
            textBoxAdresa.Name = "textBoxAdresa";
            textBoxAdresa.Size = new Size(103, 22);
            textBoxAdresa.TabIndex = 7;
            // 
            // textBoxGrad
            // 
            textBoxGrad.Location = new Point(55, 453);
            textBoxGrad.Name = "textBoxGrad";
            textBoxGrad.Size = new Size(103, 22);
            textBoxGrad.TabIndex = 6;
            // 
            // textBoxPrezime
            // 
            textBoxPrezime.Location = new Point(55, 425);
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.Size = new Size(103, 22);
            textBoxPrezime.TabIndex = 5;
            // 
            // textBoxIme
            // 
            textBoxIme.Location = new Point(55, 395);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(103, 22);
            textBoxIme.TabIndex = 4;
            // 
            // buttonTrazi
            // 
            buttonTrazi.BackColor = SystemColors.Info;
            buttonTrazi.Location = new Point(497, 21);
            buttonTrazi.Name = "buttonTrazi";
            buttonTrazi.Size = new Size(76, 23);
            buttonTrazi.TabIndex = 3;
            buttonTrazi.Text = "Traži";
            buttonTrazi.UseVisualStyleBackColor = false;
            buttonTrazi.Click += buttonTrazi_Click_1;
            // 
            // textBoxPrezime1
            // 
            textBoxPrezime1.Location = new Point(376, 21);
            textBoxPrezime1.Name = "textBoxPrezime1";
            textBoxPrezime1.Size = new Size(103, 22);
            textBoxPrezime1.TabIndex = 2;
            // 
            // textBoxIme1
            // 
            textBoxIme1.Location = new Point(267, 21);
            textBoxIme1.Name = "textBoxIme1";
            textBoxIme1.Size = new Size(103, 22);
            textBoxIme1.TabIndex = 1;
            // 
            // DataGridViewKorisnici
            // 
            DataGridViewKorisnici.AllowUserToAddRows = false;
            DataGridViewKorisnici.BackgroundColor = Color.White;
            DataGridViewKorisnici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewKorisnici.Columns.AddRange(new DataGridViewColumn[] { kupac_id, ime, prezime, grad, adresa, telefon, user });
            DataGridViewKorisnici.Location = new Point(6, 63);
            DataGridViewKorisnici.Name = "DataGridViewKorisnici";
            DataGridViewKorisnici.ReadOnly = true;
            DataGridViewKorisnici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewKorisnici.Size = new Size(645, 312);
            DataGridViewKorisnici.TabIndex = 0;
            // 
            // kupac_id
            // 
            kupac_id.HeaderText = "ID";
            kupac_id.Name = "kupac_id";
            kupac_id.ReadOnly = true;
            // 
            // ime
            // 
            ime.HeaderText = "Ime";
            ime.Name = "ime";
            ime.ReadOnly = true;
            // 
            // prezime
            // 
            prezime.HeaderText = "Prezime";
            prezime.Name = "prezime";
            prezime.ReadOnly = true;
            // 
            // grad
            // 
            grad.HeaderText = "Grad";
            grad.Name = "grad";
            grad.ReadOnly = true;
            // 
            // adresa
            // 
            adresa.HeaderText = "Adresa";
            adresa.Name = "adresa";
            adresa.ReadOnly = true;
            // 
            // telefon
            // 
            telefon.HeaderText = "Telefon";
            telefon.Name = "telefon";
            telefon.ReadOnly = true;
            // 
            // user
            // 
            user.HeaderText = "Korisničko ime";
            user.Name = "user";
            user.ReadOnly = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LightBlue;
            label9.Location = new Point(2, 21);
            label9.Name = "label9";
            label9.Size = new Size(243, 16);
            label9.TabIndex = 22;
            label9.Text = "Pretraži po imenu i prezimenu kupca";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(710, 532);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form_Admin_KreiranjeAzuriranjeKupca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 541);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "Form_Admin_KreiranjeAzuriranjeKupca";
            Text = "Kreiranje / Ažuriranje kupca";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewKorisnici).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonAzuriraj;
        private Button buttonKreiraj;
        private TextBox textBoxID;
        private TextBox textBoxSifra;
        private TextBox textBoxKorisnickoIme;
        private TextBox textBoxTelefon;
        private TextBox textBoxAdresa;
        private TextBox textBoxGrad;
        private TextBox textBoxPrezime;
        private TextBox textBoxIme;
        private Button buttonTrazi;
        private TextBox textBoxPrezime1;
        private TextBox textBoxIme1;
        private DataGridView DataGridViewKorisnici;
        private DataGridViewTextBoxColumn kupac_id;
        private DataGridViewTextBoxColumn ime;
        private DataGridViewTextBoxColumn prezime;
        private DataGridViewTextBoxColumn grad;
        private DataGridViewTextBoxColumn adresa;
        private DataGridViewTextBoxColumn telefon;
        private DataGridViewTextBoxColumn user;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label9;
        private PictureBox pictureBox1;
    }
}