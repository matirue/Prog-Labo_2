using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public class Persona : Corredor
    {
        public delegate void CorrenCallback(int avance, Corredor corredor);
        static string ruta = "carrera.txt";

        string _nombre;

        public Persona(string nombre, short velocidadMax, Carril carril)
            : base(velocidadMax, carril)
        {
            this._nombre = nombre;
        }

        public string Nombre
        {
            get { return this._nombre; }
        }


        public override void Correr()
        {
            while (true)
            {
                int velocidad = Corredor._avance.Next(0, this.VelocidadMaxima);
                System.Threading.Thread.Sleep(300);
                //this.Guardar(ruta);
                Corriendo.Invoke(velocidad, this);
            }
        }

        public override void Guardar(string path)
        {
            try
            {
                StreamWriter nuevo_archivo = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//" + path);
                nuevo_archivo.WriteLine(this.ToString());
                nuevo_archivo.Close();
            }
            catch (Exception e)
            {
                throw new NoSeGuardoException(e);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} en carril {1} a una velocidad máxima de {2}",
                this._nombre, this._carrilElegido, this.VelocidadMaxima);
            return sb.ToString();
        }

        public event CorrenCallback Corriendo;
    }
}
