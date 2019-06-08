using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Consultor
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public String Nome { get; set; }
    }
}