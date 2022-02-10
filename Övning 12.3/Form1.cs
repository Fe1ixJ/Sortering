using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_12._3
{
    public partial class Form1 : Form
    {
        int[] tal;
        Random generator = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int antal = int.Parse(textBox1.Text);
            tal = new int[antal];

            for (int i = 0; i < tal.Length; i++)
            {
                tal[i] = generator.Next(1, 10001);
                Console.WriteLine(tal[i]);
            }
            btnSearch.Enabled = true;
            btnBinarySearch.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int värde = int.Parse(textBox2.Text);
            int svar = Sök(tal, värde);
            if (svar != -1)
            {
                lblOutPut.Text = "Talet finns i position: " + svar;
            }
            else
            {
                lblOutPut.Text = "ingenträff";
            }
        }
        public int Sök(int[] lista, int värde)
        {
            int index = -1;

            for (int i = 0; i<lista.Length; i++)
            {
                if (lista[i] == värde)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public int BinarySearch(int[] lista, int värde)
        {
            int min = 0;
            int max = lista.Length -1;
            int index = -1;

            while (min <= max && index == -1)
            {
                int mitt = (min+max)/2;

                if (värde > lista[mitt]) min = mitt+1;
                else if (värde < lista[mitt]) max = mitt-1;
                else index = mitt;
            }
            return index;
        }
        public void Bubbelsortera(int[] lista)
        {
            for (int m = lista.Length-1; m>0; m--)
            {
                for (int n = 0; n<m; n++)
                {
                    if (lista[n] > lista[n+1])
                    {
                        int temp = lista[n];
                        lista[n] = lista[n+1];
                        lista[n+1] = temp;
                    }
                }
            }

        }


        private void btnBinarySearch_Click(object sender, EventArgs e)
        {
            Bubbelsortera(tal);
            btnBinarySearch.Enabled = true;
            Invalidate();

            int värde = int.Parse(textBox2.Text);
            int svar = BinarySearch(tal, värde);
            if (svar != -1)
            {
                lblOutPut.Text = "Talet finns i position: " + svar;
            }
            else
            {
                lblOutPut.Text = "ingenträff";
            }
            Invalidate();
        }
    }
}
