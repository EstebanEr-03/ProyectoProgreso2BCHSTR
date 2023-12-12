using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BochaStoreProyecto.Maui.Models
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public string ImagenProductoURL { get; set; }
        public double Precio { get; set; }
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }

    }
}
