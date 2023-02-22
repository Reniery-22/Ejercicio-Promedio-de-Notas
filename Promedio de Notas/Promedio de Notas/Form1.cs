using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promedio_de_Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxMOD.Clear();
            textBoxNOMBRE.Clear();
            textBoxASIGN.Clear();   
            Nota1.Clear();
            Nota2.Clear();
            Nota3.Clear();  
            Nota4.Clear();
            PROM.Clear();
            labelOBSER.Text = "";
            textBoxID.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
