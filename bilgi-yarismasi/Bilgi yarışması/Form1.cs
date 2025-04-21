namespace Bilgi_yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;
        private void btnsonraki_Click(object sender, EventArgs e)
        {
            btnsonraki.Text = "sonraki";

            soruno++;
            lblsoruNO.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                label3.Text = "1923";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangisi Türkiyenin başkentidir?";
                btnA.Text = "Ankara";
                btnB.Text = "Adıyaman";
                btnC.Text = "Adana";
                btnD.Text = "Ağrı";
                label3.Text = "Ankara";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Hangi il ege bölgemizde bulunmaz?";
                btnA.Text = "İzmir";
                btnB.Text = "Balıkesir";
                btnC.Text = "Manisa";
                btnD.Text = "Aydın";
                label3.Text = "Balıkesir";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Son kuşlar hangi yazarımıza aittir?";
                btnA.Text = "Atilla İlhan";
                btnB.Text = "Cemal Süreyya";
                btnC.Text = "Sait Faik";
                btnD.Text = "Reşat Nüri";
                label3.Text = "Sait Faik";

            }
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            if (soruno == 5)
            {
                btnsonraki.Enabled = false;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: " + yanlis);
            }

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            label4.Text = btnA.Text;
            if (label3.Text == label4.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            label4.Text = btnB.Text;
            if (label3.Text == label4.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            label4.Text = btnC.Text;
            if (label3.Text == label4.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            label4.Text = btnD.Text;
            if (label3.Text == label4.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            soruno = 0;
            dogru = 0;
            yanlis = 0;

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            richTextBox1.Text = "";
            btnA.Text = "A";
            btnB.Text = "B";
            btnC.Text = "C";
            btnD.Text = "D";

            lblsoruNO.Text = "-----------";
            lblDogru.Text = "-----------";
            lblYanlis.Text = "-----------";

            pictureBox1 .Visible = false;
            pictureBox2 .Visible = false;
        }
    }
}
