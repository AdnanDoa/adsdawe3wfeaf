namespace projektni_zadatak
{
    partial class Form_Admin_Glavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Admin_Glavna));
            menuStrip1 = new MenuStrip();
            administracijaToolStripMenuItem = new ToolStripMenuItem();
            artikliToolStripMenuItem = new ToolStripMenuItem();
            dodavanjeAzuriranjeArtikalaToolStripMenuItem = new ToolStripMenuItem();
            kupciToolStripMenuItem = new ToolStripMenuItem();
            kreiranjeAzuriranjeKupacaToolStripMenuItem = new ToolStripMenuItem();
            narudžbeToolStripMenuItem = new ToolStripMenuItem();
            prikazBrisanjeNarudžbiToolStripMenuItem = new ToolStripMenuItem();
            odjavaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(174, 204, 228);
            menuStrip1.Items.AddRange(new ToolStripItem[] { administracijaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(692, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // administracijaToolStripMenuItem
            // 
            administracijaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { artikliToolStripMenuItem, kupciToolStripMenuItem, narudžbeToolStripMenuItem, odjavaToolStripMenuItem });
            administracijaToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            administracijaToolStripMenuItem.Name = "administracijaToolStripMenuItem";
            administracijaToolStripMenuItem.Size = new Size(133, 25);
            administracijaToolStripMenuItem.Text = "Administracija";
            // 
            // artikliToolStripMenuItem
            // 
            artikliToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dodavanjeAzuriranjeArtikalaToolStripMenuItem });
            artikliToolStripMenuItem.Name = "artikliToolStripMenuItem";
            artikliToolStripMenuItem.Size = new Size(180, 26);
            artikliToolStripMenuItem.Text = "Artikli";
            // 
            // dodavanjeAzuriranjeArtikalaToolStripMenuItem
            // 
            dodavanjeAzuriranjeArtikalaToolStripMenuItem.Name = "dodavanjeAzuriranjeArtikalaToolStripMenuItem";
            dodavanjeAzuriranjeArtikalaToolStripMenuItem.Size = new Size(317, 26);
            dodavanjeAzuriranjeArtikalaToolStripMenuItem.Text = "Dodavanje / azuriranje artikala";
            dodavanjeAzuriranjeArtikalaToolStripMenuItem.Click += dodavanjeAzuriranjeArtikalaToolStripMenuItem_Click;
            // 
            // kupciToolStripMenuItem
            // 
            kupciToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kreiranjeAzuriranjeKupacaToolStripMenuItem });
            kupciToolStripMenuItem.Name = "kupciToolStripMenuItem";
            kupciToolStripMenuItem.Size = new Size(180, 26);
            kupciToolStripMenuItem.Text = "Kupci";
            // 
            // kreiranjeAzuriranjeKupacaToolStripMenuItem
            // 
            kreiranjeAzuriranjeKupacaToolStripMenuItem.Name = "kreiranjeAzuriranjeKupacaToolStripMenuItem";
            kreiranjeAzuriranjeKupacaToolStripMenuItem.Size = new Size(302, 26);
            kreiranjeAzuriranjeKupacaToolStripMenuItem.Text = "Kreiranje / Azuriranje kupaca";
            kreiranjeAzuriranjeKupacaToolStripMenuItem.Click += kreiranjeAzuriranjeKupacaToolStripMenuItem_Click;
            // 
            // narudžbeToolStripMenuItem
            // 
            narudžbeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { prikazBrisanjeNarudžbiToolStripMenuItem });
            narudžbeToolStripMenuItem.Name = "narudžbeToolStripMenuItem";
            narudžbeToolStripMenuItem.Size = new Size(180, 26);
            narudžbeToolStripMenuItem.Text = "Narudžbe";
            // 
            // prikazBrisanjeNarudžbiToolStripMenuItem
            // 
            prikazBrisanjeNarudžbiToolStripMenuItem.Name = "prikazBrisanjeNarudžbiToolStripMenuItem";
            prikazBrisanjeNarudžbiToolStripMenuItem.Size = new Size(275, 26);
            prikazBrisanjeNarudžbiToolStripMenuItem.Text = "Prikaz / Brisanje narudžbi";
            prikazBrisanjeNarudžbiToolStripMenuItem.Click += prikazBrisanjeNarudžbiToolStripMenuItem_Click;
            // 
            // odjavaToolStripMenuItem
            // 
            odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            odjavaToolStripMenuItem.Size = new Size(180, 26);
            odjavaToolStripMenuItem.Text = "Odjava";
            odjavaToolStripMenuItem.Click += odjavaToolStripMenuItem_Click;
            // 
            // Form_Admin_Glavna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(692, 357);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form_Admin_Glavna";
            Text = "Form_Admin_Glavna";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem administracijaToolStripMenuItem;
        private ToolStripMenuItem artikliToolStripMenuItem;
        private ToolStripMenuItem kupciToolStripMenuItem;
        private ToolStripMenuItem narudžbeToolStripMenuItem;
        private ToolStripMenuItem prikazBrisanjeNarudžbiToolStripMenuItem;
        private ToolStripMenuItem odjavaToolStripMenuItem;
        private ToolStripMenuItem dodavanjeAzuriranjeArtikalaToolStripMenuItem;
        private ToolStripMenuItem kreiranjeAzuriranjeKupacaToolStripMenuItem;
    }
}