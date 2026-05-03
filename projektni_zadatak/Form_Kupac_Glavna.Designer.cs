namespace projektni_zadatak
{
    partial class Form_Kupac_Glavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Kupac_Glavna));
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            txtTotal = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtKolicina = new TextBox();
            txtIdArtikla = new TextBox();
            btnDodaj = new Button();
            btnObrisi = new Button();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            btnKreirajNarudzbu = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(310, 295);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtKolicina);
            groupBox1.Controls.Add(txtIdArtikla);
            groupBox1.Controls.Add(btnDodaj);
            groupBox1.Controls.Add(btnObrisi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btnKreirajNarudzbu);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            groupBox1.Location = new Point(-2, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(803, 454);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kreiranje narudžbe";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(174, 204, 228);
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.Location = new Point(464, 259);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 13;
            label6.Text = "ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(174, 204, 228);
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(521, 259);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 12;
            label5.Text = "KOL";
            label5.Click += label5_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(489, 314);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(80, 23);
            txtTotal.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(174, 204, 228);
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(575, 317);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 10;
            label4.Text = "KM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(174, 204, 228);
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(447, 317);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 9;
            label3.Text = "Total:";
            // 
            // txtKolicina
            // 
            txtKolicina.Location = new Point(510, 276);
            txtKolicina.Name = "txtKolicina";
            txtKolicina.Size = new Size(59, 23);
            txtKolicina.TabIndex = 8;
            // 
            // txtIdArtikla
            // 
            txtIdArtikla.Location = new Point(445, 276);
            txtIdArtikla.Name = "txtIdArtikla";
            txtIdArtikla.Size = new Size(59, 23);
            txtIdArtikla.TabIndex = 7;
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = Color.FromArgb(154, 189, 220);
            btnDodaj.Location = new Point(328, 276);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(113, 26);
            btnDodaj.TabIndex = 6;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.BackColor = Color.FromArgb(154, 189, 220);
            btnObrisi.Location = new Point(328, 308);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(113, 26);
            btnObrisi.TabIndex = 5;
            btnObrisi.Text = "Obriši";
            btnObrisi.UseVisualStyleBackColor = false;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(174, 204, 228);
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(328, 43);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Korpa";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(328, 61);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(260, 195);
            dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(174, 204, 228);
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 3;
            label1.Text = "Pregled artikala";
            // 
            // btnKreirajNarudzbu
            // 
            btnKreirajNarudzbu.BackColor = Color.FromArgb(154, 189, 220);
            btnKreirajNarudzbu.Location = new Point(575, 276);
            btnKreirajNarudzbu.Name = "btnKreirajNarudzbu";
            btnKreirajNarudzbu.Size = new Size(115, 23);
            btnKreirajNarudzbu.TabIndex = 2;
            btnKreirajNarudzbu.Text = "Kreiraj narudžbu";
            btnKreirajNarudzbu.UseVisualStyleBackColor = false;
            btnKreirajNarudzbu.Click += btnKreirajNarudzbu_Click;
            // 
            // button1
            // 
            button1.Location = new Point(615, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Prikaz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form_Kupac_Glavna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 358);
            Controls.Add(groupBox1);
            Name = "Form_Kupac_Glavna";
            Text = "Form_Kupac_Glavna";
            Load += Form_Kupac_Glavna_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private DataGridView dataGridView2;
        private Button btnKreirajNarudzbu;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label label5;
        private TextBox txtTotal;
        private Label label4;
        private Label label3;
        private TextBox txtKolicina;
        private TextBox txtIdArtikla;
        private Button btnDodaj;
        private Button btnObrisi;
        private Button button1;
    }
}