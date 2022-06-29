using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Collections.Generic;

namespace PrzetwarzanieDanychXML
{
    public partial class AddNodeForm : Form
    {
        XDocument xmlDocument;
        XmlActionsForm previousForm;
        List<string> namesList;
        public AddNodeForm(XDocument xmlDocument,XmlActionsForm previousForm)
        {
            InitializeComponent();
            this.xmlDocument = xmlDocument;
            this.previousForm = previousForm;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            var query = xmlDocument.Descendants();
            var element = query.ElementAt(0).Descendants();
            HashSet<string> namesSet=new HashSet<string>();
            foreach (var x in element) {
                namesSet.Add(x.Name.ToString());
            }
            namesList = new List<string>(namesSet);

            if (namesList.Count() < 6) {
                for (int i=0; i < 6 - namesSet.Count(); i++) {
                    namesList.Add(string.Empty);
                }
            }   
            
            label1.Text = namesList[1];
            label2.Text = namesList[2];
            label3.Text = namesList[3];
            label4.Text = namesList[4];
            label5.Text = namesList[5];

            if (label1.Text.Equals("")) {textBox1.Hide();}
            if (label2.Text.Equals("")) { textBox2.Hide(); }
            if (label3.Text.Equals("")) { textBox3.Hide(); }
            if (label4.Text.Equals("")) { textBox4.Hide(); }
            if (label5.Text.Equals("")) { textBox5.Hide(); }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
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

        private bool valueValidation(List<string> listToValidate)
        {
            int valuesNumber = countValuesNumber(xmlDocument);
            if (listToValidate.Count() != (valuesNumber-1))
            {
                return false;
            }

            return true;
        }

        private void buttonAddNode_Click(object sender, EventArgs e)
        {
            List<String> valuesList = new List<string>();
            if (!textBox1.Text.Equals("")) { valuesList.Add(textBox1.Text); }
            if (!textBox2.Text.Equals("")) { valuesList.Add(textBox2.Text); }
            if (!textBox3.Text.Equals("")) { valuesList.Add(textBox3.Text); }
            if (!textBox4.Text.Equals("")) { valuesList.Add(textBox4.Text); }
            if (!textBox5.Text.Equals("")) { valuesList.Add(textBox5.Text); }

            if (!valueValidation(valuesList))
            {
                MessageBox.Show("Żadne pole nie może być puste");
            }
            else {
                var query = xmlDocument.Root;
                XElement elementToAdd = new XElement(namesList[0]);
                int index = 0;
                for (int i=1;i<namesList.Count();i++) {
                    if (!namesList[i].Equals("")) {
                        elementToAdd.Add(new XElement(namesList[i], valuesList[index]));
                        index++;
                    }
                }
                query.Add(elementToAdd);

                MessageBox.Show(elementToAdd.ToString(), "Dodano element do dokumentu");
            }

        }
    }
}
