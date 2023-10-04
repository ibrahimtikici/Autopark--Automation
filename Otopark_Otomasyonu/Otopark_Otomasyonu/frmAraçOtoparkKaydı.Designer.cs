namespace Otopark_Otomasyonu
{
    partial class frmAraçOtoparkKaydı
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAraçOtoparkKaydı));
            txtTc = new TextBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtTelefon = new TextBox();
            txtEmail = new TextBox();
            txtPlaka = new TextBox();
            txtRenk = new TextBox();
            comboMarka = new ComboBox();
            comboSeri = new ComboBox();
            comboParkYeri = new ComboBox();
            grupKişi = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grupAraç = new GroupBox();
            btnSeri = new Button();
            btnMarka = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            button1 = new Button();
            ımageList1 = new ImageList(components);
            button2 = new Button();
            grupKişi.SuspendLayout();
            grupAraç.SuspendLayout();
            SuspendLayout();
            // 
            // txtTc
            // 
            txtTc.Location = new Point(97, 36);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(151, 27);
            txtTc.TabIndex = 0;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(97, 69);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(151, 27);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(97, 102);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(151, 27);
            txtSoyad.TabIndex = 2;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(97, 135);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(151, 27);
            txtTelefon.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(97, 168);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(151, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtPlaka
            // 
            txtPlaka.Location = new Point(110, 40);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(151, 27);
            txtPlaka.TabIndex = 5;
            // 
            // txtRenk
            // 
            txtRenk.Location = new Point(110, 139);
            txtRenk.Name = "txtRenk";
            txtRenk.Size = new Size(151, 27);
            txtRenk.TabIndex = 6;
            // 
            // comboMarka
            // 
            comboMarka.FormattingEnabled = true;
            comboMarka.Location = new Point(110, 73);
            comboMarka.Name = "comboMarka";
            comboMarka.Size = new Size(151, 28);
            comboMarka.TabIndex = 7;
            comboMarka.SelectedIndexChanged += comboMarka_SelectedIndexChanged;
            // 
            // comboSeri
            // 
            comboSeri.FormattingEnabled = true;
            comboSeri.Location = new Point(110, 107);
            comboSeri.Name = "comboSeri";
            comboSeri.Size = new Size(151, 28);
            comboSeri.TabIndex = 8;
            // 
            // comboParkYeri
            // 
            comboParkYeri.FormattingEnabled = true;
            comboParkYeri.Location = new Point(110, 172);
            comboParkYeri.Name = "comboParkYeri";
            comboParkYeri.Size = new Size(151, 28);
            comboParkYeri.TabIndex = 9;
            // 
            // grupKişi
            // 
            grupKişi.BackColor = Color.Transparent;
            grupKişi.Controls.Add(label5);
            grupKişi.Controls.Add(label4);
            grupKişi.Controls.Add(label3);
            grupKişi.Controls.Add(label2);
            grupKişi.Controls.Add(label1);
            grupKişi.Controls.Add(txtAd);
            grupKişi.Controls.Add(txtTc);
            grupKişi.Controls.Add(txtSoyad);
            grupKişi.Controls.Add(txtTelefon);
            grupKişi.Controls.Add(txtEmail);
            grupKişi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grupKişi.Location = new Point(129, 66);
            grupKişi.Name = "grupKişi";
            grupKişi.Size = new Size(320, 282);
            grupKişi.TabIndex = 10;
            grupKişi.TabStop = false;
            grupKişi.Text = "Kişi Bilgileri";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 172);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 9;
            label5.Text = "E-mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 139);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 8;
            label4.Text = "Telefon:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 104);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 7;
            label3.Text = "Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 73);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 6;
            label2.Text = "Ad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 40);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 5;
            label1.Text = "TC:";
            // 
            // grupAraç
            // 
            grupAraç.BackColor = Color.Transparent;
            grupAraç.Controls.Add(btnSeri);
            grupAraç.Controls.Add(btnMarka);
            grupAraç.Controls.Add(label10);
            grupAraç.Controls.Add(label9);
            grupAraç.Controls.Add(label8);
            grupAraç.Controls.Add(label7);
            grupAraç.Controls.Add(label6);
            grupAraç.Controls.Add(txtPlaka);
            grupAraç.Controls.Add(txtRenk);
            grupAraç.Controls.Add(comboParkYeri);
            grupAraç.Controls.Add(comboMarka);
            grupAraç.Controls.Add(comboSeri);
            grupAraç.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grupAraç.Location = new Point(500, 66);
            grupAraç.Name = "grupAraç";
            grupAraç.Size = new Size(320, 282);
            grupAraç.TabIndex = 11;
            grupAraç.TabStop = false;
            grupAraç.Text = "Araç Bilgileri";
            // 
            // btnSeri
            // 
            btnSeri.Location = new Point(273, 110);
            btnSeri.Name = "btnSeri";
            btnSeri.Size = new Size(30, 25);
            btnSeri.TabIndex = 16;
            btnSeri.Text = "+";
            btnSeri.UseVisualStyleBackColor = true;
            btnSeri.Click += btnSeri_Click;
            // 
            // btnMarka
            // 
            btnMarka.Location = new Point(273, 74);
            btnMarka.Name = "btnMarka";
            btnMarka.Size = new Size(29, 27);
            btnMarka.TabIndex = 15;
            btnMarka.Text = "+";
            btnMarka.UseVisualStyleBackColor = true;
            btnMarka.Click += btnMarka_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(37, 175);
            label10.Name = "label10";
            label10.Size = new Size(74, 20);
            label10.TabIndex = 14;
            label10.Text = "Park Yeri:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(60, 142);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 13;
            label9.Text = "Renk:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(67, 110);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 12;
            label8.Text = "Seri:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 76);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 11;
            label7.Text = "Marka:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 43);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 10;
            label6.Text = "Plaka:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageIndex = 1;
            button1.ImageList = ımageList1;
            button1.Location = new Point(612, 374);
            button1.Name = "button1";
            button1.Size = new Size(96, 41);
            button1.TabIndex = 12;
            button1.Text = "Kayıt";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "iptal.png");
            ımageList1.Images.SetKeyName(1, "ekle.png");
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.ImageIndex = 0;
            button2.ImageList = ımageList1;
            button2.Location = new Point(724, 374);
            button2.Name = "button2";
            button2.Size = new Size(96, 41);
            button2.TabIndex = 13;
            button2.Text = "İptal";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmAraçOtoparkKaydı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(930, 504);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(grupAraç);
            Controls.Add(grupKişi);
            ForeColor = SystemColors.ControlText;
            Name = "frmAraçOtoparkKaydı";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Araç Otopark Kaydı";
            Load += frmAraçOtoparkKaydı_Load;
            grupKişi.ResumeLayout(false);
            grupKişi.PerformLayout();
            grupAraç.ResumeLayout(false);
            grupAraç.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtTc;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtTelefon;
        private TextBox txtEmail;
        private TextBox txtPlaka;
        private TextBox txtRenk;
        private ComboBox comboMarka;
        private ComboBox comboSeri;
        private ComboBox comboParkYeri;
        private GroupBox grupKişi;
        private GroupBox grupAraç;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button btnSeri;
        private Button btnMarka;
        private ImageList ımageList1;
    }
}