using MasterDetail_Yinet_Robert.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail_Yinet_Robert.DAL
{
    class CotizacionesDetailDb : DbContext
    {
        public CotizacionesDetailDb() : base("ConStr")
        {

        }

        public DbSet<Productos> Productos { get; set; }
        public DbSet<Cotizaciones> Cotizaciones { get; set; }
    }
}
