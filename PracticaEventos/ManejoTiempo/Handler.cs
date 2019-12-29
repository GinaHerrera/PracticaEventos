using PracticaEventos.Eventos;
using System;


namespace PracticaEventos.ManejoTiempo
{
   public abstract class Handler: IHandler
    {

        private IHandler handler;

        protected abstract bool Procesar(IEvento oEvento);

        public void Siguiente(IHandler handler)
        {
            this.handler = handler;
        }

        public void EvaluarResultado(IEvento oEvento)
        {
            if (!Procesar(oEvento))
            {
                this.handler?.EvaluarResultado(oEvento);
            }

        }


    }
}
