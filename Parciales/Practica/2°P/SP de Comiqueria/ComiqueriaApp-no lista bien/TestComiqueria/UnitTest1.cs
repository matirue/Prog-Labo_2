using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ComiqueriaLogic.Entidades;
using ComiqueriaLogic;
using System.Collections.Generic;


namespace TestComiqueria
{
    [TestClass]
    public class TestComiqueria
    {
        [TestMethod]
        public void TestListarVentas()
        {
            //Arrange
            Comiqueria comiqueria = new Comiqueria();

            //Act

            //Arrange
            Assert.IsNotNull(comiqueria.ListarVentas());

        }

        [TestMethod]
        public void TestLeerBaseDeDatos()
        {
            //Arrange
            //ClassSQL sql = new ClassSQL();
            List<Producto> listaTest;

            //Act
            listaTest = ClassSQL.Leer();

            //Arrange
            Assert.IsNotNull(listaTest);

        }

        [TestMethod]
        public void TestGuardarBaseDeDatos()
        {
            //Arrange
            //ClassSQL sql = new ClassSQL();

            //Act

            //Arrange

            Assert.IsFalse(ClassSQL.Guardar("test", 1, 2f));

        }
    }
}
