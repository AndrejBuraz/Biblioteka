using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BibliotekaProjekt
{
    public partial class KnjigeUnos : Form
    {
        public KnjigeUnos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("knjige.xml");
            XmlElement root = doc.DocumentElement;

            XmlNodeList elemList = doc.GetElementsByTagName("knjiga");
            Knjige novaKnjiga = new Knjige(textBoxAutor.Text, textBoxNaslov.Text, textBoxIzdavac.Text, Convert.ToInt32(textBoxKolicina.Text));
            novaKnjiga.ID = Convert.ToString(Convert.ToInt32(elemList[elemList.Count - 1].Attributes[0].Value) + 1);

            if (textBoxID.Text != "")
            {
                for(int j = 0; j < elemList.Count; j++)
                {
                    if(elemList[j].Attributes[0].Value == textBoxID.Text)
                    {
                        MessageBox.Show("ID je već iskorišten!");
                        goto skip;
                    }
                    else{
                        novaKnjiga.ID = textBoxID.Text;
                    }
                }
                
            }

            if(novaKnjiga.Kolicina == 1)
            {
                XmlElement noviElem = doc.CreateElement("knjiga");
                noviElem.SetAttribute("id", novaKnjiga.ID);
                noviElem.SetAttribute("autor", novaKnjiga.autor);
                noviElem.SetAttribute("naslov", novaKnjiga.naslov);
                noviElem.SetAttribute("izdavac", novaKnjiga.izdavac);
                root.AppendChild(noviElem);
                doc.Save("knjige.xml");
            }
            else
            {
                int IDGeneric = Convert.ToInt32(novaKnjiga.ID); 
                for (int i  = 0; i < novaKnjiga.Kolicina; i++)
                {
                    XmlElement noviElem = doc.CreateElement("knjiga");
                    noviElem.SetAttribute("id", Convert.ToString(IDGeneric));
                    noviElem.SetAttribute("autor", novaKnjiga.autor);
                    noviElem.SetAttribute("naslov", novaKnjiga.naslov);
                    noviElem.SetAttribute("izdavac", novaKnjiga.izdavac);
                    root.AppendChild(noviElem);
                    doc.Save("knjige.xml");
                    IDGeneric++;
                }
            }
            skip:;

        }

        class Knjige
        {
            public string ID, autor, naslov, izdavac;
            public int kolicina;

            public string ID1 { get => ID; set => ID = value; }
            public string Autor { get => autor; set => autor = value; }
            public string Naslov { get => naslov; set => naslov = value; }
            public string Izdavac { get => izdavac; set => izdavac = value; }
            public int Kolicina { get => kolicina; set => kolicina = value; }

            public Knjige()
            {

            }

            public Knjige(string id, string autor, string naslov, string izdavac, int kolicina)
            {
                this.ID = id;
                this.autor = autor;
                this.naslov = naslov;
                this.izdavac = izdavac;
                this.kolicina = kolicina;   

            }

            public Knjige(string autor, string naslov, string izdavac, int kolicina)
            {
                this.autor = autor;
                this.naslov = naslov;
                this.izdavac = izdavac;
                this.kolicina = kolicina;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxIzdavac.Clear();
            textBoxAutor.Clear();
            textBoxKolicina.Clear();
            textBoxNaslov.Clear();
        }
    }
}
