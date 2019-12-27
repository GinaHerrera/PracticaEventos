using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEventos.Interfaz
{
   public interface IVisualizador
    {
        void visualizarEventos(List<Evento> lstEventos);
    }
}
