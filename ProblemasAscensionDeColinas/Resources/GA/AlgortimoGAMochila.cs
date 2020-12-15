using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemasAscensionDeColinas.Resources.GA
{
    public class AlgortimoGAMochila
    {
        MochilaClass mochila;
        delegate void seleccion();
        Random rand = new Random();

        public AlgortimoGAMochila(MochilaClass mochila)
        {
            this.mochila = mochila;
        }

        public MochilaClass algoritmoGeneticoEstacionario(int iteraciones, int tamPoblacion,
          double probCruzamiento, double probMutacion)
        {
            List<MochilaClass> poblacion;
            List<MochilaClass> padres;
            List<MochilaClass> hijos;
            bool hijosValidos;
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
                hijos = MetodosCruzamiento.CruzamientoUniforme(padres);

                // Mutacion
                hijos = MetodosMutacion.MutacionBinaria(hijos, probMutacion);

                // Verifica que los hijos son validos
                hijosValidos = true;
                foreach (var item in hijos)
                {
                    if (item.pesoEnMochila > item.pesoMaximoPermitido)
                    {
                        hijosValidos = false;
                        break;
                    }
                        
                }

                if (!hijosValidos)
                    continue;

                // Reemplazo
                poblacion = MetodosReemplazo.Aleatorio(poblacion, hijos);

            }

            // Obtiene la mejor solucion
            poblacion = poblacion.OrderByDescending(p => p.pesoEnMochila).ToList();
            return poblacion[0];
        }

        public MochilaClass algoritmoGeneticoGeneracional(int iteraciones, int tamPoblacion,
         double probCruzamiento, double probMutacion)
        {
            List<MochilaClass> poblacion;
            List<MochilaClass> padres;
            List<MochilaClass> hijos;
            double probabilidad;

            poblacion = generarPoblacion(tamPoblacion);

            for (int i = 0; i < iteraciones; i++)
            {
                List<MochilaClass> nuevaPoblacion = new List<MochilaClass>();
                while (nuevaPoblacion.Count < tamPoblacion)
                {
                    // Seleccion            
                    padres = MetodosSeleccion.Proporcional(poblacion);

                    //  Cruzamiento
                    probabilidad = rand.NextDouble();
                    if (probabilidad > probCruzamiento)
                        continue;
                    hijos = MetodosCruzamiento.CruzamientoUniforme(padres);

                    // Mutacion
                    hijos = MetodosMutacion.MutacionBinaria(hijos, probMutacion);

                    // Verifica que los hijos son validos
             
                    foreach (var item in hijos)
                    {
                        if (item.pesoEnMochila <= item.pesoMaximoPermitido)
                        {
                            nuevaPoblacion.Add( item );
                        }

                    }
                }

                nuevaPoblacion = poblacion;
                
            }

            // Obtiene la mejor solucion
            poblacion = poblacion.OrderByDescending(p => p.pesoEnMochila).ToList();
            return poblacion[0];
        }


        public delegate List<MochilaClass> DelSeleccion(List<MochilaClass> poblacion);
        public delegate void x();

        public List<MochilaClass> generarPoblacion(int tamPoblacion)
        {
            List<MochilaClass> poblacion = new List<MochilaClass>();
            for (int i = 0; i < tamPoblacion; i++)
            {
                MochilaClass cromosoma = (MochilaClass)mochila.Clone();
                poblacion.Add( generarSolucionAleatorio(cromosoma) );
            }

            return poblacion;
        }
        public List<MochilaClass> MetodoSeleccion(List<MochilaClass> poblacion, DelSeleccion metodoSeleccion)
        { 
            return metodoSeleccion(poblacion);
        }


        public void GenerarSolucion( int tamPoblacion )
        {
            List<MochilaClass> poblacion = new List<MochilaClass>();
            for (int i = 0; i < tamPoblacion; i++)
            {                
                poblacion.Add((MochilaClass)generarSolucionAleatorio(mochila).Clone());
            }
        } 

        private MochilaClass generarSolucionAleatorio(MochilaClass mochila)
        {
            MochilaClass solucion = mochila;
            
            bool valorAleatorio;
            do
            {                
                for (int i = 0; i < solucion.ObjetosEnMochila.Count; i++)
                {
                    valorAleatorio = rand.NextDouble() < .5;
                    solucion.ObjetosEnMochila[i] = valorAleatorio;
                }
            } while ( mochila.pesoEnMochila > mochila.pesoMaximoPermitido);

            return solucion;
        }
    }
}
