using CrudWebForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudWebForm
{
    public partial class IncluirCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIncluirCliente_Click(object sender, EventArgs e)
        {
            ClienteDAL ctDal = new ClienteDAL();
            Cliente _cliente = new Cliente();

            _cliente.Nome = txtNomeCliente.Text;
            _cliente.Codigo = txtCodigoCliente.Text;
            _cliente.DataCriacao = DateTime.Now;
            try
            {
                ctDal.incluirCliente(_cliente);
                lblMsg.Text = "Cliente incluído com sucesso!";
                txtNomeCliente.Text = "";
                txtCodigoCliente.Text = "";                
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error -> " + ex.Message;
            }
        }
    }
}