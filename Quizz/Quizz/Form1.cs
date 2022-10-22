using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int q = 0;
        int score = 0;
        string pathToJSON = "AJ.json";
        string AJ,IT,ZM;
        Quizz Q;
        private void Form1_Load(object sender, EventArgs e)
        {
            switch(pathToJSON)
            {
                case "AJ.json":
                    AJ = File.ReadAllText(pathToJSON);
                    Q = JsonConvert.DeserializeObject<Quizz>(AJ);
                    break;
                case "IT.json":
                    IT = File.ReadAllText(pathToJSON);
                    Q = JsonConvert.DeserializeObject<Quizz>(IT);
                    break;
                case "ZM.json":
                    ZM = File.ReadAllText(pathToJSON);
                    Q = JsonConvert.DeserializeObject<Quizz>(ZM);
                    break;
            }

                
            
            quizzLoad();

        }


        void quizzLoad()
        {
            if(q > 4)
            {
                Score_label.Text = $"Score: {score}" + " /5";
                MessageBox.Show("Please choose another quizz.", "You have reached the end!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
             else
            {
                Question_label.Text = Q.Questions[q];
                switch (q)
                {
                    case 0:
                        A1_button.Text = Q.A1[0];
                        A2_button.Text = Q.A1[1];
                        A3_button.Text = Q.A1[2];
                        A4_button.Text = Q.A1[3];
                        break;
                    case 1:
                        A1_button.Text = Q.A2[0];
                        A2_button.Text = Q.A2[1];
                        A3_button.Text = Q.A2[2];
                        A4_button.Text = Q.A2[3];
                        break;
                    case 2:
                        A1_button.Text = Q.A3[0];
                        A2_button.Text = Q.A3[1];
                        A3_button.Text = Q.A3[2];
                        A4_button.Text = Q.A3[3];
                        break;
                    case 3:
                        A1_button.Text = Q.A4[0];
                        A2_button.Text = Q.A4[1];
                        A3_button.Text = Q.A4[2];
                        A4_button.Text = Q.A4[3];
                        break;
                    case 4:
                        A1_button.Text = Q.A5[0];
                        A2_button.Text = Q.A5[1];
                        A3_button.Text = Q.A5[2];
                        A4_button.Text = Q.A5[3];
                        break;
                }


                
            }
           
        }

        void resultCheck(string buttonText)
        {
            switch(pathToJSON)
            {
                case "AJ.json":
                    switch (q)
                    {
                        case 0:
                            if (buttonText == Q.A1[3].ToString()) score++;
                            q++;
                            quizzLoad();
                            break;
                        case 1:
                            if (buttonText == Q.A2[1].ToString()) score++;
                            q++;
                            quizzLoad();
                            break;
                        case 2:
                            if (buttonText == Q.A3[0].ToString()) score++;
                            q++;
                            quizzLoad();
                            break;
                        case 3:
                            if (buttonText == Q.A4[2].ToString()) score++;
                            q++;
                            quizzLoad();
                            break;
                        case 4:
                            if (buttonText == Q.A5[3].ToString()) score++;
                            q++;
                            quizzLoad();
                            break;
                        default:
                            quizzLoad();
                            break;
                    }
                    break;

                case "IT.json":
                    switch (q)
                    {
                        case 0:
                            if (buttonText == Q.A1[2].ToString()) score++;
                            q++;
                            quizzLoad();
                            break;
                        case 1:
                            if (buttonText == Q.A2[0].ToString()) score++;
                            q++;
                            quizzLoad();
                            break;
                        case 2:
                            if (buttonText == Q.A3[1].ToString()) score++;
                            q++;
                            quizzLoad();
                            break;
                        case 3:
                            if (buttonText == Q.A4[3].ToString()) score++;
                            q++;
                            quizzLoad();
                            break;
                        case 4:
                            if (buttonText == Q.A5[0].ToString()) score++;
                            q++;
                            quizzLoad();
                            break;
                        default:
                            quizzLoad();
                            break;
                    }

                    break;

                case "ZM.json":
                    switch (q)
                    {
                        case 0:
                            if (buttonText == Q.A1[2].ToString()) score++;
                            q++;
                            quizzLoad();
                            break;
                        case 1:
                            if (buttonText == Q.A2[0].ToString()) score++;
                            q++;
                            quizzLoad();
                            break;
                        case 2:
                            if (buttonText == Q.A3[3].ToString()) score++;
                            q++;
                            quizzLoad();
                            break;
                        case 3:
                            if (buttonText == Q.A4[1].ToString()) score++;
                            q++;
                            quizzLoad();
                            break;
                        case 4:
                            if (buttonText == Q.A5[0].ToString()) score++;
                            q++;
                            quizzLoad();
                            break;
                        default:
                            quizzLoad();
                            break;
                    }
                    break;
            }

           
        }

        private void A1_button_Click(object sender, EventArgs e)
        {
            
            resultCheck(A1_button.Text);
        }

        private void A2_button_Click(object sender, EventArgs e)
        {
            resultCheck(A2_button.Text);
        }

        private void A3_button_Click(object sender, EventArgs e)
        {
            resultCheck(A3_button.Text);
        }

        private void A4_button_Click(object sender, EventArgs e)
        {
            resultCheck(A4_button.Text);
        }

        private void Quiz1_button_Click(object sender, EventArgs e)
        {
            pathToJSON = "AJ.json";
            q = 0;
            score = 0;
            Form1_Load(null,null);
        }

        private void Quiz2_button_Click(object sender, EventArgs e)
        {
            pathToJSON = "IT.json";
            q = 0;
            score = 0;
            Form1_Load(null, null);
        }

        private void Quiz3_button_Click(object sender, EventArgs e)
        {
            pathToJSON = "ZM.json";
            q = 0;
            score = 0;
            Form1_Load(null, null);
        }
    }
}
