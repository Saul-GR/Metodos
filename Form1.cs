namespace Metodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal valor1 = decimal.Parse(textBox1.Text);
            decimal valor2 = 0;
            decimal resultado = 0;

            resultado = cambioDolar(valor1, valor2);

            label1.Text = ""+resultado;



        }
        public decimal cambioDolar(decimal valor1, decimal valor2)
        {
            valor1 = valor1 * 7.65m;
            return valor1;
        }
    }
}
