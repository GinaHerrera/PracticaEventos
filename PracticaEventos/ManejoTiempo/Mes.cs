using PracticaEventos.Eventos;
using PracticaEventos.ManejoTiempo;
using PracticaEventos.Visualizar;
using System;


namespace PracticaEventos
{
   public class Mes : Handler
    {

        private readonly IVisualizador oVisualizar;

        private readonly IRangoTiempo oTiempo;

        public Mes(IVisualizador oVisualizar, IRangoTiempo oTiempo) //Utilizando inyección de dependencia en el constructor.
        {
            this.oVisualizar = oVisualizar;
            this.oTiempo = oTiempo;
        }

        protected override bool Procesar(IEvento oEvento)
        {

            string cMensaje;

            TimeSpan rango = oEvento.dtFecha - DateTime.Now;


            double oRangoTiempo = Math.Abs(rango.TotalDays);

            if (oRangoTiempo >= 30)
            {
                cMensaje = oEvento.cTitulo + oTiempo.ObtenerRango(oEvento.dtFecha) + Math.Round(oRangoTiempo / 30.436875) + " meses.";

                oVisualizar.VisualizarEventos(cMensaje);

                return true;
            }
            else
            {
                return false;
            }


        }

    }
}
