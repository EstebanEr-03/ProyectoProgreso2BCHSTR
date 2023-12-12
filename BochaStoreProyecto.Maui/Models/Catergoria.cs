using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BochaStoreProyecto.Maui.Models
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Code { get; set; }
        public string Nombre { get; set; }

        public string CategoriaImageURL { get; set; }
    }
}
