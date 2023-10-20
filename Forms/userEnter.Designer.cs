namespace NO_INSTALL.Forms
{
    partial class userEnter
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
            this.text = new System.Windows.Forms.Label();
            this.folderName = new System.Windows.Forms.TextBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text.Location = new System.Drawing.Point(14, 15);
            this.text.Margin = new System.Windows.Forms.Padding(0);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(251, 28);
            this.text.TabIndex = 0;
            this.text.Text = "Enter the name:";
            this.text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // folderName
            // 
            this.folderName.Location = new System.Drawing.Point(11, 40);
            this.folderName.Margin = new System.Windows.Forms.Padding(0);
            this.folderName.Name = "folderName";
            this.folderName.Size = new System.Drawing.Size(251, 22);
            this.folderName.TabIndex = 1;
            // 
            // buttonResult
            // 
            this.buttonResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonResult.Location = new System.Drawing.Point(184, 66);
            this.buttonResult.Margin = new System.Windows.Forms.Padding(0);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(78, 27);
            this.buttonResult.TabIndex = 2;
            this.buttonResult.Text = "OK";
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // UserEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 104);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.folderName);
            this.Controls.Add(this.text);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserEnter";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Addon: Collect VSTs in a folder";
            this.Load += new System.EventHandler(this.UserEnter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox folderName;
        private System.Windows.Forms.Button buttonResult;
    }
}