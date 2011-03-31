/*
 * Created by SharpDevelop.
 * User: Spoody Goon
 * Date: 2/9/2007
 * Time: 9:48 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace YahtzeeSharp
{
	partial class frmAboutHelper
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
			this.btnOk = new System.Windows.Forms.Button();
			this.rtbReleaseNotes = new System.Windows.Forms.RichTextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnOk);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(6, 198);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(577, 70);
			this.panel1.TabIndex = 0;
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(247, 27);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(87, 23);
			this.btnOk.TabIndex = 0;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.BtnOkClick);
			// 
			// rtbReleaseNotes
			// 
			this.rtbReleaseNotes.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.rtbReleaseNotes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbReleaseNotes.Location = new System.Drawing.Point(6, 5);
			this.rtbReleaseNotes.Margin = new System.Windows.Forms.Padding(5);
			this.rtbReleaseNotes.Name = "rtbReleaseNotes";
			this.rtbReleaseNotes.ReadOnly = true;
			this.rtbReleaseNotes.Size = new System.Drawing.Size(577, 193);
			this.rtbReleaseNotes.TabIndex = 1;
			this.rtbReleaseNotes.Text = "";
			// 
			// frmAboutHelper
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(589, 273);
			this.Controls.Add(this.rtbReleaseNotes);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAboutHelper";
			this.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Release Notes";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.RichTextBox rtbReleaseNotes;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Panel panel1;
	}
}
