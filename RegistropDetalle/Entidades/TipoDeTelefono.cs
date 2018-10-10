using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistropDetalle.Entidades
{
    class TipoDeTelefono
    {
        [Key]
         public int ID { get; set;}
         public string Tipo { get; set;}

        public TipoDeTelefono()
        {
            ID = 0;
            Tipo = string.Empty;
        }

    }
}
