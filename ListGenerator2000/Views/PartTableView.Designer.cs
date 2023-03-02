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
            this.checkedListBoxBomStructure = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxComments = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxState = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventorParts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInventorParts
            // 
            this.dataGridViewInventorParts.AllowUserToAddRows = false;
            this.dataGridViewInventorParts.AllowUserToDeleteRows = false;
            this.dataGridViewInventorParts.AllowUserToOrderColumns = true;
            this.dataGridViewInventorParts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInventorParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventorParts.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewInventorParts.Margin = new System.Windows.Forms.Padding(3, 3, 300, 3);
            this.dataGridViewInventorParts.Name = "dataGridViewInventorParts";
            this.dataGridViewInventorParts.Size = new System.Drawing.Size(554, 571);
            this.dataGridViewInventorParts.TabIndex = 0;
            // 
            // checkedListBoxBomStructure
            // 
            this.checkedListBoxBomStructure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxBomStructure.CheckOnClick = true;
            this.checkedListBoxBomStructure.FormattingEnabled = true;
            this.checkedListBoxBomStructure.Location = new System.Drawing.Point(568, 24);
            this.checkedListBoxBomStructure.Name = "checkedListBoxBomStructure";
            this.checkedListBoxBomStructure.Size = new System.Drawing.Size(120, 94);
            this.checkedListBoxBomStructure.TabIndex = 1;
            this.checkedListBoxBomStructure.Tag = "[BOM Structure]";
            this.checkedListBoxBomStructure.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            // 
            // checkedListBoxComments
            // 
            this.checkedListBoxComments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxComments.CheckOnClick = true;
            this.checkedListBoxComments.FormattingEnabled = true;
            this.checkedListBoxComments.Location = new System.Drawing.Point(701, 24);
            this.checkedListBoxComments.Name = "checkedListBoxComments";
            this.checkedListBoxComments.Size = new System.Drawing.Size(120, 94);
            this.checkedListBoxComments.TabIndex = 2;
            this.checkedListBoxComments.Tag = "[Comments]";
            this.checkedListBoxComments.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            // 
            // checkedListBoxState
            // 
            this.checkedListBoxState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxState.CheckOnClick = true;
            this.checkedListBoxState.FormattingEnabled = true;
            this.checkedListBoxState.Location = new System.Drawing.Point(827, 24);
            this.checkedListBoxState.Name = "checkedListBoxState";
            this.checkedListBoxState.Size = new System.Drawing.Size(120, 94);
            this.checkedListBoxState.TabIndex = 3;
            this.checkedListBoxState.Tag = "[State]";
            this.checkedListBoxState.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            // 
            // PartTableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkedListBoxState);
            this.Controls.Add(this.checkedListBoxComments);
            this.Controls.Add(this.checkedListBoxBomStructure);
            this.Controls.Add(this.dataGridViewInventorParts);
            this.Name = "PartTableView";
            this.Size = new System.Drawing.Size(1034, 571);
            this.SizeChanged += new System.EventHandler(this.PartTableView_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventorParts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInventorParts;
        private System.Windows.Forms.CheckedListBox checkedListBoxBomStructure;
        private System.Windows.Forms.CheckedListBox checkedListBoxComments;
        private System.Windows.Forms.CheckedListBox checkedListBoxState;
    }
}
