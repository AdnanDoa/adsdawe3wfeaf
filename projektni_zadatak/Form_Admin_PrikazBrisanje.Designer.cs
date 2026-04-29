namespace projektni_zadatak
{
    partial class Form_Admin_PrikazBrisanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Admin_PrikazBrisanje));
            DataGridViewNarudzbe = new DataGridView();
            narudzba_id = new DataGridViewTextBoxColumn();
            kupac = new DataGridViewTextBoxColumn();
            datum = new DataGridViewTextBoxColumn();
            buttonObrisi = new Button();
            textBoxIDnarudzbe = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridViewNarudzbe).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // DataGridViewNarudzbe
            // 
            DataGridViewNarudzbe.AllowUserToAddRows = false;
            DataGridViewNarudzbe.BackgroundColor = Color.White;
            DataGridViewNarudzbe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewNarudzbe.Columns.AddRange(new DataGridViewColumn[] { narudzba_id, kupac, datum });
            DataGridViewNarudzbe.Location = new Point(6, 32);
            DataGridViewNarudzbe.MultiSelect = false;
            DataGridViewNarudzbe.Name = "DataGridViewNarudzbe";
            DataGridViewNarudzbe.ReadOnly = true;
            DataGridViewNarudzbe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewNarudzbe.Size = new Size(344, 144);
            DataGridViewNarudzbe.TabIndex = 0;
            // 
            // narudzba_id
            // 
            narudzba_id.HeaderText = "ID narudžbe";
            narudzba_id.Name = "narudzba_id";
            narudzba_id.ReadOnly = true;
            // 
            // kupac
            // 
            kupac.HeaderText = "Kupac";
            kupac.Name = "kupac";
            kupac.ReadOnly = true;
            // 
            // datum
            // 
            datum.HeaderText = "Datum";
            datum.Name = "datum";
            datum.ReadOnly = true;
            // 
            // buttonObrisi
            // 
            buttonObrisi.BackColor = Color.FromArgb(174, 204, 228);
            buttonObrisi.Location = new Point(184, 182);
            buttonObrisi.Name = "buttonObrisi";
            buttonObrisi.Size = new Size(166, 31);
            buttonObrisi.TabIndex = 2;
            buttonObrisi.Text = "Brisanje narudžbe";
            buttonObrisi.UseVisualStyleBackColor = false;
            buttonObrisi.Click += buttonObrisi_Click_1;
            // 
            // textBoxIDnarudzbe
            // 
            textBoxIDnarudzbe.Location = new Point(100, 189);
            textBoxIDnarudzbe.Name = "textBoxIDnarudzbe";
            textBoxIDnarudzbe.Size = new Size(78, 22);
            textBoxIDnarudzbe.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxIDnarudzbe);
            groupBox1.Controls.Add(buttonObrisi);
            groupBox1.Controls.Add(DataGridViewNarudzbe);
            groupBox1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            groupBox1.Location = new Point(15, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 224);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prikaz / Brisanje narudžbe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(174, 204, 228);
            label1.Location = new Point(6, 189);
            label1.Name = "label1";
            label1.Size = new Size(88, 16);
            label1.TabIndex = 4;
            label1.Text = "ID narudžbe:";
            // 
            // Form_Admin_PrikazBrisanje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(395, 256);
            Controls.Add(groupBox1);
            Name = "Form_Admin_PrikazBrisanje";
            Text = "Form_Admin_Glavna";
            ((System.ComponentModel.ISupportInitialize)DataGridViewNarudzbe).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridViewNarudzbe;
        private Button buttonObrisi;
        private DataGridViewTextBoxColumn narudzba_id;
        private DataGridViewTextBoxColumn kupac;
        private DataGridViewTextBoxColumn datum;
        private TextBox textBoxIDnarudzbe;
        private GroupBox groupBox1;
        private Label label1;
    }
}