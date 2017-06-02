using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail_Yinet_Robert.Entidades
{
    class Cotizaciones
    {
        [Key]
        public int CotizacionId { get; set; }
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }
    }
}
