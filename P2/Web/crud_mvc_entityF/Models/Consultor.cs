using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace crud_mvc_entityF.Models
{
     [Table("Consultores")]
        public class Consultor
        {
            public int Id { get; set; }
            [Required]
            [MaxLength(100)]
            public String Nome { get; set; }


        }
    }