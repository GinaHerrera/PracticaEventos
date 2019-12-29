using System;
using System.Collections.Generic;
using PracticaEventos.Leer;
using PracticaEventos.ManejoTiempo;
using PracticaEventos.Visualizar;

namespace PracticaEventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de Eventos: \n ");


            ILeerArchivo oLeer = new LeerArchivo();

            string[] texto = oLeer.LeerTexto("archivo.txt");


            ILectorEvento oLector = new LectorEvento();

            List<Evento> olstEvento = oLector.ExtraerEvento(texto);


         
            IVisualizador oVisualizar = new Visualizador();

            IRangoTiempo oTiempo = new RangoTiempo();

            Handler oMinuto = new Minuto(oVisualizar, oTiempo);
            Handler oHora = new Hora(oVisualizar, oTiempo);
            Handler oDia = new Dia(oVisualizar, oTiempo);
            Handler oMes = new Mes(oVisualizar, oTiempo);

            oMinuto.Siguiente(oHora);
            oHora.Siguiente(oDia);
            oDia.Siguiente(oMes);


            foreach (Evento oEvent in olstEvento)
            {
                oMinuto.EvaluarResultado(oEvent);
            }

            Console.Write("\n");

            Console.WriteLine("Presiona la tecla 's' para salir");

            Console.ReadLine();
        }
    }
        
}
