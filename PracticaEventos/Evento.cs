using PracticaEventos.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEventos
{
    public class Evento : IEvento
    {
       public string cTitulo { get; set; }
       public DateTime dtFecha { get; set; }
    }
}
