/*
 * Created by SharpDevelop.
 * User: Spoody Goon
 * Date: 2/7/2007
 * Time: 8:18 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EmailError
{
	partial class frmError
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lbnSendEmail = new System.Windows.Forms.LinkLabel();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.btnCopyError = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.rtbError = new System.Windows.Forms.RichTextBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(5, 5);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(431, 109);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(10, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "An Error has occured...";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.Control;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.textBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(0, 29);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(431, 80);
			this.textBox1.TabIndex = 0;
			this.textBox1.TabStop = false;
			this.textBox1.Text = "Please take a moment to send the error to me so I can improve YahtzeeSharp.\r\nBelo" +
			"w is the Error details please take a moment to email me the details so I may fix" +
			" the problems\r\n\r\nThank You!";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnClose);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(5, 314);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(431, 54);
			this.panel2.TabIndex = 1;
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(162, 19);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.lbnSendEmail);
			this.panel3.Controls.Add(this.textBox2);
			this.panel3.Controls.Add(this.btnCopyError);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.rtbError);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(5, 114);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(431, 200);
			this.panel3.TabIndex = 0;
			// 
			// lbnSendEmail
			// 
			this.lbnSendEmail.Location = new System.Drawing.Point(163, 130);
			this.lbnSendEmail.Name = "lbnSendEmail";
			this.lbnSendEmail.Size = new System.Drawing.Size(149, 23);
			this.lbnSendEmail.TabIndex = 4;
			this.lbnSendEmail.TabStop = true;
			this.lbnSendEmail.Text = "andy@brdstudio.net";
			this.lbnSendEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbnSendEmailLinkClicked);
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.Control;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.textBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(0, 151);
			this.textBox2.Margin = new System.Windows.Forms.Padding(5);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(431, 49);
			this.textBox2.TabIndex = 3;
			this.textBox2.TabStop = false;
			this.textBox2.Text = "Please copy the error text using the button that is provided and then click on th" +
			"e email link";
			// 
			// btnCopyError
			// 
			this.btnCopyError.Location = new System.Drawing.Point(12, 126);
			this.btnCopyError.Name = "btnCopyError";
			this.btnCopyError.Size = new System.Drawing.Size(116, 23);
			this.btnCopyError.TabIndex = 2;
			this.btnCopyError.Text = "Copy Error Text";
			this.btnCopyError.UseVisualStyleBackColor = true;
			this.btnCopyError.Click += new System.EventHandler(this.BtnCopyErrorClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Error Details:";
			// 
			// rtbError
			// 
			this.rtbError.BackColor = System.Drawing.Color.LightGray;
			this.rtbError.Location = new System.Drawing.Point(10, 24);
			this.rtbError.Name = "rtbError";
			this.rtbError.ReadOnly = true;
			this.rtbError.Size = new System.Drawing.Size(420, 96);
			this.rtbError.TabIndex = 0;
			this.rtbError.TabStop = false;
			this.rtbError.Text = "";
			// 
			// frmError
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 373);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmError";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Error";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.LinkLabel lbnSendEmail;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnCopyError;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.RichTextBox rtbError;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
	}
}
