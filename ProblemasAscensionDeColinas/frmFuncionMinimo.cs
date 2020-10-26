﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProblemasAscensionDeColinas
{
    public partial class frmFuncionMinimo : Form
    {
        public frmFuncionMinimo()
        {
            InitializeComponent();
            
        }
       
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            MinFuncion.Text = "";
            TBEstadoInicial.Text = "";
            float[] bestResult = DoRMHC();
            printBestResult(bestResult);
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
        }

        public float [] GeneracionAleatoriaEstadoInicial()
        {
            float[] listaDeValoresDeX = new float[(int)NumDimensiones.Value];                          
            Random rand = new Random();
            for (int i = 0; i < listaDeValoresDeX.Length; i++)
            {
                int ValorX = rand.Next(-10, 10);
                listaDeValoresDeX[i] = ValorX;
                TBEstadoInicial.Text += "   " + ValorX;
            }

            return listaDeValoresDeX;
        }

        public float Sumatoria (float[] listaDeValoresDeX)
        {
            float suma =0;

            for (int i = 0; i < listaDeValoresDeX.Length; i++)
            {
                suma += (listaDeValoresDeX[i])* (listaDeValoresDeX[i]);
            }


            return suma;
        }

        public float[] MutarEstadoInicial(in float[] ValoresdeX, int iter) {

            Random rand = new Random();
            float[] NewListaDeValoresDeX = new float[ValoresdeX.Length];

            for (int i = 0; i < ValoresdeX.Length; i++)
            {
                NewListaDeValoresDeX[i] = ValoresdeX[i];
            }
            //NewListaDeValoresDeX = ValoresdeX;

            float ValorX = rand.Next(-10, 10);
            NewListaDeValoresDeX[iter] = ValorX;

            return NewListaDeValoresDeX;
        }

        public void printBestResult (float[] bestResult)
        {
            for (int i = 0; i < bestResult.Length; i++)
            {
                MinFuncion.Text += "   " + bestResult[i];
            }
        }

        public float[] DoRMHC() {

            float[] best_evaluated = GeneracionAleatoriaEstadoInicial();
            float f_best_evaluated = Sumatoria(best_evaluated);

            Random rand = new Random();
            //int locus = rand.Next(0, best_evaluated.Length-1);

            int iter = 0;

            do
            {
                iter++;
                //int locus = best_evaluated[posicion];
                int locus = rand.Next(0, best_evaluated.Length);
                float[] new_best_evaluated = MutarEstadoInicial(best_evaluated, locus);
                float new_f_best_evaluated = Sumatoria(new_best_evaluated);

                if (new_f_best_evaluated <= f_best_evaluated)
                {
                    best_evaluated = new_best_evaluated;
                    f_best_evaluated = new_f_best_evaluated;

                }
                if (f_best_evaluated == 0)
                {
                    IterRealizadas.Text = "" + iter;
                    break;
                }

            } while ( iter < NumIteracionMax.Value);

            return best_evaluated;
        }


    }
}
