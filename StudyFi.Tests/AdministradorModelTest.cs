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
    public class AdministradorModelTest
    {
        public AdministradorModelTest()
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
            List<AdministradorEntity> administradores = AdministradorModel.findAll();
            Assert.AreEqual(administradores.Count, 0);
        }

        [TestMethod]
        public void findById()
        {
            int id = 1;
            AdministradorEntity administrador = AdministradorModel.findById(id);
            Assert.AreEqual(administrador, null);
        }

        [TestMethod]
        public void findByCorreoAndPassword()
        {
            string correo = "sd";
            string password = "wilmer";
            AdministradorEntity administrador = AdministradorModel.findByCorreoAndPassword(correo, password);
            Assert.AreEqual(administrador.Nombre, "Wilmer");
        }

        [TestMethod]
        public void notFindCorreoAndPassword()
        {
            string correo = "dwsd";
            string password = "qwdqw";
            AdministradorEntity administrador = AdministradorModel.findByCorreoAndPassword(correo, password);
            Assert.AreEqual(administrador, null);
        }

        [TestMethod]
        public void delete()
        {
            AdministradorEntity administrador = new AdministradorEntity();
            administrador.Id = 2;
            bool isDeleted = AdministradorModel.delete(administrador);
            Assert.AreEqual(isDeleted, true);
        }

        [TestMethod]
        public void update()
        {
            AdministradorEntity administrador = AdministradorModel.findById(1);
            administrador.Apellido = "sabandija";
            bool isUpdated = AdministradorModel.update(administrador);
            Assert.AreEqual(isUpdated, true);
        }

        [TestMethod]
        public void save()
        {
            AdministradorEntity administrador = new AdministradorEntity();
            administrador.Nombre = "Wilmer";
            administrador.Apellido = "Delgado";
            administrador.Direccion = "Wilmer delgado";
            administrador.FechaNacimiento = new DateTime();
            administrador.Password = "123";
            administrador.Correo = "dwq";
            bool success = AdministradorModel.save(administrador);
            Assert.AreEqual(success, true);
        }
    }
}
