using PracticaEventos.ManejoTiempo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticaEventos
{
   public class RangoTiempo: IRangoTiempo
    {
        public string ObtenerRango(DateTime dtFechaEvento)
        {
            if (dtFechaEvento < DateTime.Now)
            {
                return " ocurrió hace ";
            }
            else
            {
                return " ocurrirá dentro de ";
            }

        }
    }
}

