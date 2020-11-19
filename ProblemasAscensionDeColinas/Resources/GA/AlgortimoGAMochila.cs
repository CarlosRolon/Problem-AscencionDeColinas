using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemasAscensionDeColinas.Resources.GA
{
    public class AlgortimoGAMochila
    {
        MochilaClass mochila;
        delegate void seleccion();
        Random r = new Random();

        public AlgortimoGAMochila(MochilaClass mochila)
        {
            this.mochila = mochila;
        }

        public delegate List<MochilaClass> DelSeleccion(List<MochilaClass> poblacion);
        public delegate void x();

        public List<MochilaClass> generarPoblacion(int tamPoblacion)
        {
            List<MochilaClass> poblacion = new List<MochilaClass>();
            for (int i = 0; i < tamPoblacion; i++)
            {
                MochilaClass cromosoma = (MochilaClass)mochila.Clone();
                poblacion.Add( generarSolucionAleatorio(cromosoma) );
            }

            return poblacion;
        }
        public List<MochilaClass> MetodoSeleccion(List<MochilaClass> poblacion, DelSeleccion metodoSeleccion)
        { 
            return metodoSeleccion(poblacion);
        }


        public void GenerarSolucion( int tamPoblacion )
        {
            List<MochilaClass> poblacion = new List<MochilaClass>();
            for (int i = 0; i < tamPoblacion; i++)
            {                
                poblacion.Add((MochilaClass)generarSolucionAleatorio(mochila).Clone());
            }
        } 

        private MochilaClass generarSolucionAleatorio(MochilaClass mochila)
        {
            MochilaClass solucion = mochila;
            
            bool valorAleatorio;
            do
            {                
                for (int i = 0; i < solucion.ObjetosEnMochila.Count; i++)
                {
                    valorAleatorio = r.NextDouble() < .5;
                    solucion.ObjetosEnMochila[i] = valorAleatorio;
                }
            } while ( mochila.pesoEnMochila > mochila.pesoMaximoPermitido);

            return solucion;
        }
    }
}
