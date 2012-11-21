using HarryPotter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestHarryPotter
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para ProgramTestProgram y se pretende que
    ///contenga todas las pruebas unitarias ProgramTestProgram.
    ///</summary>
    [TestClass()]
    public class ProgramTestProgram
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de la prueba que proporciona
        ///la información y funcionalidad para la ejecución de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        // 
        //Puede utilizar los siguientes atributos adicionales mientras escribe sus pruebas:
        //
        //Use ClassInitialize para ejecutar código antes de ejecutar la primera prueba en la clase 
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup para ejecutar código después de haber ejecutado todas las pruebas en una clase
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize para ejecutar código antes de ejecutar cada prueba
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup para ejecutar código después de que se hayan ejecutado todas las pruebas
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        List<int> numLibros = new List<int> { 0, 0, 0, 0, 0, 0, 0 };
        double total = 0;

        /// <summary>
        ///Prueba carro vacio
        ///</summary>
        [TestMethod()]
        [DeploymentItem("HarryPotter.exe")]
        public void Carro_vacio()
        {
            //Preparacion

            //Actuacion
            double result = HarryPotter.Carro.PrecioTotal(numLibros);
            //Confirmacion
            Assert.AreEqual(total, result);
        }


        /// <summary>
        /// Compra de un libro
        ///</summary>
        [TestMethod()]
        [DeploymentItem("HarryPotter.exe")]
        public void Compra_Un_Libro()
        {
            //Preparacion
            total = 8;
            numLibros[0] = 1;
            //Actuacion
            double result = HarryPotter.Carro.PrecioTotal(numLibros);
            //Confirmacion
            Assert.AreEqual(total, result);
        }


        /// <summary>
        /// Compra de un libro
        ///</summary>
        [TestMethod()]
        [DeploymentItem("HarryPotter.exe")]
        public void Compra_N_Libros_Iguales()
        {
            //Preparacion
            total = 16;
            numLibros[0] = 2;
            //Actuacion
            double result = HarryPotter.Carro.PrecioTotal(numLibros);
            //Confirmacion
            Assert.AreEqual(total, result);
        }


        /// <summary>
        /// Compra de un libro
        ///</summary>
        [TestMethod()]
        [DeploymentItem("HarryPotter.exe")]
        public void Decuento_2_Libros_Diferentes()
        {
            //Preparacion
            double Descuento = 0.05;
            int numLibrosDiferentes = 2;
            //Actuacion
            double result = HarryPotter.Carro.DescuentoAplicado(numLibrosDiferentes);
            //Confirmacion
            Assert.AreEqual(Descuento, result);
        }

        /// <summary>
        /// Compra de un libro
        ///</summary>
        [TestMethod()]
        [DeploymentItem("HarryPotter.exe")]
        public void Decuento_3_Libros_Diferentes()
        {
            //Preparacion
            double Descuento = 0.10;
            int numLibrosDiferentes = 3;
            //Actuacion
            double result = HarryPotter.Carro.DescuentoAplicado(numLibrosDiferentes);
            //Confirmacion
            Assert.AreEqual(Descuento, result);
        }

        /// <summary>
        /// Compra de un libro
        ///</summary>
        [TestMethod()]
        [DeploymentItem("HarryPotter.exe")]
        public void Compra_2_Diferentes()
        {
            //Preparacion
            numLibros[0] = 1;
            numLibros[1] = 1;
            total = 8 * 2 * 0.95;
            //Actuacion
            double result = HarryPotter.Carro.PrecioTotal(numLibros);
            //Confirmacion
            Assert.AreEqual(total, result);
        }

        /// <summary>
        /// Compra de un libro
        ///</summary>
        [TestMethod()]
        [DeploymentItem("HarryPotter.exe")]
        public void Compra_3_Diferentes()
        {
            //Preparacion
            numLibros[0] = 1;
            numLibros[1] = 1;
            numLibros[2] = 1;
            total = 8 * 3 * 0.90;
            //Actuacion
            double result = HarryPotter.Carro.PrecioTotal(numLibros);
            //Confirmacion
            Assert.AreEqual(total, result);
        }


        /// <summary>
        /// Compra de un libro
        ///</summary>
        [TestMethod()]
        [DeploymentItem("HarryPotter.exe")]
        public void Compra_N_Diferentes()
        {
            //Preparacion
            numLibros[0] = 1;
            numLibros[1] = 2;
            numLibros[2] = 3;
            numLibros[3] = 4;
            numLibros[4] = 5;
            numLibros[5] = 6;
            numLibros[6] = 7;

            total = 168.4;
            //Actuacion
            double result = HarryPotter.Carro.PrecioTotal(numLibros);
            //Confirmacion
            Assert.AreEqual(total, result);
        }

    }
}
