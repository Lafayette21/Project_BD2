using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PrzetwarzanieDanychXML
{
    public partial class SearchForm : Form
    {
        XDocument xmlDocument;
        XmlActionsForm previousForm;

        public SearchForm(XDocument xmlDocument, XmlActionsForm previousForm)
        {
            this.xmlDocument = xmlDocument;
            this.previousForm = previousForm;
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void badInput() {
            MessageBox.Show("Nieprawidlowy input");
        }

        private int countValuesNumber(XDocument xmlDocument)
        {
            var element = xmlDocument.Descendants().ElementAt(0).Descendants();
            HashSet<string> namesSet = new HashSet<string>();
            foreach (var x in element)
            {
                namesSet.Add(x.Name.ToString());
            }
            return namesSet.Count();
        }

        private void buttonName_Click(object sender, EventArgs e)
        {
            String searchString = textBox2.Text;
            if (searchString.Equals(""))
            {
                badInput();
            }
            else {
                var query = xmlDocument.Descendants().Descendants();
                int i = 0;
                int elementIndex = 0;
                XElement searchedElement=null;
                foreach(XElement el in query) {
                    if (el.Value.ToString().Equals(searchString)){
                        MessageBox.Show(elementIndex.ToString());
                        searchedElement = query.ElementAt(elementIndex);
                        break;
                    }
                    i++;
                    if (i % countValuesNumber(xmlDocument)==0) {
                        elementIndex+=countValuesNumber(xmlDocument);
                    }
                }
                if (searchedElement.Equals(null)) {
                    MessageBox.Show("Nie znaleziono takiego wezla");
                }
                else {
                    MessageBox.Show(searchedElement.ToString());
                }

                
                
            }

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
