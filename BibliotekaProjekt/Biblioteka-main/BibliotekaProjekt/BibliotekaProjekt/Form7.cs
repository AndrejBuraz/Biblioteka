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
    public partial class EvidencijaPovijest : Form
    {
        public EvidencijaPovijest()
        {
            InitializeComponent();
            box.AppendText("ID korisnika\tID knjige\tradnja\t\t\t\tdatum dizanja|vracanja\tDatum vracanja\n");
            box.AppendText("------------------------------------------------------------------------------------------------------------------------------------------------\n");

            XmlDocument doc = new XmlDocument();
            doc.Load("evidencije.xml");
            XmlNodeList elemList = doc.GetElementsByTagName("evidencija");
            int i  = 0;
            foreach (XmlNode elem in elemList)
            {
                if (Convert.ToString(elem.Attributes[2].Value) == "vraćanje")
                {
                    for (i = 0; i < 4; i++)
                    {
                        box.AppendText(elem.Attributes[i].Value + "\t\t");
                        if (i == 2)
                        {
                            box.AppendText("\t");
                        }
                    }
                    box.AppendText("\n");
                }
                else
                {
                    for (i = 0; i < 5; i++)
                    {
                        box.AppendText(elem.Attributes[i].Value + "\t\t");
                        if (i == 2)
                        {
                            box.AppendText("\t");
                        }
                    }
                    box.AppendText("\n");
                }
            }
        }
    

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}
