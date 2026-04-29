namespace projektni_zadatak
{
    partial class Form_Kupac_Prikaz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            Narudžbe = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            txtIDNarudzbe = new TextBox();
            txtTotal = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();

            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(txtIDNarudzbe);
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Narudžbe);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prikaz narudžbi i stavki";
            // 
            // Narudžbe
            // 
            Narudžbe.AutoSize = true;
            Narudžbe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Narudžbe.Location = new Point(22, 46);
            Narudžbe.Name = "Narudžbe";
            Narudžbe.Size = new Size(61, 15);
            Narudžbe.TabIndex = 0;
            Narudžbe.Text = "Narudžbe";

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(298, 46);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 1;
            label1.Text = "Stavke narudžbe";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(245, 183);
            dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(298, 64);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(421, 183);
            dataGridView2.TabIndex = 3;
            // 
            // txtIDNarudzbe
            // 
            txtIDNarudzbe.Location = new Point(511, 292);
            txtIDNarudzbe.Name = "txtIDNarudzbe";
            txtIDNarudzbe.Size = new Size(100, 23);
            txtIDNarudzbe.TabIndex = 4;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(511, 348);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(640, 295);
            button1.Name = "button1";
            button1.Size = new Size(79, 24);
            button1.TabIndex = 6;
            button1.Text = "Prikaži";
            button1.UseVisualStyleBackColor = true;

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(471, 351);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 7;
            label2.Text = "Total:";

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(430, 295);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 8;
            label3.Text = "ID narudžbe";

            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(617, 351);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 9;
            label4.Text = "KM";
            // 
            // Form_Kupac_Prikaz
            // 




        }

        #endregion

        private GroupBox groupBox1;
        private Label Narudžbe;
        private Button button1;
        private TextBox txtTotal;
        private TextBox txtIDNarudzbe;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}