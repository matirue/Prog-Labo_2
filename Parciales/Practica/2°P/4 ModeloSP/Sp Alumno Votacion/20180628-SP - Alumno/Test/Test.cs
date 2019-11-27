using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;
using System.Collections.Generic;
using static Entidades.Votacion;

namespace Test
{
    [TestClass]
    public class Test
    {
        //Realizar un test que compruebe que si hay un error al querer serializar un objeto del tipo Votacion lance 
        //la excepción ErrorArchivoException.
        [TestMethod]
        [ExpectedException(typeof(ErrorArchivoException))]
        public void Guardar_Archivo_XML_En_Directorio_Inexistente()
        {
            //Arrange
            Votacion votacion = new Votacion("Ley123", new Dictionary<string, Votacion.EVoto>());
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\CarpetaFalsa\a.xml";

            //Act
            votacion.SerializarXml(path);
        }

        //Realizar un test que compruebe que el evento de la clase Votacion tantas veces como Senadores haya.O sea, 
        //si hay 2 senadores el evento será invocado 2 veces.
        [TestMethod]
        public void Comprobar_Que_El_Evento_Se_Lanza_Por_Cada_Senador()
        {
            //ARRANGE
            Dictionary<string, Votacion.EVoto> diccionario;
            Votacion votacion;
            int contador = 0;

            //INITIALIZE
            diccionario = new Dictionary<string, Votacion.EVoto>();
            diccionario.Add("s1", Votacion.EVoto.Afirmativo);
            diccionario.Add("s2", Votacion.EVoto.Negativo);
            diccionario.Add("s3", Votacion.EVoto.Abstencion);
            votacion = new Votacion("Ley123", diccionario);

            //ACT
            votacion.EventoVotoEfectuado += MiContador;
            votacion.Simular();

            void MiContador(string senador, EVoto voto)
            {
                contador++;
            }

            //ASSERT
            Assert.AreEqual(3, contador);
        }


    }
}
