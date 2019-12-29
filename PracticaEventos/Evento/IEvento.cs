using System;

namespace PracticaEventos.Eventos
{
    public interface IEvento
    {
        string cTitulo { get; set; }
        DateTime dtFecha { get; set; }
    }
}
