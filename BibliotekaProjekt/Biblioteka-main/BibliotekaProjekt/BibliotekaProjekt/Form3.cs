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
    public partial class KorisnikUnos : Form
    {
        public KorisnikUnos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("korisnici.xml");
            XmlElement root = doc.DocumentElement;

            XmlNodeList elemList = doc.GetElementsByTagName("korisnik");
            Korisnik noviKorisnik = new Korisnik(textBoxIme.Text, textBoxPrezime.Text, textBoxAdresa.Text, textBoxBrojTel.Text);
            noviKorisnik.ID = Convert.ToString(Convert.ToInt32(elemList[elemList.Count - 1].Attributes[0].Value) + 1);

            if (textBoxID.Text != "")
            {
                for (int j = 0; j < elemList.Count; j++)
                {
                    if (elemList[j].Attributes[0].Value == textBoxID.Text)
                    {
                        MessageBox.Show("ID je već iskorišten!");
                        goto skip;
                    }
                    else
                    {
                        noviKorisnik.ID = textBoxID.Text;
                    }
                }

            }

            XmlElement noviElem = doc.CreateElement("korisnik");
            noviElem.SetAttribute("id", noviKorisnik.ID);
            noviElem.SetAttribute("ime", noviKorisnik.ime);
            noviElem.SetAttribute("prezime", noviKorisnik.prezime);
            noviElem.SetAttribute("adresa", noviKorisnik.adresa);
            noviElem.SetAttribute("brojTelefona", noviKorisnik.brojTelefona);
            root.AppendChild(noviElem);
            doc.Save("korisnici.xml");
            skip:;
        }

        class Korisnik
        {
            public string ID, ime, prezime, adresa, brojTelefona;

            public string ID1 { get => ID; set => ID = value; }
            public string Ime { get => ime; set => ime = value; }
            public string Prezime { get => prezime; set => prezime = value; }
            public string Adresa { get => adresa; set => adresa = value; }
            public string BrojTelefona { get => brojTelefona; set => brojTelefona = value; }

            public Korisnik()
            {

            }
            public Korisnik(string ime, string prezime, string adresa, string brojTel)
            {
                this.ime = ime;
                this.prezime = prezime;
                this.adresa = adresa;
                this.brojTelefona = brojTel;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxIme.Clear();
            textBoxPrezime.Clear();
            textBoxAdresa.Clear();
            textBoxBrojTel.Clear();
        }
    }
}
