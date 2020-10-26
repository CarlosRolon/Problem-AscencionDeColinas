using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemasAscensionDeColinas.Resources.SA
{
    public class AlgortimoSAMochila
    {
        MochilaClass mochila;

        public AlgortimoSAMochila(MochilaClass mochila)
        {
            this.mochila = mochila;
        }

        public MochilaClass optimizarSolucion(int maximoIteraciones , float temp_min , float temp_ini, float a)
        {
            MochilaClass solucionPrima, solucionInicial ;
            double valorRandom;
            int fsolucion , fsolucionPrima;
            int iteracion;
            float delta = 0;
            solucionInicial = new MochilaClass();
            
            solucionInicial = generarSolucionAleatorio(mochila);
            fsolucion = solucionInicial.valorEnMochila;
                                    
            do
            {
                iteracion = 0;
                do
                {
                    iteracion++;

                    solucionPrima = (MochilaClass)solucionInicial.Clone();
                    solucionPrima.solucionVecina();
                    fsolucionPrima = solucionPrima.valorEnMochila;

                    delta =  fsolucion - fsolucionPrima;

                    if (solucionPrima.pesoEnMochila <= solucionPrima.pesoMaximoPermitido)
                    {
                        if (delta <= 0)
                        {
                            solucionInicial = (MochilaClass)solucionPrima.Clone();
                            fsolucion = fsolucionPrima;
                        }
                        else {
                            valorRandom = new Random().NextDouble();
                            if (Math.Exp(-delta / temp_ini) > valorRandom) {                                
                                solucionInicial = (MochilaClass)solucionPrima.Clone();
                                fsolucion = fsolucionPrima;
                            }
                        }
                    }
                } while (iteracion <= maximoIteraciones);

                temp_ini = temp_ini * a;
            } while (temp_min <= temp_ini);
           
            return solucionInicial;
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
