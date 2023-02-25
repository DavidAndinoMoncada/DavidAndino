using System;
using System.Windows.Forms;

namespace DavidAndino
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Ejecutarbutton_Click(object sender, EventArgs e)
        {
            double Capital = 200000;
            double i = 0.015;
            double t = 0;
            double I;
            double NuevoCapital;


            for (double a = 1; a < 13; a++)
            {

                t++;

                if (a == 1)
                {
                    listBox1.Items.Add("Enero");
                    listBox1.Items.Add(I = Capital * i * t);
                    NuevoCapital = Capital + I;
                    Capital = Capital + I;
                }

                if (a == 2)
                {
                    listBox1.Items.Add("");
                    listBox1.Items.Add("Febrero");
                    listBox1.Items.Add(I = Capital * i * t);
                    NuevoCapital = Capital + I;
                    Capital = Capital + I;
                }

                if (a == 3)
                {
                    listBox1.Items.Add("");
                    listBox1.Items.Add("Marzo");
                    listBox1.Items.Add(I = Capital * i * t);
                    NuevoCapital = Capital + I;
                    Capital = Capital + I;
                }

                if (a == 4)
                {
                    listBox1.Items.Add("");
                    listBox1.Items.Add("Abril");
                    listBox1.Items.Add(I = Capital * i * t);
                    NuevoCapital = Capital + I;
                    Capital = Capital + I;
                }

                if (a == 5)
                {
                    listBox1.Items.Add("");
                    listBox1.Items.Add("Mayo");
                    listBox1.Items.Add(I = Capital * i * t);
                    NuevoCapital = Capital + I;
                    Capital = Capital + I;
                }

                if (a == 6)
                {
                    listBox1.Items.Add("");
                    listBox1.Items.Add("Junio");
                    listBox1.Items.Add(I = Capital * i * t);
                    NuevoCapital = Capital + I;
                    Capital = Capital + I;
                }

                if (a == 7)
                {
                    listBox1.Items.Add("");
                    listBox1.Items.Add("Julio");
                    listBox1.Items.Add(I = Capital * i * t);
                    NuevoCapital = Capital + I;
                    Capital = Capital + I;
                }

                if (a == 8)
                {
                    listBox1.Items.Add("");
                    listBox1.Items.Add("Agosto");
                    listBox1.Items.Add(I = Capital * i * t);
                    NuevoCapital = Capital + I;
                    Capital = Capital + I;
                }

                if (a == 9)
                {
                    listBox1.Items.Add("");
                    listBox1.Items.Add("Septiembre");
                    listBox1.Items.Add(I = Capital * i * t);
                    NuevoCapital = Capital + I;
                    Capital = Capital + I;
                }

                if (a == 10)
                {
                    listBox1.Items.Add("");
                    listBox1.Items.Add("Octubre");
                    listBox1.Items.Add(I = Capital * i * t);
                    NuevoCapital = Capital + I;
                    Capital = Capital + I;
                }

                if (a == 11)
                {
                    listBox1.Items.Add("");
                    listBox1.Items.Add("Noviembre");
                    listBox1.Items.Add(I = Capital * i * t);
                    NuevoCapital = Capital + I;
                    Capital = Capital + I;
                }

                if (a == 12)
                {
                    listBox1.Items.Add("");
                    listBox1.Items.Add("Diciembre");
                    listBox1.Items.Add(I = Capital * i * t);
                    NuevoCapital = Capital + I;
                    Capital = Capital + I;
                }

            }
        }
    }
}
