using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_12._1_Sortering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void SorteraInfogande(int[] lista)
        {
            int i, n;
            int length = lista.Length; if (length < 2) return;
            int temp;

            for (n=1; n<length; n++)
            {
                temp = lista[n];
                i = n-1;

                while (i >= 0 && lista[i] > temp)
                {
                    lista[i+1] = lista[i];
                    i--;
                }
                lista[i+1] = temp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] tal = new int[6];
            tal[0] = int.Parse(tbxTal1.Text);
            tal[1] = int.Parse(tbxTal2.Text);
            tal[2] = int.Parse(tbxTal3.Text);
            tal[3] = int.Parse(tbxTal4.Text);
            tal[4] = int.Parse(tbxTal5.Text);
            tal[5] = int.Parse(tbxTal6.Text);

            SorteraInfogande(tal);

            tbxTal1.Text = tal[0].ToString();
            tbxTal2.Text = tal[1].ToString();
            tbxTal3.Text = tal[2].ToString();
            tbxTal4.Text = tal[3].ToString();
            tbxTal5.Text = tal[4].ToString();
            tbxTal6.Text = tal[5].ToString();





        }
    }
}
