﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistropDetalle.Entidades
{
    public class PersonaDetalle
    {
        [Key]

        public int PersonaId { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public virtual List<TelefonosDetalle> Telefonos { get; set; }

        public PersonaDetalle()
        {
            PersonaId = 0;
            Nombre = string.Empty;
            Cedula = string.Empty;
            Direccion = string.Empty;
            FechaNacimiento = DateTime.Now;

            Telefonos = new List<TelefonosDetalle>();
        }
    }
}
