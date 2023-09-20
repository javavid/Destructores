using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivos manejoArchivos1 = new ManejoArchivos();
            manejoArchivos1.Mensaje();
        }
    }

    class ManejoArchivos
    {
        StreamReader archivo = null;

        int contador = 0;
        string linea;

        public ManejoArchivos()

        {
            archivo = new StreamReader(@"C:\Users\saram\OneDrive\Escritorio\eder tapias.txt");

            while ((linea = archivo.ReadLine()) != null) 
            {
             contador++;
            }
        }

        public void Mensaje()
        {
            Console.WriteLine("hay {0} lineas", contador);
        }

        ~ManejoArchivos()
        {
            archivo.Close();
        }
    }
}
