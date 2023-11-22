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
    public partial class FormKorisniciPopis : Form
    {
        public FormKorisniciPopis()
        {
            InitializeComponent();
            box.AppendText("ID\t\t\tIme\t\t      Prezime\t\t      Adresa\t\t       Broj telefona\n");
            box.AppendText("-----------------------------------------------------------------------------------------------------------------------------------\n");

            XmlDocument doc = new XmlDocument();
            doc.Load("korisnici.xml");
            XmlNodeList elemList = doc.GetElementsByTagName("korisnik");
            foreach (XmlNode elem in elemList)
            {
                for (int i = 0; i < 5; i++)
                {
                    box.AppendText(elem.Attributes[i].Value + "\t                   ");
                    
                }
                box.AppendText("\n");
            }
        }
    

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}
