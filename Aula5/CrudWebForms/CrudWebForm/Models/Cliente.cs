using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudWebForm.Models
{
    public class Cliente
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }        
        public DateTime Idade { get; set; }
    }
}