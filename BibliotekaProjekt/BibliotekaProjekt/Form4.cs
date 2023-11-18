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
    public partial class UnosEvidencija : Form
    {
        public UnosEvidencija()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("evidencije.xml");
            XmlElement root = doc.DocumentElement;

            XmlDocument docKorisnici = new XmlDocument();
            docKorisnici.Load("korisnici.xml");
            XmlNodeList korisniciList = docKorisnici.GetElementsByTagName("korisnik");

            XmlDocument docKnjige = new XmlDocument();
            docKnjige.Load("knjige.xml");
            XmlNodeList knjigeList = docKnjige.GetElementsByTagName("knjiga");


            for(int j = 0; j < korisniciList.Count; j++)
            {
                if (korisniciList[j].Attributes[0].Value == textBoxIDKorisnik.Text)
                {
                    goto iduci;
                }
                else if (j == (korisniciList.Count - 1))
                {
                    
                     MessageBox.Show("Korisnik ID ne postoji!");
                     goto skip;
                }
            }

            iduci: for (int i = 0; i < knjigeList.Count; i++)
            {
                if (knjigeList[i].Attributes[0].Value == textBoxIDKnjiga.Text)
                {
                    goto dalje;
                }
                else if( i == (knjigeList.Count - 1))
                {
                    MessageBox.Show("Knjiga ID ne postoji!");
                    goto skip;
                }
            }

        dalje: Evidencija novaEvidencija = new Evidencija(textBoxIDKorisnik.Text, textBoxIDKnjiga.Text, dateTimePickerUzeto.Value, dateTimePickerVraceno.Value);

            XmlElement noviElem = doc.CreateElement("evidencija");
            noviElem.SetAttribute("korisnikID", novaEvidencija.korisnikID);
            noviElem.SetAttribute("knjigaID", novaEvidencija.knjigaID);
            noviElem.SetAttribute("podignuto", Convert.ToString(novaEvidencija.podizanje));
            noviElem.SetAttribute("vratiti", Convert.ToString(novaEvidencija.vracanje));
            root.AppendChild(noviElem);
            doc.Save("evidencije.xml");
            skip:;
        }

        class Evidencija
        {
            public string korisnikID, knjigaID;
            public DateTime podizanje, vracanje;


            public string KorisnikID { get => korisnikID; set => korisnikID = value; }
            public string KnjigaID { get => knjigaID; set => knjigaID = value; }
            public DateTime Podizanje { get => podizanje; set => podizanje = value; }
            public DateTime Vracanje { get => vracanje; set => vracanje = value; }

            public Evidencija()
            {

            }

            public Evidencija(string korisnik,string knjiga,DateTime uzmi,DateTime vrati)
            {
                this.korisnikID = korisnik;
                this.knjigaID = knjiga;
                this.podizanje = uzmi;
                this.vracanje = vrati;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxIDKnjiga.Clear();
            textBoxIDKorisnik.Clear();
            textBoxIDKorisnik.Clear();
        }
    }
}
