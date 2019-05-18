namespace EntityFrameworkDBFirst
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Aula : DbContext
    {
        public Aula()
            : base("name=Aula")
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Consultore> Consultores { get; set; }
        public virtual DbSet<Telefone> Telefones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Telefones)
                .WithOptional(e => e.Cliente)
                .HasForeignKey(e => e.Cliente_Id);

            modelBuilder.Entity<Consultore>()
                .HasMany(e => e.Clientes)
                .WithRequired(e => e.Consultore)
                .HasForeignKey(e => e.IdConsultor);
        }
    }
}
