using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string[] Rim = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I", " " };
        public static int[] Arab = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1, 0 };
        private static readonly int MaxVariant = Rim.Length;
        public static string arab_rim(int N)
        {
            string S = "";
            int I = 0;
            while (N > 0)
            {
                while (Arab[I] <= N)
                {
                    S += Rim[I];
                    N -= Arab[I];
                }
                I++;
            }
            return S;
        }

        public static int arab_rim(string S)
        {
            int I = 0, N = 0;
            string s0 = S;

            while ((S.Length != 0) && (I < MaxVariant))
            {
                while (Rim[I] == S.Substring(0, (Rim[I].Length > S.Length ? S.Length : Rim[I].Length)).ToUpper())
                {
                    S = S.Substring(0 + Rim[I].Length);
                    N += Arab[I];
                }
                I++;
            }
            return N;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt16(textBox1.Text);
            textBox2.Text = arab_rim(input);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = textBox3.Text;
            textBox4.Text = Convert.ToString(arab_rim(input));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
