using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisPla
{
    public class PortadaCompraEnt
    {
        public int PcId { get; set; }

        public int? PortId { get; set; }

        public DateTime? PcFecha { get; set; }

        public decimal? PcPrecio { get; set; }

        public string PcMoneda { get; set; }

        public int? PcCantidad { get; set; }

        public bool? Activo { get; set; }
        //Adicionales
        public string Descripcion { get; set; }
        public double Total { get; set; }
    }
}
