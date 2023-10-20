using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace NO_INSTALL.Forms
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void about_Load(object sender, EventArgs e)
        {
            textCategories.Text = "Name:\nVersion:\nAuthor:";
            textValues.Text = $"NO INSTALL\n{ProductVersion}\nwvzxn";
            textLink.Text = @"https://github.com/wvzxn/no_install";
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Process.Start(textLink.Text);
        }
    }
}
