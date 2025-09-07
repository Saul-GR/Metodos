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
        int MaximoCompra = 0;
        double SubTotal = 0;
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
            List<Producto> proBus = new List<Producto>();
            Producto proBuscado = new Producto();
            string datoBuscado = "";
            LimpiarCampos2();




            datoBuscado = textBoxProBuscado.Text;


            if (string.IsNullOrWhiteSpace(datoBuscado))
            {
                MessageBox.Show("Ingrese dato en el campo de búsqueda Saúl!");
                return; // Salir del método si el campo de búsqueda está vacío
            }
            foreach (Producto p in productos)
            {
                if (datoBuscado.All(char.IsDigit) == true)
                {
                    if (p.Codigo == int.Parse(datoBuscado))
                    {
                        idSeleccionado = p.Codigo;
                        proBuscado.Codigo = p.Codigo;
                        proBuscado.Nombre = p.Nombre;
                        proBuscado.Descripcion = p.Descripcion;
                        proBuscado.Stock = p.Stock;
                        proBuscado.Precio = p.Precio;
                        proBuscado.Activo = p.Activo;

                        proBus.Add(proBuscado);
                        dgvProducto.DataSource = null;
                        dgvProducto.DataSource = proBus;
                        // MessageBox.Show("Encontrado en código.");
                        textBoxProNombre.Text = p.Nombre;
                        textBoxProDescripcion.Text = p.Descripcion;
                        textBoxProStock.Text = p.Stock.ToString();
                        textBoxProPrecio.Text = p.Precio.ToString();
                        textBoxProId.Text = p.Codigo.ToString();
                        return;
                    }
                }
                else if (p.Nombre.Contains(datoBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    proBuscado = new Producto();
                    idSeleccionado = p.Codigo;

                    proBuscado.Codigo = p.Codigo;
                    proBuscado.Nombre = p.Nombre;
                    proBuscado.Descripcion = p.Descripcion;
                    proBuscado.Stock = p.Stock;
                    proBuscado.Precio = p.Precio;
                    proBuscado.Activo = p.Activo;
                    proBus.Add(proBuscado);
                    dgvProducto.DataSource = null;
                    dgvProducto.DataSource = proBus;


                    //MessageBox.Show("Encontrado en nombre."+p.Nombre);

                }

            }
            //Usar p.Nombre.Contains pero no ha funcionado
            //proBus.Add(proBuscado);
            //dgvProducto.DataSource = null;
            //dgvProducto.DataSource = proBus;
            if (idSeleccionado == 0)
            {
                MessageBox.Show("No se encontró el producto en el inventario.");
                return; // Salir del método si el producto no se encuentra
            }
            idSeleccionado = 0;
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
            numericUpDownCarrito.Maximum = MaximoCompra;
            productos = lista.prodcutos();
            dgvProducto.DataSource = productos;
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
                checkBoxActivo.Checked = fila.Cells["Activo"].Value == "Si" ? true : false;
                labelId.Text = "Id:" + idSeleccionado.ToString();


            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto para modificar.");
                return;
            }
            try
            {
                modificarProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El tipo de dato no es correcto o el formulario esta vacio: \n" + ex.Message);
            }
        }
        private void agregarProducto()
        {
            Producto NuevoProducto = new Producto();
            int Codigo = 0;
            string Nombre = "";
            string Descripcion = "";
            int Stock = 0;
            double Precio = 0;
            string Activo = "No";

            Nombre = textBoxNombre.Text;
            Descripcion = textBoxDescripcion.Text;
            Stock = int.Parse(textBoxStock.Text);
            Precio = double.Parse(textBoxPrecio.Text);
            Activo = checkBoxActivo.Checked ? "Si" : "No";

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
            LimpiarCampos();
        }
        private void modificarProducto()
        {
            Producto NuevoProducto = new Producto();
            string Nombre = "";
            string Descripcion = "";
            int Stock = 0;
            double Precio = 0;
            string Activo = "No";

            Nombre = textBoxNombre.Text;
            Descripcion = textBoxDescripcion.Text;
            Stock = int.Parse(textBoxStock.Text);
            Precio = double.Parse(textBoxPrecio.Text);
            Activo = checkBoxActivo.Checked ? "Si" : "No";

            if (string.IsNullOrWhiteSpace(Nombre) || string.IsNullOrWhiteSpace(Descripcion) || Precio <= 0 || Stock <= 0)
            {
                MessageBox.Show("Los campos Nombre y Descripción no pueden estar vacíos.");
                return; // Salir del método si los campos están vacíos
            }

            foreach (Producto p in productos)
            {
                if (p.Codigo == idSeleccionado)
                {
                    if (!p.Nombre.Equals(Nombre, StringComparison.OrdinalIgnoreCase) || !p.Descripcion.Equals(Descripcion, StringComparison.OrdinalIgnoreCase)
                        || p.Precio != Precio || p.Stock != Stock || p.Activo != Activo)
                    {
                        p.Nombre = Nombre;
                        p.Descripcion = Descripcion;
                        p.Stock = Stock;
                        p.Precio = Precio;
                        p.Activo = Activo;
                        dgvInventario.DataSource = null;
                        dgvInventario.DataSource = productos;

                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese valor para modificar");
                    }
                }
            }
        }
        private void LimpiarCampos()
        {
            textBoxNombre.Clear();
            textBoxDescripcion.Clear();
            textBoxStock.Clear();
            textBoxPrecio.Clear();
            checkBoxActivo.Checked = false;
            labelId.Text = "";
            idSeleccionado = 0;

            textBoxProNombre.Clear();
            textBoxProDescripcion.Clear();
            textBoxProStock.Clear();
            textBoxProPrecio.Clear();
            textBoxProId.Clear();
            textBoxProBuscado.Clear();
            dgvProducto.DataSource = null;
            dgvProducto.DataSource = productos;

            MaximoCompra = 0;
            numericUpDownCarrito.Minimum = 0;
            numericUpDownCarrito.Value = MaximoCompra;
            numericUpDownCarrito.Maximum = 0;
            labelSubTotal.Text = "Q. 0.00";
        }
        private void LimpiarCampos2()
        {
            textBoxNombre.Clear();
            textBoxDescripcion.Clear();
            textBoxStock.Clear();
            textBoxPrecio.Clear();
            checkBoxActivo.Checked = false;
            labelId.Text = "";
            idSeleccionado = 0;

            textBoxProNombre.Clear();
            textBoxProDescripcion.Clear();
            textBoxProStock.Clear();
            textBoxProPrecio.Clear();
            textBoxProId.Clear();
            //textBoxProBuscado.Clear();
            dgvProducto.DataSource = null;
            dgvProducto.DataSource = productos;
        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvInventario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (e.ColumnIndex == dgvInventario.Columns[5].Index && e.RowIndex >= 0)
            //{
            //    // Asegúrate de que el valor es booleano
            //    if (e.Value is bool valorBooleano)
            //    {
            //        // Asigna "Sí" para true y "No" para false
            //        e.Value = valorBooleano ? "Sí" : "No";
            //    }
            //}
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvInventario.Rows[e.RowIndex];

                idSeleccionado = Convert.ToInt32(fila.Cells["Codigo"].Value);
                textBoxProNombre.Text = fila.Cells["Nombre"].Value.ToString();
                textBoxProDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
                textBoxProStock.Text = fila.Cells["Stock"].Value.ToString();
                textBoxProPrecio.Text = fila.Cells["Precio"].Value.ToString();
                textBoxProId.Text = fila.Cells["Codigo"].Value.ToString();
                MaximoCompra = int.Parse(fila.Cells["Stock"].Value.ToString());
                numericUpDownCarrito.Maximum = MaximoCompra;
                numericUpDownCarrito.Value = 1;
                numericUpDownCarrito.Minimum = 1;
                SubTotal = double.Parse(fila.Cells["Precio"].Value.ToString());
                SubTotal = SubTotal * (double)numericUpDownCarrito.Value;
                textBoxSubTotal.Text = "Q. " + SubTotal;
                //MessageBox.Show("Compra maxima: " + MaximoCompra);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();

        }

        private void numericUpDownCarrito_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownCarrito.Value > 0)
            {
                SubTotal = double.Parse(textBoxProPrecio.Text);
                SubTotal = SubTotal * (double)numericUpDownCarrito.Value;
                textBoxSubTotal.Text = "Q. " + SubTotal;
            }
        }    
    }
}
