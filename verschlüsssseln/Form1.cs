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

          // String[] Buch = { "B", "A", "U", "M", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "N", "O", "P", "Q", "R", "S", "T", "V", "W", "X", "Y", "Z" };

            String HH = "BAUMCDEFGHIJKLNOPQRSTVWXYZ";
            Char[] Buch = HH.ToCharArray();


             Wort = Convert.ToString(textBox1.Text);
            Char[] array = Wort.ToCharArray();

           // string[] array = Wort.Split();
            // int index = Array.IndexOf(strings, searchString);

             int[] code = new int[array.Length];
           
           for (int i = 0; i < array.Length; i++)
            {
                code[i] = Array.IndexOf(Buch, array[i]);
           }

            String[] output = new string[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if(code[i] < 10)
                {
                    output[i] = Convert.ToString("0" + code[i]);
                }
                else
                {
                    output[i] = Convert.ToString(code[i]);
                }
            }


            String schluessel = string.Join(" ", output);

            textBox2.Text = Convert.ToString(schluessel);



        }
    }
}
