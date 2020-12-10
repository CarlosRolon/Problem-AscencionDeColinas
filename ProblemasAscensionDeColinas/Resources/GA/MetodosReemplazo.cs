using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemasAscensionDeColinas.Resources.GA
{
    public static class MetodosReemplazo
    {

        static Random rand = new Random();



        public static List<MochilaClass> Aleatorio(List<MochilaClass> poblacionO, List<MochilaClass> hijosO)
        {
            List<MochilaClass> poblacion = poblacionO.ConvertAll(x => (MochilaClass)x.Clone());
            List<MochilaClass> hijos = hijosO.ConvertAll(x => (MochilaClass)x.Clone());
            List<MochilaClass> poblacionAleatorio = new List<MochilaClass>();
            int pos;

            poblacion = poblacion.Union(hijos).ToList();

            for (int i = 0; i < poblacionO.Count; i++)
            {
                pos = rand.Next(poblacion.Count);
                poblacionAleatorio.Add(poblacion[pos]);
                poblacion.RemoveAt(pos);
            }
            return poblacionAleatorio;
        }

        public static List<Viajero> Fitness(List<Viajero> poblacionO, List<Viajero> hijosO)
        {
            List<Viajero> poblacion = poblacionO.ConvertAll(x => (Viajero)x.Clone());
            List<Viajero> hijos = hijosO.ConvertAll(x => (Viajero)x.Clone());
            poblacion = poblacion.Union(hijos).ToList();
            poblacion = poblacion.OrderBy(o => o.distanciaRuta).ToList();
            poblacion = poblacion.Take(poblacionO.Count).ToList();
            return poblacion;
        }

        public static List<FuncionMinimos> Crowding(List<FuncionMinimos> poblacionO, List<FuncionMinimos> hijosO, List<FuncionMinimos> padresO)
        {
            List<FuncionMinimos> poblacion = poblacionO.ConvertAll(x => (FuncionMinimos)x.Clone());
            List<FuncionMinimos> hijos = hijosO.ConvertAll(x => (FuncionMinimos)x.Clone());
            List<FuncionMinimos> padres = padresO.ConvertAll(x => (FuncionMinimos)x.Clone());
            double distancia_p1_h1 = 0, distancia_p1_h2 = 0, distancia_p2_h1 = 0, distancia_p2_h2 = 0;

            distancia_p1_h1 = Distancia(padres[0], hijos[0]);
            distancia_p1_h2 = Distancia(padres[0], hijos[1]);
            distancia_p2_h1 = Distancia(padres[1], hijos[0]);
            distancia_p2_h2 = Distancia(padres[1], hijos[1]);

            if ((distancia_p1_h1 + distancia_p2_h2) < (distancia_p1_h2 + distancia_p2_h1))
            {
                //Torneo
                if (padres[0].Sumatoria() < hijos[0].Sumatoria())
                {
                    //remplaza el hijo 0 al padre en la población; si el hijo no es mejor se queda el padre
                    poblacion.Remove(padres[0]);
                    poblacion.Add(hijos[0]);

                }
                if (padres[1].Sumatoria() < hijos[1].Sumatoria())
                {
                    //remplaza el hijo 1 al padre en la población; si el hijo no es mejor se queda el padre
                    poblacion.Remove(padres[1]);
                    poblacion.Add(hijos[1]);
                }

            }
            else {
                //Torneo
                if (padres[0].Sumatoria() < hijos[1].Sumatoria())
                {
                    //remplaza el hijo 0 al padre en la población; si el hijo no es mejor se queda el padre
                    poblacion.Remove(padres[0]);
                    poblacion.Add(hijos[1]);
                }
                if (padres[1].Sumatoria() < hijos[0].Sumatoria())
                {
                    //remplaza el hijo 1 al padre en la población; si el hijo no es mejor se queda el padre
                    poblacion.Remove(padres[1]);
                    poblacion.Add(hijos[0]);
                }
            }

            return poblacion;
        }

        private static double Distancia(FuncionMinimos padres, FuncionMinimos hijos)
        {
            FuncionMinimos padresD = (FuncionMinimos)padres.Clone();
            FuncionMinimos hijosD = (FuncionMinimos)hijos.Clone();
            double distancia = 0;
            for (int i = 0; i < padresD.listaDeValoresDeX.Count; i++)
            {
                distancia += (padresD.listaDeValoresDeX[i] - hijosD.listaDeValoresDeX[i]) * (padresD.listaDeValoresDeX[i] - hijosD.listaDeValoresDeX[i]);
            }

            return Math.Sqrt(distancia);
        }
    }
}