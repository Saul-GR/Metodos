using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Metodos
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=Tiendas;Trusted_Connection=True;TrustServerCertificate=True;";
        int idSeleccionado = 0;
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
        private void agregarProducto()
        {
            Producto NuevoProducto = new Producto();
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

            if (string.IsNullOrWhiteSpace(Nombre) || string.IsNullOrWhiteSpace(Descripcion) || Precio <= 0 || Stock <= 0)
            {
                MessageBox.Show("Los campos Nombre y Descripción no pueden estar vacíos.");
                return; // Salir del método si los campos están vacíos
            }

            foreach (Producto p in productos)
            {
                if (p.Nombre.Equals(Nombre, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("El producto ya existe en el inventario.");
                    return; // Salir del método si el producto ya existe
                }
            }
            NuevoProducto.Codigo = productos.Max(p => p.Codigo) + 1; // Asigna un código único incrementando el máximo existente
            NuevoProducto.Nombre = Nombre;
            NuevoProducto.Descripcion = Descripcion;
            NuevoProducto.Stock = Stock;
            NuevoProducto.Precio = Precio;
            NuevoProducto.Activo = Activo;

            productos.Add(NuevoProducto);
            dgvInventario.DataSource = null;
            dgvInventario.DataSource = productos;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                agregarProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El tipo de dato no es correcto o el formulario esta vacio: \n" + ex.Message);
            }
        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvInventario.Rows[e.RowIndex];

                idSeleccionado = Convert.ToInt32(fila.Cells["Codigo"].Value);
                textBoxNombre.Text = fila.Cells["Nombre"].Value.ToString();
                textBoxDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
                textBoxStock.Text = fila.Cells["Stock"].Value.ToString();
                textBoxPrecio.Text = fila.Cells["Precio"].Value.ToString();
                checkBoxActivo.Checked = Convert.ToBoolean(fila.Cells["Activo"].Value);
                labelId.Text = "Id:" + idSeleccionado.ToString();
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
