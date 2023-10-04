namespace Otopark_Otomasyonu
{
    partial class frmAnaSayfa
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
            btnAracKayit = new Button();
            btnAracYerleri = new Button();
            btnAracCikis = new Button();
            btnCikis = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnAracKayit
            // 
            btnAracKayit.Location = new Point(417, 331);
            btnAracKayit.Margin = new Padding(4, 3, 4, 3);
            btnAracKayit.Name = "btnAracKayit";
            btnAracKayit.Size = new Size(264, 33);
            btnAracKayit.TabIndex = 0;
            btnAracKayit.Text = "Araç Otopark Kayıt Sayfası";
            btnAracKayit.UseVisualStyleBackColor = true;
            btnAracKayit.Click += btnAracKayit_Click;
            // 
            // btnAracYerleri
            // 
            btnAracYerleri.Location = new Point(417, 383);
            btnAracYerleri.Margin = new Padding(4, 3, 4, 3);
            btnAracYerleri.Name = "btnAracYerleri";
            btnAracYerleri.Size = new Size(264, 34);
            btnAracYerleri.TabIndex = 1;
            btnAracYerleri.Text = "Araç Otopark Yerleri";
            btnAracYerleri.UseVisualStyleBackColor = true;
            btnAracYerleri.Click += btnAracYerleri_Click;
            // 
            // btnAracCikis
            // 
            btnAracCikis.Location = new Point(417, 436);
            btnAracCikis.Margin = new Padding(4, 3, 4, 3);
            btnAracCikis.Name = "btnAracCikis";
            btnAracCikis.Size = new Size(264, 33);
            btnAracCikis.TabIndex = 2;
            btnAracCikis.Text = "Araç Otopark Çıkış Sayfası";
            btnAracCikis.UseVisualStyleBackColor = true;
            btnAracCikis.Click += btnAracCikis_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.Transparent;
            btnCikis.Location = new Point(417, 540);
            btnCikis.Margin = new Padding(4, 3, 4, 3);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(264, 33);
            btnCikis.TabIndex = 3;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // button1
            // 
            button1.Location = new Point(417, 488);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(264, 33);
            button1.TabIndex = 4;
            button1.Text = "Satış Listeleme Sayfası";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmAnaSayfa
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = Properties.Resources.Otopark2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1062, 613);
            Controls.Add(button1);
            Controls.Add(btnCikis);
            Controls.Add(btnAracCikis);
            Controls.Add(btnAracYerleri);
            Controls.Add(btnAracKayit);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmAnaSayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Sayfa";
            Load += frmAnaSayfa_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAracKayit;
        private Button btnAracYerleri;
        private Button btnAracCikis;
        private Button btnCikis;
        private Button button1;
    }
}