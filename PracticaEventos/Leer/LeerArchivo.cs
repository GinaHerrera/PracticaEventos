using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaEventos.Leer;

namespace PracticaEventos.Leer
{
    public class LeerArchivo : ILeerArchivo
    {
        public string[] LeerTexto(string cRuta)
        {
            string[] texto = new string[] { };

            try
            {
                texto = File.ReadAllLines(cRuta);

            }
           
            catch (Exception)
            {
                Console.WriteLine("No es posible leer el archivo.");
            }

            return texto;
        }
    }
}
