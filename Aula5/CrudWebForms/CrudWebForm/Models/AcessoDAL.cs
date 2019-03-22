using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration; // incluir o namespace

namespace CrudWebForm
{
    public class AcessoDB
    {
        static public String ConnectionString
        {
            get
            {    // pega a string de conexão do web.config
                return WebConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
               
            }
        }
    }
}