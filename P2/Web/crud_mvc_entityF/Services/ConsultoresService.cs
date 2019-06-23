using crud_mvc_entityF.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace crud_mvc_entityF.Services
{
    public class ConsultoresService
    {
        HttpClient client = new HttpClient();
        private static string url = "https://localhost:44352/api/Consultores/";

        public async Task<List<Consultor>> GetConsultoresAsync()
        {
            try
            {
                var response = await client.GetStringAsync(url);
                var consultores = JsonConvert.DeserializeObject<List<Consultor>>(response);
                return consultores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Consultor> GetConsultorAsync(int? id)
        {
            try
            {
                var response = await client.GetStringAsync(url + id);
                var consultor = JsonConvert.DeserializeObject<Consultor>(response);
                return consultor;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task AddConsultorAsync(Consultor consultor)
        {
            try
            {
                var uri = new Uri(string.Format(url));
                var data = JsonConvert.SerializeObject(consultor);
                var content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = null;
                response = await client.PostAsync(uri, content);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Erro ao adicionar cliente");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task EditConsultorAsync(Consultor consultor)
        {
            try
            {
                var uri = new Uri(string.Format(url + consultor.Id));
                var data = JsonConvert.SerializeObject(consultor);
                var content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = null;
                response = await client.PutAsync(uri, content);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Erro ao atualizar consultor");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task RemoveConsultorAsync(int id)
        {
            try
            {
                var uri = new Uri(string.Format(url + id));
                HttpResponseMessage response = null;
                response = await client.DeleteAsync(uri);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Erro ao deletar consultor");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}