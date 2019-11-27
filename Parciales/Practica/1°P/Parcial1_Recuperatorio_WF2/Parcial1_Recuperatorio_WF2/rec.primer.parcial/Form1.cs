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

//DESARROLLAR DENTRO DEL NAMESPACE RAIZ ENTIDADES.RPP EN UN PROYECTO DE TIPO CLASS LIBRARY

namespace rec.primer.parcial
{
    public partial class Form1 : Form
    {
        private BancoNacional _bn;
        private BancoProvincial _bp;
        private BancoMunicipal _bm;

        public Form1()
        {
            InitializeComponent();
      MessageBox.Show("Luciano Moreno 2A - RPP.");
        }

        //Crear dos objetos de tipo Deposito, cada uno de estos objetos contiene una lista de la clase Producto.
        //Un constructor por default (inicializa en 3 productos) y una sobrecarga que reciba la cantidad de productos 
        //del depósito (REUTILIZAR CODIGO). 
        //La clase Producto tiene dos atributos: nombre y stock y un único constructor.
        //Se debe poder sumar las listas de los dos depósitos (con la sobrecarga de un operador en la clase Deposito) 
        //y guardar el valor que retorna en una lista de Productos, recordar que si un producto está en las dos listas, 
        //se debe sumar el stock y no agregar dos veces al mismo producto.
        //Mostrar el contenido del array resultante (nombre y stock)
        private void button1_Click(object sender, EventArgs e)
        {
            Producto p1 = new Producto("tomate", 10);
            Producto p2 = new Producto("azucar", 25);
            Producto p3 = new Producto("yerba", 30);
            Producto p4 = new Producto("cafe", 5);

            Deposito d1 = new Deposito(5);
            Deposito d2 = new Deposito();

            d1.productos.Add(p1);
            d1.productos.Add(p2);
            d1.productos.Add(p3);
            d1.productos.Add(p4);

            d2.productos.Add(p1);
            d2.productos.Add(p1);
            d2.productos.Add(p2);

            List<Producto> aux = d1 + d2;

            String s = "";
            foreach (Producto item in aux)
            {
                s += (item.nombre + " - " + item.stock + "\n");
            }
            //tomate-->30
            //azucar-->50
            //yerba-->30
            //cafe-->5
            MessageBox.Show(s);

        }

        //Crear en la clase Comparadora el método bool GetElDelMedio(int uno, int dos, int tres, out int elDelMedio). 
        //La funcionalidad de este método de clase es la siguiente: Retornará un true, si encuentra el valor medio entre los 
        //tres parámetros recibidos(y lo alojará en el parámetro de salida elDelMedio). Retornará false si no encuentra un valor medio.
        //Ejemplo 1: uno = 6; dos = 9; tres = 8; => true; elDelMedio = 8. Ejemplo 2: uno = 5; dos = 1; tres = 5; => false; elDelMedio = 0
        //Hacer un Test Unitario para el ingreso de:  3, 5, 4;  5, 4, 4;  5, 1, 2; y  1, 1, 0.

        private void button2_Click(object sender, EventArgs e)
        {
            //3, 5, 4; 5, 4, 4; 5, 1, 2; y  1, 1, 0.
            int elDelMedio;
            if (Comparadora.GetElDelMedio(3, 5, 4, out elDelMedio))
            {
                MessageBox.Show("El del medio de entre\n 3, 5, 4 es: " + elDelMedio);
            }
            else
            {
                MessageBox.Show("No hay del medio de entre 3, 5, 4");
            }

            if (Comparadora.GetElDelMedio(5, 4, 4, out elDelMedio))
            {
                MessageBox.Show("El del medio de entre\n 5, 4, 4 es: " + elDelMedio);
            }
            else
            {
                MessageBox.Show("No hay del medio de entre 5, 4, 4");
            }

            if (Comparadora.GetElDelMedio(5, 1, 2, out elDelMedio))
            {
                MessageBox.Show("El del medio de entre\n 5, 1, 2 es: " + elDelMedio);
            }
            else
            {
                MessageBox.Show("No hay del medio de entre 5, 1, 2");
            }

            if (Comparadora.GetElDelMedio(1, 1, 0, out elDelMedio))
            {
                MessageBox.Show("El del medio de entre\n 1, 1, 0 es: " + elDelMedio);
            }
            else
            {
                MessageBox.Show("No hay del medio de entre 1, 1, 0");
            }
        }

