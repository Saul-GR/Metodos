using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Metodos
{
    internal class listaConDatos
    {
        public List <Producto> prodcutos()
        {
            // 1. Crea una nueva lista del tipo deseado (Libro en este caso)
            List<Producto> pro = new List<Producto>();

            // 2. Agrega elementos a la lista usando el método Add()
            pro.Add(new Producto { Codigo = 1, Nombre = "Libro", Descripcion ="Libro de cuadriculas", Stock=25 });
            pro.Add(new Producto { Codigo = 2, Nombre = "Lapicero", Descripcion = "Lapicero de color negro", Stock = 5 });
            pro.Add(new Producto { Codigo = 3, Nombre = "Borrador", Descripcion = "Borrador tamaño grande", Stock = 2 });
            pro.Add(new Producto { Codigo = 4, Nombre = "Tijeras", Descripcion = "Tijeras punta cuadrada", Stock = 3 });
            pro.Add(new Producto { Codigo = 5, Nombre = "Folder", Descripcion = "Folder azul tamaño carta", Stock = 6 });
            // 3. Usa la palabra clave 'return' para devolver la lista
            return pro;
        } 
    }
}
