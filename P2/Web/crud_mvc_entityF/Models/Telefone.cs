﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace crud_mvc_entityF.Models
{
    public class Telefone
    {
        public int Id { get; set; }
        public int DDD { get; set; }
        public String Numero { get; set; }
        public TipoTelefone Tipo { get; set; }



    }
}