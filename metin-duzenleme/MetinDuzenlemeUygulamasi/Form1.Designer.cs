namespace MetinDuzenlemeUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.MetinTextBox = new System.Windows.Forms.TextBox();
            this.ArananKelimeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BuyukHarfeDonusturButton = new System.Windows.Forms.Button();
            this.KucukHarfeDonusturButton = new System.Windows.Forms.Button();
            this.KelimeBulButton = new System.Windows.Forms.Button();
            this.KelimeDegistirButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.EskiKelimeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.YeniKelimeTextBox = new System.Windows.Forms.TextBox();
            this.KelimeSilButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SilinecekKelimeTextBox = new System.Windows.Forms.TextBox();
            this.DogrulaButton = new System.Windows.Forms.Button();
            this.BosluklariKaldirButton = new System.Windows.Forms.Button();
            this.KarakterSayButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MetinTextBox
            // 
            this.MetinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MetinTextBox.Location = new System.Drawing.Point(223, 36);
            this.MetinTextBox.Name = "MetinTextBox";
            this.MetinTextBox.Size = new System.Drawing.Size(571, 38);
            this.MetinTextBox.TabIndex = 0;
            this.MetinTextBox.UseWaitCursor = true;
            // 
            // ArananKelimeTextBox
            // 
            this.ArananKelimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ArananKelimeTextBox.Location = new System.Drawing.Point(317, 187);
            this.ArananKelimeTextBox.Name = "ArananKelimeTextBox";
            this.ArananKelimeTextBox.Size = new System.Drawing.Size(176, 38);
            this.ArananKelimeTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Metin Giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(63, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aranan Kelime :";
            // 
            // BuyukHarfeDonusturButton
            // 
            this.BuyukHarfeDonusturButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BuyukHarfeDonusturButton.Location = new System.Drawing.Point(26, 96);
            this.BuyukHarfeDonusturButton.Name = "BuyukHarfeDonusturButton";
            this.BuyukHarfeDonusturButton.Size = new System.Drawing.Size(191, 60);
            this.BuyukHarfeDonusturButton.TabIndex = 4;
            this.BuyukHarfeDonusturButton.Text = "Metni Büyüt";
            this.BuyukHarfeDonusturButton.UseVisualStyleBackColor = true;
            this.BuyukHarfeDonusturButton.Click += new System.EventHandler(this.BuyukHarfeDonusturButton_Click);
            // 
            // KucukHarfeDonusturButton
            // 
            this.KucukHarfeDonusturButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KucukHarfeDonusturButton.Location = new System.Drawing.Point(223, 96);
            this.KucukHarfeDonusturButton.Name = "KucukHarfeDonusturButton";
            this.KucukHarfeDonusturButton.Size = new System.Drawing.Size(191, 60);
            this.KucukHarfeDonusturButton.TabIndex = 5;
            this.KucukHarfeDonusturButton.Text = "Metni Küçült";
            this.KucukHarfeDonusturButton.UseVisualStyleBackColor = true;
            this.KucukHarfeDonusturButton.Click += new System.EventHandler(this.KucukHarfeDonusturButton_Click);
            // 
            // KelimeBulButton
            // 
            this.KelimeBulButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KelimeBulButton.Location = new System.Drawing.Point(530, 187);
            this.KelimeBulButton.Name = "KelimeBulButton";
            this.KelimeBulButton.Size = new System.Drawing.Size(96, 60);
            this.KelimeBulButton.TabIndex = 6;
            this.KelimeBulButton.Text = "Bul";
            this.KelimeBulButton.UseVisualStyleBackColor = true;
            this.KelimeBulButton.Click += new System.EventHandler(this.KelimeBulButton_Click);
            // 
            // KelimeDegistirButton
            // 
            this.KelimeDegistirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KelimeDegistirButton.Location = new System.Drawing.Point(530, 272);
            this.KelimeDegistirButton.Name = "KelimeDegistirButton";
            this.KelimeDegistirButton.Size = new System.Drawing.Size(128, 60);
            this.KelimeDegistirButton.TabIndex = 9;
            this.KelimeDegistirButton.Text = "Değiştir";
            this.KelimeDegistirButton.UseVisualStyleBackColor = true;
            this.KelimeDegistirButton.Click += new System.EventHandler(this.KelimeDegistirButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(63, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Eski Kelime :";
            // 
            // EskiKelimeTextBox
            // 
            this.EskiKelimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EskiKelimeTextBox.Location = new System.Drawing.Point(317, 256);
            this.EskiKelimeTextBox.Name = "EskiKelimeTextBox";
            this.EskiKelimeTextBox.Size = new System.Drawing.Size(176, 38);
            this.EskiKelimeTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(59, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Yeni Kelime :";
            // 
            // YeniKelimeTextBox
            // 
            this.YeniKelimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YeniKelimeTextBox.Location = new System.Drawing.Point(317, 300);
            this.YeniKelimeTextBox.Name = "YeniKelimeTextBox";
            this.YeniKelimeTextBox.Size = new System.Drawing.Size(176, 38);
            this.YeniKelimeTextBox.TabIndex = 10;
            // 
            // KelimeSilButton
            // 
            this.KelimeSilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KelimeSilButton.Location = new System.Drawing.Point(530, 356);
            this.KelimeSilButton.Name = "KelimeSilButton";
            this.KelimeSilButton.Size = new System.Drawing.Size(96, 60);
            this.KelimeSilButton.TabIndex = 14;
            this.KelimeSilButton.Text = "Sil";
            this.KelimeSilButton.UseVisualStyleBackColor = true;
            this.KelimeSilButton.Click += new System.EventHandler(this.KelimeSilButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(59, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Silinecek Kelime :";
            // 
            // SilinecekKelimeTextBox
            // 
            this.SilinecekKelimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilinecekKelimeTextBox.Location = new System.Drawing.Point(317, 368);
            this.SilinecekKelimeTextBox.Name = "SilinecekKelimeTextBox";
            this.SilinecekKelimeTextBox.Size = new System.Drawing.Size(176, 38);
            this.SilinecekKelimeTextBox.TabIndex = 12;
            // 
            // DogrulaButton
            // 
            this.DogrulaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DogrulaButton.Location = new System.Drawing.Point(420, 96);
            this.DogrulaButton.Name = "DogrulaButton";
            this.DogrulaButton.Size = new System.Drawing.Size(171, 60);
            this.DogrulaButton.TabIndex = 15;
            this.DogrulaButton.Text = "Doğrula";
            this.DogrulaButton.UseVisualStyleBackColor = true;
            this.DogrulaButton.Click += new System.EventHandler(this.DogrulaButton_Click);
            // 
            // BosluklariKaldirButton
            // 
            this.BosluklariKaldirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BosluklariKaldirButton.Location = new System.Drawing.Point(597, 96);
            this.BosluklariKaldirButton.Name = "BosluklariKaldirButton";
            this.BosluklariKaldirButton.Size = new System.Drawing.Size(197, 60);
            this.BosluklariKaldirButton.TabIndex = 16;
            this.BosluklariKaldirButton.Text = "Boşluk Kaldır";
            this.BosluklariKaldirButton.UseVisualStyleBackColor = true;
            this.BosluklariKaldirButton.Click += new System.EventHandler(this.BosluklariKaldirButton_Click);
            // 
            // KarakterSayButton
            // 
            this.KarakterSayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KarakterSayButton.Location = new System.Drawing.Point(530, 426);
            this.KarakterSayButton.Name = "KarakterSayButton";
            this.KarakterSayButton.Size = new System.Drawing.Size(96, 60);
            this.KarakterSayButton.TabIndex = 19;
            this.KarakterSayButton.Text = "Say";
            this.KarakterSayButton.UseVisualStyleBackColor = true;
            this.KarakterSayButton.Click += new System.EventHandler(this.KarakterSayButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(59, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Karakter Sayısı :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(317, 438);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 38);
            this.textBox1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 552);
            this.Controls.Add(this.KarakterSayButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BosluklariKaldirButton);
            this.Controls.Add(this.DogrulaButton);
            this.Controls.Add(this.KelimeSilButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SilinecekKelimeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.YeniKelimeTextBox);
            this.Controls.Add(this.KelimeDegistirButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EskiKelimeTextBox);
            this.Controls.Add(this.KelimeBulButton);
            this.Controls.Add(this.KucukHarfeDonusturButton);
            this.Controls.Add(this.BuyukHarfeDonusturButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArananKelimeTextBox);
            this.Controls.Add(this.MetinTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MetinTextBox;
        private System.Windows.Forms.TextBox ArananKelimeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuyukHarfeDonusturButton;
        private System.Windows.Forms.Button KucukHarfeDonusturButton;
        private System.Windows.Forms.Button KelimeBulButton;
        private System.Windows.Forms.Button KelimeDegistirButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EskiKelimeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox YeniKelimeTextBox;
        private System.Windows.Forms.Button KelimeSilButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SilinecekKelimeTextBox;
        private System.Windows.Forms.Button DogrulaButton;
        private System.Windows.Forms.Button BosluklariKaldirButton;
        private System.Windows.Forms.Button KarakterSayButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}

