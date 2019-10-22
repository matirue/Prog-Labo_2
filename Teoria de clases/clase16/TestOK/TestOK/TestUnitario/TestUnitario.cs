using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Facultad;

namespace TestUnitario
{
    [TestClass]
    public class TestUnitario
    {
        /// <summary>
        /// Corrobora que la lista está correctamente instanciada
        /// </summary>
        [TestMethod]
        public void ListaCorrecta()
        {
            Aula aula = new Aula(2);

            Assert.IsNotNull(aula.Alumnos);
        }

        /// <summary>
        /// Corrobora que Espacio se encuentre en los valores
        /// Mínimo: 1
        /// Máximo: 50
        /// </summary>
        [TestMethod]
        public void EspacioAulaIncorrecto()
        {
            // Corroboro que el espacio no pueda ser mayor a 50
            Aula aulaGrande = new Aula(51);
            if (aulaGrande.EspacioDisponible != 50)
                Assert.Fail("Espacio disponible mal validado: {0}.", aulaGrande.EspacioDisponible);

            // Corroboro que el espacio no pueda ser menor a 1
            Aula aulaChica = new Aula(0);
            Assert.AreNotEqual(aulaChica.EspacioDisponible, 0);
            //if (aulaChica.EspacioDisponible != 1)
            //    Assert.Fail("Espacio disponible mal validado: {0}.", aulaChica.EspacioDisponible);

            // Corroboro si el espacio es el mismo que cargo
            Aula aulaCorrecta = new Aula(20);
            Assert.AreEqual(aulaCorrecta.EspacioDisponible, 20);
        }

        /// <summary>
        /// Verifico que valide el espacio total del aula al agregar alumnos
        /// En caso de estar completa, el Aula lanzará la excepción AulaLlenaException
        /// </summary>
        [TestMethod]
        public void AgregaAlumnosAulaLlena()
        {
            Aula aula = new Aula(2);
            Alumno a1 = new Alumno("Martín Miguel de Güemes", "60-2451-9");
            Alumno a2 = new Alumno("Juana Azurduy", "32-9545-2");
            Alumno a3 = new Alumno("José Francisco de San Martín", "55-5495-9");

            // Agrego dos alumnos, colmando la capacidad del aula
            aula = aula + a1;
            aula += a2;

            try
            {
                // Capacidad llena
                aula += a3;
                Assert.Fail("Debería avisar que el aula está llena.");
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(AulaLlenaException));
            }
        }

        /// <summary>
        /// Verifico que al agregar un alumno,
        /// disminuya la cantidad de espacio disponible
        /// </summary>
        [TestMethod]
        public void AgregaAlumnoEspacioDisponible()
        {
            Aula aula = new Aula(2);
            Alumno a1 = new Alumno("Martín Miguel de Güemes", "60-2451-9");
            Alumno a2 = new Alumno("Juana Azurduy", "32-9545-2");
            Alumno a3 = new Alumno("José Francisco de San Martín", "55-5495-9");

            // Agrego dos alumnos, colmando la capacidad del aula
            aula = aula + a1;
            Assert.AreEqual(aula.EspacioDisponible, 1);
            aula += a2;
            Assert.AreEqual(aula.EspacioDisponible, 0);
        }
    }
}
