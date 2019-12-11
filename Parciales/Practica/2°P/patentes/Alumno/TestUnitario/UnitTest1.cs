using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;
using System.Linq;

using Archivos;
using Entidades;

namespace TestUnitario
{
    [TestClass]
    public class TestUnitarioArchivos
    {
        Queue<Patente> cola;
        Patente pat1;
        Patente pat2;

        public TestUnitarioArchivos()
        {
            this.cola = new Queue<Patente>();

            pat1 = "GAL015".ValidarPatentr();
            pat2 = "RW017AV".ValidarPatentr();
            this.cola.Enqueue(pat1);
            this.cola.Enqueue(pat2);
        }

        [TestMethod]
        public void TestSQL()
        {
            try
            {
                Sql sql = new Sql();
                sql.Guardar("Patentes", this.cola);
                sql.Leer("Patentes", out this.cola);

                short cont = 0;
                foreach (Patente p in this.cola)
                {
                    if (p.CodigoPatente == pat1.CodigoPatente || p.CodigoPatente == pat2.CodigoPatente)
                        cont++;
                }
                if (cont < 2)
                    Assert.Fail("No se encontraron las dos patentes que se guardaron.");
            }
            catch (Exception e)
            {
                Assert.Fail("Excepción: " + e.Message);
            }
        }

        [TestMethod]
        public void TestXML()
        {
            try
            {
                List<Patente> lista = new List<Patente>();
                Xml<List<Patente>> xml = new Xml<List<Patente>>();
                foreach (Patente p in this.cola)
                {
                    lista.Add(p);
                }
                xml.Guardar("patentes.xml", lista);
                xml.Leer("patentes.xml", out lista);
                Queue<Patente> cola2 = new Queue<Patente>(lista);

                foreach (Patente p in this.cola)
                {
                    if (p.CodigoPatente != cola2.Dequeue().CodigoPatente)
                        Assert.Fail("Colas distintas en el archivo.");
                }
            }
            catch (Exception e)
            {
                Assert.Fail("Excepción: " + e.Message);
            }
        }

        [TestMethod]
        public void TestTXT()
        {
            try
            {
                Queue<Patente> cola2 = new Queue<Patente>();
                Texto txt = new Texto();
                txt.Guardar("patentes.txt", this.cola);
                txt.Leer("patentes.txt", out cola2);

                foreach (Patente p in this.cola)
                {
                    if (p.CodigoPatente != cola2.Dequeue().CodigoPatente)
                        Assert.Fail("Colas distintas en el archivo.");
                }
            }
            catch (Exception e)
            {
                Assert.Fail("Excepción: " + e.Message);
            }
        }
    }
}
