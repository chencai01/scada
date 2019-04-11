﻿namespace Scada.Table.Editor.Forms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnFileNew = new System.Windows.Forms.ToolStripButton();
            this.btnFileOpen = new System.Windows.Forms.ToolStripButton();
            this.btnFileSave = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.splVert = new System.Windows.Forms.Splitter();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.cbCnlGrouping = new System.Windows.Forms.ComboBox();
            this.tvCnl = new System.Windows.Forms.TreeView();
            this.pnlHint = new System.Windows.Forms.Panel();
            this.lblHint = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.colItemCnlNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemCtrlCnlNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemHidden = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddItem = new System.Windows.Forms.ToolStripButton();
            this.btnAddEmptyItem = new System.Windows.Forms.ToolStripButton();
            this.btnMoveUpItem = new System.Windows.Forms.ToolStripButton();
            this.btnMoveDownItem = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.btnItemInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefreshBase = new System.Windows.Forms.ToolStripButton();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlHint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(734, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileNew,
            this.miFileOpen,
            this.miFileSave,
            this.miFileSaveAs,
            this.toolStripMenuItem1,
            this.miFileExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(37, 20);
            this.miFile.Text = "&File";
            // 
            // miFileNew
            // 
            this.miFileNew.Image = ((System.Drawing.Image)(resources.GetObject("miFileNew.Image")));
            this.miFileNew.Name = "miFileNew";
            this.miFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.miFileNew.Size = new System.Drawing.Size(180, 22);
            this.miFileNew.Text = "New";
            this.miFileNew.Click += new System.EventHandler(this.miFileNew_Click);
            // 
            // miFileOpen
            // 
            this.miFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("miFileOpen.Image")));
            this.miFileOpen.Name = "miFileOpen";
            this.miFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.miFileOpen.Size = new System.Drawing.Size(180, 22);
            this.miFileOpen.Text = "Open...";
            this.miFileOpen.Click += new System.EventHandler(this.miFileOpen_Click);
            // 
            // miFileSave
            // 
            this.miFileSave.Image = ((System.Drawing.Image)(resources.GetObject("miFileSave.Image")));
            this.miFileSave.Name = "miFileSave";
            this.miFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.miFileSave.Size = new System.Drawing.Size(180, 22);
            this.miFileSave.Text = "Save";
            this.miFileSave.Click += new System.EventHandler(this.miFileSave_Click);
            // 
            // miFileSaveAs
            // 
            this.miFileSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("miFileSaveAs.Image")));
            this.miFileSaveAs.Name = "miFileSaveAs";
            this.miFileSaveAs.Size = new System.Drawing.Size(180, 22);
            this.miFileSaveAs.Text = "Save As...";
            this.miFileSaveAs.Click += new System.EventHandler(this.miFileSaveAs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // miFileExit
            // 
            this.miFileExit.Image = ((System.Drawing.Image)(resources.GetObject("miFileExit.Image")));
            this.miFileExit.Name = "miFileExit";
            this.miFileExit.Size = new System.Drawing.Size(180, 22);
            this.miFileExit.Text = "Exit";
            this.miFileExit.Click += new System.EventHandler(this.miFileExit_Click);
            // 
            // miHelp
            // 
            this.miHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHelpAbout});
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(44, 20);
            this.miHelp.Text = "&Help";
            // 
            // miHelpAbout
            // 
            this.miHelpAbout.Image = ((System.Drawing.Image)(resources.GetObject("miHelpAbout.Image")));
            this.miHelpAbout.Name = "miHelpAbout";
            this.miHelpAbout.Size = new System.Drawing.Size(180, 22);
            this.miHelpAbout.Text = "About";
            this.miHelpAbout.Click += new System.EventHandler(this.miHelpAbout_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFileNew,
            this.btnFileOpen,
            this.btnFileSave,
            this.toolStripSeparator1,
            this.btnRefreshBase,
            this.toolStripSeparator2,
            this.btnAddItem,
            this.btnAddEmptyItem,
            this.btnMoveUpItem,
            this.btnMoveDownItem,
            this.btnDeleteItem,
            this.btnItemInfo});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(734, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // btnFileNew
            // 
            this.btnFileNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFileNew.Image = ((System.Drawing.Image)(resources.GetObject("btnFileNew.Image")));
            this.btnFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFileNew.Name = "btnFileNew";
            this.btnFileNew.Size = new System.Drawing.Size(23, 22);
            this.btnFileNew.ToolTipText = "New Table (Ctrl+N)";
            this.btnFileNew.Click += new System.EventHandler(this.miFileNew_Click);
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnFileOpen.Image")));
            this.btnFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(23, 22);
            this.btnFileOpen.ToolTipText = "Open Table (Ctrl+O)";
            this.btnFileOpen.Click += new System.EventHandler(this.miFileOpen_Click);
            // 
            // btnFileSave
            // 
            this.btnFileSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFileSave.Image = ((System.Drawing.Image)(resources.GetObject("btnFileSave.Image")));
            this.btnFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFileSave.Name = "btnFileSave";
            this.btnFileSave.Size = new System.Drawing.Size(23, 22);
            this.btnFileSave.Text = "Save Table (Ctrl+S)";
            this.btnFileSave.Click += new System.EventHandler(this.miFileSave_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 489);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(734, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel1.Text = "lblBaseDir";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.pnlHint);
            this.pnlLeft.Controls.Add(this.tvCnl);
            this.pnlLeft.Controls.Add(this.cbCnlGrouping);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 49);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(250, 440);
            this.pnlLeft.TabIndex = 3;
            // 
            // splVert
            // 
            this.splVert.Location = new System.Drawing.Point(250, 49);
            this.splVert.MinExtra = 100;
            this.splVert.MinSize = 100;
            this.splVert.Name = "splVert";
            this.splVert.Size = new System.Drawing.Size(3, 440);
            this.splVert.TabIndex = 5;
            this.splVert.TabStop = false;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.dgvItems);
            this.pnlRight.Controls.Add(this.txtTitle);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(253, 49);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(481, 440);
            this.pnlRight.TabIndex = 6;
            // 
            // cbCnlGrouping
            // 
            this.cbCnlGrouping.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCnlGrouping.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCnlGrouping.FormattingEnabled = true;
            this.cbCnlGrouping.Items.AddRange(new object[] {
            "Group by devices",
            "Group by objects"});
            this.cbCnlGrouping.Location = new System.Drawing.Point(0, 0);
            this.cbCnlGrouping.Name = "cbCnlGrouping";
            this.cbCnlGrouping.Size = new System.Drawing.Size(250, 21);
            this.cbCnlGrouping.TabIndex = 0;
            // 
            // tvCnl
            // 
            this.tvCnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvCnl.Location = new System.Drawing.Point(0, 24);
            this.tvCnl.Margin = new System.Windows.Forms.Padding(0);
            this.tvCnl.Name = "tvCnl";
            this.tvCnl.Size = new System.Drawing.Size(250, 363);
            this.tvCnl.TabIndex = 1;
            // 
            // pnlHint
            // 
            this.pnlHint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHint.Controls.Add(this.lblHint);
            this.pnlHint.Location = new System.Drawing.Point(0, 390);
            this.pnlHint.Name = "pnlHint";
            this.pnlHint.Size = new System.Drawing.Size(250, 50);
            this.pnlHint.TabIndex = 2;
            // 
            // lblHint
            // 
            this.lblHint.Location = new System.Drawing.Point(3, 3);
            this.lblHint.Margin = new System.Windows.Forms.Padding(3);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(240, 42);
            this.lblHint.TabIndex = 0;
            this.lblHint.Text = "Press Enter or double-click a node to add it to the table.";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(0, 0);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(481, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToResizeRows = false;
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemCnlNum,
            this.colItemCtrlCnlNum,
            this.colItemCaption,
            this.colItemHidden});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvItems.Location = new System.Drawing.Point(0, 24);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(0);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(481, 416);
            this.dgvItems.TabIndex = 10;
            // 
            // colItemCnlNum
            // 
            this.colItemCnlNum.DataPropertyName = "CnlNum";
            this.colItemCnlNum.HeaderText = "Input Channel";
            this.colItemCnlNum.Name = "colItemCnlNum";
            this.colItemCnlNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colItemCnlNum.Width = 65;
            // 
            // colItemCtrlCnlNum
            // 
            this.colItemCtrlCnlNum.DataPropertyName = "CtrlCnlNum";
            this.colItemCtrlCnlNum.HeaderText = "Output Channel";
            this.colItemCtrlCnlNum.Name = "colItemCtrlCnlNum";
            this.colItemCtrlCnlNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colItemCtrlCnlNum.Width = 75;
            // 
            // colItemCaption
            // 
            this.colItemCaption.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItemCaption.DataPropertyName = "Caption";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.colItemCaption.DefaultCellStyle = dataGridViewCellStyle8;
            this.colItemCaption.HeaderText = "Caption";
            this.colItemCaption.Name = "colItemCaption";
            this.colItemCaption.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colItemHidden
            // 
            this.colItemHidden.DataPropertyName = "Hidden";
            this.colItemHidden.HeaderText = "Hidden";
            this.colItemHidden.Name = "colItemHidden";
            this.colItemHidden.Width = 60;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddItem
            // 
            this.btnAddItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItem.Image")));
            this.btnAddItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(23, 22);
            this.btnAddItem.ToolTipText = "Add Item";
            // 
            // btnAddEmptyItem
            // 
            this.btnAddEmptyItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddEmptyItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmptyItem.Image")));
            this.btnAddEmptyItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddEmptyItem.Name = "btnAddEmptyItem";
            this.btnAddEmptyItem.Size = new System.Drawing.Size(23, 22);
            this.btnAddEmptyItem.ToolTipText = "Add Empty Item";
            // 
            // btnMoveUpItem
            // 
            this.btnMoveUpItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMoveUpItem.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveUpItem.Image")));
            this.btnMoveUpItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMoveUpItem.Name = "btnMoveUpItem";
            this.btnMoveUpItem.Size = new System.Drawing.Size(23, 22);
            this.btnMoveUpItem.ToolTipText = "Move Item Up";
            // 
            // btnMoveDownItem
            // 
            this.btnMoveDownItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMoveDownItem.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveDownItem.Image")));
            this.btnMoveDownItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMoveDownItem.Name = "btnMoveDownItem";
            this.btnMoveDownItem.Size = new System.Drawing.Size(23, 22);
            this.btnMoveDownItem.ToolTipText = "Move Item Down";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteItem.Image")));
            this.btnDeleteItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteItem.ToolTipText = "Delete Selected Items";
            // 
            // btnItemInfo
            // 
            this.btnItemInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItemInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnItemInfo.Image")));
            this.btnItemInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItemInfo.Name = "btnItemInfo";
            this.btnItemInfo.Size = new System.Drawing.Size(23, 22);
            this.btnItemInfo.ToolTipText = "Show Item Info";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRefreshBase
            // 
            this.btnRefreshBase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefreshBase.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshBase.Image")));
            this.btnRefreshBase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshBase.Name = "btnRefreshBase";
            this.btnRefreshBase.Size = new System.Drawing.Size(23, 22);
            this.btnRefreshBase.ToolTipText = "Refresh Configuration Database";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.splVert);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Edtor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlHint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miFileNew;
        private System.Windows.Forms.ToolStripMenuItem miFileOpen;
        private System.Windows.Forms.ToolStripMenuItem miFileSave;
        private System.Windows.Forms.ToolStripMenuItem miFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miFileExit;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem miHelpAbout;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnFileNew;
        private System.Windows.Forms.ToolStripButton btnFileOpen;
        private System.Windows.Forms.ToolStripButton btnFileSave;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Splitter splVert;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.ComboBox cbCnlGrouping;
        private System.Windows.Forms.TreeView tvCnl;
        private System.Windows.Forms.Panel pnlHint;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemCnlNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemCtrlCnlNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemCaption;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colItemHidden;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAddItem;
        private System.Windows.Forms.ToolStripButton btnAddEmptyItem;
        private System.Windows.Forms.ToolStripButton btnMoveUpItem;
        private System.Windows.Forms.ToolStripButton btnMoveDownItem;
        private System.Windows.Forms.ToolStripButton btnDeleteItem;
        private System.Windows.Forms.ToolStripButton btnItemInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnRefreshBase;
    }
}

