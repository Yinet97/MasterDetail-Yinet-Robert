using Microsoft.VisualStudio.TestTools.UnitTesting;
using MasterDetail_Yinet_Robert.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail_Yinet_Robert.BLL.Tests
{
    [TestClass()]
    public class CotizacionesBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            var cot = new Entidades.Cotizaciones()
            {
                CotizacionId = 0,
                Fecha = DateTime.Now,
                Monto = 150
            };

            cot.AgregarDetalle(new Entidades.Productos()
            {
                ProductoId = 0,
                Descripcion = "Feo",
                Precio = 100
            },10
            );
            Assert.IsTrue(BLL.CotizacionesBLL.Guardar(cot).CotizacionId>0);
        }

        [TestMethod()]
        public void MofidicarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }
    }
}