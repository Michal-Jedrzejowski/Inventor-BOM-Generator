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

        public frmListGenerator()
        {
            InitializeComponent();

            closeBOMToolStripMenuItem.Enabled = false;
        }


        private void loadBOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog
            {
                Title = "Select Assembly file",
                DefaultExt = ".iam",
                Filter = "Inventor Assembly File (*.iam) | *.iam"
            };
            openFileDlg.ShowDialog();

            var inventorParts = _inventorViewerService.GetInventorParts(openFileDlg.FileName);
            var name = Path.GetFileName(openFileDlg.FileName);

            var partTableView = new PartTableView(inventorParts, name);
            AddTab(partTableView, name);
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
    }
}
