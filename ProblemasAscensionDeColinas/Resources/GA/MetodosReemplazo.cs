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
            int pos ;

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
            poblacion = poblacion.OrderBy( o=> o.distanciaRuta).ToList();
            poblacion = poblacion.Take(poblacionO.Count).ToList();
            return poblacion;
        }

        public static List<FuncionMinimos> Fitness(List<FuncionMinimos> poblacionO, List<FuncionMinimos> hijosO)
        {
            List<FuncionMinimos> poblacion = poblacionO.ConvertAll(x => (FuncionMinimos)x.Clone());

            return poblacion;
        }

    }
}
