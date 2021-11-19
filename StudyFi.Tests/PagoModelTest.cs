using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using StudyFi.Model;
using StudyFi.entity;
using System.Collections.Generic;

namespace StudyFi.Tests
{
    [TestClass]
    public class PagoModelTest
    {
        [TestMethod]
        public void findAll()
        {
            List<PagoEntity> pagos = PagoModel.findAll();
            Assert.AreEqual(pagos.Count, 0);
        }

        [TestMethod]
        public void findAllByIdEstudiante()
        {
            List<PagoEntity> pagos = PagoModel.findAllByIdEstudiante(1);
            Assert.AreEqual(pagos.Count, 0);
        }

        [TestMethod]
        public void findAllByIdPrograma()
        {
            List<PagoEntity> pagos = PagoModel.findAllByIdPrograma(1);
            Assert.AreEqual(pagos.Count, 0);
        }

        [TestMethod]
        public void findById()
        {
            PagoEntity pago = PagoModel.findById(1);
            Assert.AreEqual(pago, null);
        }

        [TestMethod]
        public void delete()
        {
            PagoEntity pago = PagoModel.findById(1);
            bool deleted = PagoModel.delete(pago);
            Assert.AreEqual(deleted, true);
        }

        [TestMethod]
        public void update()
        {
            PagoEntity pago = PagoModel.findById(1);
            pago.Costo = 2.3;
            bool updated = PagoModel.update(pago);
            Assert.AreEqual(updated, true);
        }

        [TestMethod]
        public void save()
        {
            PagoEntity pago = new PagoEntity();
            pago.Costo = 2.4;
            pago.IdPrograma = 1;
            pago.IdEstudiante = 2;
            bool saved = PagoModel.save(pago);
            Assert.AreEqual(saved, true);
        }
    }
}
