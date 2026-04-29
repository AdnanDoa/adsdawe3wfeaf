namespace projektni_zadatak
{
    partial class Form_Prijava
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Prijava));
            buttonPrijaviSe = new Button();
            textBoxKorisnickoIme = new TextBox();
            textBoxLozinka = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // buttonPrijaviSe
            // 
            buttonPrijaviSe.BackColor = Color.NavajoWhite;
            buttonPrijaviSe.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            buttonPrijaviSe.Location = new Point(450, 303);
            buttonPrijaviSe.Name = "buttonPrijaviSe";
            buttonPrijaviSe.Size = new Size(119, 35);
            buttonPrijaviSe.TabIndex = 0;
            buttonPrijaviSe.Text = "PRIJAVA";
            buttonPrijaviSe.UseVisualStyleBackColor = false;
            buttonPrijaviSe.Click += buttonPrijaviSe_Click;
            // 
            // textBoxKorisnickoIme
            // 
            textBoxKorisnickoIme.Location = new Point(410, 208);
            textBoxKorisnickoIme.Name = "textBoxKorisnickoIme";
            textBoxKorisnickoIme.Size = new Size(159, 23);
            textBoxKorisnickoIme.TabIndex = 1;
            // 
            // textBoxLozinka
            // 
            textBoxLozinka.Location = new Point(410, 253);
            textBoxLozinka.Name = "textBoxLozinka";
            textBoxLozinka.Size = new Size(159, 23);
            textBoxLozinka.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 211);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 3;
            label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(371, 256);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 4;
            label2.Text = "Šifra:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = Properties.Resources.viber_image_2026_03_20_22_37_08_5101;
            pictureBox1.Location = new Point(-14, -11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(631, 455);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.viber_image_2026_03_20_22_37_08_205;
            pictureBox2.Location = new Point(185, 182);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 115);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Form_Prijava
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 436);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxLozinka);
            Controls.Add(textBoxKorisnickoIme);
            Controls.Add(buttonPrijaviSe);
            Controls.Add(pictureBox1);
            Name = "Form_Prijava";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPrijaviSe;
        private TextBox textBoxKorisnickoIme;
        private TextBox textBoxLozinka;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
