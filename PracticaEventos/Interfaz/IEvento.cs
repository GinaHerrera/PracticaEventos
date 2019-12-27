using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEventos.Interfaz
{
    public interface IEvento
    {
        string cTitulo { get; set; }
        DateTime dtFecha { get; set; }
    }
}
