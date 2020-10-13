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

        public Stack<int> ciudadesVisitadas { get; set; }

        public List<int> rutaSolucion { get; set; }

        public int distanciaRecorrida { get; private set; }

        public Viajero()
        {

        }

        public void recortarLista(int posiciones)
        {
            for (int i = 0; i < posiciones; i++)
            {
                ciudadesVisitadas.Pop();
            }
        }

        public void generarRutaValida() {
            Random r = new Random();
            int ciudadDestino , ciudadActual , ciudadInicial;
            ciudadesVisitadas.Clear();
            ciudadInicial = r.Next(0, matrizAdyacencia.Length);
            ciudadesVisitadas.Push( ciudadInicial);
            do
            {
                ciudadActual = ciudadesVisitadas.Peek();
                do
                {
                   ciudadDestino = r.Next(0, matrizAdyacencia.Length);
                } while ( ciudadesVisitadas.Contains(ciudadDestino) || matrizAdyacencia[ciudadActual, ciudadDestino] <= 0  );

                distanciaRecorrida += matrizAdyacencia[ ciudadActual, ciudadDestino];
                ciudadesVisitadas.Push(ciudadDestino);

            } while (ciudadesVisitadas.Count < matrizAdyacencia.Length);

            if (matrizAdyacencia[ciudadesVisitadas.Peek(), ciudadInicial] > 0)
            {
                distanciaRecorrida += matrizAdyacencia[ciudadesVisitadas.Peek(), ciudadInicial];
            }

        }

    }
}
