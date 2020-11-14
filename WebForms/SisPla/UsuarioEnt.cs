using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisPla
{
   public class UsuarioEnt
    {
      
            public int UsuId { get; set; }

            public string UsuDescripcion { get; set; }

            public string UsuEmail { get; set; }

            public string UsuClave { get; set; }

            public bool UsuActivo { get; set; }

            public int RolId { get; set; }

            public string RolDescripcion { get; set; }


    }
}
