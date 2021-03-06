namespace Enesy.EnesyCAD.CommandManager
{
    partial class CommandsManagerDialog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommandsManagerDialog));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Enesy.vn");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Autodesk");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("All", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.dgrvCommands = new System.Windows.Forms.DataGridView();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.pnlViewer = new System.Windows.Forms.Panel();
            this.pnlData = new System.Windows.Forms.Panel();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.txtDescription = new Enesy.Forms.RichTextBoxData();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblWebLink = new Enesy.Forms.LinkLabelData();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCommandsStore = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDisplayFavorite = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDisplayDescription = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDisplayCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuError = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoadUC = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLinkButton = new System.Windows.Forms.Panel();
            this.butFanPage = new System.Windows.Forms.Button();
            this.butHomePage = new System.Windows.Forms.Button();
            this.butYoutube = new System.Windows.Forms.Button();
            this.searchBox = new Enesy.Forms.SearchBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvSubCommands = new Enesy.Forms.TreeViewSheets();
            this.cmnuRoot = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuSub = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuCommand = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuExpand = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvCommands)).BeginInit();
            this.pnlViewer.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.pnlDescription.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.pnlLinkButton.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrvCommands
            // 
            this.dgrvCommands.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrvCommands.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgrvCommands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrvCommands.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgrvCommands.Location = new System.Drawing.Point(0, 4);
            this.dgrvCommands.Margin = new System.Windows.Forms.Padding(4);
            this.dgrvCommands.Name = "dgrvCommands";
            this.dgrvCommands.ReadOnly = true;
            this.dgrvCommands.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgrvCommands.RowTemplate.ReadOnly = true;
            this.dgrvCommands.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrvCommands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrvCommands.ShowEditingIcon = false;
            this.dgrvCommands.Size = new System.Drawing.Size(743, 202);
            this.dgrvCommands.TabIndex = 0;
            this.dgrvCommands.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrvCommands_CellDoubleClick);
            this.dgrvCommands.MouseHover += new System.EventHandler(this.dgrvCommands_MouseHover);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescription.Location = new System.Drawing.Point(4, 7);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 17);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblStatus.Location = new System.Drawing.Point(543, 4);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(200, 15);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHelp.Location = new System.Drawing.Point(4, 4);
            this.lblHelp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(41, 17);
            this.lblHelp.TabIndex = 3;
            this.lblHelp.Text = "Help:";
            // 
            // pnlViewer
            // 
            this.pnlViewer.Controls.Add(this.pnlData);
            this.pnlViewer.Controls.Add(this.pnlDescription);
            this.pnlViewer.Controls.Add(this.pnlStatus);
            this.pnlViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewer.Location = new System.Drawing.Point(0, 0);
            this.pnlViewer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlViewer.Name = "pnlViewer";
            this.pnlViewer.Size = new System.Drawing.Size(747, 335);
            this.pnlViewer.TabIndex = 4;
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.dgrvCommands);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(0, 0);
            this.pnlData.Margin = new System.Windows.Forms.Padding(4);
            this.pnlData.Name = "pnlData";
            this.pnlData.Padding = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.pnlData.Size = new System.Drawing.Size(747, 210);
            this.pnlData.TabIndex = 2;
            // 
            // pnlDescription
            // 
            this.pnlDescription.Controls.Add(this.lblDescription);
            this.pnlDescription.Controls.Add(this.txtDescription);
            this.pnlDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDescription.Location = new System.Drawing.Point(0, 210);
            this.pnlDescription.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Padding = new System.Windows.Forms.Padding(4, 7, 4, 4);
            this.pnlDescription.Size = new System.Drawing.Size(747, 102);
            this.pnlDescription.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.DataMember = null;
            this.txtDescription.DisplayMember = "";
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDescription.Location = new System.Drawing.Point(4, 27);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(739, 71);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Text = "...";
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.lblStatus);
            this.pnlStatus.Controls.Add(this.lblHelp);
            this.pnlStatus.Controls.Add(this.lblWebLink);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.Location = new System.Drawing.Point(0, 312);
            this.pnlStatus.Margin = new System.Windows.Forms.Padding(4);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Padding = new System.Windows.Forms.Padding(4);
            this.pnlStatus.Size = new System.Drawing.Size(747, 23);
            this.pnlStatus.TabIndex = 0;
            // 
            // lblWebLink
            // 
            this.lblWebLink.AutoSize = true;
            this.lblWebLink.DataMember = null;
            this.lblWebLink.DisplayMember = "";
            this.lblWebLink.Location = new System.Drawing.Point(53, 4);
            this.lblWebLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWebLink.Name = "lblWebLink";
            this.lblWebLink.Size = new System.Drawing.Size(51, 17);
            this.lblWebLink.TabIndex = 4;
            this.lblWebLink.TabStop = true;
            this.lblWebLink.Text = "https://";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mnuMain);
            this.panel1.Controls.Add(this.pnlLinkButton);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(925, 33);
            this.panel1.TabIndex = 7;
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.Transparent;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuView,
            this.toolsToolStripMenuItem});
            this.mnuMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mnuMain.Location = new System.Drawing.Point(4, 4);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuMain.Size = new System.Drawing.Size(451, 28);
            this.mnuMain.TabIndex = 5;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuImport,
            this.mnuSave,
            this.mnuCommandsStore,
            this.mnuClose});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(44, 24);
            this.mnuFile.Text = "File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(203, 24);
            this.mnuOpen.Text = "Open ...";
            // 
            // mnuImport
            // 
            this.mnuImport.Name = "mnuImport";
            this.mnuImport.Size = new System.Drawing.Size(203, 24);
            this.mnuImport.Text = "Import ...";
            this.mnuImport.Click += new System.EventHandler(this.mnuImport_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(203, 24);
            this.mnuSave.Text = "Save";
            // 
            // mnuCommandsStore
            // 
            this.mnuCommandsStore.Name = "mnuCommandsStore";
            this.mnuCommandsStore.Size = new System.Drawing.Size(203, 24);
            this.mnuCommandsStore.Text = "Commands store ...";
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(203, 24);
            this.mnuClose.Text = "Close";
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDisplayFavorite,
            this.mnuDisplayDescription,
            this.mnuDisplayCommand,
            this.mnuError});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(53, 24);
            this.mnuView.Text = "View";
            // 
            // mnuDisplayFavorite
            // 
            this.mnuDisplayFavorite.Checked = true;
            this.mnuDisplayFavorite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuDisplayFavorite.Name = "mnuDisplayFavorite";
            this.mnuDisplayFavorite.Size = new System.Drawing.Size(241, 24);
            this.mnuDisplayFavorite.Text = "Display Favorite";
            this.mnuDisplayFavorite.Click += new System.EventHandler(this.mnuDisplayFavorite_Click);
            // 
            // mnuDisplayDescription
            // 
            this.mnuDisplayDescription.Checked = true;
            this.mnuDisplayDescription.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuDisplayDescription.Name = "mnuDisplayDescription";
            this.mnuDisplayDescription.Size = new System.Drawing.Size(241, 24);
            this.mnuDisplayDescription.Text = "Display Description";
            this.mnuDisplayDescription.Click += new System.EventHandler(this.mnuDisplayDescription_Click);
            // 
            // mnuDisplayCommand
            // 
            this.mnuDisplayCommand.Checked = true;
            this.mnuDisplayCommand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuDisplayCommand.Enabled = false;
            this.mnuDisplayCommand.Name = "mnuDisplayCommand";
            this.mnuDisplayCommand.Size = new System.Drawing.Size(241, 24);
            this.mnuDisplayCommand.Text = "Display Command name";
            // 
            // mnuError
            // 
            this.mnuError.Name = "mnuError";
            this.mnuError.Size = new System.Drawing.Size(241, 24);
            this.mnuError.Text = "Error log";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoadUC});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // mnuLoadUC
            // 
            this.mnuLoadUC.Name = "mnuLoadUC";
            this.mnuLoadUC.Size = new System.Drawing.Size(230, 24);
            this.mnuLoadUC.Text = "Load User Command ...";
            this.mnuLoadUC.Click += new System.EventHandler(this.mnuLoadUC_Click);
            // 
            // pnlLinkButton
            // 
            this.pnlLinkButton.Controls.Add(this.butFanPage);
            this.pnlLinkButton.Controls.Add(this.butHomePage);
            this.pnlLinkButton.Controls.Add(this.butYoutube);
            this.pnlLinkButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLinkButton.Location = new System.Drawing.Point(455, 4);
            this.pnlLinkButton.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLinkButton.Name = "pnlLinkButton";
            this.pnlLinkButton.Size = new System.Drawing.Size(131, 25);
            this.pnlLinkButton.TabIndex = 4;
            // 
            // butFanPage
            // 
            this.butFanPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butFanPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butFanPage.BackgroundImage")));
            this.butFanPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butFanPage.FlatAppearance.BorderSize = 0;
            this.butFanPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butFanPage.Location = new System.Drawing.Point(7, 0);
            this.butFanPage.Margin = new System.Windows.Forms.Padding(4);
            this.butFanPage.Name = "butFanPage";
            this.butFanPage.Padding = new System.Windows.Forms.Padding(4);
            this.butFanPage.Size = new System.Drawing.Size(31, 26);
            this.butFanPage.TabIndex = 6;
            this.butFanPage.UseVisualStyleBackColor = true;
            this.butFanPage.Click += new System.EventHandler(this.butFanPage_Click);
            // 
            // butHomePage
            // 
            this.butHomePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butHomePage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butHomePage.BackgroundImage")));
            this.butHomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butHomePage.FlatAppearance.BorderSize = 0;
            this.butHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butHomePage.Location = new System.Drawing.Point(45, 0);
            this.butHomePage.Margin = new System.Windows.Forms.Padding(4);
            this.butHomePage.Name = "butHomePage";
            this.butHomePage.Padding = new System.Windows.Forms.Padding(4);
            this.butHomePage.Size = new System.Drawing.Size(31, 26);
            this.butHomePage.TabIndex = 5;
            this.butHomePage.UseVisualStyleBackColor = true;
            this.butHomePage.Click += new System.EventHandler(this.butHomePage_Click);
            // 
            // butYoutube
            // 
            this.butYoutube.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butYoutube.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butYoutube.BackgroundImage")));
            this.butYoutube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butYoutube.FlatAppearance.BorderSize = 0;
            this.butYoutube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butYoutube.Location = new System.Drawing.Point(84, 0);
            this.butYoutube.Margin = new System.Windows.Forms.Padding(4);
            this.butYoutube.Name = "butYoutube";
            this.butYoutube.Size = new System.Drawing.Size(31, 26);
            this.butYoutube.TabIndex = 4;
            this.butYoutube.UseVisualStyleBackColor = true;
            this.butYoutube.Click += new System.EventHandler(this.butYoutube_Click);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.White;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.DisplayMember = "";
            this.searchBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchBox.Enabled = false;
            this.searchBox.Location = new System.Drawing.Point(586, 4);
            this.searchBox.Margin = new System.Windows.Forms.Padding(0);
            this.searchBox.MinimumSize = new System.Drawing.Size(173, 25);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(335, 25);
            this.searchBox.TabIndex = 0;
            this.searchBox.MouseHover += new System.EventHandler(this.searchBox_MouseHover);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 33);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvSubCommands);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlViewer);
            this.splitContainer1.Size = new System.Drawing.Size(925, 335);
            this.splitContainer1.SplitterDistance = 171;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 8;
            // 
            // trvSubCommands
            // 
            this.trvSubCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvSubCommands.Location = new System.Drawing.Point(4, 4);
            this.trvSubCommands.Margin = new System.Windows.Forms.Padding(4);
            this.trvSubCommands.Name = "trvSubCommands";
            treeNode1.Name = "ndoEnesy";
            treeNode1.Text = "Enesy.vn";
            treeNode2.Name = "ndoAutodesk";
            treeNode2.Text = "Autodesk";
            treeNode3.Name = "ndoRoot";
            treeNode3.Text = "All";
            this.trvSubCommands.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.trvSubCommands.Size = new System.Drawing.Size(167, 327);
            this.trvSubCommands.TabIndex = 0;
            // 
            // cmnuRoot
            // 
            this.cmnuRoot.Name = "cmnuRoot";
            this.cmnuRoot.Size = new System.Drawing.Size(61, 4);
            // 
            // cmnuSub
            // 
            this.cmnuSub.Name = "cmnuSub";
            this.cmnuSub.Size = new System.Drawing.Size(61, 4);
            // 
            // cmnuCommand
            // 
            this.cmnuCommand.Name = "cmnuCommand";
            this.cmnuCommand.Size = new System.Drawing.Size(61, 4);
            // 
            // cmnuExpand
            // 
            this.cmnuExpand.Name = "cmnuExpand";
            this.cmnuExpand.Size = new System.Drawing.Size(61, 4);
            // 
            // CommandsManagerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 368);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(887, 237);
            this.Name = "CommandsManagerDialog";
            this.ShowInTaskbar = false;
            this.Text = "Commands Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dgrvCommands)).EndInit();
            this.pnlViewer.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.pnlDescription.ResumeLayout(false);
            this.pnlDescription.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlLinkButton.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Enesy.Forms.SearchBox searchBox;
        private Enesy.Forms.RichTextBoxData txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DataGridView dgrvCommands;
        private System.Windows.Forms.Label lblStatus;
        private Enesy.Forms.LinkLabelData lblWebLink;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Panel pnlViewer;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Panel pnlDescription;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Enesy.Forms.TreeViewSheets trvSubCommands;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.Panel pnlLinkButton;
        private System.Windows.Forms.Button butFanPage;
        private System.Windows.Forms.Button butHomePage;
        private System.Windows.Forms.Button butYoutube;
        private System.Windows.Forms.ToolStripMenuItem mnuDisplayFavorite;
        private System.Windows.Forms.ToolStripMenuItem mnuDisplayDescription;
        private System.Windows.Forms.ToolStripMenuItem mnuDisplayCommand;
        private System.Windows.Forms.ToolStripMenuItem mnuImport;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ContextMenuStrip cmnuRoot;
        private System.Windows.Forms.ContextMenuStrip cmnuSub;
        private System.Windows.Forms.ContextMenuStrip cmnuCommand;
        private System.Windows.Forms.ContextMenuStrip cmnuExpand;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem mnuError;
        private System.Windows.Forms.ToolStripMenuItem mnuCommandsStore;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLoadUC;
    }
}