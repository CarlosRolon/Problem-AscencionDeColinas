using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // matrizAdyacencia = new int[0,0];
            ciudadesVisitadas = new Stack<int>();
            rutaSolucion = new List<int>();
            distanciaRecorrida = 0;

        }

        public void recortarLista(int posiciones)
        {
            for (int i = 0; i < posiciones; i++)
            {
                ciudadesVisitadas.Pop();
            }
        }

        public void generarRutaValida2() {
            Random r = new Random();
            int ciudadDestino, ciudadActual, ciudadInicial , posAleatorio;
            bool solucion = true;
            ciudadDestino = 0;
            do
            {
                ciudadesVisitadas.Clear();
                ciudadInicial = r.Next(0, matrizAdyacencia.GetLength(0));
                ciudadesVisitadas.Push(ciudadInicial);
                do
                {
                    ciudadActual = ciudadesVisitadas.Peek();
                    List<int> vecinos = CiudadesVecinas(ciudadActual);
                    do
                    {

                        if (vecinos.Count <= 0)
                        {
                           continue;
                        }

                        posAleatorio = r.Next(0, vecinos.Count);
                        ciudadDestino = vecinos[posAleatorio];
                        vecinos.RemoveAt(posAleatorio);

                        if (ciudadesVisitadas.Count == matrizAdyacencia.GetLength(0) && matrizAdyacencia[ciudadActual, ciudadDestino] <= 0)
                        {
                            break;
                        }

                    } while (ciudadesVisitadas.Contains(ciudadDestino));

                    distanciaRecorrida += matrizAdyacencia[ciudadActual, ciudadDestino];
                    ciudadesVisitadas.Push(ciudadDestino);

                } while (ciudadesVisitadas.Count <= matrizAdyacencia.GetLength(0));

                solucion = false;
            } while (solucion);

        }


        public void generarRutaValida()
        {
            Random r = new Random();
            int ciudadDestino, ciudadActual, ciudadInicial, posAleatorio;
            bool solucion = true;
            ciudadDestino = 0;
            bool existenCaminos = true;

            do
            {
                ciudadesVisitadas.Clear();
                ciudadInicial = r.Next(0, matrizAdyacencia.GetLength(0));
                ciudadesVisitadas.Push(ciudadInicial);
                existenCaminos = true;
                distanciaRecorrida = 0;
                do
                {
                    ciudadActual = ciudadesVisitadas.Peek();
                    List<int> vecinos = CiudadesVecinas(ciudadActual);
                    do
                    {

                        if (vecinos.Count <= 0)
                        {
                            existenCaminos = false;
                            break;
                        }

                        posAleatorio = r.Next(0, vecinos.Count);
                        ciudadDestino = vecinos[posAleatorio];
                        vecinos.RemoveAt(posAleatorio);

                    } while (ciudadesVisitadas.Contains(ciudadDestino) && existenCaminos);

                    if (!existenCaminos)
                    {
                        break;
                    }

                    distanciaRecorrida += matrizAdyacencia[ciudadActual, ciudadDestino];
                    ciudadesVisitadas.Push(ciudadDestino);

                } while (ciudadesVisitadas.Count < matrizAdyacencia.GetLength(0));

                if (existenCaminos)
                {
                    if (matrizAdyacencia[ciudadesVisitadas.Peek(), ciudadInicial] > 0)
                    {
                        distanciaRecorrida += matrizAdyacencia[ciudadesVisitadas.Peek(), ciudadInicial];
                        ciudadesVisitadas.Push(ciudadInicial);
                        solucion = false;
                    }
                   
                }
            } while (solucion);
        }


        private List<int> CiudadesVecinas(int ciudadActual)
        {
            List<int> vecinos = new List<int>();
            int maxCiudades = matrizAdyacencia.GetLength(0);

            for (int i = 0; i < maxCiudades; i++)
            {
                if (matrizAdyacencia[ciudadActual,i] > 0)
                    vecinos.Add(i);
            }
            return vecinos;
        }
    

    }
}
