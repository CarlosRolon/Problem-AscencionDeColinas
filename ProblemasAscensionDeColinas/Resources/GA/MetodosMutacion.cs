using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemasAscensionDeColinas.Resources.GA
{
    public static class MetodosMutacion
    {

        static Random rand = new Random();

        public static List<MochilaClass> MutacionBinaria(List<MochilaClass> elementos, double probabilidad)
        {
            List<MochilaClass> elementosMutados = elementos.ConvertAll(x => (MochilaClass)x.Clone());
            double probActual;
            int dimension;

            // Realiza la operacion en cada solucion
            foreach (var item in elementosMutados)
            {
                // Obtiene la dimension de la solucion
                dimension = item.ObjetosEnMochila.Count;

                // Realiza la operacion en cada delemento de la solucion
                for (int i = 0; i < dimension; i++)
                {
                    // Obtiene una probabilidad
                    probActual = rand.NextDouble();

                    //Verifica que este en el rango de probabilidad
                    if (probActual <= probabilidad)
                    {
                        // Muta el valor
                        item.ObjetosEnMochila[i] = !item.ObjetosEnMochila[i];
                    }

                }
            }
            return elementosMutados;
        }

        public static List<Viajero> MutacionEnOrden(List<Viajero> elementos, double probabilidad)
        {
            List<Viajero> elementosMutados = elementos.ConvertAll(x => (Viajero)x.Clone());
            double probActual;
            int dimension;

            return elementosMutados;            
        }
        public static List<FuncionMinimos> MutacionEnReales(List<FuncionMinimos> elementos, double probabilidad)
        {
            List<FuncionMinimos> elementosMutados = elementos.ConvertAll(x => (FuncionMinimos)x.Clone());
            double probActual;
            int dimension;

            return elementosMutados;
        }

    }
}
