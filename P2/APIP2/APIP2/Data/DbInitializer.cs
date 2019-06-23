using APIP2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIP2.Data
{
    public static class DbInitializer
    {
        public static void Initialize(LojaContext context)
        {
            context.Database.EnsureCreated();
            if (context.Clientes.Any())
            {
                return;   // DB has been seeded
            }

            //var consultores = new Consultor[]
            //{
            //    new Consultor{Nome="Ronaldo"}
            //};

            //foreach (Consultor c in consultores)
            //{
            //    context.Consultores.Add(c);
            //}

            //context.SaveChanges();

            var clientes = new Cliente[]
            {
            new Cliente{Nome= "Daniel", Email= "daniel@ifsp.com",
                        Consultor = new Consultor{Nome="Ronaldo"},
                        Telefones = new List<Telefone>
                        {
                            new Telefone{DDD=13, Numero="12345678", Tipo=TipoTelefone.Recado, IdCliente=1}
                        }
            }
            };

            foreach (Cliente c in clientes)
            {
                context.Clientes.Add(c);
            }
            context.SaveChanges();

            //var telefones = new Telefone[]
            //{
            //    new Telefone { DDD=13, Numero="12345678", Tipo=TipoTelefone.Residencial, IdCliente=1 }
            //};

            //foreach (Telefone t in telefones)
            //{
            //    context.Telefone.Add(t);
            //}

            //context.SaveChanges();
        }
    }
}

