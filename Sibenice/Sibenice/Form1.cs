using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Sibenice
{
  

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Button[] tlacitka;
        string slova,slovo, jmeno;
        slovy js;
        Label[] pismena;
        int pocetPismen;
        int pocetChyb = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
           

            slova = File.ReadAllText("slova.json");
            js = JsonConvert.DeserializeObject<slovy>(slova);
            Random rnd = new Random();
            slovo = js.slova[rnd.Next(10)];

            for (int i = 0; i < pocetPismen; i++)
                pismena[i].Dispose();

            //nadeklarujeme pole popisků pro jednotlivá písmena 
            pismena = new Label[slovo.Length]; //alokace paměti
            for (int i = 0; i < slovo.Length; i++)
            {
                pismena[i] = new Label
                {
                    Parent = this,
                    Width = 30,
                    Height = 30,
                    BackColor = Color.Bisque,
                    Location = new Point(300 + i * 40, 200)
                };
                pismena[0].Text = " "; //znak mezera
            }
            pismena[0].Text = slovo[0].ToString();//první písmeno
            pismena[slovo.Length - 1].Text = slovo[slovo.Length - 1].ToString();//poslední písmeno
            pocetPismen = slovo.Length;

            pictureBox1.Image = null;
            pocetChyb = 0;

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tlacitka = new Button[(int)('Z') - (int)('A') + 1 + 15];

            for (int i = 0; i < (int)('Z') - (int)('A') + 1; i++)
            {
                tlacitka[i] = new Button
                {
                    Parent = this, //tlačítko se bude vykreslovat na formuláři   
                    Width = 30,
                    Height = 30,
                    Location = new Point(250 + 30 * (i % 13), 50 + i / 13 * 50),
                    BackColor = Color.Yellow,
                    ForeColor = Color.Red,
                    Text = ((char)(i + (int)('A'))).ToString()
                };
                tlacitka[i].Click += new EventHandler(Kontrola); 
                //přidáme reakci na kliknutí na tlačítko, ale zatím ji zakomentujeme
            }

            string cestina = "ÁÉÍÓÚŮĚÝŽŠČŘĎŤŇ";

            for (int i = (int)('Z') - (int)('A') + 1; i < (int)('Z') - (int)('A') + 1 + 15; i++)
            {
                tlacitka[i] = new Button
                {
                    Parent = this,
                    Width = 30,
                    Height = 30,
                    Location = new Point(250 + 30 * (i - 26), 150),
                    BackColor = Color.Yellow,
                    ForeColor = Color.Red,
                    Text = cestina[i - 26].ToString()
                };
                tlacitka[i].Click += new EventHandler(Kontrola);
                //přidáme reakci na kliknutí na tlačítko
            }


            Button1_Click(null, null);
        }

        void Kontrola(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Zapomněli jste vyplnit jméno", "Jméno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                jmeno = "Anonym";
            }

            //  (sender as Button).BackColor = Color.White;
            char pismeno = (sender as Button).Text[0];
            for (int i = 0; i < slovo.Length - 1; i++)
            {
                if (slovo[i] == pismeno)
                {
                    pismena[i].Text = pismeno.ToString();
                }
                
               
            }

            if (!slovo.Contains(pismeno))
            {
                Spravne(false);
            }
            Vyhra();

            
        }

        void Obrazek(int pocetChyb)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen peroH = new Pen(Color.Maroon, 10);
            Pen peroM = new Pen(Color.Navy, 10);
            SolidBrush vypln = new SolidBrush(Color.Green);
            //zacatek

             switch(pocetChyb)
             {
                 case 1: g.FillEllipse(vypln, 0, 170, 200, 50); g.DrawLine(peroH, 150, 50, 150, 180); break;
                 case 2: peroH.Width = 3; g.DrawLine(peroH, 130, 50, 150, 70); g.DrawLine(peroH, 50, 50, 50, 70); break;
                 case 3: vypln.Color = Color.Orange; g.FillEllipse(vypln, 43, 70, 13, 13); peroM.Width = 5; g.DrawLine(peroM, 50, 82, 50, 100); break;
                 case 4: peroM.Width = 3; g.DrawLine(peroM, 50, 82, 60, 98); g.DrawLine(peroM, 50, 82, 40, 98); break;
                 case 5: peroH.Width = 3; g.DrawLine(peroM, 50, 96, 60, 120); break;
                 case 6: peroM.Width = 3; g.DrawLine(peroM, 50, 96, 40, 120); break;
                case 7: MessageBox.Show("Prohráli jste", "You lost", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    
                    jmeno = textBox1.Text;
                    Serializace();
                    break;
             }



        }

        void Spravne(bool sp)
        {
            if(!sp)
            {
                pocetChyb += 1;
                Obrazek(pocetChyb);
            }
        }


        void Serializace()
        {
            /* if(File.Exists("hraci.json"))
             {
                 string path = File.ReadAllText("hraci.json");
                 Hraci pridatH = JsonConvert.DeserializeObject<Hraci>(path);

                 pridatH.hrac = jmeno;
                 pridatH.pocetChyb = pocetChyb;
                 pridatH.hledaneSlovo = slovo;


                 string json = JsonConvert.SerializeObject(pridatH);
                 using (var sw = new StreamWriter("hraci.json", true))
                 {
                     sw.WriteLine(json.ToString());
                     sw.Close();
                 }
             }
             else 
             { 
                 Hraci hr = new Hraci();
                 hr.hrac = jmeno;
                 hr.pocetChyb = pocetChyb;
                 hr.hledaneSlovo = slovo;


                 string json = JsonConvert.SerializeObject(hr);
                 using(var sw = new StreamWriter("hraci.json"))
                 {
                     sw.WriteLine(json.ToString());
                     sw.Close();
                 }*/

                        
            StreamWriter sw = new StreamWriter("hraci.txt", true);
            sw.WriteLine($"Hrac: {jmeno} Pocet Chyb: {Convert.ToString(pocetChyb)} Slovo: {slovo}");
            sw.Close();


        
        }


        void Vyhra()
        {
            bool v = false;
            for(int i = 0; i < (slovo.Length - 1); i++)
            {
                if (pismena[i].Text != slovo[i].ToString())
                {
                    v = false;
                    break;
                }

                v = true;
            }
            if(v)
            {
                MessageBox.Show("Vyhráli jste", "You win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Serializace();
            }
           
        }
    }
}
