using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Votacion
    {
        public enum EVoto { Afirmativo, Negativo, Abstencion, Esperando }

        private string nombreLey;
        private Dictionary<string, EVoto> senadores;

        private short contadorAfirmativo;
        private short contadorNegativo;
        private short contadorAbstencion;

        public string NombreLey
        {
            get
            {
                return nombreLey;
            }
            set
            {
                nombreLey = value;
            }
        }

        public short ContadorAfirmativo
        {
            get
            {
                return contadorAfirmativo;
            }
            set
            {
                contadorAfirmativo = value;
            }
        }

        public short ContadorNegativo
        {
            get
            {
                return contadorNegativo;
            }
            set
            {
                contadorNegativo = value;
            }
        }

        public short ContadorAbstencion
        {
            get
            {
                return contadorAbstencion;
            }
            set
            {
                contadorAbstencion = value;
            }
        }



        public delegate void Voto(string senador, EVoto voto);
        public event Voto EventoVotoEfectuado;

        public Votacion()
        {

        }

        public Votacion(string nombreLey, Dictionary<string, EVoto> senadores)
        {
            this.nombreLey = nombreLey;
            this.senadores = senadores;
        }

        //Dentro del método Simular invocar el evento creado anteriormente bajo el comentario // Invocar Evento.

        public void Simular()
        {
            // Reseteo contadores
            this.contadorAbstencion = 0;
            this.contadorAfirmativo = 0;
            this.contadorNegativo = 0;
            // Itero todos los Senadores
            for (int index = 0; index < this.senadores.Count; index++)
            {
                // Duermo el hilo
                System.Threading.Thread.Sleep(50);

                // Leo el senador actual
                KeyValuePair<string, EVoto> k = this.senadores.ElementAt(index);
                // Generador de número aleatorio
                Random r = new Random(k.Key.ToString().Length + DateTime.Now.Millisecond);
                // Modifico el voto de forma aleatoria
                this.senadores[k.Key] = (EVoto)r.Next(0, 3);

                // Invocar Evento
                this.EventoVotoEfectuado(k.Key, this.senadores[k.Key]);

                // Incrementar contadores
                switch(this.senadores[k.Key]) // aca tambien tenia k.Value
                {
                    case EVoto.Afirmativo:
                        this.contadorAfirmativo++;
                        break;
                    case EVoto.Negativo:
                        this.contadorNegativo++;
                        break;
                    case EVoto.Abstencion:
                        this.contadorAbstencion++;
                        break;
                }
            }
        }
        public void SerializarXml(string rutaArchivo)
        {
            new SerializarXml<Votacion>().Guardar(rutaArchivo, this);
        }

        public void GuardarEnDB(string tabla)
        {
            new Dao().Guardar(tabla, this);
        }
    }
}
