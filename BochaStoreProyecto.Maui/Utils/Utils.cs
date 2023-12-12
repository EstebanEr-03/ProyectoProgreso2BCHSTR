using BochaStoreProyecto.Maui.Models;
using BochaStoreProyecto.Maui.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BochaStoreProyecto.Maui.Utils
{
    public static class Utils
    {
        static public APIService apiservice = new APIService();

        public static List<Producto> ProductosList = new List<Producto>()
        {
            new Producto { IdProducto=0,Nombre="Camiseta Adidas", Descripcion="Azul Camiseta Adidas",Cantidad=5,ImagenProductoURL="@url.com",Precio=15,IdMarca=1,IdCategoria=1},
            new Producto { IdProducto=1,Nombre="Zapatos Nike", Descripcion="Vapor Zapatos Nike",Cantidad=2,ImagenProductoURL="@url.com",Precio=100,IdMarca=1,IdCategoria=2},
            new Producto { IdProducto=2,Nombre="Pantalon Adidas", Descripcion="RM Pantalon Adidas",Cantidad=2,ImagenProductoURL="@url.com",Precio=20,IdMarca=1,IdCategoria=1},
            new Producto { IdProducto=3,Nombre="Balon Puma", Descripcion="Mundial Balon Puma",Cantidad=7,ImagenProductoURL="@url.com",Precio=30,IdMarca=1,IdCategoria=3}
        };
    }
}
