using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppPersonalEjemplo.Models
{
    public class PersonalEnt
    {
        public int PersonalId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
    }
}