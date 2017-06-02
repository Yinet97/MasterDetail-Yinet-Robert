using MasterDetail_Yinet_Robert.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterDetail_Yinet_Robert.DAL;

namespace MasterDetail_Yinet_Robert.BLL
{
    class CotizacionesBLL
    {
        public static Cotizaciones Guardar(Cotizaciones cotizacion)
        {
            Cotizaciones creado = null;

            using (var repositorio = new Repositorio<Cotizaciones>())
            {
                //todo: validar que el nombre de producto no exista

                creado = repositorio.Guardar(cotizacion);
            }

            return creado;
        }

        public static bool Mofidicar(Cotizaciones cotizacion)
        {
            bool eliminado = false;
            using (var repositorio = new Repositorio<Cotizaciones>())
            {
                eliminado = repositorio.Modificar(cotizacion);
            }

            return eliminado;

        }

        public static bool Eliminar(Cotizaciones cotizacion)
        {
            bool eliminado = false;

            using (var repositorio = new Repositorio<Cotizaciones>())
            {
                eliminado = repositorio.Eliminar(cotizacion);
            }

            return eliminado;
        }

        public static Cotizaciones Buscar(Expression<Func<Cotizaciones, bool>> tipo)
        {
            Cotizaciones Result = null;

            using (var repositorio = new Repositorio<Cotizaciones>())
            {
                Result = repositorio.Buscar(tipo);

                if (Result != null)
                    Result.Detalle.Count();//para oblibar el lazyloading a cargar los datos
            }

            return Result;
        }
    }
}
