﻿using ProblemasAscensionDeColinas.Resources;
using ProblemasAscensionDeColinas.Resources.GA;
using ProblemasAscensionDeColinas.Resources.SA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProblemasAscensionDeColinas
{
    public partial class frmMochila : Form
    {
        MochilaClass mochila;
        public frmMochila()
        {
            InitializeComponent();
            mochila = new MochilaClass();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (mochila.objetosPosibles.Count <= 0)
            {
                MessageBox.Show("No hay Items", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nupPesoMaximo.Value <= 0)
            {
                MessageBox.Show("El peso maximo soportado por la mochila debe ser mayor a 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nupTemperaturaMin.Value > nupTemperaturaInicial.Value)
            {
                MessageBox.Show("La temperatura inicial debe ser menor a la temperatura final", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            mochila.pesoMaximoPermitido = (int)nupPesoMaximo.Value;

            if (!mochila.pesoItemsPosiblesAceptables())
            {
                MessageBox.Show("Todos los objetos tienen un peso mayor al aceptable", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            AlgortimoGAMochila algortimoGAMochila = new AlgortimoGAMochila(mochila);

            List<MochilaClass> poblacion = algortimoGAMochila.generarPoblacion(10);

            List<MochilaClass> Padres = algortimoGAMochila.MetodoSeleccion(poblacion, MetodosSeleccion.Proporcional);
            List<MochilaClass> HijosCU = MetodosCruzamiento.CruzamientoUniforme(Padres);
            List<MochilaClass> HijosDPX = MetodosCruzamiento.CruzamientoDosPuntos(Padres);
            List<MochilaClass> HijosDPXMutados = MetodosMutacion.MutacionBinaria(HijosDPX, .5);
            List<MochilaClass> PoblacionReemplazada = MetodosReemplazo.Aleatorio(poblacion, HijosDPXMutados);



            rtbSolucion.Text =
                "  Poblacion Inicial :  \n";

            foreach (MochilaClass item in poblacion)
            {
                for (int i = 0; i < item.ObjetosEnMochila.Count; i++)
                {
                    if (item.ObjetosEnMochila[i])
                    {
                        rtbSolucion.Text += (i + 1) + " , ";
                    }
                }

                rtbSolucion.Text += " \n";
            }

            

            rtbSolucion.Text +=
                " \n  Padres con metodo Ruleta  :  \n";
            foreach (MochilaClass item in Padres)
            {
                for (int i = 0; i < item.ObjetosEnMochila.Count; i++)
                {
                    if (item.ObjetosEnMochila[i])
                    {
                        rtbSolucion.Text += (i + 1) + " , ";
                    }
                }

                rtbSolucion.Text += " \n";
            }

            
            rtbSolucion.Text +=
              " \n  Hijos con Cruzamiento Uniforme:  \n";
            foreach (MochilaClass item in HijosCU)
            {
                for (int i = 0; i < item.ObjetosEnMochila.Count; i++)
                {
                    if (item.ObjetosEnMochila[i])
                    {
                        rtbSolucion.Text += (i + 1) + " , ";
                    }
                }

                rtbSolucion.Text += " \n";
            }


            rtbSolucion.Text +=
              " \n  Hijos con Cruzamiento Dos Cortes:  \n";
            foreach (MochilaClass item in HijosDPX)
            {
                for (int i = 0; i < item.ObjetosEnMochila.Count; i++)
                {
                    if (item.ObjetosEnMochila[i])
                    {
                        rtbSolucion.Text += (i + 1) + " , ";
                    }
                }

                rtbSolucion.Text += " \n";
            }


            rtbSolucion.Text +=
             " \n  Hijos con Cruzamiento Dos Cortes Mutados:  \n";
            foreach (MochilaClass item in HijosDPXMutados)
            {
                for (int i = 0; i < item.ObjetosEnMochila.Count; i++)
                {
                    if (item.ObjetosEnMochila[i])
                    {
                        rtbSolucion.Text += (i + 1) + " , ";
                    }
                }

                rtbSolucion.Text += " \n";
            }

            rtbSolucion.Text +=
             " \n  Reemplazo Aleatorio:  \n";
            foreach (MochilaClass item in PoblacionReemplazada)
            {
                for (int i = 0; i < item.ObjetosEnMochila.Count; i++)
                {
                    if (item.ObjetosEnMochila[i])
                    {
                        rtbSolucion.Text += (i + 1) + " , ";
                    }
                }

                rtbSolucion.Text += " \n";
            }

            return;
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            if (nupPesoItem.Value <= 0 || nupValorItem.Value <= 0 )
            {
                MessageBox.Show("El peso/valor del item debe ser mayor a 0" , "ERROR" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int peso = (int)nupPesoItem.Value;
            int valor = (int)nupValorItem.Value;
            int[,] item = { { peso, valor } };

            mochila.agregarObjetoPosible( item );
            UpdateItemsListBox();
        }


        void UpdateItemsListBox()
        {
            listbItems.Items.Clear();
            ArrayList objetos = mochila.objetosPosibles;

            for (int i = 0; i < objetos.Count; i++)
            {
                int[,] item = (int[,])objetos[i];
                listbItems.Items.Add("ITEM " + (i + 1) +" : PESO " + item[0,0] + " , VALOR " + item[0,1]);
            }
        }

        private void btnEliminarTodosItems_Click(object sender, EventArgs e)
        {
            mochila.eliminarTodosObjetoPosibles();
            UpdateItemsListBox();
        }

        private void btnEliminarItem_Click(object sender, EventArgs e)
        {
            int posicion = listbItems.SelectedIndex;

            if (posicion < 0)
            {
                MessageBox.Show("Seleccionar item de la lista a eliminar" , "ERROR" , MessageBoxButtons.OK , MessageBoxIcon.Warning );
                return;
            }

            mochila.eliminarObjetoPosiblePosicion(posicion);
            UpdateItemsListBox();
        }

      
    }
}
