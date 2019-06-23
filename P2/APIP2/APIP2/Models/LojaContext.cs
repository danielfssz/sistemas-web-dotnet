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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Consultor>().ToTable("Consultor");
            modelBuilder.Entity<Telefone>().ToTable("Telefone");
        }
    }
}
