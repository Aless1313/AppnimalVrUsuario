using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using ZXing;
using System.Net;

namespace Appnimalv2.Clases
{
    public class UserManager
    {
        const String URL = "http://appnimal.atwebpages.com/";

        private HttpClient getClient()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Connection", "close");

            return client;
        }

        //Metodo de Login
        public async Task<IEnumerable<user>> userlogin(string correo, string password)
        {
            HttpClient client = getClient();

            var result = await client.GetAsync(URL + "login.php?Correo=" + correo + "&Contrasena=" + password);

            if(result.IsSuccessStatusCode)
            {
                string content = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<user>>(content);
            }
            else
            {
                return Enumerable.Empty<user>();
            }
        }

        //Metodo de registrar
        public async void registrarusuario(string nombre, string apellido, string correo, string contraseña)
        {
            HttpClient client = getClient();
            var result = await client.GetAsync(URL + "registrar.php?Nombre="+ nombre + "&Apellido="+apellido+"&Correo="+correo+"&Contrasena="+contraseña);

        }

        public async Task<IEnumerable<user>> consulta(string correo)
        {
            HttpClient client = getClient();
            var result = await client.GetAsync(URL + "consulta.php?Correo=" + correo);

            if(result.IsSuccessStatusCode)
            {
                string content = await result.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<user>>(content);
            }
            return Enumerable.Empty<user>();
        }

        public async void Agendar(string iduser, string dia, string hora, string cantidad)
        {
            HttpClient client = getClient();
            var result = await client.GetAsync(URL + "agendar.php?iduser=" + iduser + "&dia=" + hora + "&hora=" + dia + "&cantidad=" + cantidad);
        }

    }
}
