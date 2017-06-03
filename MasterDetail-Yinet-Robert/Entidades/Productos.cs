using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail_Yinet_Robert.Entidades
{
    class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public virtual ICollection<CotizacionesDetalle> CotizacionesDetalle { get; set; }

        public Productos()
        {
            this.CotizacionesDetalle = new HashSet<CotizacionesDetalle>();
        }

        //Funcion para cambiar el formato a los datos
        public override string ToString()
        {
            return string.Format("ProductoId: {0}, Descripción: {1}", this.ProductoId, this.Descripcion);
        }
    }
}
