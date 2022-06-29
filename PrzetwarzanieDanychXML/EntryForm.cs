using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PrzetwarzanieDanychXML
{
    public partial class EntryForm : Form
    {
        XmlActionsForm xmlActions;
        CreateXmlForm createXmlForm;
        public EntryForm()
        {
            InitializeComponent();
            xmlActions = new XmlActionsForm(this);
            createXmlForm = new CreateXmlForm(this);
        }

        private void openXmlActionWindow(XDocument xmlDocument,string filePath) {
            this.Hide();
            xmlActions.setXmlDocument(xmlDocument);
            xmlActions.setFilePath(filePath);
            xmlActions.Show();
        }

        private void buttonChooseXml_Click(object sender, EventArgs e)
        { 
            var filePath = string.Empty;
            XDocument xmlDocument=null;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Xml files (*.xml)|*.xml";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    xmlDocument = XDocument.Load(filePath);
                }
            }
            if (xmlDocument != null) {
                openXmlActionWindow(xmlDocument,filePath);
            }
            else{
                MessageBox.Show("Nie wybrano zadnego pliku");
            }
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            createXmlForm.Show();
        }
    }
}
