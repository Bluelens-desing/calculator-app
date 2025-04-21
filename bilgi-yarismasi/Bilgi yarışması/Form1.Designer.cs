namespace Bilgi_yarışması
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            panel1 = new Panel();
            button1 = new Button();
            btnsonraki = new Button();
            lblYanlis = new Label();
            lblDogru = new Label();
            lblsoruNO = new Label();
            lablel3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(576, 187);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnA
            // 
            btnA.Enabled = false;
            btnA.Location = new Point(3, 195);
            btnA.Name = "btnA";
            btnA.Size = new Size(285, 84);
            btnA.TabIndex = 1;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.Enabled = false;
            btnB.Location = new Point(294, 195);
            btnB.Name = "btnB";
            btnB.Size = new Size(285, 84);
            btnB.TabIndex = 2;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // btnC
            // 
            btnC.Enabled = false;
            btnC.Location = new Point(3, 285);
            btnC.Name = "btnC";
            btnC.Size = new Size(285, 83);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnD
            // 
            btnD.Enabled = false;
            btnD.Location = new Point(294, 285);
            btnD.Name = "btnD";
            btnD.Size = new Size(285, 84);
            btnD.TabIndex = 4;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            btnD.Click += btnD_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnsonraki);
            panel1.Controls.Add(lblYanlis);
            panel1.Controls.Add(lblDogru);
            panel1.Controls.Add(lblsoruNO);
            panel1.Controls.Add(lablel3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(20, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 209);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(133, 146);
            button1.Name = "button1";
            button1.Size = new Size(115, 47);
            button1.TabIndex = 7;
            button1.Text = "Sıfırla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnsonraki
            // 
            btnsonraki.Location = new Point(13, 146);
            btnsonraki.Name = "btnsonraki";
            btnsonraki.Size = new Size(114, 47);
            btnsonraki.TabIndex = 6;
            btnsonraki.Text = "Başlat";
            btnsonraki.UseVisualStyleBackColor = true;
            btnsonraki.Click += btnsonraki_Click;
            // 
            // lblYanlis
            // 
            lblYanlis.AutoSize = true;
            lblYanlis.Location = new Point(118, 100);
            lblYanlis.Name = "lblYanlis";
            lblYanlis.Size = new Size(100, 28);
            lblYanlis.TabIndex = 5;
            lblYanlis.Text = "-----------";
            // 
            // lblDogru
            // 
            lblDogru.AutoSize = true;
            lblDogru.Location = new Point(118, 59);
            lblDogru.Name = "lblDogru";
            lblDogru.Size = new Size(100, 28);
            lblDogru.TabIndex = 4;
            lblDogru.Text = "-----------";
            // 
            // lblsoruNO
            // 
            lblsoruNO.AutoSize = true;
            lblsoruNO.Location = new Point(118, 17);
            lblsoruNO.Name = "lblsoruNO";
            lblsoruNO.Size = new Size(100, 28);
            lblsoruNO.TabIndex = 3;
            lblsoruNO.Text = "-----------";
            // 
            // lablel3
            // 
            lablel3.AutoSize = true;
            lablel3.Location = new Point(13, 100);
            lablel3.Name = "lablel3";
            lablel3.Size = new Size(78, 28);
            lablel3.TabIndex = 2;
            lablel3.Text = "Yanlış:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 59);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 1;
            label2.Text = "Doğru:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 17);
            label1.Name = "label1";
            label1.Size = new Size(97, 28);
            label1.TabIndex = 0;
            label1.Text = "SoruNO:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(585, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(299, 366);
            panel2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(153, 227);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(128, 133);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Image = Properties.Resources.doğru;
            pictureBox1.Location = new Point(20, 227);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(441, 383);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(441, 423);
            label4.Name = "label4";
            label4.Size = new Size(72, 28);
            label4.TabIndex = 8;
            label4.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(892, 376);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(richTextBox1);
            Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Bilgi Yarışması";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Panel panel1;
        private Label lblYanlis;
        private Label lblDogru;
        private Label lblsoruNO;
        private Label lablel3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnsonraki;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}
