using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIP2.Models
{
    public class LojaContext : DbContext
    {

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Consultor> Consultores { get; set; }
        public DbSet<Telefone> Telefone { get; set; }

        public LojaContext(DbContextOptions<LojaContext> options)
              : base(options)
        {
        }
    }
}
