using CrudWebForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudWebForm
{
    public partial class AtualizarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetDetalhes_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == string.Empty)
            {
                lblMsg.Text = "Código inválido";
                return;
            }

            Cliente c = ClienteDAL.GetCliente(Int32.Parse(txtCodigo.Text));
            if (c != null)
            {
                txtId.Text = c.Id.ToString();
                txtNome.Text = c.Nome;
                txtCodigo.Text = c.Codigo;
                txtData.Text = c.DataCriacao.ToString();
                btnAtualiza.Enabled = true;
            }
            else
            {
                lblMsg.Text = "Contato não encontrado";
                btnAtualiza.Enabled = false;
            }

        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            Cliente _cliente = new Cliente();
            _cliente.Id = int.Parse(txtId.Text);
            _cliente.Nome = txtNome.Text;            
            _cliente.Codigo = txtCodigo.Text;

            try
            {
                ClienteDAL.atualizarCliente(_cliente);
                lblMsg.Text = "Contato atualizado com sucesso!";
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error -> " + ex.Message;
            }
        }
    }
}