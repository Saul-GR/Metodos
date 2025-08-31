using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Metodos
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=Tiendas;Trusted_Connection=True;TrustServerCertificate=True;";
        //int idSeleccionado = 0;
        listaConDatos lista = new listaConDatos();
        List<Producto> productos = new List<Producto>();


        public Form1()
        {
            InitializeComponent();
            
            productos= lista.prodcutos();
            dgvUsuarios.DataSource = productos;
            //CargarDatos();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
