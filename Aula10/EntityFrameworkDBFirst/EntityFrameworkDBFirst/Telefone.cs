namespace EntityFrameworkDBFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Telefone
    {
        public int Id { get; set; }

        public int DDD { get; set; }

        public string Numero { get; set; }

        public int Tipo { get; set; }

        public int? Cliente_Id { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
