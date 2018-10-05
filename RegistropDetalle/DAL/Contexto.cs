using RegistropDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistropDetalle.DAL
{
   public class Contexto : DbContext
    {
        public  DbSet<PersonaDetalle> PersonaD { get; set; }

        public Contexto() : base("ConStr")
        {

        }

    }
}
