using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEventos
{
    class LectorEvento: ILectorEvento
    {
        public List<Evento> ExtraerEvento(string cRuta)
        {
            List<Evento> oEventos;

            string[] lineas = File.ReadAllLines(cRuta);

            Fechas oFecha = new Fechas();

            oEventos = oFecha.ObtenerFecha(lineas);

            return oEventos;
        }

    }
}
