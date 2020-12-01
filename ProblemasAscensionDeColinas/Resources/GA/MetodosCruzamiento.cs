using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemasAscensionDeColinas.Resources.GA
{
    public class MetodosCruzamiento
    {
        static Random rand = new Random();

        public static List<MochilaClass> CruzamientoUniforme(List<MochilaClass> padresO)
        {
            List<MochilaClass> padres = padresO.ConvertAll(x => (MochilaClass)x.Clone());
            List<MochilaClass> hijos = padresO.ConvertAll(x => (MochilaClass)x.Clone());
            int dimensionSolucion = padres[0].ObjetosEnMochila.Count;
            bool valorAleatorio;


            // Se hace el cruzamiento para el hijo 1
            for (int i = 0; i < dimensionSolucion; i++)
            {
                valorAleatorio = rand.NextDouble() < .5;
                if (valorAleatorio)
                {
                    hijos[0].ObjetosEnMochila[i] = padres[1].ObjetosEnMochila[i];
                }
                else
                {
                    hijos[0].ObjetosEnMochila[i] = padres[0].ObjetosEnMochila[i];
                }
                
            }

            // Se hace el cruzamiento para el hijo 2
            for (int i = 0; i < dimensionSolucion; i++)
            {
                valorAleatorio = rand.NextDouble() < .5;
                if (valorAleatorio)
                {
                    hijos[1].ObjetosEnMochila[i] = padres[1].ObjetosEnMochila[i];
                }
                else
                {
                    hijos[1].ObjetosEnMochila[i] = padres[0].ObjetosEnMochila[i];
                }
            }


            return hijos;
        }

        public static List<FuncionMinimos> CruzamientoArimetico(List<FuncionMinimos> padresO)
        {
            List<FuncionMinimos> padres = padresO.ConvertAll(x => (FuncionMinimos)x.Clone());
            List<FuncionMinimos> hijos = padresO.ConvertAll(x => (FuncionMinimos)x.Clone());
            int tamañoSolucion = padres[0].NumDimensiones;
            float w = (float)rand.NextDouble();

            for (int i = 0; i < tamañoSolucion; i++)
            {
                hijos[0].listaDeValoresDeX[i] = w * hijos[0].listaDeValoresDeX[i] + (1 - w) * hijos[1].listaDeValoresDeX[i];
                hijos[1].listaDeValoresDeX[i] = w * hijos[1].listaDeValoresDeX[i] + (1 - w) * hijos[0].listaDeValoresDeX[i];
            }

            return hijos;
        }

        public static List<Viajero> CruzamientoOrderCrossover(List<Viajero> padresO)
        {
            List<Viajero> padres = padresO.ConvertAll(x => (Viajero)x.Clone());
            List<Viajero> hijos = padresO.ConvertAll(x => (Viajero)x.Clone());

            List<int> posicionesTomadas = new List<int>();
            List<int> nuevaRuta = new List<int>();

            int tamañoSolucion = padres[0].ruta.Count;
            int r = rand.Next(0, tamañoSolucion);
            int r_2 = rand.Next(0, tamañoSolucion);

            while (r_2 == r)
            {
                r_2 = rand.Next(0, tamañoSolucion);
            }

            if (r_2 < r)
            {
                int r_aux = r;
                r = r_2;
                r_2 = r_aux;
            }

            // Se genera el hijo 1
            // Se toma las posiciones
            posicionesTomadas = padres[0].ruta.GetRange(r, r_2 - r + 1);
            for (int i = 0; i < padres[1].ruta.Count; i++)
            {
                if (!posicionesTomadas.Contains(padres[1].ruta[i]))
                {
                    posicionesTomadas.Add(padres[1].ruta[i]);
                }
            }
            
            // Se asignan
            for (int i = r; i < hijos[0].ruta.Count; i++)
            {
                hijos[0].ruta[i] = posicionesTomadas[0];
                posicionesTomadas.RemoveAt(0);
            }

            for (int i = 0; i < r; i++)
            {
                hijos[0].ruta[i] = posicionesTomadas[0];
                posicionesTomadas.RemoveAt(0);
            }

            // Se genera el hijo 2
            // Se toma las posiciones
            posicionesTomadas.Clear();
            posicionesTomadas = padres[1].ruta.GetRange(r, r_2 - r + 1);
            for (int i = 0; i < padres[0].ruta.Count; i++)
            {
                if (!posicionesTomadas.Contains(padres[0].ruta[i]))
                {
                    posicionesTomadas.Add(padres[0].ruta[i]);
                }
            }

            // Se asignan
            for (int i = r; i < hijos[1].ruta.Count; i++)
            {
                hijos[1].ruta[i] = posicionesTomadas[0];
                posicionesTomadas.RemoveAt(0);
            }

            for (int i = 0; i < r; i++)
            {
                hijos[1].ruta[i] = posicionesTomadas[0];
                posicionesTomadas.RemoveAt(0);
            }

            return hijos;
        }


        public static List<MochilaClass> CruzamientoDosPuntos(List<MochilaClass> padresO)
        {
            List<MochilaClass> padres = padresO.ConvertAll(x => (MochilaClass)x.Clone()); 
            List<MochilaClass> hijos = padresO.ConvertAll(x => (MochilaClass)x.Clone());

            int tamañoSolucion = padres[0].ObjetosEnMochila.Count;
            int r = rand.Next(0, tamañoSolucion);
            int r_2 = rand.Next(0, tamañoSolucion);

            while (r_2 == r)
            {
                r_2 = rand.Next(0, tamañoSolucion);
            }

            if (r_2 < r)
            {
                int r_aux = r;
                r = r_2;
                r_2 = r_aux;
            }

            // Se hace el cambio en el intervalo r, r_2
            for (int i = r; i < r_2 + 1; i++)
            {
                hijos[0].ObjetosEnMochila[i] = padres[1].ObjetosEnMochila.ElementAt(i);
                hijos[1].ObjetosEnMochila[i] = padres[0].ObjetosEnMochila.ElementAt(i);

            }

            return hijos;
        }








        public static List<Viajero> CruzamientoDosPuntos(List<Viajero> padresO)
        {
            List<Viajero> padres = padresO.ConvertAll(x => (Viajero)x.Clone());
            List<Viajero> hijos = padresO.ConvertAll(x => (Viajero)x.Clone());

            int tamañoSolucion = padres[0].ruta.Count;
            int r = rand.Next(0, tamañoSolucion);
            int r_2 = rand.Next(0, tamañoSolucion);

            while (r_2 == r)
            {
                r_2 = rand.Next(0, tamañoSolucion);
            }

            if (r_2 < r)
            {
                int r_aux = r;
                r = r_2;
                r_2 = r_aux;
            }

            // Se hace el cambio en el intervalo r, r_2
            for (int i = r; i < r_2 + 1; i++)
            {
                hijos[0].ruta[i] = padres[1].ruta.ElementAt(i);
                hijos[1].ruta[i] = padres[0].ruta.ElementAt(i);

            }


            return hijos;
        }

    }
}
