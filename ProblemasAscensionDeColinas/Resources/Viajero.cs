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
        public bool caminoValido { get; private set; }
        private int ciudadInicial { get; set; }
        public int[,] matrizAdyacencia { get; set; }

        public Stack<int> ciudadesVisitadas { get; set; }

        public int distanciaRecorrida { get; private set; }

        public Viajero()
        {
            caminoValido = false;
            ciudadInicial = 0;
            ciudadesVisitadas = new Stack<int>();
            distanciaRecorrida = 0;
        }

        public void regresarCamino(int posiciones)
        {
            posiciones = ciudadesVisitadas.Count - posiciones;
            int ciudadOrigen, ciudadDestino;
            for (int i = 0; i < posiciones; i++)
            {
                ciudadDestino = ciudadesVisitadas.Peek();
                ciudadesVisitadas.Pop();
                if (ciudadesVisitadas.Count > 0)
                {
                    ciudadOrigen = ciudadesVisitadas.Peek();
                    distanciaRecorrida -= matrizAdyacencia[ciudadOrigen, ciudadDestino];
                }
                else
                {
                    distanciaRecorrida = 0;
                    ciudadesVisitadas.Clear();
                    ciudadesVisitadas.Push(ciudadInicial);
                }
             
            }
        }

        public void generarRutaValidaAleatoria()
        {
            Random r = new Random();
            int ciudadDestino, ciudadActual, posAleatorio;
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
                        caminoValido = true;
                    }
                   
                }
            } while (solucion);
            
        }

        
        public void mutarCamino(int posicion)
        {
            Random r = new Random();
            int ciudadDestino, ciudadActual, posAleatorio;
            ciudadDestino = 0;
            bool existenCaminos = true;
            regresarCamino(posicion);

            //distanciaRecorrida = 0;
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
                    caminoValido = true;
                }
                else
                {
                    caminoValido = false;
                }

            }
            else
            {
                caminoValido = false;
            }
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

        public object Clone()
        {
            object obj = this.MemberwiseClone();
           
            this.ciudadesVisitadas = new Stack<int>(ciudadesVisitadas);
            return obj;
        }


    }
}
