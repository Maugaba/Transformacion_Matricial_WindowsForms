﻿using System;
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

            double[] MatrizTraslacionRotacion = {Math.Cos((SliderGrado.Value * Math.PI / 180)), -Math.Sin((SliderGrado.Value * Math.PI / 180)), SliderX.Value* Math.Cos((SliderGrado.Value * Math.PI / 180)) - SliderY.Value * Math.Sin((SliderGrado.Value * Math.PI / 180)),
                                                Math.Sin((SliderGrado.Value* Math.PI / 180)), Math.Cos((SliderGrado.Value* Math.PI / 180)), SliderY.Value* Math.Cos((SliderGrado.Value* Math.PI / 180)) + SliderX.Value * Math.Sin((SliderGrado.Value* Math.PI / 180)),
                                                0,0,1};
            double[] vector1 = { 0, 1, 1 };
            double[] vector2 = { -2, 0.00033, 1 };
            double[] vector3 = { 2, 2980, 1 };

            double[] vector4 = { MatrizTraslacionRotacion[0] * vector1[0] + MatrizTraslacionRotacion[1] * vector1[1] + MatrizTraslacionRotacion[2] * vector1[2], MatrizTraslacionRotacion[3] * vector1[0] + MatrizTraslacionRotacion[4] * vector1[1] + MatrizTraslacionRotacion[5] * vector1[2] };
            double[] vector5 = { MatrizTraslacionRotacion[0] * vector2[0] + MatrizTraslacionRotacion[1] * vector2[1] + MatrizTraslacionRotacion[2] * vector2[2], MatrizTraslacionRotacion[3] * vector2[0] + MatrizTraslacionRotacion[4] * vector2[1] + MatrizTraslacionRotacion[5] * vector2[2] };
            double[] vector6 = { MatrizTraslacionRotacion[0] * vector3[0] + MatrizTraslacionRotacion[1] * vector3[1] + MatrizTraslacionRotacion[2] * vector3[2], MatrizTraslacionRotacion[3] * vector3[0] + MatrizTraslacionRotacion[4] * vector3[1] + MatrizTraslacionRotacion[5] * vector3[2] };

            textBox1.Text = vector4[0].ToString();
            textBox2.Text = vector4[1].ToString();
            textBox3.Text = vector5[0].ToString();
            textBox4.Text = vector5[1].ToString();
            textBox5.Text = vector6[0].ToString();
            textBox6.Text = vector6[1].ToString();
        }

        private void SliderX_Scroll(object sender, EventArgs e)
        {
            label1.Text = SliderX.Value.ToString();
            double[] MatrizTraslacionRotacion = {Math.Cos((SliderGrado.Value * Math.PI / 180)), -Math.Sin((SliderGrado.Value * Math.PI / 180)), SliderX.Value* Math.Cos((SliderGrado.Value * Math.PI / 180)) - SliderY.Value * Math.Sin((SliderGrado.Value * Math.PI / 180)),
                                                Math.Sin((SliderGrado.Value* Math.PI / 180)), Math.Cos((SliderGrado.Value* Math.PI / 180)), SliderY.Value* Math.Cos((SliderGrado.Value* Math.PI / 180)) + SliderX.Value * Math.Sin((SliderGrado.Value* Math.PI / 180)),
                                                0,0,1};
            double[] vector1 = { 0, 1, 1 };
            double[] vector2 = { -2, 0.00033, 1 };
            double[] vector3 = { 2, 2980, 1 };

            double[] vector4 = { MatrizTraslacionRotacion[0] * vector1[0] + MatrizTraslacionRotacion[1] * vector1[1] + MatrizTraslacionRotacion[2] * vector1[2], MatrizTraslacionRotacion[3] * vector1[0] + MatrizTraslacionRotacion[4] * vector1[1] + MatrizTraslacionRotacion[5] * vector1[2] };
            double[] vector5 = { MatrizTraslacionRotacion[0] * vector2[0] + MatrizTraslacionRotacion[1] * vector2[1] + MatrizTraslacionRotacion[2] * vector2[2], MatrizTraslacionRotacion[3] * vector2[0] + MatrizTraslacionRotacion[4] * vector2[1] + MatrizTraslacionRotacion[5] * vector2[2] };
            double[] vector6 = { MatrizTraslacionRotacion[0] * vector3[0] + MatrizTraslacionRotacion[1] * vector3[1] + MatrizTraslacionRotacion[2] * vector3[2], MatrizTraslacionRotacion[3] * vector3[0] + MatrizTraslacionRotacion[4] * vector3[1] + MatrizTraslacionRotacion[5] * vector3[2] };

            textBox1.Text = vector4[0].ToString();
            textBox2.Text = vector4[1].ToString();
            textBox3.Text = vector5[0].ToString();
            textBox4.Text = vector5[1].ToString();
            textBox5.Text = vector6[0].ToString();
            textBox6.Text = vector6[1].ToString();
        }

        private void SliderY_Scroll(object sender, EventArgs e)
        {
            label2.Text = SliderY.Value.ToString();
            double[] MatrizTraslacionRotacion = {Math.Cos((SliderGrado.Value * Math.PI / 180)), -Math.Sin((SliderGrado.Value * Math.PI / 180)), SliderX.Value* Math.Cos((SliderGrado.Value * Math.PI / 180)) - SliderY.Value * Math.Sin((SliderGrado.Value * Math.PI / 180)),
                                                Math.Sin((SliderGrado.Value* Math.PI / 180)), Math.Cos((SliderGrado.Value* Math.PI / 180)), SliderY.Value* Math.Cos((SliderGrado.Value* Math.PI / 180)) + SliderX.Value * Math.Sin((SliderGrado.Value* Math.PI / 180)),
                                                0,0,1};
            double[] vector1 = { 0, 1, 1 };
            double[] vector2 = { -2, 0.00033, 1 };
            double[] vector3 = { 2, 2980, 1 };

            double[] vector4 = { MatrizTraslacionRotacion[0] * vector1[0] + MatrizTraslacionRotacion[1] * vector1[1] + MatrizTraslacionRotacion[2] * vector1[2], MatrizTraslacionRotacion[3] * vector1[0] + MatrizTraslacionRotacion[4] * vector1[1] + MatrizTraslacionRotacion[5] * vector1[2] };
            double[] vector5 = { MatrizTraslacionRotacion[0] * vector2[0] + MatrizTraslacionRotacion[1] * vector2[1] + MatrizTraslacionRotacion[2] * vector2[2], MatrizTraslacionRotacion[3] * vector2[0] + MatrizTraslacionRotacion[4] * vector2[1] + MatrizTraslacionRotacion[5] * vector2[2] };
            double[] vector6 = { MatrizTraslacionRotacion[0] * vector3[0] + MatrizTraslacionRotacion[1] * vector3[1] + MatrizTraslacionRotacion[2] * vector3[2], MatrizTraslacionRotacion[3] * vector3[0] + MatrizTraslacionRotacion[4] * vector3[1] + MatrizTraslacionRotacion[5] * vector3[2] };

            textBox1.Text = vector4[0].ToString();
            textBox2.Text = vector4[1].ToString();
            textBox3.Text = vector5[0].ToString();
            textBox4.Text = vector5[1].ToString();
            textBox5.Text = vector6[0].ToString();
            textBox6.Text = vector6[1].ToString();
        }

        private void SliderGrado_Scroll(object sender, EventArgs e)
        {
            label3.Text = SliderGrado.Value.ToString();
            double[] MatrizTraslacionRotacion = {Math.Cos((SliderGrado.Value * Math.PI / 180)), -Math.Sin((SliderGrado.Value * Math.PI / 180)), SliderX.Value* Math.Cos((SliderGrado.Value * Math.PI / 180)) - SliderY.Value * Math.Sin((SliderGrado.Value * Math.PI / 180)),
                                                Math.Sin((SliderGrado.Value* Math.PI / 180)), Math.Cos((SliderGrado.Value* Math.PI / 180)), SliderY.Value* Math.Cos((SliderGrado.Value* Math.PI / 180)) + SliderX.Value * Math.Sin((SliderGrado.Value* Math.PI / 180)),
                                                0,0,1};
            double[] vector1 = { 0, 1, 1 };
            double[] vector2 = { -2, 0.00033, 1 };
            double[] vector3 = { 2, 2980, 1 };

            double[] vector4 = { MatrizTraslacionRotacion[0] * vector1[0] + MatrizTraslacionRotacion[1] * vector1[1] + MatrizTraslacionRotacion[2] * vector1[2], MatrizTraslacionRotacion[3] * vector1[0] + MatrizTraslacionRotacion[4] * vector1[1] + MatrizTraslacionRotacion[5] * vector1[2] };
            double[] vector5 = { MatrizTraslacionRotacion[0] * vector2[0] + MatrizTraslacionRotacion[1] * vector2[1] + MatrizTraslacionRotacion[2] * vector2[2], MatrizTraslacionRotacion[3] * vector2[0] + MatrizTraslacionRotacion[4] * vector2[1] + MatrizTraslacionRotacion[5] * vector2[2] };
            double[] vector6 = { MatrizTraslacionRotacion[0] * vector3[0] + MatrizTraslacionRotacion[1] * vector3[1] + MatrizTraslacionRotacion[2] * vector3[2], MatrizTraslacionRotacion[3] * vector3[0] + MatrizTraslacionRotacion[4] * vector3[1] + MatrizTraslacionRotacion[5] * vector3[2] };

            textBox1.Text = vector4[0].ToString();
            textBox2.Text = vector4[1].ToString();
            textBox3.Text = vector5[0].ToString();
            textBox4.Text = vector5[1].ToString();
            textBox5.Text = vector6[0].ToString();
            textBox6.Text = vector6[1].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}