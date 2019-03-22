using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrudWebForm.Models;

namespace CrudWebForm
{
    public partial class Deletar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == string.Empty)
            {
                lblmsg.Text = "Código inválido";
                return;
            }

            try
            {
                ContatoDAL.deletarContato(Int32.Parse(txtCodigo.Text));
                lblmsg.Text = "Contato excluído com sucesso!";
            }
            catch (Exception ex)
            {
                lblmsg.Text = "Error -> " + ex.Message;
            }
        }
    }
}