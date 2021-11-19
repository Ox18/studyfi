using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudyFi.Model;
using StudyFi.entity;

namespace StudyFi.Tests
{
    /// <summary>
    /// Descripción resumida de ProfesorModelTest
    /// </summary>
    [TestClass]
    public class ProfesorModelTest
    {
        public ProfesorModelTest()
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

        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion
        [TestMethod]
        public void findAll()
        {
            List<ProfesorEntity> profesores = ProfesorModel.findAll();
            Assert.AreEqual(profesores.Count, 0);
        }

        [TestMethod]
        public void findById()
        {
            int id = 1;
            ProfesorEntity profesor = ProfesorModel.findById(id);
            Assert.AreEqual(profesor, null);
        }

        [TestMethod]
        public void findByCorreoAndPassword()
        {
            string correo = "sd";
            string password = "wilmer";
            ProfesorEntity profesor = ProfesorModel.findByCorreoAndPassword(correo, password);
            Assert.AreEqual(profesor.Nombre, "Wilmer");
        }

        [TestMethod]
        public void notFindCorreoAndPassword()
        {
            string correo = "dwsd";
            string password = "qwdqw";
            ProfesorEntity profesor = ProfesorModel.findByCorreoAndPassword(correo, password);
            Assert.AreEqual(profesor, null);
        }

        [TestMethod]
        public void delete()
        {
            ProfesorEntity profesor = new ProfesorEntity();
            profesor.Id = 2;
            bool isDeleted = ProfesorModel.delete(profesor);
            Assert.AreEqual(isDeleted, true);
        }

        [TestMethod]
        public void update()
        {
            ProfesorEntity profesor = ProfesorModel.findById(1);
            profesor.Apellido = "sabandija";
            bool isUpdated = ProfesorModel.update(profesor);
            Assert.AreEqual(isUpdated, true);
        }

        [TestMethod]
        public void save()
        {
            ProfesorEntity profesor = new ProfesorEntity();
            profesor.Nombre = "Wilmer";
            profesor.Apellido = "Delgado";
            profesor.Direccion = "Wilmer delgado";
            profesor.FechaNacimiento = new DateTime();
            profesor.Password = "123";
            profesor.Correo = "dwq";
            bool success = ProfesorModel.save(profesor);
            Assert.AreEqual(success, true);
        }
    }
}
