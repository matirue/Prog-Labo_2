using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComiqueriaLogic.Comun;

namespace Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void Verificar_Precio_Bien_Formateado()
        {
            //Arrange
            double numero;
            string numeroFormateado;

            //Act
            numero = 22.3;
            numeroFormateado = numero.FormatearPrecio();

            //Assert
            Assert.AreEqual("$22,30", numeroFormateado);
        }
    }
}
