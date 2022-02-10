using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._12_Bubbelsortering
{
    public partial class Form1 : Form
    {
        int[] tal = new int[300];
        Random generator = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Point origo = new Point(80, 180);

            e.Graphics.DrawLine(Pens.Black, origo.X, origo.Y, origo.X + tal.Length, origo.Y);
            e.Graphics.DrawLine(Pens.Black, origo.X, origo.Y, origo.X, origo.Y -100);

            for (int i = 0; i < tal.Length; i++)
            {
                e.Graphics.FillEllipse(Brushes.Blue, origo.X + i, origo.Y - tal[i], 2, 2);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i< tal.Length; i++)
            {
                tal[i] = generator.Next(1, 101);
            }
            Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bubbelsortera(tal);
            Invalidate();
        }
    }
}
