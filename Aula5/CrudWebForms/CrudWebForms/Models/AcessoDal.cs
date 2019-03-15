using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace CrudWebForms.Models
{
    public class AcessoDal
    {
        static public String ConnectionString
        {
            get
            {
                return WebConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
            }
        }
    }
}