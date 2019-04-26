using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace P1Crud.Models
{
    public class AcessoDAL
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