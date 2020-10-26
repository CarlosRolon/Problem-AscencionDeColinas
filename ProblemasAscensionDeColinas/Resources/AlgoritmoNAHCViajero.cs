using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProblemasAscensionDeColinas.Resources
{
    public class AlgoritmoNAHCViajero
    {
        Viajero viajero;

        public Viajero optimizarFuncion(Viajero viajero, int maximoIteraciones)
        {
            Viajero new_best, best_evaluated;
            int fbest_evaluated, fnew_best;
            int iteracion, locus;
            new_best = new Viajero();

            best_evaluated = viajero;
            best_evaluated.generarRutaValidaAleatoria();
            fbest_evaluated = best_evaluated.distanciaRecorrida;
            iteracion = 0;
            do
            {
                iteracion++;
                locus = new Random().Next(0, best_evaluated.matrizAdyacencia.GetLength(0));
                new_best = (Viajero)best_evaluated.Clone();
                new_best.mutarCamino(locus);
                if (new_best.caminoValido)
                {
                    fnew_best = new_best.distanciaRecorrida;
                    if (fnew_best <= fbest_evaluated)
                    {
                        best_evaluated = (Viajero)new_best.Clone();
                        fbest_evaluated = fnew_best;
                    }
                }
            } while (iteracion <= maximoIteraciones);
            return best_evaluated;
        }
    }
}
