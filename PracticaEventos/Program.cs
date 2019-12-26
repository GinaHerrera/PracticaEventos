using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticaEventos
{
    class Program
    {
        static void Main(string[] args)
        {
            LeerTexto();
        }

        public static void LeerTexto()
        {
            string[] lineas;

            lineas = File.ReadAllLines(@"C:\Ejercicios\PracticaEventos\archivo.txt");

            char[] delimitador = { ',' };

            DateTime fecha = DateTime.Now;
          

            Console.WriteLine("Serie de eventos");

            foreach (string line in lineas)
            {
               
                Console.WriteLine("\t" + line);
            }
          
            Console.ReadKey();
        }
        
    }
}
