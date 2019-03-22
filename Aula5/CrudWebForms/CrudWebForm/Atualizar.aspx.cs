using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrudWebForm.Models;

namespace CrudWebForm
{
    public partial class Atualizar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetDetalhes_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == string.Empty)
            {
                lblmsg.Text = "Código inválido";
                return;
            }

            Contato c = ContatoDAL.GetContato(Int32.Parse(txtCodigo.Text));
            if (c != null)
            {
                txtNome.Text = c.Nome;
                txtEmail.Text = c.Email;
                txtIdade.Text = c.Idade.ToString();
                btnAtualiza.Enabled = true;
            }
            else
            {
                lblmsg.Text = "Contato não encontrado";
                btnAtualiza.Enabled = false;
            }

        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            Contato _contato = new Contato();
            _contato.Nome = txtNome.Text;
            _contato.Email = txtEmail.Text;
            _contato.Idade = Int32.Parse(txtIdade.Text);
            _contato.Codigo = Int32.Parse(txtCodigo.Text);

            try
            {
                ContatoDAL.atualizarContato(_contato);
                lblmsg.Text = "Contato excluído com sucesso!";
            }
            catch (Exception ex)
            {
                lblmsg.Text = "Error -> " + ex.Message;
            }
        }
    }
}