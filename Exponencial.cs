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
    public partial class Exponencial : Form
    {
        public Exponencial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void SliderX_Scroll(object sender, EventArgs e)
        {
            label1.Text = SliderX.Value.ToString();
            exponencial();
        }

        private void SliderY_Scroll(object sender, EventArgs e)
        {
            label2.Text = SliderY.Value.ToString();
            exponencial();
        }

        private void SliderGrado_Scroll(object sender, EventArgs e)
        {
            label3.Text = SliderGrado.Value.ToString();
            exponencial();
        }

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
