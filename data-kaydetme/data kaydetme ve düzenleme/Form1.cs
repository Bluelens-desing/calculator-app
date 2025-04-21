namespace data_kaydetme_ve_düzenleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].HeaderText = "ÖĞRENCİNO";
            dataGridView1.Columns[1].HeaderText = "ADI SOYADI";
            dataGridView1.Columns[2].HeaderText = "VİZE";
            dataGridView1.Columns[3].HeaderText = "FİNAL";
            dataGridView1.Columns[4].HeaderText = "BAŞARI ORTALAMASI";

            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[4].Width = 150;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount += 1;
            int satır = dataGridView1.RowCount - 1;
            dataGridView1.Rows[satır].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[satır].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[satır].Cells[2].Value = textBox3.Text;
            dataGridView1.Rows[satır].Cells[3].Value = textBox4.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentRow.Cells[0].Value = textBox1.Text;
            dataGridView1.CurrentRow.Cells[1].Value = textBox2.Text;
            dataGridView1.CurrentRow.Cells[2].Value = textBox3.Text;
            dataGridView1.CurrentRow.Cells[3].Value = textBox4.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(Convert.ToInt32(textBox5.Text)-1);
        }
    }
}
