using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using crud_mvc_entityF.Models;
using Newtonsoft.Json;

namespace crud_mvc_entityF.Services
{
    public class ClientesService
    {
        HttpClient client = new HttpClient();

        public async Task<List<Cliente>> GetClientesAsync()
        {
            try
            {
                string url = "http://localhost:52848/api/Clientes";
                var response = await client.GetStringAsync(url);
                var clientes = JsonConvert.DeserializeObject<List<Cliente>>(response);
                return clientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task AddClienteAsync(Cliente cliente)
        {
            try
            {
                string url = "http://localhost:52848/api/Clientes";
                var uri = new Uri(string.Format(url, cliente.Id));
                var data = JsonConvert.SerializeObject(cliente);
                var content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = null;
                response = await client.PostAsync(uri, content);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Erro ao incluir produto");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}