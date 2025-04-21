namespace Pasta_Pişirme_Süreç_Uygulaması
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            progressBar2 = new ProgressBar();
            label3 = new Label();
            progressBar3 = new ProgressBar();
            label4 = new Label();
            progressBar4 = new ProgressBar();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            label6 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            pasta_reset = new Button();
            button_duraklat = new Button();
            label9 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.BackColor = SystemColors.GradientActiveCaption;
            progressBar1.Location = new Point(4, 98);
            progressBar1.Margin = new Padding(5, 4, 5, 4);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(662, 28);
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 66);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(302, 28);
            label1.TabIndex = 1;
            label1.Text = "Un ve yumurta karıştırılıyor...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 171);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(256, 28);
            label2.TabIndex = 3;
            label2.Text = "Çırpma işlemi yapılıyor...";
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(4, 203);
            progressBar2.Margin = new Padding(5, 4, 5, 4);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(662, 28);
            progressBar2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 276);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(392, 28);
            label3.TabIndex = 5;
            label3.Text = "Malzemeler ekleniyor ve karıştırılıyor...";
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(4, 308);
            progressBar3.Margin = new Padding(5, 4, 5, 4);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(662, 28);
            progressBar3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 381);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(182, 28);
            label4.TabIndex = 7;
            label4.Text = "Pasta pişiriliyor...";
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(4, 413);
            progressBar4.Margin = new Padding(5, 4, 5, 4);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(662, 28);
            progressBar4.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 66);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(302, 28);
            label5.TabIndex = 1;
            label5.Text = "Un ve yumurta karıştırılıyor...";
            // 
            // timer1
            // 
            timer1.Interval = 60;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 120;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 30;
            timer3.Tick += timer3_Tick;
            // 
            // timer4
            // 
            timer4.Interval = 200;
            timer4.Tick += timer4_Tick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 12);
            label6.Name = "label6";
            label6.Size = new Size(146, 28);
            label6.TabIndex = 8;
            label6.Text = "Pasta pişirme";
            // 
            // button1
            // 
            button1.Location = new Point(152, 7);
            button1.Name = "button1";
            button1.Size = new Size(150, 38);
            button1.TabIndex = 9;
            button1.Text = "Başlat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(20, 461);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 56);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(336, 461);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 56);
            panel2.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(105, 12);
            label8.Name = "label8";
            label8.Size = new Size(156, 28);
            label8.TabIndex = 12;
            label8.Text = "------------------";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(3, 12);
            label7.Name = "label7";
            label7.Size = new Size(96, 28);
            label7.TabIndex = 8;
            label7.Text = "Durumu:";
            // 
            // pasta_reset
            // 
            pasta_reset.Location = new Point(20, 523);
            pasta_reset.Name = "pasta_reset";
            pasta_reset.Size = new Size(626, 42);
            pasta_reset.TabIndex = 12;
            pasta_reset.Text = "Yeni Pasta";
            pasta_reset.UseVisualStyleBackColor = true;
            pasta_reset.Click += pasta_reset_Click;
            // 
            // button_duraklat
            // 
            button_duraklat.Location = new Point(20, 571);
            button_duraklat.Name = "button_duraklat";
            button_duraklat.Size = new Size(626, 47);
            button_duraklat.TabIndex = 13;
            button_duraklat.Text = "Duraklat / Devam";
            button_duraklat.UseVisualStyleBackColor = true;
            button_duraklat.Click += button_duraklat_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(181, 621);
            label9.Name = "label9";
            label9.Size = new Size(0, 28);
            label9.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(667, 658);
            Controls.Add(label9);
            Controls.Add(button_duraklat);
            Controls.Add(pasta_reset);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(progressBar4);
            Controls.Add(label3);
            Controls.Add(progressBar3);
            Controls.Add(label2);
            Controls.Add(progressBar2);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label label1;
        private Label label2;
        private ProgressBar progressBar2;
        private Label label3;
        private ProgressBar progressBar3;
        private Label label4;
        private ProgressBar progressBar4;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private Label label6;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Label label7;
        private Label label8;
        private Button pasta_reset;
        private Button button_duraklat;
        private Label label9;
    }
}
