using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemasAscensionDeColinas.Resources.GA
{
    class AlgoritmoGAMinimos
    {


        FuncionMinimos funcion;
        delegate void seleccion();
        Random r = new Random();

        public AlgoritmoGAMinimos(FuncionMinimos funcion)
        {
            this.funcion = funcion;
        }

        public delegate List<FuncionMinimos> DelSeleccion(List<FuncionMinimos> poblacion);

        public List<FuncionMinimos> generarPoblacion(int tamPoblacion)
        {
            List<FuncionMinimos> poblacion = new List<FuncionMinimos>();
            for (int i = 0; i < tamPoblacion; i++)
            {
                FuncionMinimos cromosoma = (FuncionMinimos)funcion.Clone();
                poblacion.Add(generarSolucionAleatorio(cromosoma));
            }

            return poblacion;
        }
        public List<FuncionMinimos> MetodoSeleccion(List<FuncionMinimos> poblacion, DelSeleccion metodoSeleccion)
        {
            return metodoSeleccion(poblacion);
        }


      /*  public void GenerarSolucion(int tamPoblacion)
        {
            List<FuncionMinimos> poblacion = new List<FuncionMinimos>();
            for (int i = 0; i < tamPoblacion; i++)
            {
                poblacion.Add((FuncionMinimos)generarSolucionAleatorio(funcion).Clone());
            }
        }*/

        private FuncionMinimos generarSolucionAleatorio(FuncionMinimos funcion)
        {
            FuncionMinimos solucion = funcion;

            //float[] listaDeValoresDeX = new float[NumDimensiones];
            Random rand = new Random();
            for (int i = 0; i < solucion.listaDeValoresDeX.Count; i++)
            {
                float ValorX = (float)(rand.NextDouble() * 20) - 10;
                solucion.listaDeValoresDeX[i] = ValorX;
                //TBEstadoInicial.Text += "   " + ValorX;
            }
            return solucion;
        }
    }
}
