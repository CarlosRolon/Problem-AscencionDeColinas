using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemasAscensionDeColinas.Resources
{
    public class FuncionMinimos
    {

        public int NumDimensiones { get; set; }
        public List<float> listaDeValoresDeX { get; set; }

        public float fitness { get; set; }

        /*public FuncionMinimos(int numDim) {
            this.NumDimensiones = numDim;
            this.listaDeValoresDeX = new float[numDim];
        }
        */
        public List<float> GeneracionAleatoriaEstadoInicial()
        {
            //float[] listaDeValoresDeX = new float[NumDimensiones];
            Random rand = new Random();
            for (int i = 0; i < this.listaDeValoresDeX.Count; i++)
            {
                float ValorX = (float)(rand.NextDouble() * 20) - 10;
                this.listaDeValoresDeX[i] = ValorX;
                //TBEstadoInicial.Text += "   " + ValorX;
            }            
            return this.listaDeValoresDeX;
        }

        public float Sumatoria(float[] listaDeValoresDeX)
        {
            float suma = 0;

            for (int i = 0; i < listaDeValoresDeX.Length; i++)
            {
                suma += (listaDeValoresDeX[i]) * (listaDeValoresDeX[i]);
            }

            this.fitness = suma;
            return suma;
        }

        public float[] MutarEstadoInicial(in float[] ValoresdeX, int iter)
        {

            Random rand = new Random();
            float[] NewListaDeValoresDeX = new float[ValoresdeX.Length];

            for (int i = 0; i < ValoresdeX.Length; i++)
            {
                NewListaDeValoresDeX[i] = ValoresdeX[i];
            }

            float X = ValoresdeX[iter];
            X = (float)(X * Math.Sin(X));
            NewListaDeValoresDeX[iter] = X;

            return NewListaDeValoresDeX;
        }

        public float[] solucionVecina(in float[] ValoresdeX)
        {
            Random rand = new Random();
            int iter = rand.Next(0, ValoresdeX.Length);
            float[] NewListaDeValoresDeX = new float[ValoresdeX.Length];

            for (int i = 0; i < ValoresdeX.Length; i++)
            {
                NewListaDeValoresDeX[i] = ValoresdeX[i];
            }

            float X = ValoresdeX[iter];
            X = (float)(X * Math.Sin(X));
            NewListaDeValoresDeX[iter] = X;

            return NewListaDeValoresDeX;
        }

        public object Clone()
        {
            object obj = this.MemberwiseClone();
            this.listaDeValoresDeX = listaDeValoresDeX.ToList();
            return obj;
        }


    }
}
