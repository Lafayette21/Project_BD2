using System;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace PrzetwarzanieDanychXML
{
    public partial class XmlActionsForm : Form
    {
        EntryForm entryForm;
        XDocument xmlDocument;
        string filepath;

        private void XmlActions_Load(object sender, EventArgs e)
        {
            
        }

        private void labelMainOperations_Click(object sender, EventArgs e)
        {
          
        }
        public XmlActionsForm() {
            InitializeComponent();
        }

        public XmlActionsForm(EntryForm entryForm)
        {
            InitializeComponent();
            this.entryForm = entryForm;
        }
        
        private void buttonCheckState_Click(object sender, EventArgs e)
        {
            MessageBox.Show(xmlDocument.ToString(),"Zawartosc pliku");
        }
        
        private void buttonChooseAnother_Click(object sender, EventArgs e)
        {
            this.Hide();
            entryForm.Show();
        }

        private void buttonAddNodeForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNodeForm addNodeForm = new AddNodeForm(this.xmlDocument,this);
            addNodeForm.Show();
        }
        
        private void buttonRemoveNode_Click(object sender, EventArgs e)
        {
            RemoveNodeForm removeNodeForm = new RemoveNodeForm(this.xmlDocument,this);
            this.Hide();
            removeNodeForm.Show();
        }
        
        private void buttonModifyNodeForm_Click(object sender, EventArgs e)
        {
            ModifyNodeForm modifyNodeForm = new ModifyNodeForm(this.xmlDocument,this);
            this.Hide();
            modifyNodeForm.Show();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            xmlDocument.Save(filepath);
            MessageBox.Show("Zapisano zmiany");
        }

        public void setXmlDocument(XDocument xmlDocument)
        {
            this.xmlDocument = xmlDocument;
        }

        public void setFilePath(string filePath)
        {
            this.filepath = filePath;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(this.xmlDocument, this);
            this.Hide();
            searchForm.Show();
        }
    }
}
