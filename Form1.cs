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

            multiplicaciones();
        }

        private void SliderX_Scroll(object sender, EventArgs e)
        {
            label1.Text = SliderX.Value.ToString();
            multiplicaciones();
        }

        private void SliderY_Scroll(object sender, EventArgs e)
        {
            label2.Text = SliderY.Value.ToString();
            multiplicaciones();
        }

        private void SliderGrado_Scroll(object sender, EventArgs e)
        {
            label3.Text = SliderGrado.Value.ToString();
            multiplicaciones();
            
            

        }

        void graficar(double[] vector4, double[] vector5, double[] vector6 )
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


        }
        void cruzPrincipal()
        {
            float x1 = this.Width / 2;
            float y1 = this.Height / 2;
            Graphics cruz = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Black, 3);
            cruz.DrawLine(pen, x1 - 300, y1, x1 + 300, y1);
            cruz.DrawLine(pen, x1, y1 + 250, x1, y1 - 250);

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        void multiplicaciones()
        {
            double[] MatrizTraslacionRotacion = {Math.Cos((SliderGrado.Value * Math.PI / 180)), -Math.Sin((SliderGrado.Value * Math.PI / 180)), SliderX.Value* Math.Cos((SliderGrado.Value * Math.PI / 180)) - SliderY.Value * Math.Sin((SliderGrado.Value * Math.PI / 180)),
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
            graficar(vector4, vector5, vector6);


        }
    }
}
