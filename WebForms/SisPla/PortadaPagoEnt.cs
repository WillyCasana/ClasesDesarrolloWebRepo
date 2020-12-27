using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisPla
{
    public class PortadaPagoEnt
    {
        public int PpId { get; set; }
        public string NumTarjeta { get; set; }

        public string MesAnio { get; set; }

        public int Cvv { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string Correo { get; set; }
    }
}
