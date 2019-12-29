using PracticaEventos.Eventos;
using PracticaEventos.ManejoTiempo;
using PracticaEventos.Visualizar;
using System;

namespace PracticaEventos 
{
    public class Hora : Handler
    {

        private readonly IVisualizador oVisualizar;

        private readonly IRangoTiempo oTiempo;

        public Hora(IVisualizador oVisualizar, IRangoTiempo oTiempo) //Utilizando inyección de dependencia en el constructor.
        {
            this.oVisualizar = oVisualizar;
            this.oTiempo = oTiempo;
        }

        protected override bool Procesar(IEvento oEvento)
        {

            string cMensaje;

            TimeSpan rango = oEvento.dtFecha - DateTime.Now;


            double oRangoTiempo = Math.Abs(rango.TotalHours);

            if (oRangoTiempo >= 24)
            {
                return false;
            }
            else
            {
                cMensaje = oEvento.cTitulo + oTiempo.ObtenerRango(oEvento.dtFecha) + Math.Round(oRangoTiempo) + " horas.";

                oVisualizar.VisualizarEventos(cMensaje);

                return true;
            }

        }
    }
}
