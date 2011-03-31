/*
 * Created by SharpDevelop.
 * User: Spoody Goon
 * Date: 2/18/2007
 * Time: 5:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace YahtzeeSharp
{
	partial class frmFinish
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinish));
			this.pnlFinish = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnNoNewGame = new System.Windows.Forms.Button();
			this.btnNewGame = new System.Windows.Forms.Button();
			this.lblScore = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pnlFinish.SuspendLayout();
			this.panel9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlFinish
			// 
			this.pnlFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.pnlFinish.Controls.Add(this.panel9);
			this.pnlFinish.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlFinish.Location = new System.Drawing.Point(5, 5);
			this.pnlFinish.Name = "pnlFinish";
			this.pnlFinish.Padding = new System.Windows.Forms.Padding(5);
			this.pnlFinish.Size = new System.Drawing.Size(476, 221);
			this.pnlFinish.TabIndex = 13;
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.SystemColors.Control;
			this.panel9.Controls.Add(this.pictureBox15);
			this.panel9.Controls.Add(this.label3);
			this.panel9.Controls.Add(this.btnNoNewGame);
			this.panel9.Controls.Add(this.btnNewGame);
			this.panel9.Controls.Add(this.lblScore);
			this.panel9.Controls.Add(this.label4);
			this.panel9.Controls.Add(this.label5);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel9.Location = new System.Drawing.Point(5, 5);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(466, 211);
			this.panel9.TabIndex = 1;
			// 
			// pictureBox15
			// 
			this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
			this.pictureBox15.Location = new System.Drawing.Point(3, 10);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(190, 189);
			this.pictureBox15.TabIndex = 1;
			this.pictureBox15.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(206, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(248, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Would you like to play a New Game?";
			// 
			// btnNoNewGame
			// 
			this.btnNoNewGame.DialogResult = System.Windows.Forms.DialogResult.No;
			this.btnNoNewGame.Location = new System.Drawing.Point(333, 164);
			this.btnNoNewGame.Name = "btnNoNewGame";
			this.btnNoNewGame.Size = new System.Drawing.Size(75, 23);
			this.btnNoNewGame.TabIndex = 5;
			this.btnNoNewGame.Text = "No";
			this.btnNoNewGame.UseVisualStyleBackColor = true;
			this.btnNoNewGame.Click += new System.EventHandler(this.BtnNoNewGameClick);
			// 
			// btnNewGame
			// 
			this.btnNewGame.DialogResult = System.Windows.Forms.DialogResult.Yes;
			this.btnNewGame.Location = new System.Drawing.Point(235, 164);
			this.btnNewGame.Name = "btnNewGame";
			this.btnNewGame.Size = new System.Drawing.Size(75, 23);
			this.btnNewGame.TabIndex = 4;
			this.btnNewGame.Text = "Yes";
			this.btnNewGame.UseVisualStyleBackColor = true;
			this.btnNewGame.Click += new System.EventHandler(this.BtnNewGameClick);
			// 
			// lblScore
			// 
			this.lblScore.AutoSize = true;
			this.lblScore.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblScore.Location = new System.Drawing.Point(311, 92);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(16, 16);
			this.lblScore.TabIndex = 3;
			this.lblScore.Text = "0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(266, 60);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 16);
			this.label4.TabIndex = 2;
			this.label4.Text = "Your Score was";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(209, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(244, 29);
			this.label5.TabIndex = 0;
			this.label5.Text = "Congratulations !";
			// 
			// frmFinish
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(486, 231);
			this.Controls.Add(this.pnlFinish);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmFinish";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmFinish";
			this.pnlFinish.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.Button btnNewGame;
		private System.Windows.Forms.Button btnNoNewGame;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Panel pnlFinish;
	}
}
