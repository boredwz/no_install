using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace no_install
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxFile.Text = comboBoxFile.Items[0].ToString();
            comboBoxDir.Text = comboBoxDir.Items[0].ToString();
        }

        private void panelRList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
            {
                if (panelRList.Sorting != SortOrder.Ascending) { panelRList.Sorting = SortOrder.Ascending; }
                else { panelRList.Sorting = SortOrder.Descending; }
                panelRList.Sort();
            }
        }

        private void buttonSelectDir_Click(object sender, EventArgs e)
        {
            using (var dir = new FolderBrowserDialog())
            {
                DialogResult result = dir.ShowDialog();
                if (result == DialogResult.OK) { textBoxDirectory.Text = dir.SelectedPath.ToString(); }
            }
        }

        private void buttonRegexSearch_Click(object sender, EventArgs e)
        {
            if (textBoxDirectory.Text == "") { return; }
            panelRList.Items.Clear();
            string regexDefault = @"vst3|vstplugins|program files|common files|programdata|roaming|documents";
            string regex = textBoxRegex.Text;

            foreach (string itemFullPath in Directory.EnumerateDirectories(textBoxDirectory.Text, "*", SearchOption.AllDirectories))
            {
                string itemPath = itemFullPath.Substring(textBoxDirectory.Text.Length + 1);
                string itemName = Regex.Replace(itemPath, @".+\\(.+?)$", @"$1");

                if (regex == "")
                {
                    if (!Regex.IsMatch(itemPath, $"(?:{regexDefault})" + @"\\([^\\]+?)$", RegexOptions.IgnoreCase)) { continue; }
                }
                else
                {
                    if ((!Regex.IsMatch(itemName, regex, RegexOptions.IgnoreCase))
                    || (Regex.IsMatch(itemPath, $"({regex}).+?({regex})", RegexOptions.IgnoreCase))) { continue; }
                }

                var lvi = new ListViewItem(itemPath);
                lvi.SubItems.Add(File.Exists(itemFullPath) ? comboBoxFile.Text : comboBoxDir.Text);
                lvi.Checked = !Regex.IsMatch(itemName, regexDefault, RegexOptions.IgnoreCase);
                panelRList.Items.Add(lvi);

                //      Directory check
                if (!Directory.Exists(itemFullPath)) { continue; }

                //      Child items check
                foreach (string i in Directory.EnumerateFileSystemEntries(itemFullPath, "*"))
                {
                    string iPath = i.Substring(textBoxDirectory.Text.Length + 1);
                    string iName = Regex.Replace(iPath, @".+\\(.+?)$", @"$1");

                    if (!Regex.IsMatch(iName, regex, RegexOptions.IgnoreCase)) { continue; }

                    var ilvi = new ListViewItem(iPath);
                    ilvi.SubItems.Add(File.Exists(i) ? comboBoxFile.Text : comboBoxDir.Text);
                    panelRList.Items.Add(ilvi);
                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in panelRList.SelectedItems) { panelRList.Items.Remove(i); }
        }

        private void buttonAddFiles_Click(object sender, EventArgs e)
        {
            var dir = new OpenFileDialog
            {
                InitialDirectory = textBoxDirectory.Text,
                Multiselect = true
            };
            DialogResult result = dir.ShowDialog();
            if (result == DialogResult.OK)
            {
                foreach (string i in dir.FileNames)
                {
                    var lvi = new ListViewItem(i);
                    lvi.SubItems.Add(comboBoxFile.Text);
                    panelRList.Items.Add(lvi);
                }
            }
        }

        private void buttonAddFolder_Click(object sender, EventArgs e)
        {
            using (var dir = new FolderBrowserDialog())
            {
                DialogResult result = dir.ShowDialog();
                if (result == DialogResult.OK)
                    panelRList.Items.Add(dir.SelectedPath.ToString()).SubItems.Add(comboBoxDir.Text);
            }
        }

        private void buttonCreateInstaller_Click(object sender, EventArgs e)
        {
            if (textBoxDirectory.Text == "") { return; }
            CreateCmd(textBoxDirectory.Text + @"\SymLink Installer.cmd", GetCmdList(true));
        }

        private void buttonCreateUninstaller_Click(object sender, EventArgs e)
        {
            if (textBoxDirectory.Text == "") { return; }
            CreateCmd(textBoxDirectory.Text + @"\SymLink Uninstaller.cmd", GetCmdList(false));
        }

        private List<string> GetCmdList (bool installer)
        {
            string par;
            string itemPath;
            string parentPath;
            string parentName;
            string mdPattern = @"program files|common files|programdata|roaming|documents|%.+?%";
            var list = new List<string>();
            var list2 = new List<string>();
            var mdDuplicateList = new List<string>();

            foreach (ListViewItem listItem in panelRList.Items)
            {
                if (!listItem.Checked) { continue; }

                if (installer) { par = listItem.SubItems[1].Text == "(default)" ? "" : $"{listItem.SubItems[1].Text} "; }
                else { par = File.Exists(textBoxDirectory.Text + "\\" + listItem.Text) ? "del /f /q" : "rd /q"; }
                itemPath = EditEnv(listItem.Text);
                parentPath = Path.GetDirectoryName(itemPath);
                parentName = Regex.Replace(listItem.Text, @".+\\(.+?)\\.+?$", @"$1");

                if ((!Regex.IsMatch(parentName, mdPattern, RegexOptions.IgnoreCase))
                && (!mdDuplicateList.Contains(parentPath)))
                {
                    mdDuplicateList.Add(parentPath);
                    if (installer) { list.Add($"md \"{parentPath}\" && echo Folder created: {parentPath}"); }
                    else { list2.Add($"rd /q \"{parentPath}\" && echo Deleted: {parentPath}"); }
                }
                if (installer) { list.Add($"mklink {par}\"{itemPath}\" \"%~dp0{listItem.Text}\""); }
                else { list.Add($"{par} \"{itemPath}\" && echo Deleted: {itemPath}"); }
            }
            if (!installer) { list.AddRange(list2); }
            return list;
        }

        private void CreateCmd(string filePath, List<string> commands)
        {
            string folderName = Path.GetFileName(Path.GetDirectoryName(filePath));
            string title = Path.GetFileNameWithoutExtension(filePath);
            string folderNamePad = null;
            string titlePad = null;
            for (int i = 0; i < ((45 - folderName.Length) / 2); i++) { folderNamePad += " "; }
            for (int i = 0; i < ((45 - title.Length) / 2); i++) { titlePad += " "; }

            var text = new List<string>
            {
                $"::        Generated {DateTime.Now:yyyy/MM/dd HH:mm:ss} | https://github.com/wvzxn/no_install | v{ProductVersion.Substring(0, 3)}",
                "@echo off",
                "cd /d \"%~dp0\"",
                "fsutil dirty query %SYSTEMDRIVE% >nul",
                "if ERRORLEVEL 1 (echo Run as Administrator required & pause & exit)",
                "echo #############################################",
                $"echo {titlePad}{title}",
                "echo #############################################",
                $"echo {folderNamePad}{folderName}",
                "echo #############################################",
                "pause & echo:"
            };
            text.AddRange(commands);
            text.Add("echo: & pause");

            using (StreamWriter file = new StreamWriter(filePath, false))
            {
                foreach (var i in text)
                {
                    file.WriteLine(i);
                }
            }
        }

        private string EditEnv(string var2edit)
        {
            var replace1list = new List<string>
            {
                @"^(c)",
                @"^(.+?appdata\\roaming)",
                @"^(.+?appdata\\local)",
                @"^(.*?users\\\(name\))",
                @"^(.*?common files)",
                @"^(.*?program files)",
                @"^(.*?programdata)"
            };
            var replace2list = new List<string>
            {
                @"%SYSTEMDRIVE%",
                @"%APPDATA%",
                @"%LOCALAPPDATA%",
                @"%USERPROFILE%",
                @"%COMMONPROGRAMFILES%",
                @"%PROGRAMFILES%",
                @"%PROGRAMDATA%"
            };
            for (int i = 0; i < replace1list.Count; i++)
            {
                var2edit = Regex.Replace(var2edit, replace1list[i], replace2list[i], RegexOptions.IgnoreCase);
            }
            return var2edit;
        }
    }

    class Background
    {
        public static void Test(string[] arguments)
        {
            MessageBox.Show(arguments[0]);
        }
    }
}
