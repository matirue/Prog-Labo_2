using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Entidades;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestImparPar()
        {
            Int32 entero = new Int32();
            entero = 2;
            Assert.IsTrue(entero.EsPar());
            entero = 3;
            Assert.IsTrue(entero.EsImpar());
        }

        //Hacer un Test Unitario para el ingreso de: 3, 5, 4;  5, 4, 4;  5, 1, 2; y  1, 1, 0.
        [TestMethod]
        public void ElDelMedio()
        {
            int elDelMedio = 0;
            Assert.IsTrue(Comparadora.GetElDelMedio(1, 4, 2, out elDelMedio));
        }
    }
}
