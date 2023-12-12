using BochaStoreProyecto.Maui.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace BochaStoreProyecto.Maui.Services
{
    public class APIService
    {
        public static string _baseUrl;
        public HttpClient _httpClient;
        public APIService()
        {

            _baseUrl = "http://10.0.2.2:5149";
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_baseUrl);
        }
        // P R O D U C T O
        public async Task<bool> DeleteProducto(int IdProducto)
        {
            var response = await _httpClient.DeleteAsync($"/api/Producto/{IdProducto}");
            if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                return true;
            }
            return false;
        }

        public async Task<Producto> GetProducto(int IdProducto)
        {
            var response = await _httpClient.GetAsync($"/api/Producto/{IdProducto}");
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                Producto producto = JsonConvert.DeserializeObject<Producto>(json_response);
                return producto;
            }
            return new Producto();
        }

        public async Task<List<Producto>> GetProductos()
        {
            var response = await _httpClient.GetAsync("/api/Producto");
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                List<Producto> productos = JsonConvert.DeserializeObject<List<Producto>>(json_response);
                return productos;
            }
            return new List<Producto>();

        }

        public async Task<Producto> PostProducto(Producto producto)
        {
            var content = new StringContent(JsonConvert.SerializeObject(producto), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("/api/Producto/", content);
            //Debug.WriteLine(content);
            //Debug.WriteLine(response);
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                Producto producto2 = JsonConvert.DeserializeObject<Producto>(json_response);
                return producto2;
            }
            return new Producto();
        }

        public async Task<Producto> PutProducto(int IdProducto, Producto producto)
        {
            var content = new StringContent(JsonConvert.SerializeObject(producto), Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"/api/Producto/{IdProducto}", content);
            Debug.WriteLine(content);
            Debug.WriteLine(response);
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                Producto producto2 = JsonConvert.DeserializeObject<Producto>(json_response);
                return producto2;
            }
            return new Producto();
        }

        public Usuario PostUsuario(Usuario usuario)
        {
            if (usuario != null)
            {
                if (usuario.username.Equals("Carlos") && usuario.password.Equals("1234"))
                {
                    return new Usuario
                    {
                        //SOLO REGRESA ID O TOKEN
                        idUsuario = 100,
                        username = usuario.username,
                        password = "",
                    };
                }

            }

            return null;
        }

        // P R O O V E D O R

        public async Task<bool> DeleteProovedor(int IdProovedor)
        {
            var response = await _httpClient.DeleteAsync($"/api/Proovedor/{IdProovedor}");
            if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                return true;
            }
            return false;
        }

        public async Task<Proovedor> GetProovedor(int IdProovedor)
        {
            var response = await _httpClient.GetAsync($"/api/Proovedor/{IdProovedor}");
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                Proovedor proovedor = JsonConvert.DeserializeObject<Proovedor>(json_response);
                return proovedor;
            }
            return new Proovedor();
        }

        public async Task<List<Proovedor>> GetProovedor()
        {
            var response = await _httpClient.GetAsync("/api/Proovedor");
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                List<Proovedor> proovedor = JsonConvert.DeserializeObject<List<Proovedor>>(json_response);
                return proovedor;
            }
            return new List<Proovedor>();

        }

        public async Task<Proovedor> PostProovedor(Proovedor proovedor)
        {
            var content = new StringContent(JsonConvert.SerializeObject(proovedor), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("/api/Proovedor/", content);
            //Debug.WriteLine(content);
            //Debug.WriteLine(response);
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                Proovedor proovedor2 = JsonConvert.DeserializeObject<Proovedor>(json_response);
                return proovedor2;
            }
            return new Proovedor();
        }

        public async Task<Proovedor> PutProovedor(int IdProovedor, Proovedor proovedor)
        {
            var content = new StringContent(JsonConvert.SerializeObject(proovedor), Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"/api/Proovedor/{IdProovedor}", content);
            Debug.WriteLine(content);
            Debug.WriteLine(response);
            if (response.IsSuccessStatusCode)
            {
                var json_response = await response.Content.ReadAsStringAsync();
                Proovedor proovedor2 = JsonConvert.DeserializeObject<Proovedor>(json_response);
                return proovedor2;
            }
            return new Proovedor();
        }
    }
}
