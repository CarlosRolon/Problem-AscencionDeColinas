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
        ViajeroNAHC viajero;

        public ViajeroNAHC optimizarFuncion(ViajeroNAHC viajero, int maximoIteraciones)
        {
            ViajeroNAHC new_best, best_evaluated;
            int fbest_evaluated, fnew_best;
            int iteracion, locus;
            new_best = new ViajeroNAHC();

            best_evaluated = viajero;
            best_evaluated.generarRutaValidaAleatoria();
            fbest_evaluated = best_evaluated.distanciaRecorrida;
            iteracion = 0;
            do
            {
                iteracion++;
                locus = new Random().Next(0, best_evaluated.matrizAdyacencia.GetLength(0));
                new_best = (ViajeroNAHC)best_evaluated.Clone();
                new_best.mutarCamino(locus);
                if (new_best.caminoValido)
                {
                    fnew_best = new_best.distanciaRecorrida;
                    if (fnew_best <= fbest_evaluated)
                    {
                        best_evaluated = (ViajeroNAHC)new_best.Clone();
                        fbest_evaluated = fnew_best;
                    }
                }
            } while (iteracion <= maximoIteraciones);
            return best_evaluated;
        }
    }
}
