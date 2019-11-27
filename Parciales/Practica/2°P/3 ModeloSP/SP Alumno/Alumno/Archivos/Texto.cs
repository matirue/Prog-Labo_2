using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using System.IO;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {
        public void Guardar(string archivo, Queue<Patente> datos)
        {
            StreamWriter sw = new StreamWriter(archivo, false);
            try
            {                
                foreach(Patente patente in datos)
                {
                    sw.WriteLine(patente.ToString());
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                sw.Close();
            }
        }

        public void Leer(string archivo, out Queue<Patente> datos)
        {
            StreamReader sr = new StreamReader(archivo);
            datos = new Queue<Patente>();

            try
            {
                while (!sr.EndOfStream)
                {
                    try
                    {
                        string codigoPatente = sr.ReadLine();
                        datos.Enqueue(codigoPatente.ValidarPatente());
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                sr.Close();
            }
        }
    }
}
