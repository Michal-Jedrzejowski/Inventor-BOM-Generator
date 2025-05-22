using ListGenerator2000.Models;
using ListGenerator2000.Services;
using ListGenerator2000.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ListGenerator2000
{
    public partial class frmListGenerator : Form
    {
        private readonly InventorViewerService _inventorViewerService = new InventorViewerService();
        private readonly InventorXMLService _inventorXMLService = new InventorXMLService();
        private readonly InventorListsCompareService _inventorListsCompareService = new InventorListsCompareService();

        public frmListGenerator()
        {
            InitializeComponent();
            
            closeBOMToolStripMenuItem.Enabled = false;
        }


        private void loadBOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Otwieranie eksploratora Windows";
            OpenFileDialog openFileDlg = new OpenFileDialog
            {
                Title = "Select Assembly file",
                DefaultExt = ".iam",
                Filter = "Inventor Assembly File (*.iam) | *.iam"
            };

            if (Directory.Exists(@"\\192.168.8.253\dane\Projekty_nowe"))
            {
                openFileDlg.InitialDirectory = @"\\192.168.8.253\dane\Projekty_nowe";
            }
            openFileDlg.ShowDialog();

            if (openFileDlg.FileName == null || openFileDlg.FileName.Length == 0)
            {
                MessageBox.Show("File not selected");
                return;
            }
            toolStripStatusLabel1.Text = "Otwieranie pliku Autodesk Inventor";

            var name = Path.GetFileName(openFileDlg.FileName);
            name = name.Substring(0, name.Length - 4);
            
            foreach (TabPage tab in tabControl1.TabPages)
            {
                if (name.Equals(tab.Name))
                {
                    MessageBox.Show("Lista o takiej nazwie jest już otwarta");
                    return;
                }
            }
            toolStripStatusLabel1.Text = "Wczytywanie listy z programu Autodesk Inventor";

            List<InventorPart> inventorParts = new List<InventorPart>(_inventorViewerService.GetInventorParts(openFileDlg.FileName));

            string xmlName = openFileDlg.SafeFileName.Substring(0, openFileDlg.SafeFileName.Length - 4) + ".xml";
            xmlName = Properties.Settings.Default["ListFileLocation"].ToString()+"\\"+ xmlName;
            
            toolStripStatusLabel1.Text = "Wczytywanie listy XML";

            List<InventorPart> xmlParts = new List<InventorPart>(_inventorXMLService.ReadFromXML(xmlName));

            toolStripStatusLabel1.Text = "Porównywanie list";

            List<InventorPart> comparedParts = new List<InventorPart>(inventorParts);

            toolStripStatusLabel1.Text = "Zapis do XML";
            _inventorXMLService.SaveToXML(inventorParts, name);

            
            var partTableView = new PartTableView(comparedParts, name);
            AddTab(partTableView, name);
            toolStripStatusLabel1.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeBOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCurrentTab();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            Console.WriteLine("selected");
        }

        private void AddTab(PartTableView view, string tabName)
        {
            TabPage newTab = new TabPage(tabName);
            string filename = Properties.Settings.Default["ListFileLocation"] + "\\" + tabName + ".xml";
            List<InventorPart> listToSave = new List<InventorPart>();

            view.OnSaveClick += inventorPart => _inventorXMLService.ChangeXMLValue(inventorPart, tabName);
            newTab.Name = tabName;

            tabControl1.TabPages.Add(newTab);
            tabControl1.SelectedIndex = tabControl1.TabCount - 1;
            closeBOMToolStripMenuItem.Enabled = true;

            newTab.Controls.Add(view);
        }

        private void RemoveCurrentTab()
        {
            tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);

            if (tabControl1.SelectedIndex == -1)
                closeBOMToolStripMenuItem.Enabled = false;
        }


        private void setListsLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.FileLocationSettings.SetFileLocation();

        }

        private void loadXMLBOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog
            {
                Title = "Select Assembly file",
                DefaultExt = ".xml",
                Filter = "Inventor Assembly File (*.xml) | *.xml"
            };

            if (Directory.Exists(Properties.Settings.Default["ListFileLocation"].ToString()))
            {
                openFileDlg.InitialDirectory = Properties.Settings.Default["ListFileLocation"].ToString();
            }

            openFileDlg.ShowDialog();

            if (openFileDlg.FileName == null || openFileDlg.FileName.Length == 0)
            {
                MessageBox.Show("File not selected");
                return;
            }

            
            var name = Path.GetFileName(openFileDlg.FileName);
            name = name.Substring(0, name.Length - 4);
            foreach (TabPage tab in tabControl1.TabPages)
            {
                if (name.Equals(tab.Name))
                {
                    MessageBox.Show("Lista o takiej nazwie jest już otwarta");
                    return;
                }
            }
            List<InventorPart> xmlParts = new List<InventorPart>(_inventorXMLService.ReadFromXML(openFileDlg.FileName));
            var partTableView = new PartTableView(xmlParts, name);
            AddTab(partTableView, name);
        }
    }
}
