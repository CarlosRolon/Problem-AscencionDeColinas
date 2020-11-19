using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemasAscensionDeColinas.Resources.GA
{
    class AlgoritmoGAViajero
    {
        Viajero vendedor;
        delegate void seleccion();
        Random r = new Random();

        public AlgoritmoGAViajero(Viajero vendedor)
        {
            this.vendedor = vendedor;
        }

        public delegate List<Viajero> DelSeleccion(List<Viajero> poblacion);
        public delegate void x();

        public List<Viajero> generarPoblacion(int tamPoblacion)
        {
            List<Viajero> poblacion = new List<Viajero>();
            for (int i = 0; i < tamPoblacion; i++)
            {
                Viajero cromosoma = (Viajero)vendedor.Clone();
                poblacion.Add(generarSolucionAleatorio(cromosoma));
            }

            return poblacion;
        }
        public List<Viajero> MetodoSeleccion(List<Viajero> poblacion, DelSeleccion metodoSeleccion)
        {
            return metodoSeleccion(poblacion);
        }


        private Viajero generarSolucionAleatorio(Viajero vendedor)
        {
            Viajero solucion = vendedor;

            List<int> ciudadesPosibles = new List<int>();
            List<int> rutaAleatoria = new List<int>();
            Random randNum = new Random();
            int pos;

            for (int i = 0; i < solucion.matrizAdyacencia.GetLength(0); i++)
            {
                ciudadesPosibles.Add(i);
            }

            while (ciudadesPosibles.Count > 0)
            {
                pos = randNum.Next(0, ciudadesPosibles.Count);
                rutaAleatoria.Add(ciudadesPosibles[pos]);
                ciudadesPosibles.RemoveAt(pos);
            }
            solucion.ruta = rutaAleatoria;
            return  solucion;
        }
    }
}
