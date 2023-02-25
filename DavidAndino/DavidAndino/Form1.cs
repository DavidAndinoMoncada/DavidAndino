using System;
using System.Windows.Forms;

namespace DavidAndino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formulario1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form1 = new Form2();
            form1.Show();
        }

        private void foemulario2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form2 = new Form3();
            form2.Show();
        }

        private void formulario3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form3 = new Form4();
            form3.Show();
        }
    }
}
