using BochaStoreProyecto.Maui.Models;
using BochaStoreProyecto.Maui.Services;
using BochaStoreProyecto.Maui.Views.Producto;
using CommunityToolkit.Maui.Alerts;

namespace BochaStoreProyecto.Maui.Views;

public partial class LoginPage : ContentPage
{
    private readonly APIService _APIService;
    public LoginPage(APIService apiservice)
    {
        InitializeComponent();
        _APIService = apiservice;
    }

    private async void Login_Clicked(object sender, EventArgs e)
    {
        string username = Username.Text;
        string password = Password.Text;
        Usuario usuario = new Usuario
        {
            IdUser = 0,
            Username = username,
            Password = password
        };

        Usuario usuario2 = _APIService.PostUsuario(usuario);
        if (usuario2 != null)
        {
            Preferences.Set("username", username);
            Preferences.Set("idusuario", usuario2.IdUser);
            await Navigation.PushAsync(new ProductoPage(_APIService));
        }
        else
        {
            var toast = Toast.Make("Nombre de usuario o password incorrecto", CommunityToolkit.Maui.Core.ToastDuration.Short, 14);
            await toast.Show();
        }
    }
}