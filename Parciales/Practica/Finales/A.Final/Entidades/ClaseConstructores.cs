using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Entidades
{
    //crear una clase (ClaseConstructores) que al instanciarse:
    //    *pase por un constructor estático
    //    *pase por un constructor que reciba 2 parámetros (privado)
    //    *pase por un constructor publico (default)
    //    *pase por una propiedad de sólo escritura
    //    *pase por una propiedad de sólo lectura
    //    *pase por un método de instancia
    //    *pase por un método de clase
    //NOTA: por cada lugar que pase, mostrar con un MessageBox.Show dicho lugar
    //NOTA: agregar la referencia a System.Windows.Form; para poder acceder a la clase MessageBox.
    //NOTA: NO MAS DE 2 LINEAS DE CODIGO POR METODO/PROPIEDAD/CONSTRUCTOR
    public class ClaseConstructores
    {
        int datoUno;
         int datoDos;

        public int DatoUno
        {
            get
            {
                MessageBox.Show("En propiedad lectura");
                return this.datoUno;
            }
        }

        public int DatoDos
        {
            set
            {
                MessageBox.Show("En propiedad escritura");
                this.datoDos = value;
            }

        }

        static ClaseConstructores()
        {
            MessageBox.Show("En constructor estatico");
        }

        public ClaseConstructores() : this(1, 2)
        {
            MessageBox.Show("En constructor por defecto");
            this.DatoDos = 5;
            this.datoDos = this.DatoUno * 5;
            InicioInstancia();
        }

        private ClaseConstructores(int d1, int d2)
        {
            MessageBox.Show("En constructor parametrizado");
            this.datoUno = d1;
            this.datoDos = d2;
        }

        static void Inicio()
        {
            MessageBox.Show("En metodo de clase");
        }

        private void InicioInstancia()
        {
            MessageBox.Show("En metodo de instancia");
            Inicio();
        }
    }
}
