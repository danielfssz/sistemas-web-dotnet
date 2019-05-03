using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityCrud.Models
{
    public class Telefone
    {
        public int Id { get; set; }
        public int DDD { get; set; }
        public string Numero { get; set; }
        public TipoTelefone tipoTelefone { get; set; }
    }
}