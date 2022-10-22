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
using System.Xml;
using System.Xml.Linq;

namespace _02_29_9_2020_SouboryVíceokenní
{
    public partial class Form2 : Form
    {
        private readonly int body;
        private readonly string zpusob;
        private string nickname;
       // private string password;

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(int body, string zpusob)
        {
            InitializeComponent();
            label4.Text = Convert.ToString(body);
            this.body = body;
            this.zpusob = zpusob;
            button1.Enabled = false;
            if (textBox1.Text != null && textBox2.Text != null)
            {
                button1.Enabled = true;
            }
        }
        [Serializable]
        struct Hrac
        {
            public string nick;
            public int body;
        }


        
        private void button1_Click(object sender, EventArgs e)
        {
            nickname = textBox1.Text;
            //password = textBox2.Text;
            zpusobUlozeni(zpusob);

        }

        private void zpusobUlozeni(string zpusob)
        { 
            switch (zpusob)
            {

                case "textovy":
                    StreamWriter sw;
                    sw = new StreamWriter("Body.txt", true);
                    sw.WriteLine(nickname + " " + Convert.ToString(body));
                    sw.Close();
                    break;



                case "binarni":
                    Hrac h;
                    h.nick = nickname;
                    h.body = body;
                    FileStream fs = new FileStream("Body2.dat", FileMode.Append);
                    System.Runtime.Serialization.Formatters.Binary.BinaryFormatter output =
                    new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    output.Serialize(fs, h);
                    fs.Close();
                    break;



                case "xml":
                    if (File.Exists("body.xml")) 
                    {
                        XDocument xdoc = XDocument.Load("body.xml");
                        XElement hraci = xdoc.Element("hraci");
                        hraci.Add(new XElement("hrac",
                            new XAttribute(nickname, body.ToString())));
                        xdoc.Save("body.xml");
                    }
                    else
                    {

                        XmlWriterSettings settings = new XmlWriterSettings
                        {
                            Indent = true
                        };
                        using (XmlWriter xmlWriter = XmlWriter.Create("body.xml", settings))
                        {
                            xmlWriter.WriteStartDocument();
                            xmlWriter.WriteStartElement("hraci");
                            xmlWriter.WriteEndElement();
                            xmlWriter.WriteEndDocument();
                            xmlWriter.Close();
                        }
                        XDocument xdoc = XDocument.Load("body.xml");
                        XElement hraci = xdoc.Element("hraci");
                        hraci.Add(new XElement("hrac",
                            new XAttribute(nickname, body.ToString())));
                        xdoc.Save("body.xml");
                       
                        
                        /* xmlWriter.WriteStartElement(nickname);
                        xmlWriter.WriteElementString("body", Convert.ToString(body));
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteEndDocument();
                        xmlWriter.Close();*/
                        
                    }
                    break;
            }

            this.Close();
        }

    }
}
