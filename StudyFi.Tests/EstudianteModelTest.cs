using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using StudyFi.Model;
using StudyFi.entity;

namespace StudyFi.Tests
{
    /// <summary>
    /// Descripción resumida de Estudiante
    /// </summary>
    [TestClass]
    public class EstudianteModelTest
    {
        public EstudianteModelTest()
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
        public void FindAllEstudiantes()
        {
            List<EstudianteEntity> estudiantes = EstudianteModel.findAll();
            Assert.AreEqual(estudiantes.Count, 1);
        }

        [TestMethod]
        public void findById()
        {
            int idEstudent = 1;
            EstudianteEntity estudiante = EstudianteModel.findById(idEstudent);
            Assert.AreEqual(estudiante.Nombre, "Wilmer");
        }

        [TestMethod]
        public void findByCorreoAndPassword()
        {
            string correo = "sd";
            string password = "wilmer";
            EstudianteEntity estudiante = EstudianteModel.findByCorreoAndPassword(correo, password);
            Assert.AreEqual(estudiante.Nombre, "Wilmer");
        }

        [TestMethod]
        public void notFindCorreoAndPassword()
        {
            string correo = "dwsd";
            string password = "qwdqw";
            EstudianteEntity estudiante = EstudianteModel.findByCorreoAndPassword(correo, password);
            Assert.AreEqual(estudiante,null);
        }

        [TestMethod]
        public void delete()
        {
            EstudianteEntity estudiante = new EstudianteEntity();
            estudiante.Id = 2;
            bool isDeleted = EstudianteModel.delete(estudiante);
            Assert.AreEqual(isDeleted, true);
        }

        [TestMethod]
        public void update()
        {
            EstudianteEntity estudiante = EstudianteModel.findById(1);
            estudiante.Apellido = "sabandija";
            bool isUpdated = EstudianteModel.update(estudiante);
            Assert.AreEqual(isUpdated, true);
        }

        [TestMethod]
        public void save()
        {
            EstudianteEntity estudiante = new EstudianteEntity();
            estudiante.Nombre = "Wilmer";
            estudiante.Apellido = "Delgado";
            estudiante.Direccion = "Wilmer delgado";
            estudiante.FechaNacimiento = new DateTime();
            estudiante.Password = "123";
            estudiante.Correo = "dwq";
            bool success = EstudianteModel.save(estudiante);
            Assert.AreEqual(success, true);
        }
    }
}
