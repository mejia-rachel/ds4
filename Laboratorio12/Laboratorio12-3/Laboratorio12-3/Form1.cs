namespace Laboratorio12_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double LadoA = double.Parse(textBox1.Text);
            double LadoB = double.Parse(textBox2.Text);
            double LadoC = double.Parse(textBox3.Text);

            double perimetro = LadoA + LadoB + LadoC;
            double semiperimetro = perimetro / 2;

            textBox4.Text = semiperimetro.ToString("F1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double LadoA = double.Parse(textBox1.Text);
            double ladoB = double.Parse(textBox2.Text);
            double area = (LadoA * ladoB) / 2;

            textBox5.Text = area.ToString("F1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
