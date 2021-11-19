using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using StudyFi.Model;
using StudyFi.entity;

namespace StudyFi.Tests
{
    /// <summary>
    /// Descripción resumida de UnitTest1
    /// </summary>
    [TestClass]
    public class MateriaModelTest
    {
        public MateriaModelTest()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la serie de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        public void findAll()
        {
            List<MateriaEntity> materias = MateriaModel.findAll();
            Assert.AreEqual(materias.Count, 0);
        }

        [TestMethod]
        public void findById()
        {
            MateriaEntity materia = MateriaModel.findById(0);
            Assert.AreEqual(materia, null);
        }

        [TestMethod]
        public void delete()
        {
            MateriaEntity materia = MateriaModel.findById(0);
            bool deleted = MateriaModel.delete(materia);
            Assert.AreEqual(deleted, true);
        }

        [TestMethod]
        public void update()
        {
            MateriaEntity materia = new MateriaEntity();
            materia.Nombre = "Ingles";
            materia.Descripcion = "descripcion";
            materia.IdPrograma = 1;
            materia.PhotoUri = "https://...";
            materia.Id = 1;
            bool updated = MateriaModel.update(materia);
            Assert.AreEqual(updated, true);
        }

        [TestMethod]
        public void save()
        {
            MateriaEntity materia = new MateriaEntity();
            materia.Nombre = "Ingles";
            materia.Descripcion = "descripcion";
            materia.IdPrograma = 1;
            materia.PhotoUri = "https://...";

            bool saved = MateriaModel.save(materia);
            Assert.AreEqual(saved, true);
        }
    }
}
