using System;
using System.Windows.Forms;

namespace DavidAndino
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Ejecutarbutton_Click(object sender, EventArgs e)
        {

            for (int i = 1; i < 101; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    listBox1.Items.Add("David Andino");
                }
                else
                {
                    if (i % 3 == 0)
                    {
                        listBox1.Items.Add("David");
                    }
                    else
                    {
                        if (i % 5 == 0)
                        {
                            listBox1.Items.Add("Andino");
                        }
                        else
                        {
                            listBox1.Items.Add(i);
                        }
                    }
                }

            }
        }
    }
}
