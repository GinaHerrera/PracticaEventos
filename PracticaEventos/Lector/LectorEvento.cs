using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEventos
{
    class LectorEvento: ILectorEvento
    {
        public List<Evento> ExtraerEvento(string [] texto)
        {
       
            List<Evento> Eventos = new List<Evento>();

            foreach (string cEvento in texto)
            {

                Evento oEvento = new Evento();

                try
                {
                    string[] separar;
                    separar = cEvento.Split(',');

                    oEvento.cTitulo = separar[0];
                    oEvento.dtFecha = Convert.ToDateTime(separar[1]);
                    Eventos.Add(oEvento);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

               

            }
            return Eventos;

        }

    }
}
