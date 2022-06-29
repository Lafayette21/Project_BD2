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
    public partial class RemoveNodeForm : Form
    {
        XmlActionsForm previousForm;
        XDocument xmlDocument;
        private int valueNumber = 0;
        public RemoveNodeForm(XDocument xmlDocument,XmlActionsForm previousForm)
        {
            InitializeComponent();
            this.xmlDocument = xmlDocument;
            this.previousForm = previousForm;
        }

        private void RemoveNodeForm_Load(object sender, EventArgs e)
        {
            
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            valueNumber = countValuesNumber(xmlDocument);
            int removeNumber = Int32.Parse(idRemoveTextField.Text);
            var query = xmlDocument.Descendants().Descendants();

            if (removeNumber > query.Count())
            {
                MessageBox.Show("Podany numer jest większy niz ilosc wezlow");
            }
            else {
                XElement element=query.ElementAt(valueNumber*(removeNumber - 1));
                element.Remove();
                MessageBox.Show("Usunieto wezel o numerze " +removeNumber);
            }
        }
        private int countValuesNumber(XDocument xmlDocument) {
            var element = xmlDocument.Descendants().ElementAt(0).Descendants();
            HashSet<string> namesSet = new HashSet<string>();
            foreach (var x in element)
            {
                namesSet.Add(x.Name.ToString());
            }
            return namesSet.Count();
        }


        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {}

        
    }
}
