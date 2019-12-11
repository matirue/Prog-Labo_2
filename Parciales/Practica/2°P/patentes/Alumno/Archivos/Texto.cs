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
        //public void Guardar(string archivo, Queue<Patente> datos)
        //{
        //    StreamWriter sw = null;

        //    try
        //    {
        //        sw = new StreamWriter(archivo, true);

        //        foreach(Patente p in datos)
        //        {
        //            sw.WriteLine(p);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (sw != null)
        //        {
        //            sw.Close();
        //        }
        //    }

        //}

        //public void Leer(string archivo, out Queue<Patente> datos)
        //{
        //    datos = new Queue<Patente>();
        //    StreamReader sr = null;

        //    try
        //    {
        //        sr = new StreamReader(archivo);

        //        while (!sr.EndOfStream)
        //        {
        //            try
        //            {
        //                datos.Enqueue(sr.ReadLine().ValidarPatentr());
        //            }
        //            catch (Exception ex)
        //            {

        //                throw ex;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (sr != null)
        //            sr.Close();
        //    }
        //}

        public void Guardar(string archivo, Queue<Patente> datos)
        {
            using (StreamWriter file = new StreamWriter(archivo, true))
            {
                foreach (Patente item in datos)
                {
                    file.WriteLine(item);
                }
            }
        }
        public void Leer(string archivo, out Queue<Patente> datos)
        {
            datos = new Queue<Patente>();
            using (StreamReader file = new StreamReader(archivo))
            {
                while (!file.EndOfStream)
                {
                    try
                    {
                        datos.Enqueue(file.ReadLine().ValidarPatentr());
                    }
                    catch (PatenteInvalidaException ex)
                    { }
                }
            }
        }
    }
}
