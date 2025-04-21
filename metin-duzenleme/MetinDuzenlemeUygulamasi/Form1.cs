using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MetinDuzenlemeUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BuyukHarfeDonusturButton_Click(object sender, EventArgs e)
        {
            MetinTextBox.Text = MetinTextBox.Text.ToUpper(); // metin içindeki bütün harflari büyük harf yapar
        }

        private void KucukHarfeDonusturButton_Click(object sender, EventArgs e)
        {
            MetinTextBox.Text = MetinTextBox.Text.ToLower(); // metin içindeki bütün harflari küçük harf yapar
        }

        private void BosluklariKaldirButton_Click(object sender, EventArgs e)
        {
            MetinTextBox.Text = MetinTextBox.Text.Trim(); // metin başındaki ve sonunda ki boşlukları siler
        }

        private void KelimeBulButton_Click(object sender, EventArgs e)
        {
            string arananKelime = ArananKelimeTextBox.Text; // aranan kelime string ifade olarak atanır
            int kelimeSayisi = MetinTextBox.Text.Split(' ').Count(kelime => kelime.Equals(arananKelime, StringComparison.OrdinalIgnoreCase));
            // split komutu ile boşluklara bakılarak kelimeler sayılır / sonra büyük küçük harfi yoksayarak bulduğu kelimeleri sayar ve kelime sayısı değişkenine atar
            MessageBox.Show($"\"{arananKelime}\" kelimesi metin içinde {kelimeSayisi} kez geçiyor.", "Kelime Sayısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //mesaj boxta ise aranan kelime ve kaç kere geçtiği yazdırılır
        }

        private void KelimeDegistirButton_Click(object sender, EventArgs e)
        {
            string eskiKelime = EskiKelimeTextBox.Text;
            string yeniKelime = YeniKelimeTextBox.Text;
            MetinTextBox.Text = MetinTextBox.Text.Replace(yeniKelime,eskiKelime); // eski kelime ile yeni kelime yer değiştiriyor
        }

        private void KelimeSilButton_Click(object sender, EventArgs e)
        {
            string silinecekKelime = SilinecekKelimeTextBox.Text;
            MetinTextBox.Text = MetinTextBox.Text.Replace(silinecekKelime, ""); // aynı işlemi silmek için kullanılır
        }

        private void DogrulaButton_Click(object sender, EventArgs e)
        {
            string[] sozluk = { "bugün", "hava", "güzel", "yağmur", "bekleniyor" };
            List<string> hataliKelimeler = new List<string>(); // hatalaı kelimeler burada tutulacak

            string[] kelimeler = MetinTextBox.Text.Split(new char[] { ' ', '.', ',', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            // noktala işaretleri ve boşlukla kelimeler ayrıştırılır
            foreach (string kelime in kelimeler)
            {
                if (!sozluk.Contains(kelime.ToLower())) // hepsi küçük harfe çevrilip karşılaştırılır
                {
                    hataliKelimeler.Add(kelime); // hatalı kelimeler listeye eklenir
                }
            }

            if (hataliKelimeler.Any())
            {
                string hataliKelimelerString = string.Join(", ", hataliKelimeler);
                MessageBox.Show($"Metinde şu hatalı kelimeler bulunmaktadır: {hataliKelimelerString}", "Doğrulama Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // hatalı kelimeler varsa bunları (,) ile birleştirip ekrana yazdırır
            }
            else
            {
                MessageBox.Show("Metin doğrulandı, hatalı kelime bulunmamaktadır.", "Doğrulama Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // hatalı kelime yoksa metin temiz mesajı gösterir
            }
        }

        private void KarakterSayButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = MetinTextBox.Text.Length.ToString(); // metindeki karakter sayılırını yazdırır
        }
    }
    }
