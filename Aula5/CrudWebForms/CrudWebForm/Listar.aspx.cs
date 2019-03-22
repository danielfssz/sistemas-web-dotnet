using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrudWebForm.Models;

namespace CrudWebForm
{
    public partial class Listar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = ContatoDAL.GetContatos();
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Codigo"))
            {
                string idProduto = e.CommandArgument.ToString();
                if (!String.IsNullOrEmpty(idProduto))
                    this.Response.Redirect("DetalheProduto.aspx?IdProduto=" + idProduto);
            }
        }
    }
}