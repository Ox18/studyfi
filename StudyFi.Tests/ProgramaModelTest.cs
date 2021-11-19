using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using StudyFi.Model;
using StudyFi.entity;
using System.Collections.Generic;

namespace StudyFi.Tests
{
    [TestClass]
    public class ProgramaModelTest
    {
        [TestMethod]
        public void findById()
        {
            int id = 1;
            ProgramaEntity programa = ProgramaModel.findById(id);
            Assert.AreEqual(programa, null);
        }

        [TestMethod]
        public void findAll()
        {
            List<ProgramaEntity> programas = ProgramaModel.findAll();
            Assert.AreEqual(programas.Count, 0);
        }

        [TestMethod]
        public void delete()
        {
            ProgramaEntity programa = new ProgramaEntity();
            programa.Id = 1;
            bool deleted = ProgramaModel.delete(programa);
            Assert.AreEqual(deleted, true);
        }

        [TestMethod]
        public void update()
        {
            ProgramaEntity programa = new ProgramaEntity();
            programa.Id = 1;
            bool updated = ProgramaModel.update(programa);
            Assert.AreEqual(updated, true);
        }

        [TestMethod]
        public void save()
        {
            ProgramaEntity programa = new ProgramaEntity();
            programa.Id = 1;
            programa.Nombre = "";
            programa.PhotoUri = "";
            programa.FechaInicio = new DateTime();
            programa.FechaFin = new DateTime();
            bool created = ProgramaModel.save(programa);
            Assert.AreEqual(created, true);
        }
    }
}
