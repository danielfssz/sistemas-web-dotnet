using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;



namespace TesteWebApi
{
    public partial class Form1 : Form
    {
        string URI = "";
        int g_codigoItem = 1;

        public Form1()
        {
            InitializeComponent();
        }




        private async void GetAllProdutos()
        {
            URI = txtURI.Text;
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                        dgvDados.DataSource = JsonConvert.DeserializeObject<TodoItem[]>(ProdutoJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível obter o item : " + response.StatusCode);
                    }
                }
            }
        }



        private async void GetProdutoById(int codItem)
        {
            using (var client = new HttpClient())
            {
                BindingSource bsDados = new BindingSource();
                URI = txtURI.Text + "/" + codItem.ToString();
                HttpResponseMessage response = await client.GetAsync(URI);
                if (response.IsSuccessStatusCode)
                {
                    var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                    bsDados.DataSource = JsonConvert.DeserializeObject<TodoItem>(ProdutoJsonString);
                    dgvDados.DataSource = bsDados;
                }
                else
                {
                    MessageBox.Show("Falha ao obter o item : " + response.StatusCode);
                }
            }
        }



        private async void AddProduto()
        {
            URI = txtURI.Text;
            TodoItem item = new TodoItem();
            item.Name = "Fazer almoco";
            item.IsComplete = false;
             using (var client = new HttpClient())
            {
                var serializedProduto = JsonConvert.SerializeObject(item);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI, content);
            }
            GetAllProdutos();
        }



        private async void UpdateProduto(int codItem)
        {
            URI = txtURI.Text;
            TodoItem item = new TodoItem();
            item.Id = codItem;
            item.Name = "Feito almoco";
            item.IsComplete = true;
 

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI + "/" + item.Id, item);
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Produto atualizado");
                }
                else
                {
                    MessageBox.Show("Falha ao atualizar o item : " + responseMessage.StatusCode);
                }
            }
            GetAllProdutos();
        }



        private async void DeleteProduto(int codItem)
        {
            URI = txtURI.Text;
            int ItemId = codItem;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI);
                HttpResponseMessage responseMessage = await
                client.DeleteAsync(String.Format("{0}/{1}", URI, ItemId));
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Produto excluído com sucesso");
                }
                else
                {
                    MessageBox.Show("Falha ao excluir o produto  : " + responseMessage.StatusCode);
                }
            }
            GetAllProdutos();
        }

        


        private void btnObterProdutos_Click(object sender, EventArgs e)
        {
            GetAllProdutos();
        }

        private void btnProdutosPorId_Click(object sender, EventArgs e)
        {

            g_codigoItem = Convert.ToInt32(txtCodigo.Text);            
                GetProdutoById(g_codigoItem);
            
         
        }

        private void btnIncluirProduto_Click(object sender, EventArgs e)
        {
            AddProduto();
        }

        private void btnAtualizaProduto_Click(object sender, EventArgs e)
        {

            g_codigoItem = Convert.ToInt32(txtCodigo.Text);
            UpdateProduto(g_codigoItem);
        }

        private void btnDeletarProduto_Click(object sender, EventArgs e)
        {
            g_codigoItem = Convert.ToInt32(txtCodigo.Text);
           DeleteProduto(g_codigoItem);
        }
    }
}
