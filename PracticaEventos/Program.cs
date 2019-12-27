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
            Console.WriteLine("Eventos: ");

            LectorEvento oLeerDocumento = new LectorEvento();

            List<Evento> lstEventos = oLeerDocumento.ExtraerEvento("archivo.txt");

            DateTime dtFechaHoy = DateTime.Now;

            string[] lines = File.ReadAllLines("archivo.txt"); 
            foreach (string linea in lines) 
            {
                string[] separar; 
                separar = linea.Split(','); 
                Console.WriteLine(separar[0] + "\t \t" + separar[1]); 
            }


            Console.ReadKey();
        }
    }
        
}
