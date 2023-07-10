namespace DoubleHesapMakinesiApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, toplama, cikarma, carpma, bolme;

            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);

            toplama = sayi1 + sayi2;
            cikarma = sayi1 - sayi2;
            carpma = sayi1 * sayi2;
            bolme = sayi1 / sayi2;

            label4.Text = toplama.ToString();
            label6.Text = cikarma.ToString();
            label8.Text = carpma.ToString();
            label10.Text = carpma.ToString();
        }
    }
}
