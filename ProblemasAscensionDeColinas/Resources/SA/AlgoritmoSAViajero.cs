using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProblemasAscensionDeColinas.Resources.SA
{
    public class AlgoritmoSAViajero
    {


        public Viajero optimizarSolucion(Viajero viajero ,int maximoIteraciones, float temp_min, float temp_ini, float a)
        {
            Viajero solucionPrima, solucionInicial;
            double valorRandom;
            int fsolucion, fsolucionPrima;
            int iteracion;
            float delta = 0;
            solucionInicial = viajero;

            solucionInicial.generarRutaAleatoria();
            fsolucion = solucionInicial.distanciaCamino();

            do
            {
                iteracion = 0;
                do
                {
                    iteracion++;

                    solucionPrima = (Viajero)solucionInicial.Clone();
                    solucionPrima.solucionVecina();
                    fsolucionPrima = solucionPrima.distanciaCamino();

                    delta =  fsolucionPrima - fsolucion ;


                    if (delta <= 0)
                    {
                        solucionInicial = (Viajero)solucionPrima.Clone();
                        fsolucion = fsolucionPrima;
                    }
                    else
                    {
                        valorRandom = new Random().NextDouble();
                        if (Math.Exp(-delta / temp_ini) > valorRandom)
                        {
                            solucionInicial = (Viajero)solucionPrima.Clone();
                            fsolucion = fsolucionPrima;
                        }
                    }

                } while (iteracion <= maximoIteraciones);

                temp_ini = temp_ini * a;
            } while (temp_min <= temp_ini);

            return solucionInicial;
        }


    }
}
