using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudWebForm.Models
{
    public class Contato
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
    }
}