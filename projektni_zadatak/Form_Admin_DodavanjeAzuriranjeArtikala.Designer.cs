namespace projektni_zadatak
{
    partial class Form_Admin_DodavanjeAzuriranjeArtikala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Admin_DodavanjeAzuriranjeArtikala));
            groupBox1 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            buttonDodaj = new Button();
            numericUpDownDodajKol = new NumericUpDown();
            textBoxIDArt = new TextBox();
            textBoxKolicina = new TextBox();
            textBoxCijena = new TextBox();
            textBoxVrstaArt = new TextBox();
            textBoxNazivArt = new TextBox();
            DataGridViewArtikli = new DataGridView();
            artikal_id = new DataGridViewTextBoxColumn();
            naziv = new DataGridViewTextBoxColumn();
            vrsta = new DataGridViewTextBoxColumn();
            cijena = new DataGridViewTextBoxColumn();
            kolicina = new DataGridViewTextBoxColumn();
            buttonTrazi = new Button();
            textBoxNazivArtikla = new TextBox();
            textBoxSifraArtikla = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDodajKol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewArtikli).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(buttonDodaj);
            groupBox1.Controls.Add(numericUpDownDodajKol);
            groupBox1.Controls.Add(textBoxIDArt);
            groupBox1.Controls.Add(textBoxKolicina);
            groupBox1.Controls.Add(textBoxCijena);
            groupBox1.Controls.Add(textBoxVrstaArt);
            groupBox1.Controls.Add(textBoxNazivArt);
            groupBox1.Controls.Add(DataGridViewArtikli);
            groupBox1.Controls.Add(buttonTrazi);
            groupBox1.Controls.Add(textBoxNazivArtikla);
            groupBox1.Controls.Add(textBoxSifraArtikla);
            groupBox1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            groupBox1.Location = new Point(12, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(562, 433);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dodavanje / Ažuriranje artikala";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(174, 204, 228);
            label7.Location = new Point(108, 24);
            label7.Name = "label7";
            label7.Size = new Size(158, 16);
            label7.TabIndex = 18;
            label7.Text = "Pretraži po šifri i nazivu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(174, 204, 228);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(228, 366);
            label6.Name = "label6";
            label6.Size = new Size(102, 16);
            label6.TabIndex = 17;
            label6.Text = "Dodaj količinu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(174, 204, 228);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(262, 337);
            label5.Name = "label5";
            label5.Size = new Size(68, 16);
            label5.TabIndex = 16;
            label5.Text = "ID artikla:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(174, 204, 228);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(67, 362);
            label4.Name = "label4";
            label4.Size = new Size(63, 16);
            label4.TabIndex = 15;
            label4.Text = "Količina:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(174, 204, 228);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(78, 334);
            label3.Name = "label3";
            label3.Size = new Size(52, 16);
            label3.TabIndex = 14;
            label3.Text = "Cijena:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(174, 204, 228);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(44, 301);
            label2.Name = "label2";
            label2.Size = new Size(86, 16);
            label2.TabIndex = 13;
            label2.Text = "Vrsta artikla:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(174, 204, 228);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(40, 276);
            label1.Name = "label1";
            label1.Size = new Size(90, 16);
            label1.TabIndex = 12;
            label1.Text = "Naziv artikla:";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(154, 189, 220);
            button2.Location = new Point(285, 389);
            button2.Name = "button2";
            button2.Size = new Size(139, 25);
            button2.TabIndex = 11;
            button2.Text = "Ažuriranje artikla";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // buttonDodaj
            // 
            buttonDodaj.BackColor = Color.FromArgb(154, 189, 220);
            buttonDodaj.Location = new Point(67, 389);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(157, 25);
            buttonDodaj.TabIndex = 10;
            buttonDodaj.Text = "Dodavanje artikla";
            buttonDodaj.UseVisualStyleBackColor = false;
            buttonDodaj.Click += buttonDodaj_Click_1;
            // 
            // numericUpDownDodajKol
            // 
            numericUpDownDodajKol.BackColor = Color.White;
            numericUpDownDodajKol.Location = new Point(336, 362);
            numericUpDownDodajKol.Name = "numericUpDownDodajKol";
            numericUpDownDodajKol.Size = new Size(88, 22);
            numericUpDownDodajKol.TabIndex = 9;
            // 
            // textBoxIDArt
            // 
            textBoxIDArt.BackColor = Color.White;
            textBoxIDArt.Location = new Point(336, 334);
            textBoxIDArt.Name = "textBoxIDArt";
            textBoxIDArt.Size = new Size(88, 22);
            textBoxIDArt.TabIndex = 8;
            // 
            // textBoxKolicina
            // 
            textBoxKolicina.Location = new Point(136, 360);
            textBoxKolicina.Name = "textBoxKolicina";
            textBoxKolicina.Size = new Size(88, 22);
            textBoxKolicina.TabIndex = 7;
            // 
            // textBoxCijena
            // 
            textBoxCijena.Location = new Point(136, 332);
            textBoxCijena.Name = "textBoxCijena";
            textBoxCijena.Size = new Size(88, 22);
            textBoxCijena.TabIndex = 6;
            // 
            // textBoxVrstaArt
            // 
            textBoxVrstaArt.Location = new Point(136, 301);
            textBoxVrstaArt.Name = "textBoxVrstaArt";
            textBoxVrstaArt.Size = new Size(88, 22);
            textBoxVrstaArt.TabIndex = 5;
            // 
            // textBoxNazivArt
            // 
            textBoxNazivArt.Location = new Point(136, 273);
            textBoxNazivArt.Name = "textBoxNazivArt";
            textBoxNazivArt.Size = new Size(88, 22);
            textBoxNazivArt.TabIndex = 4;
            // 
            // DataGridViewArtikli
            // 
            DataGridViewArtikli.AllowUserToAddRows = false;
            DataGridViewArtikli.BackgroundColor = Color.White;
            DataGridViewArtikli.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewArtikli.Columns.AddRange(new DataGridViewColumn[] { artikal_id, naziv, vrsta, cijena, kolicina });
            DataGridViewArtikli.Location = new Point(8, 54);
            DataGridViewArtikli.Name = "DataGridViewArtikli";
            DataGridViewArtikli.ReadOnly = true;
            DataGridViewArtikli.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewArtikli.Size = new Size(544, 213);
            DataGridViewArtikli.TabIndex = 3;
            // 
            // artikal_id
            // 
            artikal_id.HeaderText = "Šifra";
            artikal_id.Name = "artikal_id";
            artikal_id.ReadOnly = true;
            // 
            // naziv
            // 
            naziv.HeaderText = "Naziv artikla";
            naziv.Name = "naziv";
            naziv.ReadOnly = true;
            // 
            // vrsta
            // 
            vrsta.HeaderText = "Vrsta";
            vrsta.Name = "vrsta";
            vrsta.ReadOnly = true;
            // 
            // cijena
            // 
            cijena.HeaderText = "Cijena";
            cijena.Name = "cijena";
            cijena.ReadOnly = true;
            // 
            // kolicina
            // 
            kolicina.HeaderText = "Količina";
            kolicina.Name = "kolicina";
            kolicina.ReadOnly = true;
            // 
            // buttonTrazi
            // 
            buttonTrazi.BackColor = Color.FromArgb(154, 189, 220);
            buttonTrazi.Location = new Point(466, 21);
            buttonTrazi.Name = "buttonTrazi";
            buttonTrazi.Size = new Size(86, 22);
            buttonTrazi.TabIndex = 2;
            buttonTrazi.Text = "Traži";
            buttonTrazi.UseVisualStyleBackColor = false;
            buttonTrazi.Click += buttonTrazi_Click_1;
            // 
            // textBoxNazivArtikla
            // 
            textBoxNazivArtikla.Location = new Point(366, 21);
            textBoxNazivArtikla.Name = "textBoxNazivArtikla";
            textBoxNazivArtikla.Size = new Size(88, 22);
            textBoxNazivArtikla.TabIndex = 1;
            // 
            // textBoxSifraArtikla
            // 
            textBoxSifraArtikla.Location = new Point(272, 21);
            textBoxSifraArtikla.Name = "textBoxSifraArtikla";
            textBoxSifraArtikla.Size = new Size(88, 22);
            textBoxSifraArtikla.TabIndex = 0;
            // 
            // Form_Admin_DodavanjeAzuriranjeArtikala
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 450);
            Controls.Add(groupBox1);
            Name = "Form_Admin_DodavanjeAzuriranjeArtikala";
            Text = "Dodavanje / Ažuriranje artikala";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDodajKol).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewArtikli).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonTrazi;
        private TextBox textBoxNazivArtikla;
        private TextBox textBoxSifraArtikla;
        private Button button2;
        private Button buttonDodaj;
        private NumericUpDown numericUpDownDodajKol;
        private TextBox textBoxIDArt;
        private TextBox textBoxKolicina;
        private TextBox textBoxCijena;
        private TextBox textBoxVrstaArt;
        private TextBox textBoxNazivArt;
        private DataGridView DataGridViewArtikli;
        private DataGridViewTextBoxColumn artikal_id;
        private DataGridViewTextBoxColumn naziv;
        private DataGridViewTextBoxColumn vrsta;
        private DataGridViewTextBoxColumn cijena;
        private DataGridViewTextBoxColumn kolicina;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label7;
    }
}