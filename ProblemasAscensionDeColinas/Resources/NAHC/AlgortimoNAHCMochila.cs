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
            
            float temp_min = 0.001f;
            float temp_ini = 100; //Poner entrada del usuario
            float a = 0.80f; //Poner entrada del usuario
            float delta = 0;
            do
            {
                iteracion = 0;
                do
                {
                    iteracion++;
                    //cambiar nombres
                    locus = new Random().Next(0, best_evaluated.objetosPosibles.Count);

                    new_best = (MochilaClass)best_evaluated.Clone();
                    new_best.mutarObjetoEnMochila(locus);
                    fnew_best = new_best.valorEnMochila;

                    delta =  fbest_evaluated - fnew_best;


                    if (new_best.pesoEnMochila <= new_best.pesoMaximoPermitido)
                    {

                        if (delta <= 0)
                        {
                            best_evaluated = (MochilaClass)new_best.Clone();
                            fbest_evaluated = fnew_best;
                        }
                        else {
                            double locus_dos = new Random().NextDouble();
                            if (Math.Exp(-delta / temp_ini) > locus_dos) {                                
                                best_evaluated = (MochilaClass)new_best.Clone();
                                fbest_evaluated = fnew_best;
                            }
                        }
                    }


                } while (iteracion <= maximoIteraciones);
                temp_ini = temp_ini * a;
            } while (temp_min <= temp_ini);
           

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
