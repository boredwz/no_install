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
            this.buttonAddFolder = new System.Windows.Forms.Button();
            this.comboBoxFile = new System.Windows.Forms.ComboBox();
            this.labelComboFile = new System.Windows.Forms.Label();
            this.comboBoxDir = new System.Windows.Forms.ComboBox();
            this.buttonCreateUninstaller = new System.Windows.Forms.Button();
            this.buttonCreateInstaller = new System.Windows.Forms.Button();
            this.labelComboDir = new System.Windows.Forms.Label();
            this.tableBack = new System.Windows.Forms.TableLayoutPanel();
            this.tableL = new System.Windows.Forms.TableLayoutPanel();
            this.tableL1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableL3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonRemoveJunk = new System.Windows.Forms.Button();
            this.buttonSandboxie = new System.Windows.Forms.Button();
            this.tableRGroupCreate = new System.Windows.Forms.GroupBox();
            this.buttonCreate2Reg = new System.Windows.Forms.Button();
            this.tableRGroupLinkType = new System.Windows.Forms.GroupBox();
            this.tableBack.SuspendLayout();
            this.tableL.SuspendLayout();
            this.tableL1.SuspendLayout();
            this.tableL3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableRGroupCreate.SuspendLayout();
            this.tableRGroupLinkType.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDirectory.Location = new System.Drawing.Point(78, 0);
            this.textBoxDirectory.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(629, 22);
            this.textBoxDirectory.TabIndex = 0;
            // 
            // buttonSelectDir
            // 
            this.buttonSelectDir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSelectDir.Location = new System.Drawing.Point(711, 4);
            this.buttonSelectDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonSelectDir.MaximumSize = new System.Drawing.Size(70, 30);
            this.buttonSelectDir.Name = "buttonSelectDir";
            this.buttonSelectDir.Size = new System.Drawing.Size(70, 30);
            this.buttonSelectDir.TabIndex = 1;
            this.buttonSelectDir.Text = "...";
            this.buttonSelectDir.UseVisualStyleBackColor = true;
            this.buttonSelectDir.Click += new System.EventHandler(this.buttonSelectDir_Click);
            // 
            // textBoxRegex
            // 
            this.textBoxRegex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRegex.Location = new System.Drawing.Point(78, 38);
            this.textBoxRegex.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxRegex.Name = "textBoxRegex";
            this.textBoxRegex.Size = new System.Drawing.Size(629, 22);
            this.textBoxRegex.TabIndex = 2;
            // 
            // labelDirectory
            // 
            this.labelDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDirectory.Location = new System.Drawing.Point(4, 0);
            this.labelDirectory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDirectory.Name = "labelDirectory";
            this.labelDirectory.Size = new System.Drawing.Size(70, 38);
            this.labelDirectory.TabIndex = 3;
            this.labelDirectory.Text = "Directory";
            this.labelDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRegex
            // 
            this.labelRegex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRegex.Location = new System.Drawing.Point(4, 38);
            this.labelRegex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegex.Name = "labelRegex";
            this.labelRegex.Size = new System.Drawing.Size(70, 38);
            this.labelRegex.TabIndex = 4;
            this.labelRegex.Text = "Regex";
            this.labelRegex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonRegexSearch
            // 
            this.buttonRegexSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRegexSearch.Location = new System.Drawing.Point(711, 42);
            this.buttonRegexSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonRegexSearch.MaximumSize = new System.Drawing.Size(70, 30);
            this.buttonRegexSearch.Name = "buttonRegexSearch";
            this.buttonRegexSearch.Size = new System.Drawing.Size(70, 30);
            this.buttonRegexSearch.TabIndex = 9;
            this.buttonRegexSearch.Text = "Search";
            this.buttonRegexSearch.UseVisualStyleBackColor = true;
            this.buttonRegexSearch.Click += new System.EventHandler(this.buttonRegexSearch_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRemove.Location = new System.Drawing.Point(192, 2);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(86, 30);
            this.buttonRemove.TabIndex = 8;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAddFiles
            // 
            this.buttonAddFiles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddFiles.Location = new System.Drawing.Point(4, 2);
            this.buttonAddFiles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonAddFiles.Name = "buttonAddFiles";
            this.buttonAddFiles.Size = new System.Drawing.Size(86, 30);
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
            this.panelRList.Location = new System.Drawing.Point(4, 76);
            this.panelRList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panelRList.Name = "panelRList";
            this.panelRList.Size = new System.Drawing.Size(777, 383);
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
            // buttonAddFolder
            // 
            this.buttonAddFolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddFolder.Location = new System.Drawing.Point(98, 2);
            this.buttonAddFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonAddFolder.Name = "buttonAddFolder";
            this.buttonAddFolder.Size = new System.Drawing.Size(86, 30);
            this.buttonAddFolder.TabIndex = 9;
            this.buttonAddFolder.Text = "Add Folder";
            this.buttonAddFolder.UseVisualStyleBackColor = true;
            this.buttonAddFolder.Click += new System.EventHandler(this.buttonAddFolder_Click);
            // 
            // comboBoxFile
            // 
            this.comboBoxFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFile.FormattingEnabled = true;
            this.comboBoxFile.Items.AddRange(new object[] {
            "(default)",
            "/h"});
            this.comboBoxFile.Location = new System.Drawing.Point(53, 27);
            this.comboBoxFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.comboBoxFile.Name = "comboBoxFile";
            this.comboBoxFile.Size = new System.Drawing.Size(131, 24);
            this.comboBoxFile.TabIndex = 1;
            // 
            // labelComboFile
            // 
            this.labelComboFile.AutoSize = true;
            this.labelComboFile.Location = new System.Drawing.Point(13, 30);
            this.labelComboFile.Margin = new System.Windows.Forms.Padding(0);
            this.labelComboFile.Name = "labelComboFile";
            this.labelComboFile.Size = new System.Drawing.Size(29, 16);
            this.labelComboFile.TabIndex = 0;
            this.labelComboFile.Text = "File";
            this.labelComboFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxDir
            // 
            this.comboBoxDir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDir.FormattingEnabled = true;
            this.comboBoxDir.Items.AddRange(new object[] {
            "/d",
            "/j"});
            this.comboBoxDir.Location = new System.Drawing.Point(53, 61);
            this.comboBoxDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.comboBoxDir.Name = "comboBoxDir";
            this.comboBoxDir.Size = new System.Drawing.Size(131, 24);
            this.comboBoxDir.TabIndex = 1;
            // 
            // buttonCreateUninstaller
            // 
            this.buttonCreateUninstaller.Location = new System.Drawing.Point(7, 48);
            this.buttonCreateUninstaller.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonCreateUninstaller.Name = "buttonCreateUninstaller";
            this.buttonCreateUninstaller.Size = new System.Drawing.Size(180, 30);
            this.buttonCreateUninstaller.TabIndex = 1;
            this.buttonCreateUninstaller.Text = "SymLink Uninstaller";
            this.buttonCreateUninstaller.UseVisualStyleBackColor = true;
            this.buttonCreateUninstaller.Click += new System.EventHandler(this.buttonCreateUninstaller_Click);
            // 
            // buttonCreateInstaller
            // 
            this.buttonCreateInstaller.Location = new System.Drawing.Point(7, 18);
            this.buttonCreateInstaller.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttonCreateInstaller.Name = "buttonCreateInstaller";
            this.buttonCreateInstaller.Size = new System.Drawing.Size(180, 30);
            this.buttonCreateInstaller.TabIndex = 0;
            this.buttonCreateInstaller.Text = "SymLink Installer";
            this.buttonCreateInstaller.UseVisualStyleBackColor = true;
            this.buttonCreateInstaller.Click += new System.EventHandler(this.buttonCreateInstaller_Click);
            // 
            // labelComboDir
            // 
            this.labelComboDir.AutoSize = true;
            this.labelComboDir.Location = new System.Drawing.Point(18, 64);
            this.labelComboDir.Margin = new System.Windows.Forms.Padding(0);
            this.labelComboDir.Name = "labelComboDir";
            this.labelComboDir.Size = new System.Drawing.Size(24, 16);
            this.labelComboDir.TabIndex = 0;
            this.labelComboDir.Text = "Dir";
            this.labelComboDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableBack
            // 
            this.tableBack.ColumnCount = 2;
            this.tableBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableBack.Controls.Add(this.tableL, 0, 0);
            this.tableBack.Controls.Add(this.panel2, 1, 0);
            this.tableBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableBack.Location = new System.Drawing.Point(0, 0);
            this.tableBack.Margin = new System.Windows.Forms.Padding(0);
            this.tableBack.Name = "tableBack";
            this.tableBack.RowCount = 1;
            this.tableBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableBack.Size = new System.Drawing.Size(982, 493);
            this.tableBack.TabIndex = 14;
            // 
            // tableL
            // 
            this.tableL.ColumnCount = 1;
            this.tableL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableL.Controls.Add(this.panelRList, 0, 1);
            this.tableL.Controls.Add(this.tableL1, 0, 0);
            this.tableL.Controls.Add(this.tableL3, 0, 2);
            this.tableL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableL.Location = new System.Drawing.Point(0, 0);
            this.tableL.Margin = new System.Windows.Forms.Padding(0);
            this.tableL.Name = "tableL";
            this.tableL.RowCount = 3;
            this.tableL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.54339F));
            this.tableL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.71693F));
            this.tableL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.73968F));
            this.tableL.Size = new System.Drawing.Size(785, 493);
            this.tableL.TabIndex = 0;
            // 
            // tableL1
            // 
            this.tableL1.ColumnCount = 3;
            this.tableL1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableL1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableL1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableL1.Controls.Add(this.textBoxRegex, 1, 1);
            this.tableL1.Controls.Add(this.textBoxDirectory, 1, 0);
            this.tableL1.Controls.Add(this.buttonRegexSearch, 2, 1);
            this.tableL1.Controls.Add(this.labelDirectory, 0, 0);
            this.tableL1.Controls.Add(this.labelRegex, 0, 1);
            this.tableL1.Controls.Add(this.buttonSelectDir, 2, 0);
            this.tableL1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableL1.Location = new System.Drawing.Point(0, 0);
            this.tableL1.Margin = new System.Windows.Forms.Padding(0);
            this.tableL1.Name = "tableL1";
            this.tableL1.RowCount = 2;
            this.tableL1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableL1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableL1.Size = new System.Drawing.Size(785, 76);
            this.tableL1.TabIndex = 8;
            // 
            // tableL3
            // 
            this.tableL3.ColumnCount = 4;
            this.tableL3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableL3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableL3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableL3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableL3.Controls.Add(this.buttonRemove, 2, 0);
            this.tableL3.Controls.Add(this.buttonAddFolder, 1, 0);
            this.tableL3.Controls.Add(this.buttonAddFiles, 0, 0);
            this.tableL3.Controls.Add(this.panel1, 3, 0);
            this.tableL3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableL3.Location = new System.Drawing.Point(0, 459);
            this.tableL3.Margin = new System.Windows.Forms.Padding(0);
            this.tableL3.Name = "tableL3";
            this.tableL3.RowCount = 1;
            this.tableL3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableL3.Size = new System.Drawing.Size(785, 34);
            this.tableL3.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(285, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 28);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.buttonRemoveJunk);
            this.panel2.Controls.Add(this.buttonSandboxie);
            this.panel2.Controls.Add(this.tableRGroupCreate);
            this.panel2.Controls.Add(this.tableRGroupLinkType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(785, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 493);
            this.panel2.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 466);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 20);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Use \'+\' directory";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveJunk
            // 
            this.buttonRemoveJunk.Location = new System.Drawing.Point(7, 282);
            this.buttonRemoveJunk.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRemoveJunk.Name = "buttonRemoveJunk";
            this.buttonRemoveJunk.Size = new System.Drawing.Size(180, 30);
            this.buttonRemoveJunk.TabIndex = 5;
            this.buttonRemoveJunk.Text = "Remove junk (Regex)";
            this.buttonRemoveJunk.UseVisualStyleBackColor = true;
            this.buttonRemoveJunk.Click += new System.EventHandler(this.buttonRemoveJunk_Click);
            // 
            // buttonSandboxie
            // 
            this.buttonSandboxie.Location = new System.Drawing.Point(7, 249);
            this.buttonSandboxie.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSandboxie.Name = "buttonSandboxie";
            this.buttonSandboxie.Size = new System.Drawing.Size(180, 30);
            this.buttonSandboxie.TabIndex = 4;
            this.buttonSandboxie.Text = "Copy from Sandboxie";
            this.buttonSandboxie.UseVisualStyleBackColor = true;
            this.buttonSandboxie.Click += new System.EventHandler(this.buttonSandboxie_Click);
            // 
            // tableRGroupCreate
            // 
            this.tableRGroupCreate.Controls.Add(this.buttonCreate2Reg);
            this.tableRGroupCreate.Controls.Add(this.buttonCreateInstaller);
            this.tableRGroupCreate.Controls.Add(this.buttonCreateUninstaller);
            this.tableRGroupCreate.Location = new System.Drawing.Point(0, 76);
            this.tableRGroupCreate.Name = "tableRGroupCreate";
            this.tableRGroupCreate.Size = new System.Drawing.Size(194, 152);
            this.tableRGroupCreate.TabIndex = 3;
            this.tableRGroupCreate.TabStop = false;
            this.tableRGroupCreate.Text = "Create";
            // 
            // buttonCreate2Reg
            // 
            this.buttonCreate2Reg.Location = new System.Drawing.Point(7, 97);
            this.buttonCreate2Reg.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCreate2Reg.Name = "buttonCreate2Reg";
            this.buttonCreate2Reg.Size = new System.Drawing.Size(180, 30);
            this.buttonCreate2Reg.TabIndex = 2;
            this.buttonCreate2Reg.Text = "2.reg";
            this.buttonCreate2Reg.UseVisualStyleBackColor = true;
            this.buttonCreate2Reg.Click += new System.EventHandler(this.buttonCreate2Reg_Click);
            // 
            // tableRGroupLinkType
            // 
            this.tableRGroupLinkType.Controls.Add(this.comboBoxFile);
            this.tableRGroupLinkType.Controls.Add(this.comboBoxDir);
            this.tableRGroupLinkType.Controls.Add(this.labelComboFile);
            this.tableRGroupLinkType.Controls.Add(this.labelComboDir);
            this.tableRGroupLinkType.Location = new System.Drawing.Point(0, 366);
            this.tableRGroupLinkType.Name = "tableRGroupLinkType";
            this.tableRGroupLinkType.Size = new System.Drawing.Size(194, 93);
            this.tableRGroupLinkType.TabIndex = 2;
            this.tableRGroupLinkType.TabStop = false;
            this.tableRGroupLinkType.Text = "Default Link Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 493);
            this.Controls.Add(this.tableBack);
            this.Name = "Form1";
            this.Text = "NO INSTALL (by wvzxn)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.tableBack.ResumeLayout(false);
            this.tableL.ResumeLayout(false);
            this.tableL1.ResumeLayout(false);
            this.tableL1.PerformLayout();
            this.tableL3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableRGroupCreate.ResumeLayout(false);
            this.tableRGroupLinkType.ResumeLayout(false);
            this.tableRGroupLinkType.PerformLayout();
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
        private System.Windows.Forms.Label labelComboFile;
        private System.Windows.Forms.ComboBox comboBoxFile;
        private System.Windows.Forms.ComboBox comboBoxDir;
        private System.Windows.Forms.Button buttonAddFolder;
        private System.Windows.Forms.Button buttonCreateInstaller;
        private System.Windows.Forms.Button buttonCreateUninstaller;
        private System.Windows.Forms.TableLayoutPanel tableBack;
        private System.Windows.Forms.TableLayoutPanel tableL;
        private System.Windows.Forms.TableLayoutPanel tableL1;
        private System.Windows.Forms.TableLayoutPanel tableL3;
        private System.Windows.Forms.Label labelComboDir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox tableRGroupLinkType;
        private System.Windows.Forms.GroupBox tableRGroupCreate;
        private System.Windows.Forms.Button buttonCreate2Reg;
        private System.Windows.Forms.Button buttonSandboxie;
        private System.Windows.Forms.Button buttonRemoveJunk;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

