using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Metodos
{
    internal class listaConDatos
    {
        public List <Producto> prodcutos()
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=Tienda;Trusted_Connection=True;TrustServerCertificate=True;";
            DataTable dt = new DataTable();

            List<Producto> pro = new List<Producto>();
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);

                string query = "SELECT * FROM Productos";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                conn.Close();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    Producto objeto = new Producto
                    {
                        Codigo = (int)row["Id"], // Asigna el valor de la columna "Id"
                        Nombre = row["Nombre"].ToString(), // Asigna el valor de la columna "Nombre"
                        Descripcion = row["Descripcion"].ToString(),
                        Stock = (int)row["Stock"],
                        Precio= decimal.ToDouble((decimal)row["Precio"])
                    };
                    pro.Add(objeto); // Agrega el objeto a la lista
                }
                MessageBox.Show("Se conecto a la base de datos");
                return pro;
                //dgvUsuarios.DataSource = dt;
                //estadoConn(conn);
                //conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos :" + ex.Message);
                MessageBox.Show("Se usaran datos autogenerados");
                           
                // 2. Agrega elementos a la lista usando el método Add()
                pro.Add(new Producto { Codigo = 1, Nombre = "Lapicero", Descripcion = "Lapicero de color negro C#", Stock = 5, Precio= 1.25 });
                pro.Add(new Producto { Codigo = 2, Nombre = "Borrador", Descripcion = "Borrador tamaño grande C#", Stock = 2, Precio=2.5 });
                pro.Add(new Producto { Codigo = 3, Nombre = "Tijeras", Descripcion = "Tijeras punta cuadrada C#", Stock = 3, Precio= 5.75});
                pro.Add(new Producto { Codigo = 4, Nombre = "Folder", Descripcion = "Folder azul tamaño carta C#", Stock = 6, Precio= 2});
                // 3. Usa la palabra clave 'return' para devolver la lista
                return pro;
            }
        } 
    }
}
