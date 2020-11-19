using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemasAscensionDeColinas.Resources.GA
{
    public static class MetodosSeleccion
    {
        public static List<MochilaClass> NPM (List<MochilaClass> poblacionS)
        {
            List<MochilaClass> poblacion = new List<MochilaClass>(poblacionS);
            List<MochilaClass> padres = new List<MochilaClass>();
            MochilaClass padre1 , padre2;
            List<int> posiciones = new List<int>();
            int posPadre1 , p_candidato1, p_candidato2, p_candidato3;
            int dis_P1_N1, dis_P1_N2, dis_P1_N3;
            int valAleatorio;

            // Genera una lista de las posiciones de la poblacion
            for (int i = 0; i < poblacion.Count; i++)            
                posiciones.Add(i);

            //Proceso para seleccionar el primer padre aleatoriamente
            //  Selecciona una valor aleatoriamente
            valAleatorio = new Random().Next(0, posiciones.Count);
            //   Se selecciona aletatoriamente la posicion
            posPadre1 = posiciones[valAleatorio];
            //   Se accede y almacena el Padre 1
            padre1 = (MochilaClass)poblacion[posPadre1].Clone();
            padres.Add(padre1);
            //   Elimina la posicion del padre 1 de las posibles
            posiciones.RemoveAt(posPadre1);

            //Proceso para seleccionar el segundo padre aleatoriamente
            // Selecciona 3 (N=3) posibles posibles candidatas para el segundo padre

            // N1
            valAleatorio = new Random().Next(0, posiciones.Count);
            p_candidato1 = posiciones[valAleatorio];
            posiciones.RemoveAt(valAleatorio);

            // N2
            valAleatorio = new Random().Next(0, posiciones.Count);
            p_candidato2 = posiciones[valAleatorio];
            posiciones.RemoveAt(valAleatorio);

            // N3
            valAleatorio = new Random().Next(0, posiciones.Count);
            p_candidato3 = posiciones[valAleatorio];
            posiciones.RemoveAt(valAleatorio);
                        

            // Se calcula distancias entre el padre 1 y cada N
            dis_P1_N1 = Math.Abs(posPadre1 - p_candidato1);
            dis_P1_N2 = Math.Abs(posPadre1 - p_candidato2);
            dis_P1_N3 = Math.Abs(posPadre1 - p_candidato3);

            // Se selecciona el mas lejano del padre 1

            if (dis_P1_N1 >= dis_P1_N2 && dis_P1_N1 >= dis_P1_N3 )
            {
                padre2 = (MochilaClass)poblacion[p_candidato1].Clone();
            }
            else if (dis_P1_N2 >= dis_P1_N1 && dis_P1_N2 >= dis_P1_N3)
            {
                padre2 = (MochilaClass)poblacion[p_candidato2].Clone();
            }
            else
            {
                padre2 = (MochilaClass)poblacion[p_candidato3].Clone();
            }

            padres.Add(padre2);

            return padres;
        }
    
        public static List<MochilaClass> Ruleta(List<MochilaClass> poblacionS)
        {
            List<MochilaClass> poblacion = new List<MochilaClass>(poblacionS);
            List<MochilaClass> padres = new List<MochilaClass>();
            List<double> regiones = new List<double>();
            bool encontroRegion = false;
      
            // Sumatoria de la funcion fitness de los elementos de la pobliacion
            double sumaFitness = poblacion.Sum(item => item.valorEnMochila);

            // SELECCION PRIMER PADRE 
            // Se obtiene la flecha
            //double flecha = 2 * Math.PI * new Random().Next();
            double flecha = new Random().NextDouble();

            // Se busca la region de la fecha
            double region = 0;
            for (int i = 0; i < poblacion.Count && !encontroRegion; i++)
            {
                //Establece la region
                region += poblacion[i].valorEnMochila / sumaFitness;
                // Valida si esta dentro de la region
                if ( region > flecha)
                {
                    // Guarda padre
                    padres.Add(poblacion[i]);
                    encontroRegion = true;
                    poblacion.RemoveAt(i);
                }
            }        

            // SELECCION SEGUNDO PADRE 
            // Se obtiene la flecha
            //double flecha = 2 * Math.PI * new Random().Next();
            flecha = new Random().NextDouble();

            // Se busca la region de la fecha
            region = 0;
            encontroRegion = false;
            for (int i = 0; i < poblacion.Count && !encontroRegion; i++)
            {
                region += poblacion[i].valorEnMochila / sumaFitness;
                if (region > flecha)
                {
                    padres.Add(poblacion[i]);
                    encontroRegion = true;
                }
            }
            return padres;
        }

        public static List<MochilaClass> Torneo(List<MochilaClass> poblacionS)
        {
            List<MochilaClass> poblacion = new List<MochilaClass>(poblacionS);
            List<MochilaClass> padres = new List<MochilaClass>();
            List<int> posiciones = new List<int>();
            List<MochilaClass> competidores = new List<MochilaClass>();
            int posAleatoria;

            // K = Competidores
            int K = 5;

            // Genera una lista de las posiciones de la poblacion
            for (int i = 0; i < poblacion.Count; i++)
                posiciones.Add(i);

            // Se selecciona K para el torneo
            for (int i = 0; i < K; i++)
            {
                posAleatoria = new Random().Next(0, posiciones.Count);
                competidores.Add(poblacion[ posiciones[posAleatoria]]);
                posiciones.RemoveAt(posAleatoria);
            }

            // Se ordena a los competidores 
            List<MochilaClass> ordenados = competidores.OrderBy(o => o.valorEnMochila).ToList();
            //Se selecciona a los dos mejores     
            padres.Add(ordenados[ordenados.Count - 1]);
            padres.Add(ordenados[ordenados.Count - 2]);

            return padres;
        }

    }
}
