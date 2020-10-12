using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace ProblemasAscensionDeColinas.Resources
{
    public  class MochilaClass : ICloneable
    {
        public ArrayList objetosPosibles { get ;  set; }

        //private List<Boolean> objetosEnMochila;
        public List<Boolean> ObjetosEnMochila  { get; set; }
        //{  get { return objetosEnMochila.ToList(); } 
        // set { objetosEnMochila = value.ToList<Boolean>(); }  }

        public int pesoMaximoPermitido { get; set; }

        public int valorEnMochila { 
            get {
                int valor = 0;

                for (int i = 0; i < ObjetosEnMochila.Count; i++)
                {
                    if (ObjetosEnMochila[i])
                    {
                        int[,] item = (int[,])objetosPosibles[i];
                        valor += item[0, 1];
                    }
                }
                return valor;
            }
        }

        public int pesoEnMochila
        {
            get
            {
                int valor = 0;

                for (int i = 0; i < ObjetosEnMochila.Count; i++)
                {
                    if (ObjetosEnMochila[i])
                    {
                        int[,] item = (int[,])objetosPosibles[i];
                        valor += item[0, 0];
                    }
                }

                return valor;
            }
        }

        public MochilaClass ()
        {
            objetosPosibles = new ArrayList();
            ObjetosEnMochila = new List<bool>();
        }

        /// <summary>
        /// Saca los objetos dentro de la mochila
        /// </summary>
        public void vaciarMochila()
        {
            for (int i = 0; i < ObjetosEnMochila.Count ; i++)
            {
                ObjetosEnMochila[i] = false;
            }
        }

        public void agregarObjetoPosible(int[,] objeto)
        {
            objetosPosibles.Add(objeto);
            ObjetosEnMochila.Add(false);
        }

        public void eliminarTodosObjetoPosibles()
        {
            objetosPosibles.Clear();
            ObjetosEnMochila.Clear();
        }

        public void eliminarObjetoPosiblePosicion(int pos)
        {
            objetosPosibles.RemoveAt(pos);
            ObjetosEnMochila.RemoveAt(pos);
        }

        /// <summary>
        /// Verifica que todos los items posibles tienen un peso menor o igual al aceptado por la mochila
        /// </summary>
        /// <returns>
        /// True = Existe uno o mas items con peso menor o igual al aceptado por la mochila
        /// False = Todos los items tienen peso mayor al aceptado por la mochila
        /// </returns>
        public bool pesoItemsPosiblesAceptables()
        {
            bool pesoAceptable = false;
            for (int i = 0; i < objetosPosibles.Count; i++)
            {
                int[,] item = (int[,])objetosPosibles[i];
                if ( item[0,0] <= pesoMaximoPermitido)
                {
                    pesoAceptable = true;
                    return true;
                }
            }
            return pesoAceptable;
        }

     
        public void mutarObjetoEnMochila(int pos)
        {
            if (pos < ObjetosEnMochila.Count)
            {
                ObjetosEnMochila[pos] = !ObjetosEnMochila[pos];
            }
        }


        public object Clone()
        {
            object obj = this.MemberwiseClone();
            this.ObjetosEnMochila = ObjetosEnMochila.ToList();
            return obj;
        }


    }



}
