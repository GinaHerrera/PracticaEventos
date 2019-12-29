using System;
using System.Collections.Generic;

namespace PracticaEventos
{
    public interface ILectorEvento
    {
       List<Evento> ExtraerEvento(string[] texto);
    }
}
