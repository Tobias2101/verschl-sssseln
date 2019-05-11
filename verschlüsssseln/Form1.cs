using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace verschlüsssseln
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Wort; 

            int B = 00, A = 01, U = 02, M = 03, D = 04, E = 05, F = 06, G = 07, H = 08, I = 09, J = 10, K = 11, L = 12, N = 13, O = 14, P = 15, Q = 16, R = 17, S = 18, T = 19, V = 20, W = 21, X = 22, Y = 23, Z = 24;

            Wort = Convert.ToString(textBox1.Text);

            char[] array = Wort.ToCharArray();


            for (int i = 0; i < array.Length; i++)
            {

                array[i] = array[i];



            }




            textBox2.Text = Convert.ToString(array[0]);

        }
    }
}
