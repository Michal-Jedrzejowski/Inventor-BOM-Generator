using ListGenerator2000.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListGenerator2000.Views
{
    public partial class PartTableView : UserControl
    {
        private readonly List<InventorPart> _allInventorParts;

        private readonly string _tableName;

        public PartTableView(List<InventorPart> inventorParts, string tableName)
        {
            //ListGenerator2000.frmListGenerator.ta
            InitializeComponent();
            _allInventorParts = inventorParts;
            _tableName = tableName;

            this.Dock = DockStyle.Fill;
            dataGridViewInventorParts.Name = _tableName;
            dataGridViewInventorParts.AllowUserToAddRows = false;
            dataGridViewInventorParts.AllowUserToDeleteRows = false;
            dataGridViewInventorParts.AllowUserToOrderColumns = true;
            dataGridViewInventorParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dataGridViewInventorParts.ReadOnly = true;

            var bomStructureFilters = inventorParts.Select(p => p.BomStructure).Distinct().ToArray();
            foreach (var filter in bomStructureFilters)
            {
                checkedListBoxBomStructure.Items.Add(filter, true);
            }

            var commentsFilters = inventorParts.Select(p => p.Comments).Distinct().ToArray();
            foreach (var filter in commentsFilters)
            {
                checkedListBoxComments.Items.Add(filter, true);
            }

            var stateFilters = inventorParts.Select(p => p.State).Distinct().ToArray();
            foreach (var filter in stateFilters)
            {
                checkedListBoxState.Items.Add(filter, true);
            }

        }

        private void SetInventorPartsTable(List<InventorPart> inventorParts)
        {
            dataGridViewInventorParts.DataSource = inventorParts;
        }

        private readonly List<string> _bomStructureFilters = new List<string>();
        private readonly List<string> _stateCheckedFilters = new List<string>();
        private readonly List<string> _commentsCheckedFilters = new List<string>();

        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkedListBox = sender as CheckedListBox;
            string tag = checkedListBox.Tag.ToString();
            string filterValue = checkedListBox.Items[e.Index].ToString();

            if (tag == "[BOM Structure]")
            {
                if (e.NewValue == CheckState.Checked)
                    _bomStructureFilters.Add(filterValue);

                else if (e.NewValue == CheckState.Unchecked)
                    _bomStructureFilters.Remove(filterValue);

            }
            if (tag == "[State]")
            {
                if (e.NewValue == CheckState.Checked)
                    _stateCheckedFilters.Add(filterValue);

                else if (e.NewValue == CheckState.Unchecked)
                    _stateCheckedFilters.Remove(filterValue);
            }
            if (tag == "[Comments]")
            {
                if (e.NewValue == CheckState.Checked)
                    _commentsCheckedFilters.Add(filterValue);

                else if (e.NewValue == CheckState.Unchecked)
                    _commentsCheckedFilters.Remove(filterValue);
            }

            var filteredParts = _allInventorParts.Where(p => _bomStructureFilters.Contains(p.BomStructure)
                && _commentsCheckedFilters.Contains(p.Comments)
                && _stateCheckedFilters.Contains(p.State)).ToList();

            SetInventorPartsTable(filteredParts);
        }

        private void PartTableView_SizeChanged(object sender, EventArgs e)
        {
            //dataGridViewInventorParts.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height);
        }
    }
}
