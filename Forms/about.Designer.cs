namespace NO_INSTALL.Forms
{
    partial class about
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
            this.textCategories = new System.Windows.Forms.Label();
            this.textLink = new System.Windows.Forms.LinkLabel();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.textValues = new System.Windows.Forms.Label();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // textCategories
            // 
            this.textCategories.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textCategories.AutoSize = true;
            this.textCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCategories.Location = new System.Drawing.Point(123, 28);
            this.textCategories.Margin = new System.Windows.Forms.Padding(0);
            this.textCategories.Name = "textCategories";
            this.textCategories.Size = new System.Drawing.Size(0, 20);
            this.textCategories.TabIndex = 0;
            this.textCategories.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textLink
            // 
            this.textLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textLink.Location = new System.Drawing.Point(8, 85);
            this.textLink.Margin = new System.Windows.Forms.Padding(0);
            this.textLink.Name = "textLink";
            this.textLink.Size = new System.Drawing.Size(248, 24);
            this.textLink.TabIndex = 1;
            this.textLink.TabStop = true;
            this.textLink.Text = "linkLabel1";
            this.textLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.textLink.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // table
            // 
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.Controls.Add(this.textCategories, 0, 0);
            this.table.Controls.Add(this.textValues, 1, 0);
            this.table.Location = new System.Drawing.Point(9, 9);
            this.table.Margin = new System.Windows.Forms.Padding(0);
            this.table.Name = "table";
            this.table.RowCount = 1;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table.Size = new System.Drawing.Size(246, 76);
            this.table.TabIndex = 4;
            // 
            // textValues
            // 
            this.textValues.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textValues.AutoSize = true;
            this.textValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValues.Location = new System.Drawing.Point(123, 28);
            this.textValues.Margin = new System.Windows.Forms.Padding(0);
            this.textValues.Name = "textValues";
            this.textValues.Size = new System.Drawing.Size(0, 20);
            this.textValues.TabIndex = 1;
            this.textValues.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 115);
            this.Controls.Add(this.table);
            this.Controls.Add(this.textLink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "about";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.about_Load);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label textCategories;
        private System.Windows.Forms.LinkLabel textLink;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Label textValues;
    }
}