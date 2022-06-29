using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PrzetwarzanieDanychXML
{

    public partial class CreateXmlForm : Form
    {
        private EntryForm entryForm;

        public CreateXmlForm(EntryForm entryForm)
        {
            InitializeComponent();
            this.entryForm = entryForm;
        }

        private void CreateXmlForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonEntryReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            entryForm.Show();
        }

        private void buttonCreateDocument_Click(object sender, EventArgs e)
        {
            try
            {
                XDocument xmlDocument = XDocument.Parse(textBoxContent.Text);
                if (textBoxTitle.Text.Equals(""))
                {
                    MessageBox.Show("Tytul nie moze byc pusty");
                }
                else if (!textBoxTitle.Text.Contains(".xml"))
                {
                    MessageBox.Show("Tytul musi miec rozszerzenie .xml");
                }
                else {
                    xmlDocument.Save(textBoxTitle.Text);
                    MessageBox.Show("Udalo sie stworzyc plik " + textBoxTitle.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nieprawidlowo sformatowany xml");
            }

            
        }
    }
}
