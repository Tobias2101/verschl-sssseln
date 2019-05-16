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
            String Zahl;
            
            Zahl = Convert.ToString(textBox1.Text);

            string delimStr = " ";
            char[] delimiter = delimStr.ToCharArray();
            string[] split = null;
            for (int x = 1; x <= 5; x++)
            {
                split = Zahl.Split(delimiter, x);

            }

            int[] Zahl1 = new int [split.Length];

            for (int i = 0; i < split.Length; i++)
            {
                Zahl1[i] = Convert.ToInt32(split[i]);
            }
            

               String[] Buch = new string[26] { "B", "A", "U", "M", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "N", "O", "P", "Q", "R", "S", "T", "V", "W", "X", "Y", "Z"};

               string[] code = new string[Zahl1.Length];

               for (int i = 0; i < Zahl1.Length; i++)
               {
                   code[i] = Buch[Zahl1[i]];
              }

           

            String schluessel = string.Join(" ", code);

            textBox2.Text = Convert.ToString(schluessel);


        }







        private void button1_Click(object sender, EventArgs e)
        {
           

            String Wort;

            String HH = "BAUMCDEFGHIJKLNOPQRSTVWXYZ";
            Char[] Buch = HH.ToCharArray();


             Wort = Convert.ToString(textBox1.Text);
            Wort = Wort.ToUpper();

            Char[] array = Wort.ToCharArray();

           

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
