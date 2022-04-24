using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transformacion_Matricial_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SliderX_Scroll(object sender, EventArgs e)
        {
            label1.Text = SliderX.Value.ToString();
            //exponencial();
            //senoidal();
        }

        private void SliderY_Scroll(object sender, EventArgs e)
        {
            label2.Text = SliderY.Value.ToString();
            //exponencial();
            //senoidal();
        }

        private void SliderGrado_Scroll(object sender, EventArgs e)
        {
            label3.Text = SliderGrado.Value.ToString();
            //exponencial();
            //senoidal();
            
            

        }

        /*void graficar(double[,] matriz = new double[99])
        {
            Graphics grafica = this.CreateGraphics();
            grafica.Clear(Form.DefaultBackColor);
            cruzPrincipal();
            Pen lapiz = new Pen(Brushes.Red, 4);
            float desfaseX = Width / 2;
            float desfaseY = (Height / 2);
            grafica.DrawLine(lapiz, 10 * (float)vector4[0] + desfaseX, 10 * (float)vector4[1]*-1 + desfaseY, 10 * (float)vector5[0] + desfaseX, 10 * (float)vector5[1]*-1 + desfaseY);
            lapiz.Color=Color.White;
            grafica.DrawLine(lapiz, 10 * (float)vector5[0] + desfaseX, 10 * (float)vector5[1]*-1 + desfaseY, 10 * (float)vector6[0] + desfaseX, 10 * (float)vector6[1]*-1 + desfaseY);


        }*/
        void cruzPrincipal()
        {
            float x1 = this.Width / 2;
            float y1 = this.Height / 2;
            Graphics cruz = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Black, 3);
            cruz.DrawLine(pen, x1 - 450, y1, x1 + 450, y1);
            cruz.DrawLine(pen, x1, y1 + 400, x1, y1 - 400);

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        void multiplicaciones()
        {
            /*double[] MatrizTraslacionRotacion = {Math.Cos((SliderGrado.Value * Math.PI / 180)), -Math.Sin((SliderGrado.Value * Math.PI / 180)), SliderX.Value* Math.Cos((SliderGrado.Value * Math.PI / 180)) - SliderY.Value * Math.Sin((SliderGrado.Value * Math.PI / 180)),
                                                Math.Sin((SliderGrado.Value* Math.PI / 180)), Math.Cos((SliderGrado.Value* Math.PI / 180)), SliderY.Value* Math.Cos((SliderGrado.Value* Math.PI / 180)) + SliderX.Value * Math.Sin((SliderGrado.Value* Math.PI / 180)),
                                                0,0,1};
            double[] vector1 = { -2, 0, 1 };
            double[] vector2 = { 0, 1, 1 };
            double[] vector3 = { 2, 100, 1 };

            double[] vector4 = { MatrizTraslacionRotacion[0] * vector1[0] + MatrizTraslacionRotacion[1] * vector1[1] + MatrizTraslacionRotacion[2] * vector1[2], MatrizTraslacionRotacion[3] * vector1[0] + MatrizTraslacionRotacion[4] * vector1[1] + MatrizTraslacionRotacion[5] * vector1[2] };
            double[] vector5 = { MatrizTraslacionRotacion[0] * vector2[0] + MatrizTraslacionRotacion[1] * vector2[1] + MatrizTraslacionRotacion[2] * vector2[2], MatrizTraslacionRotacion[3] * vector2[0] + MatrizTraslacionRotacion[4] * vector2[1] + MatrizTraslacionRotacion[5] * vector2[2] };
            double[] vector6 = { MatrizTraslacionRotacion[0] * vector3[0] + MatrizTraslacionRotacion[1] * vector3[1] + MatrizTraslacionRotacion[2] * vector3[2], MatrizTraslacionRotacion[3] * vector3[0] + MatrizTraslacionRotacion[4] * vector3[1] + MatrizTraslacionRotacion[5] * vector3[2] };

            textBox1.Text = vector4[0].ToString();
            textBox2.Text = vector4[1].ToString();
            textBox3.Text = vector5[0].ToString();
            textBox4.Text = vector5[1].ToString();
            textBox5.Text = vector6[0].ToString();
            textBox6.Text = vector6[1].ToString();
            graficar(vector4, vector5, vector6);*/


        }
        void senoidal()
        {
            double[] MatrizTraslacionRotacion = {Math.Cos((SliderGrado.Value * Math.PI / 180)), -Math.Sin((SliderGrado.Value * Math.PI / 180)), SliderX.Value* Math.Cos((SliderGrado.Value * Math.PI / 180)) - SliderY.Value * Math.Sin((SliderGrado.Value * Math.PI / 180)),
                                                Math.Sin((SliderGrado.Value* Math.PI / 180)), Math.Cos((SliderGrado.Value* Math.PI / 180)), SliderY.Value* Math.Cos((SliderGrado.Value* Math.PI / 180)) + SliderX.Value * Math.Sin((SliderGrado.Value* Math.PI / 180)),
                                                0,0,1};
            double[,] matriz_grafica = new double[100, 3];
            double[,] matriz_resultado = new double[100, 2];
            double punto1 = 0;
            double punto2 = 0;
            for (int i = 0; i < 65; i++)
            {
                matriz_grafica[i, 0] = punto1;
                matriz_grafica[i, 1] = punto2;
                matriz_grafica[i, 2] = 1;
                if(i < 4)
                {
                    punto1 = punto1 + 0.25;
                    punto2 = punto2 + 0.375;
                }
                if ((i >= 4) && (i<8))
                {
                    punto1 = punto1 + 0.25;
                    punto2 = punto2 + 0.1875;
                }
                if ((i >= 8) && (i < 12))
                {
                    punto1 = punto1 + 0.25;
                    punto2 = punto2 + 0.125;
                }
                if ((i >= 12) && (i < 16))
                {
                    punto1 = punto1 + 0.25;
                    punto2 = punto2 + 0.0625;
                }

                if ((i >= 16) && (i < 20))
                {
                    punto1 = punto1 + 0.25;
                    punto2 = punto2 - 0.0625;
                }
                if ((i >= 20) && (i < 24))
                {
                    punto1 = punto1 + 0.25;
                    punto2 = punto2 - 0.125;
                }
                if ((i >= 24) && (i < 28))
                {
                    punto1 = punto1 + 0.25;
                    punto2 = punto2 - 0.1875;
                }
                if ((i >= 28) && (i < 32))
                {
                    punto1 = punto1 + 0.25;
                    punto2 = punto2 - 0.375;
                }

                if ((i >= 32) && (i < 36))
                {
                    punto1 = punto1 + 0.25;
                    punto2 = punto2 - 0.375;
                }
                if ((i >= 36) && (i < 40))
                {
                    punto1 = punto1 + 0.25;
                    punto2 = punto2 - 0.1875;
                }
                if ((i >= 40) && (i < 44))
                {
                    punto1 = punto1 + 0.25;
                    punto2 = punto2 - 0.125;
                }
                if ((i >= 44) && (i < 48))
                {
                    punto1 = punto1 + 0.25;
                    punto2 = punto2 - 0.0625;
                }

                if ((i >= 48) && (i < 52))
                {
                    punto1 = punto1 + 0.25;
                    punto2 = punto2 + 0.0625;
                }
                if ((i >= 52) && (i < 56))
                {
                    punto1 = punto1 + 0.25;
                    punto2 = punto2 + 0.125;
                }
                if ((i >= 56) && (i < 60))
                {
                    punto1 = punto1 + 0.25;
                    punto2 = punto2 + 0.1875;
                }
                if ((i >= 60) && (i < 64))
                {
                    punto1 = punto1 + 0.25;
                    punto2 = punto2 + 0.375;
                }
            }

            for (int i = 0; i < 65; i++)
            {
                matriz_resultado[i, 0] = MatrizTraslacionRotacion[0] * matriz_grafica[i, 0] + MatrizTraslacionRotacion[1] * matriz_grafica[i, 1] + MatrizTraslacionRotacion[2] * matriz_grafica[i, 2];
                matriz_resultado[i, 1] = MatrizTraslacionRotacion[3] * matriz_grafica[i, 0] + MatrizTraslacionRotacion[4] * matriz_grafica[i, 1] + MatrizTraslacionRotacion[5] * matriz_grafica[i, 2];

            }

            Graphics grafica = this.CreateGraphics();
            grafica.Clear(Form.DefaultBackColor);
            cruzPrincipal();
            Pen lapiz = new Pen(Brushes.Red, 4);
            float desfaseX = Width / 2;
            float desfaseY = (Height / 2);
            for (int i = 0; i < 64; i++)
            {
                grafica.DrawLine(lapiz, 10 * (float)matriz_resultado[i, 0] + desfaseX, 10 * (float)matriz_resultado[i, 1] * -1 + desfaseY, 10 * (float)matriz_resultado[i + 1, 0] + desfaseX, 10 * (float)matriz_resultado[i + 1, 1] * -1 + desfaseY);
            }
        }
        void polinomial()
        {
            double[] MatrizTraslacionRotacion = {Math.Cos((SliderGrado.Value * Math.PI / 180)), -Math.Sin((SliderGrado.Value * Math.PI / 180)), SliderX.Value* Math.Cos((SliderGrado.Value * Math.PI / 180)) - SliderY.Value * Math.Sin((SliderGrado.Value * Math.PI / 180)),
                                                Math.Sin((SliderGrado.Value* Math.PI / 180)), Math.Cos((SliderGrado.Value* Math.PI / 180)), SliderY.Value* Math.Cos((SliderGrado.Value* Math.PI / 180)) + SliderX.Value * Math.Sin((SliderGrado.Value* Math.PI / 180)),
                                                0,0,1};
            double[,] matriz_grafica = new double[100, 3];
            double[,] matriz_resultado = new double[100, 2];
            double punto1 = -5.5;
            double punto2 = 0.00033;
            for (int i = 0; i < 20; i++)
            {
                matriz_grafica[i, 0] = punto1;
                matriz_grafica[i, 1] = punto2;
                matriz_grafica[i, 2] = 1;
                punto1 = punto1 + 0.5;
                punto2 = punto2 * 2.1;
            }

            for (int i = 0; i < 20; i++)
            {
                matriz_resultado[i, 0] = MatrizTraslacionRotacion[0] * matriz_grafica[i, 0] + MatrizTraslacionRotacion[1] * matriz_grafica[i, 1] + MatrizTraslacionRotacion[2] * matriz_grafica[i, 2];
                matriz_resultado[i, 1] = MatrizTraslacionRotacion[3] * matriz_grafica[i, 0] + MatrizTraslacionRotacion[4] * matriz_grafica[i, 1] + MatrizTraslacionRotacion[5] * matriz_grafica[i, 2];

            }

            Graphics grafica = this.CreateGraphics();
            grafica.Clear(Form.DefaultBackColor);
            cruzPrincipal();
            Pen lapiz = new Pen(Brushes.Red, 4);
            float desfaseX = Width / 2;
            float desfaseY = (Height / 2);
            for (int i = 0; i < 19; i++)
            {

                grafica.DrawLine(lapiz, 10 * (float)matriz_resultado[i, 0] + desfaseX, 10 * (float)matriz_resultado[i, 1] * -1 + desfaseY, 10 * (float)matriz_resultado[i + 1, 0] + desfaseX, 10 * (float)matriz_resultado[i + 1, 1] * -1 + desfaseY);
            }
        }
        void exponencial()
        {
            double[] MatrizTraslacionRotacion = {Math.Cos((SliderGrado.Value * Math.PI / 180)), -Math.Sin((SliderGrado.Value * Math.PI / 180)), SliderX.Value* Math.Cos((SliderGrado.Value * Math.PI / 180)) - SliderY.Value * Math.Sin((SliderGrado.Value * Math.PI / 180)),
                                                Math.Sin((SliderGrado.Value* Math.PI / 180)), Math.Cos((SliderGrado.Value* Math.PI / 180)), SliderY.Value* Math.Cos((SliderGrado.Value* Math.PI / 180)) + SliderX.Value * Math.Sin((SliderGrado.Value* Math.PI / 180)),
                                                0,0,1};
            double[,] matriz_grafica = new double[100, 3];
            double[,] matriz_resultado = new double[100, 2];
            double punto1 = -5.5;
            double punto2 = 0.00033;
            for (int i = 0; i < 20; i++)
            {
                matriz_grafica[i, 0] = punto1;
                matriz_grafica[i, 1] = punto2;
                matriz_grafica[i, 2] = 1;
                punto1 = punto1 + 0.5;
                punto2 = punto2 * 2.1;
            }

            for (int i = 0; i < 20; i++)
            {
                matriz_resultado[i, 0] = MatrizTraslacionRotacion[0] * matriz_grafica[i, 0] + MatrizTraslacionRotacion[1] * matriz_grafica[i, 1] + MatrizTraslacionRotacion[2] * matriz_grafica[i, 2];
                matriz_resultado[i, 1] = MatrizTraslacionRotacion[3] * matriz_grafica[i, 0] + MatrizTraslacionRotacion[4] * matriz_grafica[i, 1] + MatrizTraslacionRotacion[5] * matriz_grafica[i, 2];

            }

            Graphics grafica = this.CreateGraphics();
            grafica.Clear(Form.DefaultBackColor);
            cruzPrincipal();
            Pen lapiz = new Pen(Brushes.Red, 4);
            float desfaseX = Width / 2;
            float desfaseY = (Height / 2);
            for(int i = 0; i < 19; i++)
            {
                
                grafica.DrawLine(lapiz, 10 * (float)matriz_resultado[i, 0] + desfaseX, 10 * (float)matriz_resultado[i, 1] * -1 + desfaseY, 10 * (float)matriz_resultado[i+1, 0] + desfaseX, 10 * (float)matriz_resultado[i+1, 1] * -1 + desfaseY);
            }
        }
    }
}
