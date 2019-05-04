using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityCrud.Models
{
    public class ConsultoriaContext : DbContext
    {
        public DbSet<Consultor> Consutores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Telefone> Telefones { get; set; }

        public ConsultoriaContext() : base("Conexao")
        {

        }
    }
}
