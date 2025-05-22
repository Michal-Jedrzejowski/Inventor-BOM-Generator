namespace ListGenerator2000
{
    partial class frmListGenerator
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadXMLBOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeBOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.loadAllFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setListsLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1337, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadXMLBOMToolStripMenuItem,
            this.loadBOMToolStripMenuItem,
            this.closeBOMToolStripMenuItem,
            this.toolStripSeparator2,
            this.loadAllFilesToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadXMLBOMToolStripMenuItem
            // 
            this.loadXMLBOMToolStripMenuItem.Name = "loadXMLBOMToolStripMenuItem";
            this.loadXMLBOMToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.loadXMLBOMToolStripMenuItem.Text = "Load XML BOM";
            this.loadXMLBOMToolStripMenuItem.Click += new System.EventHandler(this.loadXMLBOMToolStripMenuItem_Click);
            // 
            // loadBOMToolStripMenuItem
            // 
            this.loadBOMToolStripMenuItem.Name = "loadBOMToolStripMenuItem";
            this.loadBOMToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.loadBOMToolStripMenuItem.Text = "Load Inventor BOM";
            this.loadBOMToolStripMenuItem.Click += new System.EventHandler(this.loadBOMToolStripMenuItem_Click);
            // 
            // closeBOMToolStripMenuItem
            // 
            this.closeBOMToolStripMenuItem.Name = "closeBOMToolStripMenuItem";
            this.closeBOMToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.closeBOMToolStripMenuItem.Text = "Close BOM";
            this.closeBOMToolStripMenuItem.Click += new System.EventHandler(this.closeBOMToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(174, 6);
            // 
            // loadAllFilesToolStripMenuItem
            // 
            this.loadAllFilesToolStripMenuItem.Name = "loadAllFilesToolStripMenuItem";
            this.loadAllFilesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.loadAllFilesToolStripMenuItem.Text = "Load All Files";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.setListsLocationToolStripMenuItem,
            this.archiveFileToolStripMenuItem,
            this.restoreFileToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionToolStripMenuItem.Text = "Options";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // setListsLocationToolStripMenuItem
            // 
            this.setListsLocationToolStripMenuItem.Name = "setListsLocationToolStripMenuItem";
            this.setListsLocationToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.setListsLocationToolStripMenuItem.Text = "Set Lists Location";
            this.setListsLocationToolStripMenuItem.Click += new System.EventHandler(this.setListsLocationToolStripMenuItem_Click);
            // 
            // archiveFileToolStripMenuItem
            // 
            this.archiveFileToolStripMenuItem.Name = "archiveFileToolStripMenuItem";
            this.archiveFileToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.archiveFileToolStripMenuItem.Text = "Archive File";
            // 
            // restoreFileToolStripMenuItem
            // 
            this.restoreFileToolStripMenuItem.Name = "restoreFileToolStripMenuItem";
            this.restoreFileToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.restoreFileToolStripMenuItem.Text = "Restore File";
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1337, 537);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1337, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // frmListGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmListGenerator";
            this.Text = "List Generator 2000";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadBOMToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem closeBOMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadXMLBOMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAllFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setListsLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreFileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

