using PracticaEventos.Eventos;
using System;


namespace PracticaEventos
{
    public class Evento : IEvento
    {
       public string cTitulo { get; set; }
       public DateTime dtFecha { get; set; }
    }
}
