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
            CargarDatos();

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
        private void CargarDatos()
        {
            productos = lista.prodcutos();
            dgvUsuarios.DataSource = productos;
            dgvInventario.DataSource = productos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int Codigo = 0;
                string Nombre = "";
                string Descripcion = "";
                int Stock = 0;
                double Precio = 0;
                bool Activo = false;

                Nombre = textBoxNombre.Text;
                Descripcion = textBoxDescripcion.Text;
                Stock = int.Parse(textBoxStock.Text);
                Precio = double.Parse(textBoxPrecio.Text);
                Activo = checkBoxActivo.Checked;
            }
            catch (Exception ex)
            {
                MessageBox.Show("El tipo de dato no es correcto o el formulario esta vacio: \n" + ex.Message);
            }
        }
    }
}
