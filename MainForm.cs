using System;
using System.IO;
using System.Net.Security;
using System.Windows.Forms.Design;
using System.Xml;
using System.Xml.Linq;
using System.Text.Json;
namespace Daily_Logger
{

    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            InitializeLogs();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fileName = "logHistory.xml";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            // Read the existing XML file using XDocument (LINQ to XML)
            XDocument xDocument = XDocument.Load(filePath);

            // Create a new log entry element and set its attributes
            XElement xmlElement = new XElement("LogEntry",
                new XAttribute("Log", JsonEncodedText.Encode(txtLogEntry.Text)),
                new XAttribute("Created", DateTime.Now.ToString()));

            // Append the new log entry as the last child of the root element
            xDocument.Root.Add(xmlElement);

            // Save the updated XML file
            xDocument.Save(filePath);

            // Bind the data
            BindData();
            txtLogEntry.Clear();

        }

        private void BindData()
        {
            string fileName = "logHistory.xml";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            XmlTextReader xmlReader = new XmlTextReader(filePath);
            xmlReader.Close();
        }

        private void InitializeLogs()
        {
            string fileName = "logHistory.xml";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            if (!File.Exists(filePath))
            {
                XDocument xDocument = new XDocument(
                    new XElement("Root")
                );
                xDocument.Save(filePath);
            }
        }
        private void TabPage2_Enter(object sender, EventArgs e)
        {
            string fileName = "logHistory.xml";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            XDocument xmlDoc = XDocument.Load(filePath);
            XElement rootElement = xmlDoc.Root;
            treeHistory.Nodes.Clear();
            foreach (XElement logEntryElement in rootElement.Elements("LogEntry"))
            {
                XAttribute createdAttribute = logEntryElement.Attribute("Created");
                if (createdAttribute != null)
                {
                    string createdValue = createdAttribute.Value;
                    TreeNode logEntryNode = new TreeNode(createdValue);
                    XAttribute log = logEntryElement.Attribute("Log");
                    if (log != null)
                    {
                        TreeNode logNode = new TreeNode($"{log.Value}");
                        logEntryNode.Nodes.Add(logNode);
                    }
                    treeHistory.Nodes.Add(logEntryNode);
                }
            }
        }
        private TreeNode CreateTreeNode(XElement element)
        {
            TreeNode treeNode = new TreeNode(element.Name.LocalName);
            foreach (XAttribute attribute in element.Attributes())
            {
                string attributeName = $"{attribute.Name.LocalName}: {attribute.Value}";
                treeNode.Nodes.Add(attributeName);
            }
            foreach (XElement childElement in element.Elements())
            {
                TreeNode childTreeNode = CreateTreeNode(childElement);
                treeNode.Nodes.Add(childTreeNode);
            }
            return treeNode;
        }

        private void addUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeHistory.SelectedNode != null)
            {
                string selectedNode = treeHistory.SelectedNode.Text;
                selectedNode = selectedNode.Replace("\\r\\n", Environment.NewLine);
                txtLogEntry.Text = selectedNode;
                tabControl1.SelectedTab = tabPage1;
            }
            else
            {
                MessageBox.Show("Selected entry was read as NULL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeHistory.SelectedNode != null)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                string selectedNode = treeHistory.SelectedNode.Text;
                selectedNode = selectedNode.Replace("\\r\\n", Environment.NewLine);
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFile.FileName;
                    try
                    {
                        File.WriteAllText(filePath, selectedNode);
                        MessageBox.Show("Log successfully exported!", "Export Log", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error exporting log: {ex.Message}", "Export Log", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void deleteLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = "logHistory.xml";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            if (treeHistory.SelectedNode != null)
            {

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);
                XmlNode nodeToDelete = FindXmlNode(xmlDoc.DocumentElement, treeHistory.SelectedNode.Text);
                if (nodeToDelete != null)
                {
                    XmlAttribute logAttribute = nodeToDelete.Attributes["Log"];
                    XmlAttribute createdAttribute = nodeToDelete.Attributes["Created"];
                    if (logAttribute != null && createdAttribute != null)
                    {
                        nodeToDelete.Attributes.Remove(logAttribute);
                        nodeToDelete.Attributes.Remove(createdAttribute);
                        xmlDoc.Save(filePath);
                        treeHistory.SelectedNode.Remove();
                        TabPage2_Enter(sender, e);
                    }
                }
            }
        }
        private XmlNode FindXmlNode(XmlNode parentNode, string nodeText)
        {
            foreach (XmlNode node in parentNode.ChildNodes)
            {
                XmlAttribute logAttribute = node.Attributes["Log"];
                if (logAttribute != null && logAttribute.Value == nodeText)
                {
                    return node;
                }
            }
            return null;
        }
    }
}