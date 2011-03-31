/*
 * Created by SharpDevelop.
 * User: Spoody Goon
 * Date: 1/20/2007
 * Time: 6:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace YahtzeeSharp
{
	partial class frmOpen
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbxIsComplete = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnClearFilter = new System.Windows.Forms.Button();
			this.gvOpen = new System.Windows.Forms.DataGridView();
			this.dsGameData = new System.Data.DataSet();
			this.dtGameData = new System.Data.DataTable();
			this.colGameID = new System.Data.DataColumn();
			this.colPlayerName = new System.Data.DataColumn();
			this.colScore = new System.Data.DataColumn();
			this.colDate = new System.Data.DataColumn();
			this.dataColumn1 = new System.Data.DataColumn();
			this.GameID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnOpen = new System.Windows.Forms.DataGridViewButtonColumn();
			this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvOpen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsGameData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtGameData)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cbxIsComplete);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtSearch);
			this.panel1.Controls.Add(this.btnClearFilter);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(625, 40);
			this.panel1.TabIndex = 0;
			// 
			// cbxIsComplete
			// 
			this.cbxIsComplete.AutoSize = true;
			this.cbxIsComplete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cbxIsComplete.Location = new System.Drawing.Point(350, 11);
			this.cbxIsComplete.Name = "cbxIsComplete";
			this.cbxIsComplete.Size = new System.Drawing.Size(193, 17);
			this.cbxIsComplete.TabIndex = 4;
			this.cbxIsComplete.Text = "Show only incomplete games";
			this.cbxIsComplete.UseVisualStyleBackColor = true;
			this.cbxIsComplete.CheckedChanged += new System.EventHandler(this.CbxIsCompleteCheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Filter";
			// 
			// txtSearch
			// 
			this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(60, 11);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(166, 15);
			this.txtSearch.TabIndex = 2;
			this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearchTextChanged);
			// 
			// btnClearFilter
			// 
			this.btnClearFilter.Location = new System.Drawing.Point(243, 7);
			this.btnClearFilter.Name = "btnClearFilter";
			this.btnClearFilter.Size = new System.Drawing.Size(87, 23);
			this.btnClearFilter.TabIndex = 1;
			this.btnClearFilter.Text = "Clear Filter";
			this.btnClearFilter.UseVisualStyleBackColor = true;
			this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilterClick);
			// 
			// gvOpen
			// 
			this.gvOpen.AllowUserToAddRows = false;
			this.gvOpen.AllowUserToDeleteRows = false;
			this.gvOpen.AllowUserToResizeRows = false;
			this.gvOpen.AutoGenerateColumns = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gvOpen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.gvOpen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvOpen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.GameID,
									this.btnOpen,
									this.PlayerName,
									this.Score,
									this.Date,
									this.colDelete});
			this.gvOpen.DataSource = this.dsGameData;
			this.gvOpen.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gvOpen.Location = new System.Drawing.Point(0, 40);
			this.gvOpen.Margin = new System.Windows.Forms.Padding(0);
			this.gvOpen.MultiSelect = false;
			this.gvOpen.Name = "gvOpen";
			this.gvOpen.ReadOnly = true;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gray;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gvOpen.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.gvOpen.RowHeadersVisible = false;
			this.gvOpen.RowHeadersWidth = 21;
			this.gvOpen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 7F);
			this.gvOpen.RowsDefaultCellStyle = dataGridViewCellStyle9;
			this.gvOpen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.gvOpen.Size = new System.Drawing.Size(625, 320);
			this.gvOpen.TabIndex = 1;
			this.gvOpen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvOpenCellContentClick);
			// 
			// dsGameData
			// 
			this.dsGameData.DataSetName = "dsGameData";
			this.dsGameData.Tables.AddRange(new System.Data.DataTable[] {
									this.dtGameData});
			// 
			// dtGameData
			// 
			this.dtGameData.Columns.AddRange(new System.Data.DataColumn[] {
									this.colGameID,
									this.colPlayerName,
									this.colScore,
									this.colDate,
									this.dataColumn1});
			this.dtGameData.Constraints.AddRange(new System.Data.Constraint[] {
									new System.Data.UniqueConstraint("Constraint1", new string[] {
																		"colGameID"}, true)});
			this.dtGameData.PrimaryKey = new System.Data.DataColumn[] {
						this.colGameID};
			this.dtGameData.TableName = "dtGameData";
			// 
			// colGameID
			// 
			this.colGameID.AllowDBNull = false;
			this.colGameID.AutoIncrement = true;
			this.colGameID.AutoIncrementSeed = ((long)(1));
			this.colGameID.Caption = "ID";
			this.colGameID.ColumnName = "colGameID";
			this.colGameID.DataType = typeof(int);
			// 
			// colPlayerName
			// 
			this.colPlayerName.Caption = "Players Name";
			this.colPlayerName.ColumnName = "colPlayerName";
			// 
			// colScore
			// 
			this.colScore.ColumnName = "colScore";
			// 
			// colDate
			// 
			this.colDate.ColumnName = "colDate";
			this.colDate.DataType = typeof(System.DateTime);
			this.colDate.DateTimeMode = System.Data.DataSetDateTime.Local;
			// 
			// dataColumn1
			// 
			this.dataColumn1.Caption = "Finished";
			this.dataColumn1.ColumnName = "colIsComplete";
			this.dataColumn1.DataType = typeof(bool);
			this.dataColumn1.DefaultValue = false;
			// 
			// GameID
			// 
			this.GameID.DataPropertyName = "colGameID";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GameID.DefaultCellStyle = dataGridViewCellStyle2;
			this.GameID.HeaderText = "ID";
			this.GameID.Name = "GameID";
			this.GameID.ReadOnly = true;
			this.GameID.Width = 35;
			// 
			// btnOpen
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpen.DefaultCellStyle = dataGridViewCellStyle3;
			this.btnOpen.HeaderText = "";
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.ReadOnly = true;
			this.btnOpen.Text = "Open";
			this.btnOpen.UseColumnTextForButtonValue = true;
			// 
			// PlayerName
			// 
			this.PlayerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.PlayerName.DataPropertyName = "colPlayerName";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
			this.PlayerName.DefaultCellStyle = dataGridViewCellStyle4;
			this.PlayerName.HeaderText = "Players Name";
			this.PlayerName.Name = "PlayerName";
			this.PlayerName.ReadOnly = true;
			// 
			// Score
			// 
			this.Score.DataPropertyName = "colScore";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.Score.DefaultCellStyle = dataGridViewCellStyle5;
			this.Score.HeaderText = "Score";
			this.Score.Name = "Score";
			this.Score.ReadOnly = true;
			// 
			// Date
			// 
			this.Date.DataPropertyName = "colDate";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.Date.DefaultCellStyle = dataGridViewCellStyle6;
			this.Date.HeaderText = "Date";
			this.Date.Name = "Date";
			this.Date.ReadOnly = true;
			this.Date.Width = 150;
			// 
			// colDelete
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colDelete.DefaultCellStyle = dataGridViewCellStyle7;
			this.colDelete.HeaderText = "";
			this.colDelete.Name = "colDelete";
			this.colDelete.ReadOnly = true;
			this.colDelete.Text = "Delete Game";
			this.colDelete.UseColumnTextForButtonValue = true;
			// 
			// frmOpen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(625, 360);
			this.Controls.Add(this.gvOpen);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmOpen";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = " Open";
			this.Load += new System.EventHandler(this.FrmOpenLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvOpen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsGameData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtGameData)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewButtonColumn colDelete;
		private System.Windows.Forms.CheckBox cbxIsComplete;
		private System.Data.DataColumn dataColumn1;
		private System.Data.DataSet dsGameData;
		private System.Data.DataTable dtGameData;
		private System.Windows.Forms.Button btnClearFilter;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Data.DataColumn colDate;
		private System.Data.DataColumn colScore;
		private System.Data.DataColumn colPlayerName;
        private System.Data.DataColumn colGameID;
		private System.Windows.Forms.DataGridView gvOpen;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameID;
        private System.Windows.Forms.DataGridViewButtonColumn btnOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
	}
}
