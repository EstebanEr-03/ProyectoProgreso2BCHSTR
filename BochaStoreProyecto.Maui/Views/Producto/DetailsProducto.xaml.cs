namespace BochaStoreProyecto.Maui.Views.Producto;
using CommunityToolkit.Maui.Core;
using BochaStoreProyecto.Maui.Services;
using Producto = BochaStoreProyecto.Maui.Models.Producto;
public partial class DetailsProducto : ContentPage
{
    private Producto _producto;
    private APIService _APIService;

    public DetailsProducto(APIService apiservice)
    {
        InitializeComponent();
        _APIService = apiservice;

    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        _producto = BindingContext as Producto;
        Nombre.Text = _producto.Nombre;
        Descripcion.Text = _producto.Descripcion;
        Cantidad.Text = _producto.Cantidad.ToString();
        ImagenProductoURL.Text = _producto.ImagenProductoURL;
        Precio.Text = _producto.Precio.ToString();
        IdMarca.Text = _producto.IdMarca.ToString();
        IdCategoria.Text = _producto.IdCategoria.ToString();
    }
    private async void Borrar_Clicked(object sender, EventArgs e)
    {
        //Utils.Utils.ProductosList.Remove(_producto);
        await _APIService.DeleteProducto(_producto.IdProducto);
        await Navigation.PopAsync();
        /*
        // Sender contiene el objeto que dispar� el evento, en este caso un bot�n
        var button = sender as ImageButton;
        // Se accede al BindingContext que enlaza datos a los controles, en este caso el control es el bot�n
        var productoParaEliminar = button?.BindingContext as Producto;

        if (productoParaEliminar != null)
        {

            // Confirmar con el usuario si realmente desea eliminar el producto
            var confirm = await this.DisplayAlert("Confirmarci�n", "�Est�s seguro de que quieres eliminar este producto?", "S�", "No");

            if (confirm)
            {

                // Eliminar el producto
                await Utils.Utils._APIService.DeleteProducto(productoParaEliminar.IdProducto);
                // Refresco la pantalla
                OnAppearing();

            }

        }*/
        //await App._APIService.DeleteProducto(_producto.IdProducto);
        //await Utils.Utils._APIService.DeleteProducto(productoParaEliminar.IdProducto);
        //await Navigation.PopAsync();
    }

    private async void Editar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NuevoProducto(_APIService)
        {
            BindingContext = _producto,
        });
    }
}