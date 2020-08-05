using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
using System.IO;
using System.Threading;

namespace Final
{
    //DESARROLLAR DENTRO DEL NAMESPACE RAIZ ENTIDADES EN UN PROYECTO DE TIPO CLASS LIBRARY

    public partial class frmFinal : Form
    {
        public frmFinal()
        {
            InitializeComponent();
        }

        private void frmFinal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Final A ");
        }

        //Crear dos objetos de tipo Deposito, cada uno de estos objetos contiene un Array de la clase Producto.
        //Un constructor por default (inicializa en 3 productos) y una sobrecarga que reciba la cantidad de productos 
        //del depósito (REUTILIZAR CODIGO). 
        //La clase Producto tiene dos atributos: nombre y stock y un único constructor.
        //Se debe poder sumar los Array de los dos depósitos (con la sobrecarga de un operador en la clase Deposito) y guardar 
        //el valor que retorna en un Array de Productos, recordar que si un producto está en los dos Arrays, 
        //se debe sumar el stock y no agregar dos veces al mismo producto.
        //Mostrar el contenido del array resultante (nombre y stock)
        private void btnPunto1_Click(object sender, EventArgs e)
        {
            Producto p1 = new Producto("tomate", 10);
            Producto p2 = new Producto("azucar", 25);
            Producto p3 = new Producto("yerba", 30);

            Deposito d1 = new Deposito(4);
            Deposito d2 = new Deposito();

            
            d1.Productos[0] = p1;
            d1.Productos[1] = p2;
            d1.Productos[2] = p3;
            d1.Productos[3] = p3;

            d2.Productos[0] = p1;
            d2.Productos[1] = p1;
            d2.Productos[2] = p2;

            Producto[] auxProducto = d1 + d2;
            
            foreach (Producto aux in auxProducto)
                MessageBox.Show(aux.ToString());

        }

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
        private void btnPunto2_Click(object sender, EventArgs e)
        {
            ClaseConstructores o = new ClaseConstructores();
        }

        //Crear la clase DepositoHeredado, que derive de Desposito y que implemente: 
        //ISerializar(Xml(string):bool) de forma implicita y
        //IDeserializar(Xml(string, out Deposito):bool) de forma explícita
        private void btnPunto3_Click(object sender, EventArgs e)
        {
            Producto p1 = new Producto("tomate", 10);
            Producto p2 = new Producto("azucar", 25);
            Producto p3 = new Producto("yerba", 30);

            DepositoHeredado dh = new DepositoHeredado();
            DepositoHeredado aux = null;

            dh.Productos[0] = p1;
            dh.Productos[1] = p2;
            dh.Productos[2] = p3;

            if (dh.Xml("depositoHeredado.xml"))
            {
                MessageBox.Show("Serializado OK");
            }
            else
            {
                MessageBox.Show("NO Serializado");
            }

            if (((IDeserializar)dh).Xml("depositoHeredado.xml", out aux))
            {
                MessageBox.Show("Deserializado OK");
                
                foreach (Producto item in aux.Productos)
                    MessageBox.Show(item.ToString());                
            }
            else
            {
                MessageBox.Show("NO Deserializado");
            }
        }

        //Realizar el burbujeo de una excepción propia (MiException), comenzando en un método de instancia (de la clase Burbujeo),
        //pasando por un método de estático (de la misma clase) y capturado por última vez en el método que lo inició (manejador _click).
        //En cada paso, agregar en un único archivo de texto (burbujeo.txt)
        //el lugar por donde se paso junto con la hora, minuto y segundo de la accion. 
        //Atrapar la excepción y relanzarla en cada ocasión, al finalizar, leer el archivo y mostrarlo por MessageBox
        private void btnPunto4_Click(object sender, EventArgs e)
        {
            try
            {
                Burbujeo.MetodoDeClase();
            }
            catch (MiException ex)
            {

                StreamWriter sw = new StreamWriter((Environment.GetFolderPath(Environment.SpecialFolder.Desktop)) + @"\\burbujeo.txt", true);
                sw.WriteLine("En el evento click");
                sw.Close();

            }
            finally
            {
                StreamReader sr = new StreamReader((Environment.GetFolderPath(Environment.SpecialFolder.Desktop)) + @"\\burbujeo.txt");
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();
            }
        }

        //Agregar método de extensión (clase Extensora) en Producto: AgregarBD():bool.
        //AgregarBD insertará sobre la Base de Datos la instancia que lo invoque (Nombre y Stock)
        //Base de Datos (productosDB) -> Tabla productos (nombre - stock)
        private void btnPunto5_Click(object sender, EventArgs e)
        {
            Producto p = new Producto("Yerba", 21);

            if (p.AgregarBD())
            {
                MessageBox.Show("Se agrego a la BD");
            }
            else
            {
                MessageBox.Show("NO agregado a la BD");
            }
        }

        //Agregar metodo de extension (clase Extensora) en Producto: MostrarBD():string.
        //MostrarBD retornara una cadena (Nombre y Stock) de todos los registros de la BD.
        //Base de Datos (productosDB) -> Tabla productos (nombre - stock)
        private void btnPunto6_Click(object sender, EventArgs e)
        {
            Producto p = new Producto("Yerba", 21);
            MessageBox.Show(p.MostrarBD());
        }

        //Generar la clase genérica Galpon. Dicha clase tendrá el atributo _elementos:List del tipo genérico.
        //(este sólo se podrá inicializar en el constructor por defecto, que además será privado)
        //y _capacidad:int (generar un constructor que lo reciba como parámetros).
        //Realizar el método Add, que permite agregar un elemento a la colección. 
        //Cada elemento par agregado en la clase Galpon, disparará un evento (ElementosParesEvent).
        //Asociar el manejador del evento anterior a un método de instancia del formulario. 
        //Mostrar en dicho manejador las características por MessageBox.
        private void btnPunto7_Click(object sender, EventArgs e)
        {
            Galpon<Producto> g = new Galpon<Producto>(2);
            Galpon<Deposito> g1 = new Galpon<Deposito>(1);

            //Asociar manejador de eventos
            g.ElementosPares += new DelPares(ManejadorPares);
            g1.ElementosPares += new DelPares(ManejadorPares);

            g.Add(new Producto("alfajor", 2));
            g.Add(new Producto("caramelo", 100));

            g1.Add(new Deposito());
            g1.Add(new Deposito());
        }

        private void ManejadorPares(object sender, EventArgs e)
        {
            MessageBox.Show("Se agregó un elemento par!!!\n");

            if (sender is Galpon<Producto>)
            {
                MessageBox.Show(((Galpon<Producto>)sender).ToString());
            }
            else if (sender is Galpon<Deposito>)
            {
                MessageBox.Show(((Galpon<Deposito>)sender).ToString());
            }
        }

        private void btnPunto8_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(ProbarTodo);
            t.Start();
            //Implementar hilo
        }

        private void ProbarTodo()//para el thread
        {
            btnPunto1_Click(1, EventArgs.Empty);
            btnPunto2_Click(1, EventArgs.Empty);
            btnPunto3_Click(1, EventArgs.Empty);
            btnPunto4_Click(1, EventArgs.Empty);
            btnPunto5_Click(1, EventArgs.Empty);
            btnPunto6_Click(1, EventArgs.Empty);
            btnPunto7_Click(1, EventArgs.Empty);
            //Implementar código
        }
    }
}
