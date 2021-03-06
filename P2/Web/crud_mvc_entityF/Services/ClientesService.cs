﻿using System;
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
        private static string url = "https://localhost:44352/api/Clientes/";

        public async Task<List<Cliente>> GetClientesAsync()
        {
            try
            {
                var response = await client.GetStringAsync(url);
                var clientes = JsonConvert.DeserializeObject<List<Cliente>>(response);
                return clientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Cliente> GetClienteAsync(int? id)
        {
            try
            {
                var response = await client.GetStringAsync(url + id);
                var cliente = JsonConvert.DeserializeObject<Cliente>(response);
                return cliente;
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
                var uri = new Uri(string.Format(url));
                var data = JsonConvert.SerializeObject(cliente);
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

        public async Task EditClienteAsync(Cliente cliente)
        {
            try
            {
                var uri = new Uri(string.Format(url + cliente.Id));
                var data = JsonConvert.SerializeObject(cliente);
                var content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = null;
                response = await client.PutAsync(uri, content);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Erro ao atualizar cliente");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task RemoveClienteAsync(int id)
        {
            try
            {
                var uri = new Uri(string.Format(url + id));
                HttpResponseMessage response = null;
                response = await client.DeleteAsync(uri);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Erro ao deletar cliente");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}