        //Crear jerarquía que contenga los siguientes constructores (1 por clase):
        //Banco(nombre)
        //BancoNacional(nombre, pais)
        //BancoProvincial(bancoNacional, provincia)
        //BancoMunicipal(bancoProvincial, municipio)
        //Crear una instancia de cada clase e inicializar los atributos del form: 
        //_bancoNacional, _bancoProvincial y _bancoMunicipal. 
        private void button3_Click(object sender, EventArgs e)
        {
            BancoNacional bn = new BancoNacional("Banco de la Alegría", "Argentina");
            BancoProvincial bp = new BancoProvincial(bn, "Buenos Aires");
            BancoMunicipal bm = new BancoMunicipal(bp, "Avellaneda");

            this._bn = bn;
            this._bp = bp;
            this._bm = bm;

      MessageBox.Show("Se han creado los bancos con exito!");

        }

        //Agregar en Banco el método Mostrar():string y Mostrar(Banco):string, ambos abstractos.
        //El método que no recibe parámetros, retornará el nombre, mientras que el otro
        //retornará todas las características de la instancia que recibe como parametro. REUTILIZAR CODIGO.
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this._bn.Mostrar() + ":\n" + this._bn.Mostrar(this._bn));
            MessageBox.Show(this._bp.Mostrar() + ":\n" + this._bn.Mostrar(this._bp));
            MessageBox.Show(this._bm.Mostrar() + ":\n" + this._bn.Mostrar(this._bm));

        }

        //Agregar en la clase BancoMunicipal una sobrecarga en el implicit para que retorne todas
        //las características de la instancia en formato string. Aplicar polimorfismo sobre el método ToString
        //que deberá reutilizar código.
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this._bm);
        }

        //Sobrescribir el método Equals en Banco para permitir comparar bancos con cualquier objeto.
        //Si el objeto a comparar es un Banco, mostrar mensaje y retornar true si los nombres son iguales
        //Si el objeto a comparar es un BancoNacional, mostrar mensaje y retornar false
        //Si el objeto a comparar es un BancoProvincial, mostrar mensaje y retornar false
        //Si el objeto a comparar es un BancoMunicipal, mostrar mensaje y retornar false
        //Si el objeto a comparar es cualquier otro, mostrar el mensaje "no es ningun tipo de banco" y retornar false
        private void button6_Click(object sender, EventArgs e)
        {
            Banco b = new BancoNacional("Banco", "Argentina");
            BancoNacional bn = new BancoNacional("Banco de la Alegría", "Argentina");
            BancoNacional bn2 = new BancoNacional("Banco de la Alegría infinita", "Argentina");
            BancoProvincial bp = new BancoProvincial(bn, "Buenos Aires");
            BancoMunicipal bm = new BancoMunicipal(bp, "Avellaneda");
      //BancoNacional b2 = new BancoNacional("Banco", "Argentina");->Prueba que son iguales

      MessageBox.Show(b.Equals(bn).ToString());
            MessageBox.Show(b.Equals(bn2).ToString());
            MessageBox.Show(b.Equals(bp).ToString());
            MessageBox.Show(b.Equals(bm).ToString());
            MessageBox.Show(b.Equals("hola, no soy un banco").ToString());
     // MessageBox.Show(b.Equals(b2).ToString()); ->Prueba que son iguales

    }

        //Crear en Deposito el metodo necesario para poder ordenar la lista de productos segun el criterio elegido
        private void button7_Click(object sender, EventArgs e)
        {
            Producto p1 = new Producto("tomate", 10);
            Producto p2 = new Producto("azucar", 25);
            Producto p3 = new Producto("yerba", 30);
            Producto p4 = new Producto("cafe", 5);

            Deposito d1 = new Deposito(4);

            d1.productos.Add(p1);
            d1.productos.Add(p2);
            d1.productos.Add(p3);
            d1.productos.Add(p4);

            String s = "";
            Deposito.OrdenarAscendente(d1);
      //ordenado por stock ascendente
      for (int i = 0; i < 4; i++)
            {
                s += (d1.productos[i].nombre + " - " + d1.productos[i].stock + "\n");
            }

            MessageBox.Show(s);

        }

        //Crear en Deposito el metodo necesario para poder ordenar la lista de productos segun el criterio elegido
        private void button8_Click(object sender, EventArgs e)
        {
            Producto p1 = new Producto("tomate", 10);
            Producto p2 = new Producto("azucar", 25);
            Producto p3 = new Producto("yerba", 30);
            Producto p4 = new Producto("cafe", 5);

            Deposito d1 = new Deposito(4);

            d1.productos.Add(p1);
            d1.productos.Add(p2);
            d1.productos.Add(p3);
            d1.productos.Add(p4);

            Deposito.OrdenarAlfabetico(d1);

      String s = "";
            //ordenado por nombre alfabeticamente
            for (int i = 0; i < 4; i++)
            {
                s += (d1.productos[i].nombre + " - " + d1.productos[i].stock + "\n");
            }

            MessageBox.Show(s);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
