namespace YahtzeeSharp
{
    partial class frmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
        	this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
        	this.labelProductName = new System.Windows.Forms.Label();
        	this.labelVersion = new System.Windows.Forms.Label();
        	this.labelCopyright = new System.Windows.Forms.Label();
        	this.labelCompanyName = new System.Windows.Forms.Label();
        	this.textBoxDescription = new System.Windows.Forms.TextBox();
        	this.okButton = new System.Windows.Forms.Button();
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.lbnLicenceText = new System.Windows.Forms.LinkLabel();
        	this.lbnKnownIssues = new System.Windows.Forms.LinkLabel();
        	this.lbnWhatsNext = new System.Windows.Forms.LinkLabel();
        	this.lbnChangeLog = new System.Windows.Forms.LinkLabel();
        	this.logoPictureBox = new System.Windows.Forms.PictureBox();
        	this.tableLayoutPanel.SuspendLayout();
        	this.panel1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// tableLayoutPanel
        	// 
        	this.tableLayoutPanel.ColumnCount = 2;
        	this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
        	this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
        	this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
        	this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
        	this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
        	this.tableLayoutPanel.Controls.Add(this.labelCopyright, 1, 2);
        	this.tableLayoutPanel.Controls.Add(this.labelCompanyName, 1, 3);
        	this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 4);
        	this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
        	this.tableLayoutPanel.Controls.Add(this.panel1, 0, 4);
        	this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tableLayoutPanel.Location = new System.Drawing.Point(9, 9);
        	this.tableLayoutPanel.Name = "tableLayoutPanel";
        	this.tableLayoutPanel.RowCount = 6;
        	this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        	this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        	this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        	this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        	this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
        	this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        	this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        	this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        	this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        	this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        	this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        	this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        	this.tableLayoutPanel.Size = new System.Drawing.Size(417, 265);
        	this.tableLayoutPanel.TabIndex = 0;
        	// 
        	// labelProductName
        	// 
        	this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.labelProductName.Location = new System.Drawing.Point(143, 0);
        	this.labelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
        	this.labelProductName.MaximumSize = new System.Drawing.Size(0, 17);
        	this.labelProductName.Name = "labelProductName";
        	this.labelProductName.Size = new System.Drawing.Size(271, 17);
        	this.labelProductName.TabIndex = 19;
        	this.labelProductName.Text = "Product Name";
        	this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// labelVersion
        	// 
        	this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.labelVersion.Location = new System.Drawing.Point(143, 29);
        	this.labelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
        	this.labelVersion.MaximumSize = new System.Drawing.Size(0, 17);
        	this.labelVersion.Name = "labelVersion";
        	this.labelVersion.Size = new System.Drawing.Size(271, 17);
        	this.labelVersion.TabIndex = 0;
        	this.labelVersion.Text = "Version";
        	this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// labelCopyright
        	// 
        	this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.labelCopyright.Location = new System.Drawing.Point(143, 58);
        	this.labelCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
        	this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 17);
        	this.labelCopyright.Name = "labelCopyright";
        	this.labelCopyright.Size = new System.Drawing.Size(271, 17);
        	this.labelCopyright.TabIndex = 21;
        	this.labelCopyright.Text = "Copyright";
        	this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// labelCompanyName
        	// 
        	this.labelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.labelCompanyName.Location = new System.Drawing.Point(143, 87);
        	this.labelCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
        	this.labelCompanyName.MaximumSize = new System.Drawing.Size(0, 17);
        	this.labelCompanyName.Name = "labelCompanyName";
        	this.labelCompanyName.Size = new System.Drawing.Size(271, 17);
        	this.labelCompanyName.TabIndex = 22;
        	this.labelCompanyName.Text = "Company Name";
        	this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// textBoxDescription
        	// 
        	this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.textBoxDescription.Location = new System.Drawing.Point(143, 119);
        	this.textBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
        	this.textBoxDescription.Multiline = true;
        	this.textBoxDescription.Name = "textBoxDescription";
        	this.textBoxDescription.ReadOnly = true;
        	this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        	this.textBoxDescription.Size = new System.Drawing.Size(271, 110);
        	this.textBoxDescription.TabIndex = 23;
        	this.textBoxDescription.TabStop = false;
        	this.textBoxDescription.Text = "Description";
        	// 
        	// okButton
        	// 
        	this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        	this.okButton.Location = new System.Drawing.Point(339, 239);
        	this.okButton.Name = "okButton";
        	this.okButton.Size = new System.Drawing.Size(75, 23);
        	this.okButton.TabIndex = 24;
        	this.okButton.Text = "&OK";
        	// 
        	// panel1
        	// 
        	this.panel1.Controls.Add(this.lbnLicenceText);
        	this.panel1.Controls.Add(this.lbnKnownIssues);
        	this.panel1.Controls.Add(this.lbnWhatsNext);
        	this.panel1.Controls.Add(this.lbnChangeLog);
        	this.panel1.Location = new System.Drawing.Point(3, 119);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(131, 100);
        	this.panel1.TabIndex = 25;
        	// 
        	// lbnLicenceText
        	// 
        	this.lbnLicenceText.AutoSize = true;
        	this.lbnLicenceText.Location = new System.Drawing.Point(16, 80);
        	this.lbnLicenceText.Name = "lbnLicenceText";
        	this.lbnLicenceText.Size = new System.Drawing.Size(92, 13);
        	this.lbnLicenceText.TabIndex = 28;
        	this.lbnLicenceText.TabStop = true;
        	this.lbnLicenceText.Text = "GPL License Text";
        	this.lbnLicenceText.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbnLicenceText_LinkClicked);
        	// 
        	// lbnKnownIssues
        	// 
        	this.lbnKnownIssues.AutoSize = true;
        	this.lbnKnownIssues.Location = new System.Drawing.Point(16, 32);
        	this.lbnKnownIssues.Name = "lbnKnownIssues";
        	this.lbnKnownIssues.Size = new System.Drawing.Size(73, 13);
        	this.lbnKnownIssues.TabIndex = 27;
        	this.lbnKnownIssues.TabStop = true;
        	this.lbnKnownIssues.Text = "Known Issues";
        	this.lbnKnownIssues.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbnKnownIssues_LinkClicked);
        	// 
        	// lbnWhatsNext
        	// 
        	this.lbnWhatsNext.AutoSize = true;
        	this.lbnWhatsNext.Location = new System.Drawing.Point(16, 56);
        	this.lbnWhatsNext.Name = "lbnWhatsNext";
        	this.lbnWhatsNext.Size = new System.Drawing.Size(65, 13);
        	this.lbnWhatsNext.TabIndex = 29;
        	this.lbnWhatsNext.TabStop = true;
        	this.lbnWhatsNext.Text = "What\'s Next";
        	this.lbnWhatsNext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbnWhatsNextLinkClicked);
        	// 
        	// lbnChangeLog
        	// 
        	this.lbnChangeLog.AutoSize = true;
        	this.lbnChangeLog.Location = new System.Drawing.Point(16, 8);
        	this.lbnChangeLog.Name = "lbnChangeLog";
        	this.lbnChangeLog.Size = new System.Drawing.Size(65, 13);
        	this.lbnChangeLog.TabIndex = 26;
        	this.lbnChangeLog.TabStop = true;
        	this.lbnChangeLog.Text = "Change Log";
        	this.lbnChangeLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbnChangeLog_LinkClicked);
        	// 
        	// logoPictureBox
        	// 
        	this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
        	this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
        	this.logoPictureBox.Name = "logoPictureBox";
        	this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 4);
        	this.logoPictureBox.Size = new System.Drawing.Size(106, 108);
        	this.logoPictureBox.TabIndex = 13;
        	this.logoPictureBox.TabStop = false;
        	// 
        	// frmAbout
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(435, 283);
        	this.Controls.Add(this.tableLayoutPanel);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        	this.MaximizeBox = false;
        	this.MinimizeBox = false;
        	this.Name = "frmAbout";
        	this.Padding = new System.Windows.Forms.Padding(9);
        	this.ShowIcon = false;
        	this.ShowInTaskbar = false;
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        	this.Text = "frmAbout";
        	this.tableLayoutPanel.ResumeLayout(false);
        	this.tableLayoutPanel.PerformLayout();
        	this.panel1.ResumeLayout(false);
        	this.panel1.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
        	this.ResumeLayout(false);
        }
        private System.Windows.Forms.LinkLabel lbnWhatsNext;
        private System.Windows.Forms.Panel panel1;

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.LinkLabel lbnChangeLog;
        private System.Windows.Forms.LinkLabel lbnKnownIssues;
        private System.Windows.Forms.LinkLabel lbnLicenceText;
    }
}
