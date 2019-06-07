using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace crud_mvc_entityF.Models
{
    public class LojaContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Consultor> Consultores { get; set; }
        public DbSet<Telefone> Telefone { get; set; }

        public LojaContext():base("Conexao"){
            Database.Log = instrucao => System.Diagnostics.Debug.WriteLine(instrucao);
        }

    }
}