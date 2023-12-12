namespace BochaStoreProyecto.Maui.Views.Producto;
using BochaStoreProyecto.Maui.Services;

using static System.Runtime.InteropServices.JavaScript.JSType;

using Producto = BochaStoreProyecto.Maui.Models.Producto;

public partial class NuevoProducto : ContentPage
{
    private Producto _producto;
    private readonly APIService _APIService;
    public NuevoProducto(APIService apiservice)
    {
        InitializeComponent();
        _APIService = apiservice;

    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        _producto = BindingContext as Producto;
        if (_producto != null)
        {
            EntryNombre.Text = _producto.Nombre;
            EntryDescripcion.Text = _producto.Descripcion;
            Entrycantidad.Text = _producto.Cantidad.ToString();
            EntryImagenProductoURL.Text = _producto.ImagenProductoURL;
            EntryPrecio.Text = _producto.Precio.ToString();
            EntryIdMarca.Text = _producto.IdMarca.ToString();
            EntryIdCategoria.Text = _producto.IdCategoria.ToString();

        }
    }
    private async void OnClickGuardarNuevoProducto(object sender, EventArgs e)
    {

        if (_producto != null)
        {

            _producto.Nombre = EntryNombre.Text;
            _producto.Descripcion = EntryDescripcion.Text;
            _producto.Cantidad = Int32.Parse(Entrycantidad.Text);
            _producto.ImagenProductoURL = EntryImagenProductoURL.Text;
            _producto.Precio = double.Parse(EntryPrecio.Text);
            _producto.IdMarca = Int32.Parse(EntryIdMarca.Text);
            _producto.IdCategoria = Int32.Parse(EntryIdCategoria.Text);
            await _APIService.PutProducto(_producto.IdProducto, _producto);

            /*            Producto productoNuevo = new Producto
                        {

                            IdProducto = _producto.IdProducto,
                            Nombre = EntryNombre.Text,
                            Descripcion = EntryDescripcion.Text,
                            Cantidad = Int32.Parse(Entrycantidad.Text),
                            ImagenProductoURL = EntryImagenProductoURL.Text,
                            Precio=double.Parse(EntryPrecio.Text),
                            IdMarca=Int32.Parse(EntryIdMarca.Text),
                            IdCategoria=Int32.Parse(EntryIdCategoria.Text),

                        };*/


        }
        else
        {
            int id = Utils.Utils.ProductosList.Count + 1;

            Producto producto = new Producto
            {
                IdProducto = 0,
                Nombre = EntryNombre.Text,
                Descripcion = EntryDescripcion.Text,
                Cantidad = Int32.Parse(Entrycantidad.Text),
                ImagenProductoURL = EntryImagenProductoURL.Text,
                Precio = double.Parse(EntryPrecio.Text),
                IdMarca = Int32.Parse(EntryIdMarca.Text),
                IdCategoria = Int32.Parse(EntryIdCategoria.Text),
            };
            //Utils.Utils.ProductosList.Add(producto);
            await _APIService.PostProducto(producto);
        }
        await Navigation.PopAsync();
    }
}