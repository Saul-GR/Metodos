using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;



namespace Metodos
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=Tienda;Trusted_Connection=True;TrustServerCertificate=True;";
        int idSeleccionado = 0;
        int roll = 0;
        TabPage tabPageOculto;

        public Form1()
        {
            InitializeComponent();
            tabPageOculto = tabControl1.TabPages[1];
            tabVisibles();
            CargarDatos();

        }
        public void tabVisibles()
        {
            
            if (roll == 0)
            {
                tabControl1.TabPages.Remove(tabPageOculto);
            }
            else
            {
               tabControl1.TabPages.Insert(1, tabPageOculto);
            }
        }
        private void CargarDatos()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            string query = "SELECT * FROM Usuarios";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvUsuarios.DataSource = dt;
            estadoConn(conn);
            conn.Close();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (roll == 0)
            {
                roll++;
                tabVisibles();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void estadoConn(SqlConnection conn)
        {

            if (conn.State == ConnectionState.Open)
            {
                Console.WriteLine("La conexión está abierta.");
                label1.ForeColor = Color.Green;
            }
            else
            {
                Console.WriteLine("La conexión no está abierta.");
                label1.ForeColor = Color.Red;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
