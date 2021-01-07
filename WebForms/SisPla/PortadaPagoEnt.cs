using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisPla
{
    public class PortadaPagoEnt
    {
        public int PpId { get; set; }

        //Permite el ingreso de caracteres tipo numero hasta 20 digitos
        [RegularExpression(@"[0-9]{1,20}", ErrorMessage ="Solo se permiten ingresar numeros")]
        public string NumTarjeta { get; set; }

        // Primer digito va de 0 a 1, el segundo 0 a 9
        [RegularExpression(@"[0-1][0-9]/[1-9][1-9]",ErrorMessage ="Se debe ingresar el formato MM/AA")]
        public string MesAnio { get; set; }

        //Cvv hasta 3 digitos
        [Range(1,999,ErrorMessage ="Se deben ingresar valores desde el 1 al 999")]
        public int Cvv { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        [EmailAddress(ErrorMessage ="Formato incorrecto para correo")]
        public string Correo { get; set; }
    }
}
