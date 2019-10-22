using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad
{
    public class Aula
    {
        private List<Alumno> _alumnos;
        private short _espacio;

        /// <summary>
        /// Constructor privado, único lugar donde se instanciará la lista de Alumnos
        /// </summary>
        private Aula()
        {
            this._alumnos = new List<Alumno>();
        }

        /// <summary>
        /// Constructor público
        /// </summary>
        /// <param name="espacio">Espacio total del aula</param>
        public Aula(short espacio)
            : this()
        {
            this.Espacio = espacio;
        }

        /// <summary>
        /// Espacio aun disponible en el aula
        /// </summary>
        public short EspacioDisponible
        {
            get
            {
                return (short)(this._espacio - this._alumnos.Count);
            }
        }

        /// <summary>
        /// Valida y asigna el espacio total del Aula
        /// Mínimo: 1
        /// Máximo: 50
        /// </summary>
        private short Espacio
        {
            set
            {
                if (value > 0 && value < 50)
                    this._espacio = value;
                else if (value > 50)
                    this._espacio = 50;
                else
                    this._espacio = 1;
            }
        }

        public List<Alumno> Alumnos
        {
            get
            {
                return this._alumnos;
            }
        }

        /// <summary>
        /// Si hay espacio, agregará alumnos al Aula
        /// </summary>
        /// <param name="aula">Aula donde se agregará el alumno.</param>
        /// <param name="alumno">Alumno que se desea agregar.</param>
        /// <returns>El Aula con el Alumno cargado.</returns>
        public static Aula operator +(Aula aula, Alumno alumno)
        {
            // Verifico el espacio.
            if (aula._espacio > aula._alumnos.Count)
            {
                aula._alumnos.Add(alumno);
                return aula;
            }
            else
            {
                string mensaje = String.Format("El aula tiene sus {0} bancos ocupados", aula._espacio);
                throw new AulaLlenaException(mensaje);
            }
        }
    }
}
