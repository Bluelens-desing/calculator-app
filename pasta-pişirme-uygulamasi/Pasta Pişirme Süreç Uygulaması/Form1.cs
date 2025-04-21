namespace Pasta_Pişirme_Süreç_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value % 20 == 10)
            {
                label5.BackColor = Color.FromName("CornflowerBlue");
            }
            if (progressBar1.Value % 20 == 0)
            {
                label5.BackColor = Color.White;
            }
            if (sayac < 100)
            {
                sayac += 1;
                progressBar1.Value = sayac;
                label8.Text = "Karıştırılıyor...";
            }
            if (progressBar1.Value == 100)
            {
                sayac = 0;
                timer2.Start();
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar2.Value % 20 == 10)
            {
                label2.BackColor = Color.FromName("CornflowerBlue");
            }
            if (progressBar2.Value % 20 == 0)
            {
                label2.BackColor = Color.White;
            }
            if (sayac < 100)
            {
                sayac += 1;
                progressBar2.Value = sayac;
                label8.Text = "Çırpılıyor...";
            }
            if (progressBar2.Value == 100)
            {
                sayac = 0;
                timer3.Start();
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (progressBar3.Value % 20 == 10)
            {
                label3.BackColor = Color.FromName("CornflowerBlue");
            }
            if (progressBar3.Value % 20 == 0)
            {
                label3.BackColor = Color.White;
            }
            if (sayac < 100)
            {
                sayac += 1;
                progressBar3.Value = sayac;
                label8.Text = "Karıştırılıyor...";
            }
            if (progressBar3.Value == 100)
            {
                sayac = 0;
                timer4.Start();
                timer3.Stop();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (progressBar4.Value % 20 == 10)
            {
                label4.BackColor = Color.FromName("CornflowerBlue");
            }
            if (progressBar4.Value % 20 == 0)
            {
                label4.BackColor = Color.White;
            }
            if (sayac < 100)
            {
                sayac += 1;
                progressBar4.Value = sayac;
                label8.Text = "Pişiriliyor...";
            }
            if (progressBar4.Value == 100)
            {
                sayac = 0;
                timer4.Stop();
                MessageBox.Show("Pastamız hazır oldu:)");
                label8.Text = "Sunuma hazır.";

                label2.BackColor = Color.Transparent;
                label3.BackColor = Color.Transparent;
                label4.BackColor = Color.Transparent;
                label5.BackColor = Color.Transparent;
            }
        }

        private void pasta_reset_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            progressBar4.Value = 0;

            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;

            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();

            sayac = 0;

        }
        int duraklatma_sayacı = 1;
        private void button_duraklat_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;

            if (duraklatma_sayacı == 1)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                duraklatma_sayacı = 0;
            }
            else if (duraklatma_sayacı == 0){
                if (progressBar1.Value != 0 && progressBar1.Value < 100) 
                {
                    timer1.Start();
                }
                if (progressBar2.Value != 0 && progressBar2.Value < 100)
                {
                    timer2.Start();
                }
                if (progressBar3.Value != 0 && progressBar3.Value < 100)
                {
                    timer3.Start();
                }
                if (progressBar4.Value != 0 && progressBar4.Value < 100)
                {
                    label9.Text = "Pişirme işlemi duraklatılamaz.";
                }
                duraklatma_sayacı = 1;
            }
        }
    }
}
