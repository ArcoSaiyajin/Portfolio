using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Carlo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int pocetBodu, polomer;
        int bodVnitr;
        List<Point> bodyVnit = new List<Point>();
        List<Point> bodyVnej = new List<Point>();

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g3 = CreateGraphics();

            //g3.DrawRectangle(new Pen(Color.Black, 3), 50, 50, 300, 300);
            //g3.DrawEllipse(new Pen(Color.Salmon, 3), 50, 50, 300, 300);

            //foreach (Point bod in bodyVnit)
            //{
            //    g3.DrawRectangle(new Pen(Color.Green), bod.X, bod.Y, 1, 1);
            //}

            //foreach (Point bod2 in bodyVnej)
            //{
            //    g3.DrawRectangle(new Pen(Color.Blue), bod2.X, bod2.Y, 1, 1);
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            g.Clear(this.BackColor);
            g.DrawRectangle(new Pen(Color.Black, 3), 50, 50, 300, 300);
            g.DrawEllipse(new Pen(Color.Salmon, 3), 50, 50, 300, 300);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bodVnitr = 0;
            polomer = 0;
            pocetBodu = 0;
     
            try
            {
                pocetBodu = Convert.ToInt32(textBox1.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nZadejte celé číslo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Graphics g2 = CreateGraphics();
            g2.Clear(this.BackColor);
            button1_Click(sender, null);
            Pen p;
            Random r = new Random();

            for (int i = 0; i < pocetBodu; i++)
            {
                int nahodnyX = r.Next(50, 351);
                int nahodnyY = r.Next(50, 351);
                // stred je (200,200)
                polomer = (int) (Math.Sqrt(Math.Pow(nahodnyX - 200, 2) + Math.Pow(nahodnyY - 200, 2)));

                if(polomer <= 150)
                {
                    bodVnitr++;
                    p = new Pen(Color.Green);
                    bodyVnit.Add(new Point(nahodnyX, nahodnyY));
                }
                else
                {
                    p = new Pen(Color.Blue);
                    bodyVnej.Add(new Point(nahodnyX, nahodnyY));
                }

                g2.DrawRectangle(p, nahodnyX, nahodnyY, 1, 1);
                
            }

            label2.Text = "PI je : " + (double)(4 * bodVnitr) / pocetBodu;

        }
    }
}
