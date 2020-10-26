using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProblemasAscensionDeColinas.Resources
{
    public class Viajero
    {
   
        public int[,] matrizAdyacencia { get; set; }

        public List<int> ruta = new List<int>();



        public Viajero()
        {
        }

       
        public void generarRutaAleatoria()
        {
            List<int> ciudadesPosibles = new List<int>();
            List<int> rutaAleatoria = new List<int>();
            Random randNum = new Random();
            int pos;

            for (int i = 0; i < matrizAdyacencia.GetLength(0); i++)
            {
                ciudadesPosibles.Add(i); //0,1,2,3,4,5
            }

            while (ciudadesPosibles.Count > 0)
            {
                pos = randNum.Next(0, ciudadesPosibles.Count );//2
                rutaAleatoria.Add(ciudadesPosibles[pos]);//2,3,5,4,1,0
                ciudadesPosibles.RemoveAt(pos);//0
            }

            ruta =  rutaAleatoria;
        }

        public int distanciaCamino()
        {
            int inicio, fin, distancia;
            distancia = 0;
            for (int i = 1; i < ruta.Count; i++)
            {
                inicio =  ruta[i - 1];//2
                fin = ruta[i];//3
                distancia+= matrizAdyacencia[inicio,fin];//costo de 2 a 3
            }

            inicio = ruta.Count - 1;//6-1=5 = pos 5 de la lista de la ruta
            fin = ruta[0];//2
            distancia += matrizAdyacencia[inicio, fin];

            return distancia;
        }

        public void solucionVecina()
        {
            int posRandom1 = new Random().Next(0, ruta.Count);
            int posRandom2;
            
            do
            {
                posRandom2 = new Random().Next(0, ruta.Count);
            } while (posRandom1 == posRandom2);

            int valor = ruta[posRandom1];
            ruta[posRandom1] = ruta[posRandom2];
            ruta[posRandom2] = valor;
        }

          

        public object Clone()
        {
            object obj = this.MemberwiseClone();
            this.ruta = new List<int>(ruta);
            return obj;
        }


    }
}
