using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemasAscensionDeColinas.Resources
{
    public class AlgortimoNAHCMochila
    {
        MochilaClass mochila;

        public AlgortimoNAHCMochila(MochilaClass mochila)
        {
            this.mochila = mochila;
        }

        public MochilaClass optimizarSolucion(int maximoIteraciones)
        {
            MochilaClass new_best , best_evaluated ;
            int fbest_evaluated , fnew_best;
            int iteracion , locus;
            new_best = new MochilaClass();
            
            best_evaluated = generarSolucionAleatorio(mochila);
            fbest_evaluated = best_evaluated.valorEnMochila;
            iteracion = 0;
            do
            {
                iteracion++;
                locus =  new Random().Next(0, best_evaluated.objetosPosibles.Count);

                new_best = (MochilaClass)best_evaluated.Clone();
                new_best.mutarObjetoEnMochila(locus);
                fnew_best = new_best.valorEnMochila;

                if ( new_best.pesoEnMochila <= new_best.pesoMaximoPermitido)
                {
                    if (fnew_best >= fbest_evaluated)
                    {
                        best_evaluated = (MochilaClass)new_best.Clone();
                        fbest_evaluated = fnew_best;
                    }
                }
               

            } while (iteracion <= maximoIteraciones);

            return best_evaluated;
        }

        private MochilaClass generarSolucionAleatorio(MochilaClass mochila)
        {
            MochilaClass solucion = mochila;
            Random r = new Random();
            bool valorAleatorio;
            do
            {
                
                for (int i = 0; i < solucion.ObjetosEnMochila.Count; i++)
                {
                    valorAleatorio = r.Next(0,2) == 1;
                    solucion.ObjetosEnMochila[i] = valorAleatorio;
                }


            } while ( mochila.pesoEnMochila > mochila.pesoMaximoPermitido);

            return solucion;
        }
    }
}
