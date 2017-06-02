using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail_Yinet_Robert.Entidades
{
    class CotizacionesDetalle
    {
        [Key]
        public int Id { get; set; }
        public int CotizacionId { get; set; }
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}
