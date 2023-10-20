using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NO_INSTALL.Forms
{
    public partial class userEnter : Form
    {
        public userEnter()
        {
            InitializeComponent();
        }
        private void UserEnter_Load(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
        }
        public string returnValue
        {
            get { return folderName.Text; }
        }
        private void buttonResult_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
