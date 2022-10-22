using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_29_9_2020_SouboryVíceokenní
{
    public partial class Form1 : Form
   
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int body;
        Form2 f2;
        private string zpusob;

        private void button1_Click(object sender, EventArgs e)
        {
            zpusob = "textovy";
            if(textBox1.Text == "")
            {
                body = 0;
            }
            else
            {
                body = Convert.ToInt32(textBox1.Text);
            }
            
            f2 = new Form2(body, zpusob);
            f2.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            zpusob = "binarni";
            if (textBox1.Text == "")
            {
                body = 0;
            }
            else
            {
                body = Convert.ToInt32(textBox1.Text);
            }
            f2 = new Form2(body, zpusob);
            f2.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            zpusob = "xml";
            if (textBox1.Text == "")
            {
                body = 0;
            }
            else
            {
                body = Convert.ToInt32(textBox1.Text);
            }
            f2 = new Form2(body, zpusob);
            f2.ShowDialog();

        }
    }
}
