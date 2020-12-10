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
        public float sumatoriaFuncion
        {
            get
            {
                float suma = 0;
                for (int i = 0; i < listaDeValoresDeX.Count; i++)
                {
                    suma += (listaDeValoresDeX[i]) * (listaDeValoresDeX[i]);
                }
                return suma;
            }
        }

        //public float fitness { get; set; }

        /*public FuncionMinimos(int numDim) {
            this.NumDimensiones = numDim;
            this.listaDeValoresDeX = new float[numDim];
        }
        */
        public void GeneracionAleatoriaEstadoInicial()
        {
            //float[] listaDeValoresDeX = new float[NumDimensiones];
            Random rand = new Random();
            for (int i = 0; i < this.NumDimensiones; i++)
            {
                float ValorX = (float)(rand.NextDouble() * 20) - 10;
                this.listaDeValoresDeX.Add( ValorX );
                //TBEstadoInicial.Text += "   " + ValorX;
            }            
        }

        public float Sumatoria()
        {
            float suma = 0;

            for (int i = 0; i < listaDeValoresDeX.Count; i++)
            {
                suma += (listaDeValoresDeX[i]) * (listaDeValoresDeX[i]);
            }

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
