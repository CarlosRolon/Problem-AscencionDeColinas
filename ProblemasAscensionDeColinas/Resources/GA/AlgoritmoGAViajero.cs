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

        public Viajero algoritmoGeneticoGeneracional( int iteraciones , int tamPoblacion , 
            double probCruzamiento , double probMutacion)
        {
            List<Viajero> poblacion ;
            List<Viajero> padres;
            List<Viajero> hijos ;
            double probabilidad;

            poblacion = generarPoblacion(tamPoblacion);

            for (int i = 0; i < iteraciones; i++)
            {
                // Seleccion            
                padres =  MetodosSeleccion.Proporcional(poblacion);

                //  Cruzamiento
                probabilidad = new Random().NextDouble();
                if (probabilidad > probCruzamiento)
                    continue;
                hijos = MetodosCruzamiento.CruzamientoOrderCrossover(padres);

                // Mutacion
                hijos = MetodosMutacion.MutacionEnOrden(hijos, probMutacion);

                // Reemplazo
                poblacion = MetodosReemplazo.Fitness(poblacion, hijos);

            }

            // Obtiene la mejor solucion
            poblacion = poblacion.OrderBy(p => p.distanciaRuta).ToList();
            return poblacion[0];
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

        Random randNum = new Random();
        private Viajero generarSolucionAleatorio(Viajero vendedor)
        {
            Viajero solucion = vendedor;

            List<int> ciudadesPosibles = new List<int>();
            List<int> rutaAleatoria = new List<int>();
            
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
