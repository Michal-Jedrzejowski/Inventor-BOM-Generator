namespace ListGenerator2000.Views
{
    partial class PartTableView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewInventorParts = new System.Windows.Forms.DataGridView();
            this.checkedListBox_BomStructure = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_State = new System.Windows.Forms.CheckedListBox();
            this.groupBox_Filter = new System.Windows.Forms.GroupBox();
            this.checkBox_StateAll = new System.Windows.Forms.CheckBox();
            this.checkBox_VendorAll = new System.Windows.Forms.CheckBox();
            this.checkBox_BomStructureAll = new System.Windows.Forms.CheckBox();
            this.label_Vendor = new System.Windows.Forms.Label();
            this.checkedListBox_Vendor = new System.Windows.Forms.CheckedListBox();
            this.label_State = new System.Windows.Forms.Label();
            this.label_BomStructure = new System.Windows.Forms.Label();
            this.textBox_SetComment = new System.Windows.Forms.TextBox();
            this.groupBox_Settings = new System.Windows.Forms.GroupBox();
            this.button_CopyFile = new System.Windows.Forms.Button();
            this.button_OpenFileLocation = new System.Windows.Forms.Button();
            this.label_SetState = new System.Windows.Forms.Label();
            this.button_SaveData = new System.Windows.Forms.Button();
            this.listBox_State = new System.Windows.Forms.ListBox();
            this.label_Comment = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventorParts)).BeginInit();
            this.groupBox_Filter.SuspendLayout();
            this.groupBox_Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewInventorParts
            // 
            this.dataGridViewInventorParts.AllowUserToAddRows = false;
            this.dataGridViewInventorParts.AllowUserToDeleteRows = false;
            this.dataGridViewInventorParts.AllowUserToResizeRows = false;
            this.dataGridViewInventorParts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInventorParts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewInventorParts.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridViewInventorParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventorParts.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewInventorParts.Margin = new System.Windows.Forms.Padding(3, 3, 300, 3);
            this.dataGridViewInventorParts.Name = "dataGridViewInventorParts";
            this.dataGridViewInventorParts.Size = new System.Drawing.Size(628, 641);
            this.dataGridViewInventorParts.TabIndex = 0;
            this.dataGridViewInventorParts.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInventorParts_RowEnter);
            this.dataGridViewInventorParts.SelectionChanged += new System.EventHandler(this.dataGridViewInventorParts_SelectionChanged_1);
            // 
            // checkedListBox_BomStructure
            // 
            this.checkedListBox_BomStructure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox_BomStructure.CheckOnClick = true;
            this.checkedListBox_BomStructure.FormattingEnabled = true;
            this.checkedListBox_BomStructure.Location = new System.Drawing.Point(15, 52);
            this.checkedListBox_BomStructure.Name = "checkedListBox_BomStructure";
            this.checkedListBox_BomStructure.Size = new System.Drawing.Size(140, 169);
            this.checkedListBox_BomStructure.TabIndex = 1;
            this.checkedListBox_BomStructure.Tag = "[BOM Structure]";
            this.checkedListBox_BomStructure.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            this.checkedListBox_BomStructure.MouseUp += new System.Windows.Forms.MouseEventHandler(this.checkedListBox_MouseUp);
            // 
            // checkedListBox_State
            // 
            this.checkedListBox_State.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox_State.CheckOnClick = true;
            this.checkedListBox_State.FormattingEnabled = true;
            this.checkedListBox_State.Location = new System.Drawing.Point(307, 52);
            this.checkedListBox_State.Name = "checkedListBox_State";
            this.checkedListBox_State.Size = new System.Drawing.Size(140, 169);
            this.checkedListBox_State.TabIndex = 3;
            this.checkedListBox_State.Tag = "[State]";
            this.checkedListBox_State.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            this.checkedListBox_State.MouseUp += new System.Windows.Forms.MouseEventHandler(this.checkedListBox_MouseUp);
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Filter.Controls.Add(this.checkBox_StateAll);
            this.groupBox_Filter.Controls.Add(this.checkBox_VendorAll);
            this.groupBox_Filter.Controls.Add(this.checkBox_BomStructureAll);
            this.groupBox_Filter.Controls.Add(this.label_Vendor);
            this.groupBox_Filter.Controls.Add(this.checkedListBox_Vendor);
            this.groupBox_Filter.Controls.Add(this.label_State);
            this.groupBox_Filter.Controls.Add(this.label_BomStructure);
            this.groupBox_Filter.Controls.Add(this.checkedListBox_State);
            this.groupBox_Filter.Controls.Add(this.checkedListBox_BomStructure);
            this.groupBox_Filter.Location = new System.Drawing.Point(633, 3);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Size = new System.Drawing.Size(463, 230);
            this.groupBox_Filter.TabIndex = 4;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Filters";
            // 
            // checkBox_StateAll
            // 
            this.checkBox_StateAll.AutoCheck = false;
            this.checkBox_StateAll.AutoSize = true;
            this.checkBox_StateAll.Checked = true;
            this.checkBox_StateAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_StateAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBox_StateAll.Location = new System.Drawing.Point(310, 32);
            this.checkBox_StateAll.Name = "checkBox_StateAll";
            this.checkBox_StateAll.Size = new System.Drawing.Size(71, 17);
            this.checkBox_StateAll.TabIndex = 11;
            this.checkBox_StateAll.TabStop = false;
            this.checkBox_StateAll.Text = "Check All";
            this.checkBox_StateAll.ThreeState = true;
            this.checkBox_StateAll.UseVisualStyleBackColor = true;
            this.checkBox_StateAll.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBox_VendorAll
            // 
            this.checkBox_VendorAll.AutoCheck = false;
            this.checkBox_VendorAll.AutoSize = true;
            this.checkBox_VendorAll.Checked = true;
            this.checkBox_VendorAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_VendorAll.Location = new System.Drawing.Point(164, 32);
            this.checkBox_VendorAll.Name = "checkBox_VendorAll";
            this.checkBox_VendorAll.Size = new System.Drawing.Size(71, 17);
            this.checkBox_VendorAll.TabIndex = 10;
            this.checkBox_VendorAll.TabStop = false;
            this.checkBox_VendorAll.Text = "Check All";
            this.checkBox_VendorAll.ThreeState = true;
            this.checkBox_VendorAll.UseVisualStyleBackColor = true;
            this.checkBox_VendorAll.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBox_BomStructureAll
            // 
            this.checkBox_BomStructureAll.AutoCheck = false;
            this.checkBox_BomStructureAll.AutoSize = true;
            this.checkBox_BomStructureAll.Checked = true;
            this.checkBox_BomStructureAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_BomStructureAll.Location = new System.Drawing.Point(18, 32);
            this.checkBox_BomStructureAll.Name = "checkBox_BomStructureAll";
            this.checkBox_BomStructureAll.Size = new System.Drawing.Size(71, 17);
            this.checkBox_BomStructureAll.TabIndex = 9;
            this.checkBox_BomStructureAll.TabStop = false;
            this.checkBox_BomStructureAll.Text = "Check All";
            this.checkBox_BomStructureAll.ThreeState = true;
            this.checkBox_BomStructureAll.UseVisualStyleBackColor = true;
            this.checkBox_BomStructureAll.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // label_Vendor
            // 
            this.label_Vendor.AutoSize = true;
            this.label_Vendor.Location = new System.Drawing.Point(158, 16);
            this.label_Vendor.Name = "label_Vendor";
            this.label_Vendor.Size = new System.Drawing.Size(41, 13);
            this.label_Vendor.TabIndex = 8;
            this.label_Vendor.Text = "Vendor";
            // 
            // checkedListBox_Vendor
            // 
            this.checkedListBox_Vendor.CheckOnClick = true;
            this.checkedListBox_Vendor.FormattingEnabled = true;
            this.checkedListBox_Vendor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkedListBox_Vendor.Location = new System.Drawing.Point(161, 52);
            this.checkedListBox_Vendor.Name = "checkedListBox_Vendor";
            this.checkedListBox_Vendor.Size = new System.Drawing.Size(140, 169);
            this.checkedListBox_Vendor.TabIndex = 7;
            this.checkedListBox_Vendor.Tag = "[Vendor]";
            this.checkedListBox_Vendor.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            this.checkedListBox_Vendor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.checkedListBox_MouseUp);
            // 
            // label_State
            // 
            this.label_State.AutoSize = true;
            this.label_State.Location = new System.Drawing.Point(304, 16);
            this.label_State.Name = "label_State";
            this.label_State.Size = new System.Drawing.Size(32, 13);
            this.label_State.TabIndex = 6;
            this.label_State.Text = "State";
            // 
            // label_BomStructure
            // 
            this.label_BomStructure.AutoSize = true;
            this.label_BomStructure.Location = new System.Drawing.Point(12, 16);
            this.label_BomStructure.Name = "label_BomStructure";
            this.label_BomStructure.Size = new System.Drawing.Size(77, 13);
            this.label_BomStructure.TabIndex = 4;
            this.label_BomStructure.Text = "BOM Structure";
            // 
            // textBox_SetComment
            // 
            this.textBox_SetComment.Location = new System.Drawing.Point(15, 36);
            this.textBox_SetComment.Multiline = true;
            this.textBox_SetComment.Name = "textBox_SetComment";
            this.textBox_SetComment.Size = new System.Drawing.Size(286, 121);
            this.textBox_SetComment.TabIndex = 0;
            // 
            // groupBox_Settings
            // 
            this.groupBox_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Settings.Controls.Add(this.button_CopyFile);
            this.groupBox_Settings.Controls.Add(this.button_OpenFileLocation);
            this.groupBox_Settings.Controls.Add(this.label_SetState);
            this.groupBox_Settings.Controls.Add(this.button_SaveData);
            this.groupBox_Settings.Controls.Add(this.listBox_State);
            this.groupBox_Settings.Controls.Add(this.label_Comment);
            this.groupBox_Settings.Controls.Add(this.textBox_SetComment);
            this.groupBox_Settings.Location = new System.Drawing.Point(633, 258);
            this.groupBox_Settings.Name = "groupBox_Settings";
            this.groupBox_Settings.Size = new System.Drawing.Size(463, 218);
            this.groupBox_Settings.TabIndex = 5;
            this.groupBox_Settings.TabStop = false;
            this.groupBox_Settings.Text = "Selected part settings";
            // 
            // button_CopyFile
            // 
            this.button_CopyFile.Location = new System.Drawing.Point(307, 180);
            this.button_CopyFile.Name = "button_CopyFile";
            this.button_CopyFile.Size = new System.Drawing.Size(140, 25);
            this.button_CopyFile.TabIndex = 7;
            this.button_CopyFile.Text = "Copy File";
            this.button_CopyFile.UseVisualStyleBackColor = true;
            this.button_CopyFile.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // button_OpenFileLocation
            // 
            this.button_OpenFileLocation.Location = new System.Drawing.Point(161, 180);
            this.button_OpenFileLocation.Name = "button_OpenFileLocation";
            this.button_OpenFileLocation.Size = new System.Drawing.Size(140, 25);
            this.button_OpenFileLocation.TabIndex = 6;
            this.button_OpenFileLocation.Text = "Open File Location";
            this.button_OpenFileLocation.UseVisualStyleBackColor = true;
            this.button_OpenFileLocation.Click += new System.EventHandler(this.OpenLocationButton_Click);
            // 
            // label_SetState
            // 
            this.label_SetState.AutoSize = true;
            this.label_SetState.Location = new System.Drawing.Point(304, 16);
            this.label_SetState.Name = "label_SetState";
            this.label_SetState.Size = new System.Drawing.Size(51, 13);
            this.label_SetState.TabIndex = 5;
            this.label_SetState.Text = "Set State";
            // 
            // button_SaveData
            // 
            this.button_SaveData.Location = new System.Drawing.Point(15, 180);
            this.button_SaveData.Name = "button_SaveData";
            this.button_SaveData.Size = new System.Drawing.Size(140, 25);
            this.button_SaveData.TabIndex = 4;
            this.button_SaveData.Text = "Save Data To List";
            this.button_SaveData.UseVisualStyleBackColor = true;
            this.button_SaveData.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // listBox_State
            // 
            this.listBox_State.FormattingEnabled = true;
            this.listBox_State.Items.AddRange(new object[] {
            "",
            "Brak półfabrykatu",
            "W trakcie",
            "Gotowy"});
            this.listBox_State.Location = new System.Drawing.Point(307, 36);
            this.listBox_State.Name = "listBox_State";
            this.listBox_State.Size = new System.Drawing.Size(140, 121);
            this.listBox_State.TabIndex = 3;
            // 
            // label_Comment
            // 
            this.label_Comment.AutoSize = true;
            this.label_Comment.Location = new System.Drawing.Point(12, 16);
            this.label_Comment.Name = "label_Comment";
            this.label_Comment.Size = new System.Drawing.Size(70, 13);
            this.label_Comment.TabIndex = 1;
            this.label_Comment.Text = "Set Comment";
            // 
            // PartTableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_Settings);
            this.Controls.Add(this.groupBox_Filter);
            this.Controls.Add(this.dataGridViewInventorParts);
            this.Name = "PartTableView";
            this.Size = new System.Drawing.Size(1108, 641);
            this.Load += new System.EventHandler(this.PartTableView_Load);
            this.Enter += new System.EventHandler(this.PartTableView_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventorParts)).EndInit();
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            this.groupBox_Settings.ResumeLayout(false);
            this.groupBox_Settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInventorParts;
        private System.Windows.Forms.CheckedListBox checkedListBox_BomStructure;
        private System.Windows.Forms.CheckedListBox checkedListBox_State;
        private System.Windows.Forms.CheckedListBox checkedListBox_Vendor;
        private System.Windows.Forms.GroupBox groupBox_Filter;
        private System.Windows.Forms.Label label_BomStructure;
        private System.Windows.Forms.Label label_State;
        private System.Windows.Forms.Label label_Vendor;
        private System.Windows.Forms.TextBox textBox_SetComment;
        private System.Windows.Forms.GroupBox groupBox_Settings;
        private System.Windows.Forms.Label label_Comment;
        private System.Windows.Forms.ListBox listBox_State;
        private System.Windows.Forms.Button button_SaveData;
        private System.Windows.Forms.CheckBox checkBox_StateAll;
        private System.Windows.Forms.CheckBox checkBox_VendorAll;
        private System.Windows.Forms.CheckBox checkBox_BomStructureAll;
        private System.Windows.Forms.Label label_SetState;
        private System.Windows.Forms.Button button_CopyFile;
        private System.Windows.Forms.Button button_OpenFileLocation;
    }
}
