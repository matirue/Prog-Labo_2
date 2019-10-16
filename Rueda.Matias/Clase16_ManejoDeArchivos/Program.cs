
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Clase_ManejoDeArchivos
{
  public class Program
  {
        #region Main
    static void Main(string[] args)
        {
            #region comentado
            //lo crea si no existe
            //Stream StreamWriter= new Stream(C:\miCarpeta\miArchivo.txt);
            //escritura y el StreamReade lectura

            // me tira error porque toma el \ como escape, para solucionarlo o le pongo doble \\ o un @ al principio
            //StreamWriter dat = new StreamWriter("C:\miCarpeta\miArchivo.txt");
            //StreamWriter dat = new StreamWriter("C:\\miCarpeta\\miArchivo.txt");


            //asi cada vez q se ejecute me pisa el archivo cada vez q lo ejecuto
            /******************************************************************************************************
            StreamWriter dat = new StreamWriter(@"C:\miCarpeta\miArchivo.txt");
            //dat.Write("hola mundo");
            dat.WriteLine("hola mundo 2");
            dat.WriteLine(DateTime.Now);
            ******************************************************************************************************/

            /******************************************************************************************************
            //con el ,true evito q pise
            StreamWriter dat = new StreamWriter(@"C:\miCarpeta\miArchivo.txt", true);
            //dat.Write("hola mundo");
            dat.WriteLine("ahora no pisa");
            dat.WriteLine(DateTime.Now);     

            //lo cierro
            dat.Close();
            ******************************************************************************************************/

            /****************************************************************************************************
            string retornoArch;

            //si no existe tira error
            StreamReader lectura = new StreamReader(@"C:\miCarpeta\miArchivo.txt");
            //lee todo el archivo y devuelve un strimg
            //retornoArch = lectura.ReadToEnd(); //no permite haer busqueda hasta q termine de leer

            //retornoArch = lectura.ReadLine();//lee linea a linea,si tiene X lineaa debo ejecutarlo las X veces
            //Console.WriteLine(retornoArch);

            while ( (retornoArch = lectura.ReadLine()) != null)//lee todo el archivo hasta q sea distinto de null
            {
              Console.WriteLine(retornoArch);
            }

            //Lo cierro
            //lectura.Close();
            **************************************************************************************************/

            /**************************************************************************************************
            //bloque para cerrar los achivos sin importar como lo abri, si para esc o lec
            //cuando termina el bloque se cierra y libera el obj

            //bloque de escritura
            using (StreamWriter dat = new StreamWriter(@"C:\miCarpeta\miArchivo.txt", true))
            {
              dat.WriteLine("...Dentro del using...");
              dat.WriteLine(DateTime.Now);
            }

            //bloque de lectura
            using (StreamReader lectura = new StreamReader(@"C:\miCarpeta\miArchivo.txt"))
            {
              string retornoArch;
              while ((retornoArch = lectura.ReadLine()) != null)//lee todo el archivo hasta q sea distinto de null
              {
                Console.WriteLine(retornoArch);
              }
            }

            Console.ReadKey();
            **************************************************************************************************/

            /**************************************************************************************************
            //evito los errores en tiempo de ejecucion
            try//probar, aca esta todo el codigo q pueda generar error
            {
              using (StreamWriter dat = new StreamWriter(@"C:\miCarpeta\miArchivo.txt", true))
              {
                dat.WriteLine("...Dentro del TRY...");
                dat.WriteLine(DateTime.Now);
              }
              using (StreamReader lectura = new StreamReader(@"C:\miCarpeta\miArchivo.txt"))
              {
                string retornoArch;
                while ((retornoArch = lectura.ReadLine()) != null)//lee todo el archivo hasta q sea distinto de null
                {
                  Console.WriteLine(retornoArch);
                }
              }
              //proboco el error cambiando la ruta
              using (StreamReader lectura = new StreamReader(@"C:\miCarpeta**miArchivo.txt"))
              {
                string retornoArch;
                while ((retornoArch = lectura.ReadLine()) != null)//lee todo el archivo hasta q sea distinto de null
                {
                  Console.WriteLine(retornoArch);
                }
              }
            }
            //catch (Exception e)//si se genera el error se captura, exception es class base de exeption
            //{
            //  Console.WriteLine("\n\n +++++Tira exception al cambiarle la Ruta de mi archivo:\n " + e.ToString());
            //  
            //}
            catch (DirectoryNotFoundException e)//si se genera el error se captura, exception es class base de exeption
            {
              Console.WriteLine("\n\n +++++Tira exception al cambiarle la Ruta de mi archivo:\n " + e.ToString());

            }
            //el exception debe estar al final de todos los catch
            catch (Exception e)
            {
              Console.WriteLine("\n\n +++++Tira exception segundo catch:\n " + e.ToString());

            }
            //este bloque va asociado al try-catch, siemprepasa por esta bloque independientemente de error o no
            finally //se lo usa para liberar los ultimos recursos de la app
            {
              Console.WriteLine("\n\n--->que si pasa por el finally");
            }

            Console.ReadKey();
            /**************************************************************************************************/

            /**************************************************************************************************/

            //Program.metodo1();
            #endregion


            try
            {
                Program.metodo1();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);

                try
                {
                    using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory+"\\incidencia.log"))
                    {
                        sw.WriteLine(e.StackTrace);
                    }
                    using (StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\incidencia.log"))
                    {
                        sw.WriteLine(e.StackTrace);
                    }
                }
                catch (Exception)
                {

                    
                }
            }
      
      Console.ReadKey();
      
    }

        #endregion

        #region Metodos
        public static void metodo1()
    {
      try
      {
                Program.metodo2();
      }
      catch (Exception e)
      {
                Console.WriteLine("->Estoy en el metodo1...");
                Console.WriteLine(e.InnerException.InnerException.Message);
                throw new Exception("-->Excepcion en metodo 1", e);
      }
    }
    public static void metodo2()
    {
      try
      {
        Program.metodo3();
      }
      catch (DirectoryNotFoundException e)
      {
        Console.WriteLine("->Estoy en el metodo2...");
        Console.WriteLine(e.InnerException.Message);
        throw new Exception("-->Excepcion en metodo 2", e);

      }
    }
    public static void metodo3()
    {
      try
      {
        Program.metodo4();
      }
      catch (ArgumentException e)
      {
        Console.WriteLine("->Estoy en el metodo3...");
        Console.WriteLine(e.Message);
        throw new DirectoryNotFoundException("-->Excepcion en metodo 3", e);

      }      
    }
    public static void metodo4()
    {
      Console.WriteLine("--->Estoy en el metodo4.");
      throw new ArgumentException("-->Excepcion en metodo 4");
    }
        #endregion

        //constructor en otra clase que hereda exception
        public class Metodo4Exception : Exception
        {
            public Metodo4Exception(string mensaje) : base(mensaje)
            {

            }
            public Metodo4Exception(string mensaje, Exception c) : base(mensaje, e)
            {

            }
        }

  }

}
