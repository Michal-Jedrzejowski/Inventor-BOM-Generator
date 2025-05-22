using ListGenerator2000.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ListGenerator2000.Views
{
    public partial class PartTableView : UserControl
    {
        //private readonly List<InventorPart> _allInventorParts;
        private List<InventorPart> _allInventorParts;
        private List<InventorPart> _filteredParts;

        private readonly string _tableName;
        private string _id;
        private int _rowIndex;
        private bool _dataSelected;
        public event Action<InventorPart> OnSaveClick;

        public PartTableView(List<InventorPart> inventorParts, string tableName)
        {
            InitializeComponent();
            _allInventorParts = inventorParts;
            _tableName = tableName;
            CreateFilter();
        }

        private void CreateFilter()
        {
            this.Dock = DockStyle.Fill;
            dataGridViewInventorParts.Name = _tableName;

            dataGridViewInventorParts.ReadOnly = true;
            
            checkedListBox_BomStructure.Items.Add("Normal", true);
            checkedListBox_BomStructure.Items.Add("Purchased/Normal", true);
            checkedListBox_BomStructure.Items.Add("Purchased", true);

            List<string> states = new List<string> { "", "Brak półfabrykatu", "W trakcie", "Gotowy" };
            foreach (string state in states)
            {
                checkedListBox_State.Items.Add(state, true);
            }
            
            var vendorFilters = _allInventorParts.Select(p => p.Vendor).Distinct().ToArray();
            foreach (var filter in vendorFilters)
            {
                if (checkedListBox_Vendor.Items.Contains(filter) == false)
                    checkedListBox_Vendor.Items.Add(filter, true);
                else
                {
                    bool state = checkedListBox_Vendor.GetItemChecked(checkedListBox_Vendor.Items.IndexOf(filter));
                    checkedListBox_Vendor.Items.Remove(filter);
                    checkedListBox_Vendor.Items.Add(filter, state);
                }
            }
        }

        private void SetInventorPartsTable(List<InventorPart> inventorParts)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("BOM Structure"),
                new DataColumn("Description"),
                new DataColumn("Part Number"),
                new DataColumn("Quantity"),
                new DataColumn("Material"),
                new DataColumn("Vendor"),
                new DataColumn("Comments"),
                new DataColumn("State"),
            });

            foreach (InventorPart invPart in inventorParts)
            {
                if (invPart.Visibility == true)
                {
                    DataRow row = dt.NewRow();
                    row["Bom Structure"] = invPart.BomStructure;
                    row["Description"] = invPart.Description;
                    row["Part Number"] = invPart.PartNumber;
                    row["Quantity"] = invPart.Quantity;
                    row["Material"] = invPart.Material;
                    row["Vendor"] = invPart.Vendor;
                    row["Comments"] = invPart.Comments;
                    row["State"] = invPart.State;
                    dt.Rows.Add(row);
                }
            }
            dataGridViewInventorParts.DataSource = dt;
            dataGridViewInventorParts.Columns["Comments"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private readonly List<string> _bomStructureFilters = new List<string>();
        private readonly List<string> _stateCheckedFilters = new List<string>();
        private readonly List<string> _vendorCheckedFilters = new List<string>();

        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkedListBox = sender as CheckedListBox;
            string tag = checkedListBox.Tag.ToString();
            string filterValue = checkedListBox.Items[e.Index].ToString();

            if (tag == "[BOM Structure]")
                if (e.NewValue == CheckState.Checked)
                    _bomStructureFilters.Add(filterValue);
                else if (e.NewValue == CheckState.Unchecked)
                    _bomStructureFilters.Remove(filterValue);

            if (tag == "[State]")
                if (e.NewValue == CheckState.Checked)
                    _stateCheckedFilters.Add(filterValue);
                else if (e.NewValue == CheckState.Unchecked)
                    _stateCheckedFilters.Remove(filterValue);

            if (tag == "[Vendor]")
                if (e.NewValue == CheckState.Checked)
                    _vendorCheckedFilters.Add(filterValue);
                else if (e.NewValue == CheckState.Unchecked)
                    _vendorCheckedFilters.Remove(filterValue);

            _filteredParts = _allInventorParts.Where(p => _bomStructureFilters.Contains(p.BomStructure)
                && _stateCheckedFilters.Contains(p.State)
                && _vendorCheckedFilters.Contains(p.Vendor)).ToList();
            var filteredParts = _allInventorParts.Where(p => _bomStructureFilters.Contains(p.BomStructure)
                && _stateCheckedFilters.Contains(p.State)
                && _vendorCheckedFilters.Contains(p.Vendor)).ToList();

            SetInventorPartsTable(_filteredParts);
            if (_filteredParts.Count == 0)
            {
                dataGridViewInventorParts.ClearSelection();
            }
        }

        private void SetCheckBoxState(CheckedListBox clb, CheckBox cb)
        {
            if (clb.CheckedItems.Count == 0)
                cb.CheckState = CheckState.Unchecked;
            else if (clb.CheckedItems.Count == clb.Items.Count)
                cb.CheckState = CheckState.Checked;
            else
                cb.CheckState = CheckState.Indeterminate;
        }

        private void dataGridViewInventorParts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView s = sender as DataGridView;
            _rowIndex = e.RowIndex;
            _id = s.Rows[e.RowIndex].Cells[2].Value.ToString();

            this.groupBox_Settings.Text = s.Rows[e.RowIndex].Cells["Part Number"].Value.ToString() + " " + s.Rows[e.RowIndex].Cells["Description"].Value.ToString();
            this.textBox_SetComment.Text = s.Rows[e.RowIndex].Cells["Comments"].Value.ToString();
            this.listBox_State.SelectedIndex = this.listBox_State.FindStringExact(s.Rows[e.RowIndex].Cells["State"].Value.ToString());
             
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (_dataSelected)
            {
                _allInventorParts.Where(w => w.PartNumber == _id).ToList().ForEach(s => s.Comments = textBox_SetComment.Text);
                _allInventorParts.Where(w => w.PartNumber == _id).ToList().ForEach(s => s.State = listBox_State.SelectedItem.ToString());
                this.dataGridViewInventorParts.Rows[_rowIndex].Cells["Comments"].Value = textBox_SetComment.Text;
                this.dataGridViewInventorParts.Rows[_rowIndex].Cells["State"].Value = listBox_State.SelectedItem.ToString();
                InventorPart inventorPart = _allInventorParts.Where(w => w.PartNumber == _id).FirstOrDefault();
                OnSaveClick?.Invoke(inventorPart);
            }
            //OnSaveClick?.Invoke(_allInventorParts.Where(w => w.PartNumber == _id).ToList());

        }

        private void checkBox_Click(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.CheckState == CheckState.Unchecked)
                cb.CheckState = CheckState.Checked;
            else
                cb.CheckState = CheckState.Unchecked;
            if (cb.Name == "checkBox_BomStructureAll")
                CheckAll(checkedListBox_BomStructure, cb.CheckState);
            if (cb.Name == "checkBox_VendorAll")
                CheckAll(checkedListBox_Vendor, cb.CheckState);
            if (cb.Name == "checkBox_StateAll")
                CheckAll(checkedListBox_State, cb.CheckState);
        }

        private void checkedListBox_MouseUp(object sender, MouseEventArgs e)
        {
            CheckedListBox checkedListBox = sender as CheckedListBox;
            string tag = checkedListBox.Tag.ToString();
            if (tag == "[BOM Structure]")
                SetCheckBoxState(checkedListBox, checkBox_BomStructureAll);
            if (tag == "[State]")
                SetCheckBoxState(checkedListBox, checkBox_StateAll);
            if (tag == "[Vendor]")
                SetCheckBoxState(checkedListBox, checkBox_VendorAll);
        }
        
        private void CheckAll(CheckedListBox clb, CheckState cs)
        {
            if (cs == CheckState.Checked) 
                for (int i = 0; i < clb.Items.Count; i++)
                    clb.SetItemChecked(i, true);
            else if (cs == CheckState.Unchecked)
                for (int i = 0; i < clb.Items.Count; i++)
                    clb.SetItemChecked(i, false);
        }

        private void dataGridViewInventorParts_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridViewInventorParts.SelectedCells.Count == 0)
            {
                _dataSelected = false;
                groupBox_Settings.Text = "Brak zaznaczenia";
                listBox_State.ClearSelected();
            }
            else
                _dataSelected = true;
        }

        private void OpenLocationButton_Click(object sender, EventArgs e)
        {
            if (_dataSelected)
            {
                string filepath = _allInventorParts.Where(w => w.PartNumber == _id).FirstOrDefault().Path;
                if (File.Exists(filepath))
                {
                    Process process = Process.Start("explorer.exe", "/select, " + $"\"{filepath}\"");
                    process.EnableRaisingEvents = true;
                }
                else
                    MessageBox.Show("File doesn't exist in this location or path is violated");
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (_dataSelected)
            {
                string filepath = _allInventorParts.Where(w => w.PartNumber == _id).FirstOrDefault().Path;
                
                if (File.Exists(@filepath))
                {
                    System.Collections.Specialized.StringCollection filepaths = new System.Collections.Specialized.StringCollection { @filepath };
                    Clipboard.SetFileDropList(filepaths);
                }
                else
                    MessageBox.Show("File doesn't exist in this location or path is violated");
            }
        }

        private void PartTableView_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(_tableName);
        }

        private void PartTableView_Enter(object sender, EventArgs e)
        {
            //MessageBox.Show(_tableName + " Enter");
            //OnSaveClick?.Invoke(_allInventorParts);

        }
    }
}
