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
            dis_P1_N1 = distanciaSolucionesMochila( poblacion[posPadre1] , poblacion[p_candidato1] );
            dis_P1_N2 = distanciaSolucionesMochila( poblacion[posPadre1] , poblacion[p_candidato2]);
            dis_P1_N3 = distanciaSolucionesMochila( poblacion[posPadre1] , poblacion[p_candidato3]);

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
    
        public static List<MochilaClass> Proporcional(List<MochilaClass> poblacionS)
        {
            List<MochilaClass> poblacion = new List<MochilaClass>(poblacionS);
            List<MochilaClass> padres = new List<MochilaClass>();
            List<double> regiones = new List<double>();
            bool encontroRegion = false;
      
            // Sumatoria de la funcion fitness de los elementos de la pobliacion
            double sumaFitness = poblacion.Sum(item => item.valorEnMochila);

            // SELECCION PRIMER PADRE 
            // Se obtiene la region
            double puntero = new Random().NextDouble();

            // Se busca la region 
            double region = 0;
            for (int i = 0; i < poblacion.Count && !encontroRegion; i++)
            {
                //Establece la region
                region += poblacion[i].valorEnMochila / sumaFitness;
                // Valida si esta dentro de la region
                if ( region > puntero)
                {
                    // Guarda padre
                    padres.Add(poblacion[i]);
                    encontroRegion = true;
                    poblacion.RemoveAt(i);
                }
            }

            // SELECCION SEGUNDO PADRE 
            // Se obtiene la region
            sumaFitness = poblacion.Sum(item => item.valorEnMochila);
            puntero = new Random().NextDouble();

            // Se busca la region 
            region = 0;
            encontroRegion = false;
            for (int i = 0; i < poblacion.Count && !encontroRegion; i++)
            {
                region += 1 -(poblacion[i].valorEnMochila / sumaFitness);
                if (region > puntero)
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
                competidores.Add(poblacion[posiciones[posAleatoria]]);
                posiciones.RemoveAt(posAleatoria);
            }

            // Se ordena a los competidores y selecciona al mejor
            padres = competidores.OrderByDescending(o => o.valorEnMochila).Take(2).ToList();
        

            return padres;
        }

        public static List<FuncionMinimos> NPM(List<FuncionMinimos> poblacionS)
        {
            List<FuncionMinimos> poblacion = new List<FuncionMinimos>(poblacionS);
            List<FuncionMinimos> padres = new List<FuncionMinimos>();
            FuncionMinimos padre1, padre2;
            List<int> posiciones = new List<int>();
            int posPadre1, p_candidato1, p_candidato2, p_candidato3;
            double dis_P1_N1, dis_P1_N2, dis_P1_N3;
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
            padre1 = (FuncionMinimos)poblacion[posPadre1].Clone();
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
            dis_P1_N1 = distanciaSolucionesFuncionMin(poblacion[posPadre1], poblacion[p_candidato1]);
            dis_P1_N2 = distanciaSolucionesFuncionMin(poblacion[posPadre1], poblacion[p_candidato2]);
            dis_P1_N3 = distanciaSolucionesFuncionMin(poblacion[posPadre1], poblacion[p_candidato3]);

            // Se selecciona el mas lejano del padre 1

            if (dis_P1_N1 >= dis_P1_N2 && dis_P1_N1 >= dis_P1_N3)
            {
                padre2 = (FuncionMinimos)poblacion[p_candidato1].Clone();
            }
            else if (dis_P1_N2 >= dis_P1_N1 && dis_P1_N2 >= dis_P1_N3)
            {
                padre2 = (FuncionMinimos)poblacion[p_candidato2].Clone();
            }
            else
            {
                padre2 = (FuncionMinimos)poblacion[p_candidato3].Clone();
            }

            padres.Add(padre2);

            return padres;
        }

        public static List<FuncionMinimos> Proporcional(List<FuncionMinimos> poblacionS)
        {
            List<FuncionMinimos> poblacion = new List<FuncionMinimos>(poblacionS);
            List<FuncionMinimos> padres = new List<FuncionMinimos>();
            List<double> regiones = new List<double>();
            bool encontroRegion = false;

            // Sumatoria de la funcion fitness de los elementos de la pobliacion
            float sumaFitness = poblacion.Sum(item => item.Sumatoria());

            // SELECCION PRIMER PADRE 
            // Se obtiene la region
            double puntero = new Random().NextDouble();

            // Se busca la region 
            double region = 0;
            for (int i = 0; i < poblacion.Count && !encontroRegion; i++)
            {
                //Establece la region
                region += poblacion[i].Sumatoria() / sumaFitness;
                // Valida si esta dentro de la region
                if (region > puntero)
                {
                    // Guarda padre
                    padres.Add(poblacion[i]);
                    encontroRegion = true;
                    poblacion.RemoveAt(i);
                }
            }

            // SELECCION SEGUNDO PADRE 
            // Se obtiene la region
            sumaFitness = poblacion.Sum(item => item.Sumatoria());
            puntero = new Random().NextDouble();

            // Se busca la region de la fecha
            region = 0;
            encontroRegion = false;
            for (int i = 0; i < poblacion.Count && !encontroRegion; i++)
            {
                region += poblacion[i].Sumatoria() / sumaFitness;
                if (region > puntero)
                {
                    padres.Add(poblacion[i]);
                    encontroRegion = true;
                }
            }
            return padres;
        }

        public static List<FuncionMinimos> Torneo(List<FuncionMinimos> poblacionS)
        {
            List<FuncionMinimos> poblacion = new List<FuncionMinimos>(poblacionS);
            List<FuncionMinimos> padres = new List<FuncionMinimos>();
            List<int> posiciones = new List<int>();
            List<FuncionMinimos> competidores = new List<FuncionMinimos>();
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
                competidores.Add(poblacion[posiciones[posAleatoria]]);
                posiciones.RemoveAt(posAleatoria);
            }

            // Se ordena a los competidores 
            List<FuncionMinimos> ordenados = competidores.OrderBy(o => o.Sumatoria()).ToList();
            //Se selecciona a los dos mejores     
            padres.Add(ordenados[0]);
            padres.Add(ordenados[1]);

            return padres;
        }

        public static List<Viajero> NPM(List<Viajero> poblacionS)
        {
            List<Viajero> poblacion = new List<Viajero>(poblacionS);
            List<Viajero> padres = new List<Viajero>();
            Viajero padre1, padre2;
            List<int> posiciones = new List<int>();
            int posPadre1, p_candidato1, p_candidato2, p_candidato3;
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
            padre1 = (Viajero)poblacion[posPadre1].Clone();
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
            dis_P1_N1 = distanciaSolucionesViajero( poblacion[posPadre1] , poblacion[p_candidato1] );
            dis_P1_N2 = distanciaSolucionesViajero( poblacion[posPadre1] , poblacion[p_candidato2] );
            dis_P1_N3 = distanciaSolucionesViajero( poblacion[posPadre1] , poblacion[p_candidato3] );

            // Se selecciona el mas lejano del padre 1

            if (dis_P1_N1 >= dis_P1_N2 && dis_P1_N1 >= dis_P1_N3)
            {
                padre2 = (Viajero)poblacion[p_candidato1].Clone();
            }
            else if (dis_P1_N2 >= dis_P1_N1 && dis_P1_N2 >= dis_P1_N3)
            {
                padre2 = (Viajero)poblacion[p_candidato2].Clone();
            }
            else
            {
                padre2 = (Viajero)poblacion[p_candidato3].Clone();
            }

            padres.Add(padre2);

            return padres;
        }

        public static List<Viajero> Proporcional(List<Viajero> poblacionS)
        {
            List<Viajero> poblacion = new List<Viajero>(poblacionS);
            List<Viajero> padres = new List<Viajero>();
            List<double> regiones = new List<double>();
            bool encontroRegion = false;

            // Sumatoria de la funcion fitness de los elementos de la pobliacion
            int sumaFitness = poblacion.Sum(item => item.distanciaCamino());

            // SELECCION PRIMER PADRE 
            // Se obtiene la region
            double puntero = new Random().NextDouble();

            // Se busca la region 
            double region = 0;
            for (int i = 0; i < poblacion.Count && !encontroRegion; i++)
            {
                //Establece la region
                region += ((double)poblacion[i].distanciaCamino()) / sumaFitness;
                // Valida si esta dentro de la region
                if (region > puntero)
                {
                    // Guarda padre
                    padres.Add(poblacion[i]);
                    encontroRegion = true;
                    poblacion.RemoveAt(i);
                }
            }

            // SELECCION SEGUNDO PADRE 
            // Se obtiene la region
            puntero = new Random().NextDouble();
            sumaFitness = poblacion.Sum(item => item.distanciaCamino());

            // Se busca la region 
            region = 0;
            encontroRegion = false;
            for (int i = 0; i < poblacion.Count && !encontroRegion; i++)
            {
                region += ((double)poblacion[i].distanciaCamino()) / sumaFitness;
                if (region > puntero)
                {
                    padres.Add(poblacion[i]);
                    encontroRegion = true;
                }
            }
            return padres;
        }

        public static List<Viajero> Torneo(List<Viajero> poblacionS)
        {
            List<Viajero> poblacion = new List<Viajero>(poblacionS);
            List<Viajero> padres = new List<Viajero>();
            List<int> posiciones = new List<int>();
            List<Viajero> competidores = new List<Viajero>();
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
                competidores.Add(poblacion[posiciones[posAleatoria]]);
                posiciones.RemoveAt(posAleatoria);
            }

            // Se ordena a los competidores 
            List<Viajero> ordenados = competidores.OrderBy(o => o.distanciaCamino()).ToList();
            //Se selecciona a los dos mejores     
            padres.Add(ordenados[ordenados.Count - 1]);
            padres.Add(ordenados[ordenados.Count - 2]);

            return padres;
        }
    

        // Distancias NPM

        public static int distanciaSolucionesMochila(MochilaClass m1 , MochilaClass m2)
        {
            int distancia = 0;

            for (int i = 0; i < m1.ObjetosEnMochila.Count; i++)
            {
                if (m1.ObjetosEnMochila[i] != m2.ObjetosEnMochila[i])
                {
                    distancia++;
                }
            }
            return distancia;
        }

        public static int distanciaSolucionesViajero( Viajero viajero1 , Viajero viajero2)
        {
            int distancia = 0;

            for (int i = 0; i < viajero1.ruta.Count; i++)
            {
                distancia += Math.Abs ( viajero1.ruta[i] - viajero2.ruta[i] );
            }

            return distancia;
        }

   
        public static double distanciaSolucionesFuncionMin(FuncionMinimos f1, FuncionMinimos f2)
        {
            double distancia = 0;

            for (int i = 0; i < f1.listaDeValoresDeX.Count; i++)
            {
                distancia += Math.Sqrt( Math.Pow(f1.listaDeValoresDeX[i],2) + Math.Pow(f2.listaDeValoresDeX[i], 2));
            }
            return distancia;
        }

    }
}
