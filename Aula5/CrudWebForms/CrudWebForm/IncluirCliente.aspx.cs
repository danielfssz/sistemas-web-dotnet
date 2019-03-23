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
            //ContatoDAL ctDal = new ContatoDAL();
            //Contato _contato = new Contato();

            //_contato.Nome = txtNome.Text;
            //_contato.Email = txtEmail.Text;
            //_contato.Idade = Int32.Parse(txtIdade.Text);

            //try
            //{
            //    ctDal.incluirContato(_contato);
            //    lblMsg.Text = "Contato incluído com sucesso!";
            //    txtEmail.Text = "";
            //    txtIdade.Text = "";
            //    txtNome.Text = "";
            //}
            //catch (Exception ex)
            //{
            //    lblMsg.Text = "Error -> " + ex.Message;
            //}
        }
    }
}