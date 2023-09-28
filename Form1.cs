using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using JR.Utils.GUI.Forms;

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
            this.Text = $"NO INSTALL v{ProductVersion.Substring(0, 5)} (by wvzxn)";
            ControlCenter(textBoxDirectory);
            ControlCenter(textBoxRegex);
            comboBoxFile.Text = comboBoxFile.Items[0].ToString();
            comboBoxDir.Text = comboBoxDir.Items[0].ToString();
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            ControlCenter(textBoxDirectory);
            ControlCenter(textBoxRegex);
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
            string regexDefault = @"vst3|vstplugins|(?:program(?: files(?: \(x86\))?|data))|common files|roaming|documents";
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
                    if (!i.Contains(textBoxDirectory.Text)) { MessageBox.Show($"The item must be inside the folder\n'{textBoxDirectory.Text}'", i); break; }
                    string j = i.Substring(textBoxDirectory.Text.Length + 1);
                    var lvi = new ListViewItem(j);
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
                {
                    string i = dir.SelectedPath.ToString();
                    if (!i.Contains(textBoxDirectory.Text)) { MessageBox.Show($"The item must be inside the folder\n'{textBoxDirectory.Text}'", i); return; }
                    i = i.Substring(textBoxDirectory.Text.Length + 1);
                    panelRList.Items.Add(i).SubItems.Add(comboBoxDir.Text);
                }
            }
        }
        private void buttonCreateInstaller_Click(object sender, EventArgs e)
        {
            string directory = textBoxDirectory.Text;
            if (directory == "") { return; }

            string reg = @"1.reg";
            if (checkBox1.Checked) { CreatePlusFolder(directory); reg = @"+\" + reg; }
            if (!File.Exists(Path.Combine(directory, reg))) { reg = @""; }

            CreateCmd(directory + @"\SymLink Installer.cmd", GetCmdList(true, reg));
        }
        private void buttonCreateUninstaller_Click(object sender, EventArgs e)
        {
            string directory = textBoxDirectory.Text;
            if (directory == "") { return; }

            string reg = @"2.reg";
            if (checkBox1.Checked) { CreatePlusFolder(directory); reg = @"+\" + reg; }
            if (!File.Exists(Path.Combine(directory, reg))) { reg = @""; }

            CreateCmd(textBoxDirectory.Text + @"\SymLink Uninstaller.cmd", GetCmdList(false, reg));
        }
        private void buttonCreate2Reg_Click(object sender, EventArgs e)
        {
            if (textBoxDirectory.Text == "") { return; }
            CreateRegUninstall($"{textBoxDirectory.Text}\\1.reg", $"{textBoxDirectory.Text}\\2.reg");
        }
        private void buttonSandboxie_Click(object sender, EventArgs e)
        {
            string currentDir = textBoxDirectory.Text;
            if (currentDir == "") { return; }

            string envSystemDrive = Environment.GetEnvironmentVariable("SYSTEMDRIVE") + @"\";
            string envUserName = Environment.GetEnvironmentVariable("USERNAME");
            string Sandboxie = Path.Combine(envSystemDrive, "Sandbox", envUserName, "DefaultBox");
            string SandboxieC = Path.Combine(Sandboxie, @"drive\C");
            string SandboxieData = Path.Combine(Sandboxie, @"user\all");
            string SandboxieUser = Path.Combine(Sandboxie, @"user\current");

            CopyDirectory(SandboxieC, Path.Combine(currentDir, @"C"), true);
            CopyDirectory(SandboxieData, Path.Combine(currentDir, @"C\ProgramData"), true);
            CopyDirectory(SandboxieUser, Path.Combine(currentDir, @"C\Users\(Name)"), true);
        }
        private void buttonRemoveJunk_Click(object sender, EventArgs e)
        {
            string currentDir = textBoxDirectory.Text;
            string regex = textBoxRegex.Text;
            if (currentDir == "") { return; }
            //if (regex == "") { return; }

            string regexJunk1 = @"(?:microsoft\\windows\\start menu\\(.+?$))";
            string regexJunk2 = @"(?:users\\.+?\\desktop\\(.+?$))";
            string regexJunk3 = @"(?:program(?: files(?: \(x86\))?|data))\\.+?\\(unins.*?\.|.+?\.ico)";
            string regexJunk = regexJunk1 + @"|" + regexJunk2 + @"|" + regexJunk3;

            Regex regexMatch = new Regex(regex, RegexOptions.IgnoreCase);
            Regex regexJunkMatch = new Regex(regexJunk, RegexOptions.IgnoreCase);

            var files = Directory.EnumerateFiles(Path.Combine(currentDir, @"C"), @"*", SearchOption.AllDirectories);
            //string str = "";
            foreach (string file in files)
            {
                string i = file.Substring(currentDir.Length + 1);
                if (regexJunkMatch.IsMatch(i) || !regexMatch.IsMatch(i)) { File.Delete(file); }
            }
            Directory.Delete(Path.Combine(currentDir, @"C\ProgramData\Microsoft\Windows\Start Menu"), true);
            DeleteEmptyDirs(currentDir, regex);
            //FlexibleMessageBox.Show(str);
        }


        // File creation, editing and deleting
        private void CreatePlusFolder(string Dir)
        {
            string plusDir = Path.Combine(Dir, @"+");
            if (!Directory.Exists(plusDir)) { Directory.CreateDirectory(plusDir); }
            var files = Directory.EnumerateFiles(Dir, "*", SearchOption.TopDirectoryOnly);
            foreach (string filePath in files)
            {
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                string fileExt = Path.GetExtension(filePath);
                string fileNewPath = Path.Combine(plusDir, fileName + fileExt);
                if (File.Exists(fileNewPath)) { fileNewPath = Path.Combine(plusDir, fileName + @" (2)" + fileExt); }
                if (!Regex.IsMatch(fileName + fileExt, @"symlink|\.cmd", RegexOptions.IgnoreCase)) { File.Move(filePath, fileNewPath); }
            }
        }
        private void CreateBackupFile(string filePath)
        {
            string backupPath = filePath + @".BAK";

            if (File.Exists(filePath))
            {
                if (File.Exists(backupPath)) { File.Delete(backupPath); }
                File.Move(filePath, backupPath);
            }
        }
        private void CreateCmd(string filePath, List<string> commands)
        {
            string dirPath = Path.GetDirectoryName(filePath);
            string dirName = Path.GetFileName(dirPath);
            string fileName = Path.GetFileNameWithoutExtension(filePath);
            string dirNamePad = "", fileNamePad = "";
            for (int i = 0; i < ((60 - dirName.Length) / 2); i++) { dirNamePad += " "; }
            for (int i = 0; i < ((60 - fileName.Length) / 2); i++) { fileNamePad += " "; }

            var text = new List<string>
            {
                $"::        Generated via NO INSTALL v{ProductVersion.Substring(0, 5)} | https://github.com/wvzxn/no_install",
                $"::        {DateTime.Now:yyyy/MM/dd HH:mm:ss}",
                @"",
                @"@echo off",
                "cd /d \"%~dp0\"",
                @"fsutil dirty query %SYSTEMDRIVE% >nul",
                @"if ERRORLEVEL 1 (echo Run as Administrator required & pause & exit)",
                $"title {fileName}",
                @"echo ############################################################",
                $"echo {fileNamePad}{fileName}",
                @"echo ############################################################",
                $"echo {dirNamePad}{dirName}",
                @"echo ############################################################",
                @"pause & echo:",
                @""
            };
            text.AddRange(commands);
            text.Add(@"");
            text.Add(@"echo: & pause");

            CreateBackupFile(filePath);

            using (var file = new StreamWriter(filePath, false))
            {
                foreach (var line in text) { file.WriteLine(line); }
            }
        }
        private void CreateRegUninstall(string sourcePath, string destinationPath)
        {
            List<string> lines2write = new List<string>();
            string[] lines = File.ReadAllLines(sourcePath);

            foreach (string line in lines)
            {
                if (line.StartsWith("[")) { lines2write.Add(line.Replace("[", "[-")); }
                if (line.StartsWith("windows registry editor", true, null) ||
                    line.StartsWith("regedit", true, null)) { lines2write.Add(line); lines2write.Add(""); }
                if (line.StartsWith(";")) { lines2write.Add(line); }
            }

            CreateBackupFile(destinationPath);

            using (var file = new StreamWriter(destinationPath, false))
            {
                foreach (var line in lines2write) { file.WriteLine(line); }
            }
        }
        private void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
        {
            // Get information about the source directory
            var dir = new DirectoryInfo(sourceDir);

            // Check if the source directory exists
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            // Cache directories before we start copying
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Create the destination directory
            Directory.CreateDirectory(destinationDir);

            // Get the files in the source directory and copy to the destination directory
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                file.CopyTo(targetFilePath);
            }

            // If recursive and copying subdirectories, recursively call this method
            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir, true);
                }
            }
        }
        private void DeleteEmptyDirs(string dir, string regexExclude)
        {
            if (String.IsNullOrEmpty(dir))
            {
                throw new ArgumentException(
                    "Starting directory is a null reference or an empty string",
                    "dir");
            }

            try
            {
                foreach (var d in Directory.EnumerateDirectories(dir))
                {
                    string r = regexExclude;
                    DeleteEmptyDirs(d, r);
                }

                var entries = Directory.EnumerateFileSystemEntries(dir);


                if (!entries.Any())
                {
                    try
                    {
                        bool ex = Regex.IsMatch(new DirectoryInfo(dir).Name, regexExclude, RegexOptions.IgnoreCase);
                        //FlexibleMessageBox.Show($"Path: '{dir}'\nName: '{new DirectoryInfo(dir).Name}'\nMatches: " + ex.ToString());
                        if (ex) { return; }
                        Directory.Delete(dir);
                    }
                    catch (UnauthorizedAccessException) { }
                    catch (DirectoryNotFoundException) { }
                }
            }
            catch (UnauthorizedAccessException) { }
        }

        // String editing
        private string EditEnv(string var2edit) // Ex. '..\appdata\roaming' --> '%APPDATA%'
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
        private List<string> GetCmdList(bool installer, string reg) // mklink, md, regedit
        {
            string par;
            string itemPath;
            string parentPath;
            string parentName;
            string mdPattern = @"program files|common files|programdata|roaming|documents|\%[^\%]+?\%";
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
            if (reg != "")
            {
                list.Add(@"");
                if (installer)
                {
                    list.AddRange(new List<string>
                    {
                        @":: Replace old user Drive letter + Name in 1.reg",
                        ":: powershell \"(gc -LiteralPath '%~dp0+\\1.reg') -replace '(.:)(\\\\\\\\Users\\\\\\\\)[^\\\\]+?\\\\\\\\','%SYSTEMDRIVE%${2}%USERNAME%\\\\'|sc -LiteralPath '%~dp0+\\1.reg'\""
                    });
                }
                list.Add($"regedit /s {reg}");
            }
            return list;
        }

        // Misc
        private void ControlCenter(Control item) // Snap a control to the center of parent item
        {
            int pad = ((item.Parent.Height / 2) - item.Height) / 2;
            item.Margin = new Padding(item.Margin.Left, pad, item.Margin.Right, pad);
        }
    }

    class Background
    {
        public static void Test(string[] arguments)
        {
            FlexibleMessageBox.Show(arguments[0]);
        }
    }
}
