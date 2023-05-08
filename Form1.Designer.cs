namespace no_install
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.buttonSelectDir = new System.Windows.Forms.Button();
            this.textBoxRegex = new System.Windows.Forms.TextBox();
            this.labelDirectory = new System.Windows.Forms.Label();
            this.labelRegex = new System.Windows.Forms.Label();
            this.buttonRegexSearch = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAddFiles = new System.Windows.Forms.Button();
            this.panelRList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelBackTable = new System.Windows.Forms.TableLayoutPanel();
            this.panelRTop = new System.Windows.Forms.TableLayoutPanel();
            this.panelRBottom = new System.Windows.Forms.Panel();
            this.buttonAddFolder = new System.Windows.Forms.Button();
            this.comboBoxFile = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDir = new System.Windows.Forms.ComboBox();
            this.panelLCenter = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxCreate = new System.Windows.Forms.GroupBox();
            this.buttonCreateUninstaller = new System.Windows.Forms.Button();
            this.buttonCreateInstaller = new System.Windows.Forms.Button();
            this.panelBackTable.SuspendLayout();
            this.panelRTop.SuspendLayout();
            this.panelRBottom.SuspendLayout();
            this.panelLCenter.SuspendLayout();
            this.groupBoxCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDirectory.Location = new System.Drawing.Point(82, 6);
            this.textBoxDirectory.Margin = new System.Windows.Forms.Padding(10, 6, 10, 0);
            this.textBoxDirectory.MinimumSize = new System.Drawing.Size(148, 22);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(559, 22);
            this.textBoxDirectory.TabIndex = 0;
            // 
            // buttonSelectDir
            // 
            this.buttonSelectDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSelectDir.Location = new System.Drawing.Point(653, 2);
            this.buttonSelectDir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelectDir.MinimumSize = new System.Drawing.Size(36, 22);
            this.buttonSelectDir.Name = "buttonSelectDir";
            this.buttonSelectDir.Size = new System.Drawing.Size(69, 30);
            this.buttonSelectDir.TabIndex = 1;
            this.buttonSelectDir.Text = "...";
            this.buttonSelectDir.UseVisualStyleBackColor = true;
            this.buttonSelectDir.Click += new System.EventHandler(this.buttonSelectDir_Click);
            // 
            // textBoxRegex
            // 
            this.textBoxRegex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRegex.Location = new System.Drawing.Point(82, 42);
            this.textBoxRegex.Margin = new System.Windows.Forms.Padding(10, 8, 10, 0);
            this.textBoxRegex.Name = "textBoxRegex";
            this.textBoxRegex.Size = new System.Drawing.Size(559, 22);
            this.textBoxRegex.TabIndex = 2;
            // 
            // labelDirectory
            // 
            this.labelDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDirectory.Location = new System.Drawing.Point(2, 2);
            this.labelDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.labelDirectory.Name = "labelDirectory";
            this.labelDirectory.Size = new System.Drawing.Size(68, 30);
            this.labelDirectory.TabIndex = 3;
            this.labelDirectory.Text = "Directory";
            this.labelDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRegex
            // 
            this.labelRegex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRegex.Location = new System.Drawing.Point(2, 36);
            this.labelRegex.Margin = new System.Windows.Forms.Padding(2);
            this.labelRegex.Name = "labelRegex";
            this.labelRegex.Size = new System.Drawing.Size(68, 30);
            this.labelRegex.TabIndex = 4;
            this.labelRegex.Text = "Regex";
            this.labelRegex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonRegexSearch
            // 
            this.buttonRegexSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRegexSearch.Location = new System.Drawing.Point(653, 36);
            this.buttonRegexSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegexSearch.Name = "buttonRegexSearch";
            this.buttonRegexSearch.Size = new System.Drawing.Size(69, 30);
            this.buttonRegexSearch.TabIndex = 9;
            this.buttonRegexSearch.Text = "Search";
            this.buttonRegexSearch.UseVisualStyleBackColor = true;
            this.buttonRegexSearch.Click += new System.EventHandler(this.buttonRegexSearch_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(192, 3);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 28);
            this.buttonRemove.TabIndex = 8;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAddFiles
            // 
            this.buttonAddFiles.Location = new System.Drawing.Point(7, 3);
            this.buttonAddFiles.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddFiles.Name = "buttonAddFiles";
            this.buttonAddFiles.Size = new System.Drawing.Size(75, 28);
            this.buttonAddFiles.TabIndex = 6;
            this.buttonAddFiles.Text = "Add Files";
            this.buttonAddFiles.UseVisualStyleBackColor = true;
            this.buttonAddFiles.Click += new System.EventHandler(this.buttonAddFiles_Click);
            // 
            // panelRList
            // 
            this.panelRList.CheckBoxes = true;
            this.panelRList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.panelRList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRList.GridLines = true;
            this.panelRList.HideSelection = false;
            this.panelRList.LabelWrap = false;
            this.panelRList.Location = new System.Drawing.Point(184, 74);
            this.panelRList.Margin = new System.Windows.Forms.Padding(2);
            this.panelRList.Name = "panelRList";
            this.panelRList.Size = new System.Drawing.Size(724, 338);
            this.panelRList.TabIndex = 7;
            this.panelRList.UseCompatibleStateImageBehavior = false;
            this.panelRList.View = System.Windows.Forms.View.Details;
            this.panelRList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.panelRList_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Path";
            this.columnHeader1.Width = 500;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Link Type";
            this.columnHeader2.Width = 100;
            // 
            // panelBackTable
            // 
            this.panelBackTable.ColumnCount = 2;
            this.panelBackTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelBackTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.panelBackTable.Controls.Add(this.panelRList, 1, 1);
            this.panelBackTable.Controls.Add(this.panelRTop, 1, 0);
            this.panelBackTable.Controls.Add(this.panelRBottom, 1, 2);
            this.panelBackTable.Controls.Add(this.panelLCenter, 0, 1);
            this.panelBackTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackTable.Location = new System.Drawing.Point(0, 0);
            this.panelBackTable.Margin = new System.Windows.Forms.Padding(0);
            this.panelBackTable.Name = "panelBackTable";
            this.panelBackTable.RowCount = 3;
            this.panelBackTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.panelBackTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelBackTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.panelBackTable.Size = new System.Drawing.Size(910, 450);
            this.panelBackTable.TabIndex = 10;
            // 
            // panelRTop
            // 
            this.panelRTop.ColumnCount = 3;
            this.panelRTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panelRTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.panelRTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panelRTop.Controls.Add(this.buttonSelectDir, 2, 0);
            this.panelRTop.Controls.Add(this.labelRegex, 0, 1);
            this.panelRTop.Controls.Add(this.labelDirectory, 0, 0);
            this.panelRTop.Controls.Add(this.textBoxRegex, 1, 1);
            this.panelRTop.Controls.Add(this.buttonRegexSearch, 2, 1);
            this.panelRTop.Controls.Add(this.textBoxDirectory, 1, 0);
            this.panelRTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRTop.Location = new System.Drawing.Point(184, 2);
            this.panelRTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelRTop.Name = "panelRTop";
            this.panelRTop.RowCount = 2;
            this.panelRTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelRTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelRTop.Size = new System.Drawing.Size(724, 68);
            this.panelRTop.TabIndex = 9;
            // 
            // panelRBottom
            // 
            this.panelRBottom.Controls.Add(this.buttonAddFolder);
            this.panelRBottom.Controls.Add(this.comboBoxFile);
            this.panelRBottom.Controls.Add(this.label1);
            this.panelRBottom.Controls.Add(this.buttonRemove);
            this.panelRBottom.Controls.Add(this.label2);
            this.panelRBottom.Controls.Add(this.comboBoxDir);
            this.panelRBottom.Controls.Add(this.buttonAddFiles);
            this.panelRBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRBottom.Location = new System.Drawing.Point(182, 414);
            this.panelRBottom.Margin = new System.Windows.Forms.Padding(0);
            this.panelRBottom.Name = "panelRBottom";
            this.panelRBottom.Size = new System.Drawing.Size(728, 36);
            this.panelRBottom.TabIndex = 13;
            // 
            // buttonAddFolder
            // 
            this.buttonAddFolder.Location = new System.Drawing.Point(85, 3);
            this.buttonAddFolder.Name = "buttonAddFolder";
            this.buttonAddFolder.Size = new System.Drawing.Size(104, 28);
            this.buttonAddFolder.TabIndex = 9;
            this.buttonAddFolder.Text = "Add Folder";
            this.buttonAddFolder.UseVisualStyleBackColor = true;
            this.buttonAddFolder.Click += new System.EventHandler(this.buttonAddFolder_Click);
            // 
            // comboBoxFile
            // 
            this.comboBoxFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFile.FormattingEnabled = true;
            this.comboBoxFile.Items.AddRange(new object[] {
            "(default)",
            "/h"});
            this.comboBoxFile.Location = new System.Drawing.Point(639, 7);
            this.comboBoxFile.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFile.Name = "comboBoxFile";
            this.comboBoxFile.Size = new System.Drawing.Size(78, 24);
            this.comboBoxFile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Link Type (file)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Link Type (dir)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxDir
            // 
            this.comboBoxDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDir.FormattingEnabled = true;
            this.comboBoxDir.Items.AddRange(new object[] {
            "/d",
            "/j"});
            this.comboBoxDir.Location = new System.Drawing.Point(415, 7);
            this.comboBoxDir.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDir.Name = "comboBoxDir";
            this.comboBoxDir.Size = new System.Drawing.Size(74, 24);
            this.comboBoxDir.TabIndex = 1;
            // 
            // panelLCenter
            // 
            this.panelLCenter.Controls.Add(this.groupBoxCreate);
            this.panelLCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLCenter.Location = new System.Drawing.Point(0, 72);
            this.panelLCenter.Margin = new System.Windows.Forms.Padding(0);
            this.panelLCenter.Name = "panelLCenter";
            this.panelLCenter.Size = new System.Drawing.Size(182, 342);
            this.panelLCenter.TabIndex = 14;
            // 
            // groupBoxCreate
            // 
            this.groupBoxCreate.Controls.Add(this.buttonCreateUninstaller);
            this.groupBoxCreate.Controls.Add(this.buttonCreateInstaller);
            this.groupBoxCreate.Location = new System.Drawing.Point(2, 2);
            this.groupBoxCreate.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxCreate.Name = "groupBoxCreate";
            this.groupBoxCreate.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxCreate.Size = new System.Drawing.Size(176, 100);
            this.groupBoxCreate.TabIndex = 2;
            this.groupBoxCreate.TabStop = false;
            this.groupBoxCreate.Text = "Create";
            // 
            // buttonCreateUninstaller
            // 
            this.buttonCreateUninstaller.Location = new System.Drawing.Point(10, 56);
            this.buttonCreateUninstaller.Name = "buttonCreateUninstaller";
            this.buttonCreateUninstaller.Size = new System.Drawing.Size(152, 30);
            this.buttonCreateUninstaller.TabIndex = 1;
            this.buttonCreateUninstaller.Text = "SymLink Uninstaller";
            this.buttonCreateUninstaller.UseVisualStyleBackColor = true;
            this.buttonCreateUninstaller.Click += new System.EventHandler(this.buttonCreateUninstaller_Click);
            // 
            // buttonCreateInstaller
            // 
            this.buttonCreateInstaller.Location = new System.Drawing.Point(10, 20);
            this.buttonCreateInstaller.Name = "buttonCreateInstaller";
            this.buttonCreateInstaller.Size = new System.Drawing.Size(152, 30);
            this.buttonCreateInstaller.TabIndex = 0;
            this.buttonCreateInstaller.Text = "SymLink Installer";
            this.buttonCreateInstaller.UseVisualStyleBackColor = true;
            this.buttonCreateInstaller.Click += new System.EventHandler(this.buttonCreateInstaller_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.panelBackTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "No Install";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBackTable.ResumeLayout(false);
            this.panelRTop.ResumeLayout(false);
            this.panelRTop.PerformLayout();
            this.panelRBottom.ResumeLayout(false);
            this.panelRBottom.PerformLayout();
            this.panelLCenter.ResumeLayout(false);
            this.groupBoxCreate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDirectory;
        private System.Windows.Forms.Button buttonSelectDir;
        private System.Windows.Forms.TextBox textBoxRegex;
        private System.Windows.Forms.Label labelDirectory;
        private System.Windows.Forms.Label labelRegex;
        private System.Windows.Forms.Button buttonRegexSearch;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAddFiles;
        private System.Windows.Forms.ListView panelRList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TableLayoutPanel panelBackTable;
        private System.Windows.Forms.TableLayoutPanel panelRTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDir;
        private System.Windows.Forms.Panel panelRBottom;
        private System.Windows.Forms.Button buttonAddFolder;
        private System.Windows.Forms.FlowLayoutPanel panelLCenter;
        private System.Windows.Forms.Button buttonCreateInstaller;
        private System.Windows.Forms.Button buttonCreateUninstaller;
        private System.Windows.Forms.GroupBox groupBoxCreate;
    }
}

