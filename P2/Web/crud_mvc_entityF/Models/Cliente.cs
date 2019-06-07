using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace crud_mvc_entityF.Models
{


 public class Cliente
        {
            public int Id { get; set; }

            [Required]
            [MaxLength(100)]
            public String Nome { get; set; }

            [Required]
            [MaxLength(100)]
            public String Email { get; set; }

            [Required]
            [ForeignKey("Consultor")]
            public int IdConsultor { get; set; }

            public virtual Consultor Consultor { get; set; }

            public virtual List<Telefone> Telefones { get; set; }



        
    }
}