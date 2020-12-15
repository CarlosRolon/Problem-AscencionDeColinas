using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemasAscensionDeColinas.Resources.GA
{
    class AlgoritmoGAMinimos
    {


        FuncionMinimos funcion;
        delegate void seleccion();
        Random rand = new Random();

        public AlgoritmoGAMinimos(FuncionMinimos funcion)
        {
            this.funcion = funcion;
        }

        public delegate List<FuncionMinimos> DelSeleccion(List<FuncionMinimos> poblacion);

        public FuncionMinimos algoritmoGeneticoEstacionario(int iteraciones, int tamPoblacion, double probCruzamiento, double probMutacion)
        {
            List<FuncionMinimos> poblacion;
            List<FuncionMinimos> padres;
            List<FuncionMinimos> hijos;
            double probabilidad;

            poblacion = generarPoblacion(tamPoblacion);

            for (int i = 0; i < iteraciones; i++)
            {
                // Seleccion            
                padres = MetodosSeleccion.Proporcional(poblacion);

                //  Cruzamiento
                probabilidad = rand.NextDouble();
                if (probabilidad > probCruzamiento)
                    continue;
                hijos = MetodosCruzamiento.CruzamientoArimetico(padres);

                // Mutacion
                hijos = MetodosMutacion.MutacionEnReales(hijos, probMutacion);

                // Reemplazo
                poblacion = MetodosReemplazo.Crowding(poblacion, hijos, padres);

            }

            // Obtiene la mejor solucion
            poblacion = poblacion.OrderBy(p => p.sumatoriaFuncion).ToList();
            return poblacion[0];
        }


        public FuncionMinimos algoritmoGeneticoGeneracional(int iteraciones, int tamPoblacion, double probCruzamiento, double probMutacion)
        {
            List<FuncionMinimos> poblacion;
            List<FuncionMinimos> padres;
            List<FuncionMinimos> hijos;
            FuncionMinimos best_solution = new FuncionMinimos();
            double probabilidad;

            //best_solution.sumatoriaFuncion = float.MaxValue;

            poblacion = generarPoblacion(tamPoblacion);
            best_solution = poblacion[0];

            for (int i = 0; i < iteraciones; i++)
            {
                List<FuncionMinimos> nuevaPoblacion = new List<FuncionMinimos>();
                while (nuevaPoblacion.Count < tamPoblacion)
                {
                    // Seleccion            
                    padres = MetodosSeleccion.Proporcional(poblacion);

                    //  Cruzamiento
                    probabilidad = rand.NextDouble();
                    if (probabilidad > probCruzamiento)
                        continue;
                    hijos = MetodosCruzamiento.CruzamientoArimetico(padres);

                    // Mutacion
                    hijos = MetodosMutacion.MutacionEnReales(hijos, probMutacion);

                    nuevaPoblacion.AddRange(hijos);
                }

                nuevaPoblacion = nuevaPoblacion.OrderBy(p => p.sumatoriaFuncion).ToList();
                if (nuevaPoblacion[0].sumatoriaFuncion < best_solution.sumatoriaFuncion) {
                    best_solution = nuevaPoblacion[0];
                }    

                poblacion = nuevaPoblacion;

            }

            // Obtiene la mejor solucion
            //poblacion = poblacion.OrderBy(p => p.sumatoriaFuncion).ToList();
            return best_solution;
        }

        public List<FuncionMinimos> generarPoblacion(int tamPoblacion)
        {
            List<FuncionMinimos> poblacion = new List<FuncionMinimos>();
            for (int i = 0; i < tamPoblacion; i++)
            {
                FuncionMinimos cromosoma = (FuncionMinimos)funcion.Clone();
                poblacion.Add(generarSolucionAleatorio(cromosoma));
            }

            return poblacion;
        }
        public List<FuncionMinimos> MetodoSeleccion(List<FuncionMinimos> poblacion, DelSeleccion metodoSeleccion)
        {
            return metodoSeleccion(poblacion);
        }


        /*  public void GenerarSolucion(int tamPoblacion)
          {
              List<FuncionMinimos> poblacion = new List<FuncionMinimos>();
              for (int i = 0; i < tamPoblacion; i++)
              {
                  poblacion.Add((FuncionMinimos)generarSolucionAleatorio(funcion).Clone());
              }
          }*/


        private FuncionMinimos generarSolucionAleatorio(FuncionMinimos funcion)
        {
            FuncionMinimos solucion = funcion;
            solucion.listaDeValoresDeX = new List<float>();
            //float[] listaDeValoresDeX = new float[NumDimensiones];
          
            for (int i = 0; i < solucion.NumDimensiones; i++)
            {
                float ValorX = (float)(rand.NextDouble() * 20) - 10;
                solucion.listaDeValoresDeX.Add(ValorX);
                //TBEstadoInicial.Text += "   " + ValorX;
            }
            return solucion;
        }
    }
}
