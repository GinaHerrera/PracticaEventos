using System;
using PracticaEventos.Visualizar;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEventos
{
   public class Visualizador: IVisualizador
    {

        public void VisualizarEventos(string cMensaje)
        {
            Console.WriteLine(cMensaje);
        }
    }
}
