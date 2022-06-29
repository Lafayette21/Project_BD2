using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PrzetwarzanieDanychXML
{
    public partial class ContentToModifyForm : Form
    {
        private ModifyNodeForm previousForm;
        private XDocument xmlDocument;
        private int nodeNumber;
        private List<string> namesList;
        private int valuesNumber=0;
      
        public ContentToModifyForm(XDocument xmlDocument,ModifyNodeForm modifyNodeForm,int nodeNumber)
        {
            InitializeComponent();
            this.previousForm = modifyNodeForm;
            this.xmlDocument = xmlDocument;
            this.nodeNumber = nodeNumber;
        }

        private void ContentToModifyForm_Load(object sender, EventArgs e)
        {
            var query = xmlDocument.Descendants();
            var element = query.ElementAt(0).Descendants();
            HashSet<string> namesSet = new HashSet<string>();
            foreach (var x in element)
            {
                namesSet.Add(x.Name.ToString());
            }
            namesList = new List<string>(namesSet);
            valuesNumber = namesSet.Count();

            if (namesList.Count() < 6)
            {
                for (int i = 0; i < 6 - namesSet.Count(); i++)
                {
                    namesList.Add(string.Empty);
                }
            }

            label1.Text = namesList[1];
            label2.Text = namesList[2];
            label3.Text = namesList[3];
            label4.Text = namesList[4];
            label5.Text = namesList[5];

            //Default values of textBoxes

            if (label1.Text.Equals("")) { textBox1.Hide(); }
            if (label2.Text.Equals("")) { textBox2.Hide(); }
            if (label3.Text.Equals("")) { textBox3.Hide(); }
            if (label4.Text.Equals("")) { textBox4.Hide(); }
            if (label5.Text.Equals("")) { textBox5.Hide(); }
        }

        private void buttonExchangeNode_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
        }

        private bool valueValidation(List<string> listToValidate) {
            if (listToValidate.Count()!= (valuesNumber-1)) {
                return false;
            }
            
            return true;
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            List<string> valuesList = new List<string>();
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
                var query = xmlDocument.Descendants().Descendants().ElementAt(valuesNumber * (nodeNumber - 1));
                    XElement newElement = new XElement(namesList[0]);
                    int index = 0;
                    for (int i = 1; i < namesList.Count(); i++)
                    {
                        if (!namesList[i].Equals(""))
                        {
                            newElement.Add(new XElement(namesList[i], valuesList[index]));
                            index++;
                        }
                    }
                    query.ReplaceWith(newElement);
                    MessageBox.Show("Operacja udana!");
            }
        }
        


        private void buttonCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show(xmlDocument.Descendants().Descendants().ElementAt(valuesNumber * (nodeNumber - 1)).ToString());
        }
    }
}
