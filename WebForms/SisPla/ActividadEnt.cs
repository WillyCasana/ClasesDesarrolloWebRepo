using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisPla
{
    public class ActividadEnt
    {
        public int ActId { get; set; }
        public string ActComentario { get; set; }
        public decimal ActTiempo { get; set; }
        public int CatId { get; set; }
        public DateTime ActFecha { get; set; }
        public DateTime ActFecReg { get; set; }
        public int UsuId { get; set; }
        public DateTime? ActFecMod { get; set; }
        public bool? ActActivo { get; set; }

        public string CatDescripcion { get; set; }
    }
}
