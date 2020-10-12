using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemasAscensionDeColinas.Resources
{
    public class Viajero
    {
        public int[,] matrizAdyacencia { get; set; }

        public Queue<int> ciudadesVisitadas { get; set; }

        public List<int> ruta { get; set; }

        public int distanciaRecorrida { get; private set; }

        public Viajero()
        {

        }

        public void recortarLista(int posiciones)
        {
            for (int i = 0; i < posiciones; i++)
            {
                ciudadesVisitadas.Dequeue();
            }
        }

        public void generarRutaValida() {
            Random r = new Random();
            int ciudadDestino , ciudadActual;
            ciudadesVisitadas.Clear();
            //ciudadesVisitadas.Enqueue(r.Next(0, ciudadesVisitadas.Count));
            do
            {
                ciudadActual = ciudadesVisitadas.Peek();
                do
                {
                   ciudadDestino = r.Next(0, ciudadesVisitadas.Count);
                } while ( ciudadesVisitadas.Contains(ciudadDestino) && matrizAdyacencia[ciudadActual, ciudadDestino] <= 0  );

                distanciaRecorrida += matrizAdyacencia[ ciudadActual, ciudadDestino];
                ciudadesVisitadas.Enqueue(ciudadDestino);

            } while (ciudadesVisitadas.Count < matrizAdyacencia.Length);

        }

    }
}
