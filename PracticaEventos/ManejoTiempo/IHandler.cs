using PracticaEventos.Eventos;


namespace PracticaEventos.ManejoTiempo
{
    public interface IHandler
    {
        void Siguiente(IHandler _oHandler);
        void EvaluarResultado(IEvento _oEvent);
    }
}
