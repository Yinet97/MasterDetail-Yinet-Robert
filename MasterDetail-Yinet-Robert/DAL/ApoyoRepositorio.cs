using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MasterDetail_Yinet_Robert.DAL;

namespace MasterDetail_Yinet_Robert.DAL
{
    class ApoyoRepositorio<TEntity> : ClaseGenerica<TEntity> where TEntity : class
    {
        CotizacionesDetailDb Contex = null;

        public ApoyoRepositorio()
        {
            Contex = new CotizacionesDetailDb();
        }
        
        private DbSet<TEntity> EntitySet
        {
            get
            {
                return Contex.Set<TEntity>();
            }
        }

        public TEntity Guardar(TEntity laEntidad)
        {
            TEntity Result = null;

            try
            {
                EntitySet.Add(laEntidad);
                Contex.SaveChanges();
                Result = laEntidad;
            }
            catch (Exception)
            {
                throw;
            }

            return Result;
        }

        public bool Modificar(TEntity laEntidad)
        {
            bool Result = false;

            try
            {
                EntitySet.Attach(laEntidad);
                
                Contex.Entry<TEntity>(laEntidad).State = EntityState.Modified;

                Result = Contex.SaveChanges() > 0;
            }
            catch { }

            return Result;
        }

        public TEntity Buscar(Expression<Func<TEntity, bool>> criterioBusqueda)
        {
            TEntity Result = null;

            try
            {
                Result = EntitySet.FirstOrDefault(criterioBusqueda);
            }
            catch { }

            return Result;
        }

        public bool Eliminar(TEntity laEntidad)
        {
            bool Result = false;

            try
            {
                EntitySet.Attach(laEntidad);
                EntitySet.Remove(laEntidad);
                Result = Contex.SaveChanges() > 0;
            }
            catch { }

            return Result;
        }

        public List<TEntity> Lista(Expression<Func<TEntity, bool>> criterioBusqueda)
        {
            List<TEntity> Result = null;
            try
            {
                Result = EntitySet.Where(criterioBusqueda).ToList();
            }
            catch { }

            return Result;
        }

        public List<TEntity> ListaTodo()
        {
            using (var Conec = new CotizacionesDetailDb())
            {
                try
                {
                    return EntitySet.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return null;
        }

        public void Dispose()
        {
            if (Contex != null)
                Contex.Dispose();
        }
    }
}
