using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEventos
{
   public class Fechas : Evento
    {
        public List<Evento> ObtenerFecha(string[] lineas)
        {
            Evento oEvento = new Evento();

            List<Evento> lstEventos = new List<Evento>();


            foreach (string linea in lineas)
            {
                string[] separar;
                separar = linea.Split(',');

                oEvento.cTitulo = separar[0];
                oEvento.dtFecha = Convert.ToDateTime(separar[1]);
                

                lstEventos.Add(oEvento);
            }
            return lstEventos;
        }
    }
}
