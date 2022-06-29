using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PrzetwarzanieDanychXML
{
    public partial class ModifyNodeForm : Form
    {
        XmlActionsForm previousForm;
        XDocument xmlDocument;
        public ModifyNodeForm(XDocument xmlDocument,XmlActionsForm xmlActionsForm)
        {
            InitializeComponent();
            this.previousForm = xmlActionsForm;
            this.xmlDocument = xmlDocument;
        }

        private void ModifyNodeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonNextForm_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Pole na numer nie moze byc puste");
            }
            else if (!int.TryParse(textBox1.Text, out int nodeNumber))
            {
                MessageBox.Show("");
            }
            else
            {
                ContentToModifyForm contentToModifyForm = new ContentToModifyForm(this.xmlDocument, this, nodeNumber);
                this.Hide();
                contentToModifyForm.Show();
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
        }
    }
}
