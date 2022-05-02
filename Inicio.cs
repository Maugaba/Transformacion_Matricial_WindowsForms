using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Transformacion_Matricial_WindowsForms
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Senoidal senoidal = new Senoidal();
            senoidal.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Exponencial exponencial = new Exponencial();
            exponencial.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Polinomial polinomial = new Polinomial();
            polinomial.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            double largo = SystemParameters.FullPrimaryScreenHeight;
            double ancho = SystemParameters.FullPrimaryScreenWidth;
            this.Size = new Size(Convert.ToInt32(ancho), Convert.ToInt32(largo));
        }
    }
}
