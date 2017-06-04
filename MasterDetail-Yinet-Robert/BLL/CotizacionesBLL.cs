using MasterDetail_Yinet_Robert.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterDetail_Yinet_Robert.DAL;
using System.Linq.Expressions;

namespace MasterDetail_Yinet_Robert.BLL
{
    class CotizacionesBLL
    {
        public static Cotizaciones Guardar(Cotizaciones cotizacion)
        {
            Cotizaciones creado = null;

            using (var repositorio = new ApoyoRepositorio<Cotizaciones>())
            {
                creado = repositorio.Guardar(cotizacion);
            }

            return creado;
        }

        public static bool Mofidicar(Cotizaciones cotizacion)
        {
            bool eliminado = false;
            using (var repositorio = new ApoyoRepositorio<Cotizaciones>())
            {
                eliminado = repositorio.Modificar(cotizacion);
            }

            return eliminado;

        }

        public static bool Eliminar(Cotizaciones cotizacion)
        {
            bool eliminado = false;

            using (var repositorio = new ApoyoRepositorio<Cotizaciones>())
            {
                eliminado = repositorio.Eliminar(cotizacion);
            }

            return eliminado;
        }

        public static Cotizaciones Buscar(Expression<Func<Cotizaciones, bool>> tipo)
        {
            Cotizaciones Result = null;

            using (var repositorio = new ApoyoRepositorio<Cotizaciones>())
            {
                Result = repositorio.Buscar(tipo);

                if (Result != null)
                    Result.Detalle.Count();
            }

            return Result;
        }
    }
}
