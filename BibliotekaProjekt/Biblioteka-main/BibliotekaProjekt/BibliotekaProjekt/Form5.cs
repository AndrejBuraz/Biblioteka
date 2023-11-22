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
    public partial class FormKnjigePopis : Form
    {
        public FormKnjigePopis()
        {
            InitializeComponent();
            box.AppendText("ID\t\t\tAutor\t\t\tNaslov\t\t\t\tIzdavac\n");
            box.AppendText("--------------------------------------------------------------------------------------------------------------\n");

            XmlDocument doc = new XmlDocument();
            doc.Load("knjige.xml");
            XmlNodeList elemList = doc.GetElementsByTagName("knjiga");
            foreach (XmlNode elem in elemList)
            {
                for(int i = 0; i <4; i ++)
                {
                    box.AppendText(elem.Attributes[i].Value + "\t\t\t");
                    if(i == 2)
                    {
                        box.AppendText("\t");
                    }
                }
                box.AppendText("\n");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
