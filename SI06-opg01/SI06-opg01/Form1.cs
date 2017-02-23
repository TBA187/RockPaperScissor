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
using System.Xml.Serialization;

namespace SI06_opg01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
            ServiceRef.StockQuoteSoap obj = new ServiceRef.StockQuoteSoapClient();

            //Create the XmlDocument.
            var myXmlData = XElement.Parse(obj.GetQuote("BP"));

            //Get the names of all nodes
            var allNames = (from e in myXmlData.Descendants()
                            where e.Name.LocalName == "Stock"
                            select e.Name.LocalName).ToList();

            //Get the values of each node - empty string for nodes with children
            var allElements = (from e in myXmlData.Descendants()
                               select (e.HasElements ? "" : e.Value)).ToList();

            for (int i = 1; i <= allNames.Count(); i++)
            {
                foreach (var eachElement in allElements)
                {
                    dataGridView1.Rows.Add(eachElement);
                }

            }

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
