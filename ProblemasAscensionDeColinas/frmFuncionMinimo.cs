using System;
using ProblemasAscensionDeColinas.Resources;
using ProblemasAscensionDeColinas.Resources.GA;
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
        FuncionMinimos funcion;
        public frmFuncionMinimo()
        {
            InitializeComponent();
            funcion = new FuncionMinimos();
        }
       
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            MinFuncion.Text = "";
            TBEstadoInicial.Text = "";
            funcion.NumDimensiones = (int)NumDimensiones.Value;

            funcion.listaDeValoresDeX = new List<float>((int)NumDimensiones.Value);
            AlgoritmoGAMinimos algortimoGAMinimos = new AlgoritmoGAMinimos(funcion);

            List<FuncionMinimos> poblacion = algortimoGAMinimos.generarPoblacion(10);           
            List<FuncionMinimos> Padres = algortimoGAMinimos.MetodoSeleccion(poblacion, MetodosSeleccion.Proporcional);
            //List<FuncionMinimos> Hijos = MetodosCruzamiento.CruzamientoArimetico( Padres );

            rtbMinimos.Text =
                "  Poblacion Inicial :  \n";

            foreach (FuncionMinimos item in poblacion)
            {
               
                for (int i = 0; i < item.listaDeValoresDeX.Count; i++)
                {
                    rtbMinimos.Text += item.listaDeValoresDeX[i] + ", ";
                }

                rtbMinimos.Text += " \n";
            }

            
            rtbMinimos.Text +=
                " \n  Padres con metodo Ruleta :  \n";
            foreach (FuncionMinimos item in Padres)
            {
                for (int i = 0; i < item.listaDeValoresDeX.Count; i++)
                {
                    rtbMinimos.Text += item.listaDeValoresDeX[i] + ", ";
                }

                rtbMinimos.Text += " \n";
            }

            List<FuncionMinimos> Hijos = MetodosCruzamiento.CruzamientoArimetico(Padres);


            rtbMinimos.Text +=
              " \n  Cruce con Arimetico :  \n";
            foreach (FuncionMinimos item in Hijos)
            {
                for (int i = 0; i < item.listaDeValoresDeX.Count; i++)
                {
                    rtbMinimos.Text += item.listaDeValoresDeX[i] + ",";
                }

                rtbMinimos.Text += " \n";
            }
        
        /*float[] bestResult = DoSA((float)nupTemMax.Value, (float)nupTempMin.Value, (float)nupAvalue.Value, (int)NumIteracionMax.Value);
        printBestResult(bestResult);*/
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
        }

        /*public float [] GeneracionAleatoriaEstadoInicial()
        {
            float[] listaDeValoresDeX = new float[(int)NumDimensiones.Value];                          
            Random rand = new Random();
            for (int i = 0; i < listaDeValoresDeX.Length; i++)
            {
                float ValorX = (float)(rand.NextDouble() * 20) -10;
                listaDeValoresDeX[i] = ValorX;
                //TBEstadoInicial.Text += "   " + ValorX;
            }
            TBEstadoInicial.Text += "" + Sumatoria(listaDeValoresDeX);
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

            float X = ValoresdeX[iter];
            X = (float)(X * Math.Sin(X));
            NewListaDeValoresDeX[iter] = X;

            return NewListaDeValoresDeX;
        }

        public float[] solucionVecina(in float[] ValoresdeX)
        {
            Random rand = new Random();
            int iter = rand.Next(0, ValoresdeX.Length);
            float[] NewListaDeValoresDeX = new float[ValoresdeX.Length];

            for (int i = 0; i < ValoresdeX.Length; i++)
            {
                NewListaDeValoresDeX[i] = ValoresdeX[i];
            }

            float X = ValoresdeX[iter];
            X = (float)(X * Math.Sin(X));
            NewListaDeValoresDeX[iter] = X;

            return NewListaDeValoresDeX;
        }/*
        */

        /*
        public void printBestResult (float[] bestResult)
        {
            /*for (int i = 0; i < bestResult.Length; i++)
            {
                MinFuncion.Text += "   " + bestResult[i];
            }
            float f_bestResult = Sumatoria(bestResult);
            MinFuncion.Text = "" + f_bestResult;
        }
        */

       /* public float[] DoRMHC() {

            float[] best_evaluated = GeneracionAleatoriaEstadoInicial();
            float f_best_evaluated = Sumatoria(best_evaluated);

            Random rand = new Random();

            int iter = 0;

            do
            {
                iter++;
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

        public float[] DoSA(float temp_ini, float temp_min, float a, int maximoIteraciones)
        {
           
            double valorRandom;
            int iteracion;
            int contadorInd = 0;
            Random rand = new Random();
            float delta;

            float[] solucionInicial = GeneracionAleatoriaEstadoInicial(); 
            float fsolucionInicial = Sumatoria(solucionInicial); //Evaluacion 1
            contadorInd++;
            do
            {
                iteracion = 0;
                do
                {
                    iteracion++;                                        
                    float[] solucionPrima = solucionVecina(solucionInicial); 
                    float fsolucionPrima = Sumatoria(solucionPrima); // Evaluacion 2
                    contadorInd++;

                    delta = fsolucionPrima - fsolucionInicial;

                    if (delta <= 0)
                    {
                        solucionInicial = solucionPrima;
                        fsolucionInicial = fsolucionPrima;
                    }
                    else
                    {
                        valorRandom = new Random().NextDouble();
                        if (Math.Exp(-delta / temp_ini) > valorRandom)
                        {
                            solucionInicial = solucionPrima;
                            fsolucionInicial = fsolucionPrima;
                        }
                    }
                    
                } while (iteracion <= maximoIteraciones && contadorInd <= 500);

                temp_ini = temp_ini * a; 
            } while (temp_min <= temp_ini && contadorInd <= 500);

            return solucionInicial;           
        }*/
    }
}
