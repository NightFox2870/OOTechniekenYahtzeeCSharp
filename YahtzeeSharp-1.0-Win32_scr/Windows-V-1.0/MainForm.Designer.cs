/*
 * Created by SharpDevelop.
 * User: Spoody Goon
 * Date: 1/12/2007
 * Time: 7:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace YahtzeeSharp
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
			this.mTimer = new System.Windows.Forms.Timer(this.components);
			this.dsGameData = new System.Data.DataSet();
			this.dtGameData = new System.Data.DataTable();
			this.dataColumn1 = new System.Data.DataColumn();
			this.dataColumn2 = new System.Data.DataColumn();
			this.dataColumn3 = new System.Data.DataColumn();
			this.dataColumn4 = new System.Data.DataColumn();
			this.dataColumn5 = new System.Data.DataColumn();
			this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
			this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.panel157 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtPlayerName = new System.Windows.Forms.TextBox();
			this.lblHold5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblHold4 = new System.Windows.Forms.Label();
			this.lblHold3 = new System.Windows.Forms.Label();
			this.lblHold2 = new System.Windows.Forms.Label();
			this.lblHold1 = new System.Windows.Forms.Label();
			this.label70 = new System.Windows.Forms.Label();
			this.lblRollNumber = new System.Windows.Forms.Label();
			this.btnRoll = new System.Windows.Forms.Button();
			this.Dice5 = new System.Windows.Forms.PictureBox();
			this.Dice1 = new System.Windows.Forms.PictureBox();
			this.Dice4 = new System.Windows.Forms.PictureBox();
			this.Dice3 = new System.Windows.Forms.PictureBox();
			this.Dice2 = new System.Windows.Forms.PictureBox();
			this.gvResults = new System.Windows.Forms.DataGridView();
			this.colResults = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.gvHighScore = new System.Windows.Forms.DataGridView();
			this.colPlayerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colIsCompleteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnlLowerScore = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.r16c1 = new System.Windows.Forms.Panel();
			this.r16c2 = new System.Windows.Forms.Panel();
			this.r16c3 = new System.Windows.Forms.Panel();
			this.r16c4 = new System.Windows.Forms.Panel();
			this.r16c5 = new System.Windows.Forms.Panel();
			this.panel32 = new System.Windows.Forms.Panel();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.r10c3 = new System.Windows.Forms.Panel();
			this.r17c1 = new System.Windows.Forms.Panel();
			this.r17c2 = new System.Windows.Forms.Panel();
			this.r17c3 = new System.Windows.Forms.Panel();
			this.r17c4 = new System.Windows.Forms.Panel();
			this.r17c5 = new System.Windows.Forms.Panel();
			this.panel132 = new System.Windows.Forms.Panel();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.panel133 = new System.Windows.Forms.Panel();
			this.pictureBox48 = new System.Windows.Forms.PictureBox();
			this.r18c1 = new System.Windows.Forms.Panel();
			this.r18c2 = new System.Windows.Forms.Panel();
			this.r18c3 = new System.Windows.Forms.Panel();
			this.r18c4 = new System.Windows.Forms.Panel();
			this.r18c5 = new System.Windows.Forms.Panel();
			this.panel101 = new System.Windows.Forms.Panel();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.panel110 = new System.Windows.Forms.Panel();
			this.pictureBox49 = new System.Windows.Forms.PictureBox();
			this.panel88 = new System.Windows.Forms.Panel();
			this.pictureBox40 = new System.Windows.Forms.PictureBox();
			this.r15c1 = new System.Windows.Forms.Panel();
			this.r15c2 = new System.Windows.Forms.Panel();
			this.r15c3 = new System.Windows.Forms.Panel();
			this.r15c4 = new System.Windows.Forms.Panel();
			this.r15c5 = new System.Windows.Forms.Panel();
			this.panel143 = new System.Windows.Forms.Panel();
			this.pictureBox47 = new System.Windows.Forms.PictureBox();
			this.panel74 = new System.Windows.Forms.Panel();
			this.pictureBox39 = new System.Windows.Forms.PictureBox();
			this.panel75 = new System.Windows.Forms.Panel();
			this.pictureBox38 = new System.Windows.Forms.PictureBox();
			this.panel76 = new System.Windows.Forms.Panel();
			this.pictureBox37 = new System.Windows.Forms.PictureBox();
			this.panel77 = new System.Windows.Forms.Panel();
			this.pictureBox36 = new System.Windows.Forms.PictureBox();
			this.panel78 = new System.Windows.Forms.Panel();
			this.pictureBox35 = new System.Windows.Forms.PictureBox();
			this.r19c1 = new System.Windows.Forms.Panel();
			this.r14c1 = new System.Windows.Forms.Panel();
			this.r13c1 = new System.Windows.Forms.Panel();
			this.r12c1 = new System.Windows.Forms.Panel();
			this.r11c1 = new System.Windows.Forms.Panel();
			this.r10c1 = new System.Windows.Forms.Panel();
			this.r9c1 = new System.Windows.Forms.Panel();
			this.r19c2 = new System.Windows.Forms.Panel();
			this.r14c2 = new System.Windows.Forms.Panel();
			this.r13c2 = new System.Windows.Forms.Panel();
			this.r12c2 = new System.Windows.Forms.Panel();
			this.r11c2 = new System.Windows.Forms.Panel();
			this.r10c2 = new System.Windows.Forms.Panel();
			this.r9c2 = new System.Windows.Forms.Panel();
			this.r19c3 = new System.Windows.Forms.Panel();
			this.r14c3 = new System.Windows.Forms.Panel();
			this.r13c3 = new System.Windows.Forms.Panel();
			this.r12c3 = new System.Windows.Forms.Panel();
			this.r11c3 = new System.Windows.Forms.Panel();
			this.r9c3 = new System.Windows.Forms.Panel();
			this.r19c4 = new System.Windows.Forms.Panel();
			this.r14c4 = new System.Windows.Forms.Panel();
			this.r13c4 = new System.Windows.Forms.Panel();
			this.r12c4 = new System.Windows.Forms.Panel();
			this.r11c4 = new System.Windows.Forms.Panel();
			this.r10c4 = new System.Windows.Forms.Panel();
			this.r9c4 = new System.Windows.Forms.Panel();
			this.r19c5 = new System.Windows.Forms.Panel();
			this.r14c5 = new System.Windows.Forms.Panel();
			this.r13c5 = new System.Windows.Forms.Panel();
			this.r12c5 = new System.Windows.Forms.Panel();
			this.r11c5 = new System.Windows.Forms.Panel();
			this.r10c5 = new System.Windows.Forms.Panel();
			this.r9c5 = new System.Windows.Forms.Panel();
			this.panel128 = new System.Windows.Forms.Panel();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.panel131 = new System.Windows.Forms.Panel();
			this.pictureBox50 = new System.Windows.Forms.PictureBox();
			this.panel134 = new System.Windows.Forms.Panel();
			this.pictureBox46 = new System.Windows.Forms.PictureBox();
			this.panel135 = new System.Windows.Forms.Panel();
			this.pictureBox45 = new System.Windows.Forms.PictureBox();
			this.panel136 = new System.Windows.Forms.Panel();
			this.pictureBox44 = new System.Windows.Forms.PictureBox();
			this.panel137 = new System.Windows.Forms.Panel();
			this.pictureBox43 = new System.Windows.Forms.PictureBox();
			this.panel138 = new System.Windows.Forms.Panel();
			this.pictureBox34 = new System.Windows.Forms.PictureBox();
			this.panel139 = new System.Windows.Forms.Panel();
			this.pictureBox42 = new System.Windows.Forms.PictureBox();
			this.panel140 = new System.Windows.Forms.Panel();
			this.pictureBox41 = new System.Windows.Forms.PictureBox();
			this.label55 = new System.Windows.Forms.Label();
			this.pnlUpperScore = new System.Windows.Forms.Panel();
			this.r1c1 = new System.Windows.Forms.Panel();
			this.r0c2 = new System.Windows.Forms.Panel();
			this.r0c1 = new System.Windows.Forms.Panel();
			this.r5c3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.pictureBox30 = new System.Windows.Forms.PictureBox();
			this.panel21 = new System.Windows.Forms.Panel();
			this.pictureBox22 = new System.Windows.Forms.PictureBox();
			this.panel20 = new System.Windows.Forms.Panel();
			this.pictureBox21 = new System.Windows.Forms.PictureBox();
			this.panel19 = new System.Windows.Forms.Panel();
			this.pictureBox20 = new System.Windows.Forms.PictureBox();
			this.panel18 = new System.Windows.Forms.Panel();
			this.pictureBox19 = new System.Windows.Forms.PictureBox();
			this.panel17 = new System.Windows.Forms.Panel();
			this.pictureBox18 = new System.Windows.Forms.PictureBox();
			this.r8c1 = new System.Windows.Forms.Panel();
			this.r7c1 = new System.Windows.Forms.Panel();
			this.r6c1 = new System.Windows.Forms.Panel();
			this.r5c1 = new System.Windows.Forms.Panel();
			this.r4c1 = new System.Windows.Forms.Panel();
			this.r3c1 = new System.Windows.Forms.Panel();
			this.r2c1 = new System.Windows.Forms.Panel();
			this.panel72 = new System.Windows.Forms.Panel();
			this.pictureBox25 = new System.Windows.Forms.PictureBox();
			this.r8c2 = new System.Windows.Forms.Panel();
			this.r7c2 = new System.Windows.Forms.Panel();
			this.r6c2 = new System.Windows.Forms.Panel();
			this.r5c2 = new System.Windows.Forms.Panel();
			this.r4c2 = new System.Windows.Forms.Panel();
			this.r3c2 = new System.Windows.Forms.Panel();
			this.r2c2 = new System.Windows.Forms.Panel();
			this.r1c2 = new System.Windows.Forms.Panel();
			this.panel60 = new System.Windows.Forms.Panel();
			this.pictureBox26 = new System.Windows.Forms.PictureBox();
			this.r8c3 = new System.Windows.Forms.Panel();
			this.r7c3 = new System.Windows.Forms.Panel();
			this.r6c3 = new System.Windows.Forms.Panel();
			this.r4c3 = new System.Windows.Forms.Panel();
			this.r3c3 = new System.Windows.Forms.Panel();
			this.r2c3 = new System.Windows.Forms.Panel();
			this.r1c3 = new System.Windows.Forms.Panel();
			this.r0c3 = new System.Windows.Forms.Panel();
			this.panel47 = new System.Windows.Forms.Panel();
			this.pictureBox27 = new System.Windows.Forms.PictureBox();
			this.r8c4 = new System.Windows.Forms.Panel();
			this.r7c4 = new System.Windows.Forms.Panel();
			this.r6c4 = new System.Windows.Forms.Panel();
			this.r5c4 = new System.Windows.Forms.Panel();
			this.r4c4 = new System.Windows.Forms.Panel();
			this.r3c4 = new System.Windows.Forms.Panel();
			this.r2c4 = new System.Windows.Forms.Panel();
			this.r1c4 = new System.Windows.Forms.Panel();
			this.r0c4 = new System.Windows.Forms.Panel();
			this.panel35 = new System.Windows.Forms.Panel();
			this.pictureBox28 = new System.Windows.Forms.PictureBox();
			this.r8c5 = new System.Windows.Forms.Panel();
			this.r7c5 = new System.Windows.Forms.Panel();
			this.r6c5 = new System.Windows.Forms.Panel();
			this.r5c5 = new System.Windows.Forms.Panel();
			this.r4c5 = new System.Windows.Forms.Panel();
			this.r3c5 = new System.Windows.Forms.Panel();
			this.r2c5 = new System.Windows.Forms.Panel();
			this.r1c5 = new System.Windows.Forms.Panel();
			this.r0c5 = new System.Windows.Forms.Panel();
			this.panel27 = new System.Windows.Forms.Panel();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.panel26 = new System.Windows.Forms.Panel();
			this.pictureBox23 = new System.Windows.Forms.PictureBox();
			this.panel25 = new System.Windows.Forms.Panel();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.panel24 = new System.Windows.Forms.Panel();
			this.pictureBox33 = new System.Windows.Forms.PictureBox();
			this.panel23 = new System.Windows.Forms.Panel();
			this.pictureBox32 = new System.Windows.Forms.PictureBox();
			this.panel22 = new System.Windows.Forms.Panel();
			this.pictureBox31 = new System.Windows.Forms.PictureBox();
			this.panel16 = new System.Windows.Forms.Panel();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.panel15 = new System.Windows.Forms.Panel();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.panel14 = new System.Windows.Forms.Panel();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.panel13 = new System.Windows.Forms.Panel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.panel12 = new System.Windows.Forms.Panel();
			this.pictureBox17 = new System.Windows.Forms.PictureBox();
			this.panel11 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel10 = new System.Windows.Forms.Panel();
			this.pictureBox29 = new System.Windows.Forms.PictureBox();
			this.panel6 = new System.Windows.Forms.Panel();
			this.pictureBox24 = new System.Windows.Forms.PictureBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.updatesToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.panel7 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dsGameData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dtGameData)).BeginInit();
			this.panel157.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Dice5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dice1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dice4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dice3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Dice2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvResults)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvHighScore)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
			this.panel2.SuspendLayout();
			this.pnlLowerScore.SuspendLayout();
			this.panel8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
			this.panel32.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
			this.panel132.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
			this.panel133.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).BeginInit();
			this.panel101.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
			this.panel110.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).BeginInit();
			this.panel88.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
			this.panel143.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).BeginInit();
			this.panel74.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
			this.panel75.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
			this.panel76.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
			this.panel77.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
			this.panel78.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
			this.panel128.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			this.panel131.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).BeginInit();
			this.panel134.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).BeginInit();
			this.panel135.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).BeginInit();
			this.panel136.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).BeginInit();
			this.panel137.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).BeginInit();
			this.panel138.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
			this.panel139.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).BeginInit();
			this.panel140.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).BeginInit();
			this.pnlUpperScore.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
			this.panel21.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
			this.panel20.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
			this.panel19.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
			this.panel18.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
			this.panel17.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
			this.panel72.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
			this.panel60.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
			this.panel47.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
			this.panel35.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
			this.panel27.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			this.panel26.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
			this.panel25.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			this.panel24.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
			this.panel23.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
			this.panel22.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
			this.panel16.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			this.panel15.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.panel14.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.panel13.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.panel12.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
			this.panel11.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.panel7.SuspendLayout();
			this.SuspendLayout();
			// 
			// mTimer
			// 
			this.mTimer.Enabled = true;
			this.mTimer.Interval = 5000;
			this.mTimer.Tick += new System.EventHandler(this.mTimer_Tick);
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
									this.dataColumn1,
									this.dataColumn2,
									this.dataColumn3,
									this.dataColumn4,
									this.dataColumn5});
			this.dtGameData.Constraints.AddRange(new System.Data.Constraint[] {
									new System.Data.UniqueConstraint("Constraint1", new string[] {
																		"colGameID"}, true)});
			this.dtGameData.PrimaryKey = new System.Data.DataColumn[] {
						this.dataColumn1};
			this.dtGameData.TableName = "dtGameData";
			// 
			// dataColumn1
			// 
			this.dataColumn1.AllowDBNull = false;
			this.dataColumn1.AutoIncrement = true;
			this.dataColumn1.AutoIncrementSeed = ((long)(1));
			this.dataColumn1.ColumnName = "colGameID";
			this.dataColumn1.DataType = typeof(int);
			// 
			// dataColumn2
			// 
			this.dataColumn2.ColumnName = "colPlayerName";
			// 
			// dataColumn3
			// 
			this.dataColumn3.ColumnName = "colScore";
			this.dataColumn3.DataType = typeof(int);
			// 
			// dataColumn4
			// 
			this.dataColumn4.ColumnName = "colDate";
			this.dataColumn4.DataType = typeof(System.DateTime);
			// 
			// dataColumn5
			// 
			this.dataColumn5.Caption = "Finished";
			this.dataColumn5.ColumnName = "colIsComplete";
			this.dataColumn5.DataType = typeof(bool);
			this.dataColumn5.DefaultValue = false;
			// 
			// BottomToolStripPanel
			// 
			this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.BottomToolStripPanel.Name = "BottomToolStripPanel";
			this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// TopToolStripPanel
			// 
			this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.TopToolStripPanel.Name = "TopToolStripPanel";
			this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// RightToolStripPanel
			// 
			this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.RightToolStripPanel.Name = "RightToolStripPanel";
			this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// ContentPanel
			// 
			this.ContentPanel.AutoScroll = true;
			this.ContentPanel.Size = new System.Drawing.Size(817, 875);
			// 
			// LeftToolStripPanel
			// 
			this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.LeftToolStripPanel.Name = "LeftToolStripPanel";
			this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.LeftToolStripPanel.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
			this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// panel157
			// 
			this.panel157.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel157.Controls.Add(this.panel3);
			this.panel157.Controls.Add(this.gvResults);
			this.panel157.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel157.Location = new System.Drawing.Point(631, 0);
			this.panel157.Margin = new System.Windows.Forms.Padding(2);
			this.panel157.MinimumSize = new System.Drawing.Size(150, 2);
			this.panel157.Name = "panel157";
			this.panel157.Size = new System.Drawing.Size(186, 642);
			this.panel157.TabIndex = 8;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.txtPlayerName);
			this.panel3.Controls.Add(this.lblHold5);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.lblHold4);
			this.panel3.Controls.Add(this.lblHold3);
			this.panel3.Controls.Add(this.lblHold2);
			this.panel3.Controls.Add(this.lblHold1);
			this.panel3.Controls.Add(this.label70);
			this.panel3.Controls.Add(this.lblRollNumber);
			this.panel3.Controls.Add(this.btnRoll);
			this.panel3.Controls.Add(this.Dice5);
			this.panel3.Controls.Add(this.Dice1);
			this.panel3.Controls.Add(this.Dice4);
			this.panel3.Controls.Add(this.Dice3);
			this.panel3.Controls.Add(this.Dice2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Margin = new System.Windows.Forms.Padding(2);
			this.panel3.MinimumSize = new System.Drawing.Size(150, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(184, 417);
			this.panel3.TabIndex = 14;
			// 
			// txtPlayerName
			// 
			this.txtPlayerName.Location = new System.Drawing.Point(9, 26);
			this.txtPlayerName.Margin = new System.Windows.Forms.Padding(2);
			this.txtPlayerName.Name = "txtPlayerName";
			this.txtPlayerName.Size = new System.Drawing.Size(137, 21);
			this.txtPlayerName.TabIndex = 27;
			this.txtPlayerName.Text = "New Player";
			// 
			// lblHold5
			// 
			this.lblHold5.AutoSize = true;
			this.lblHold5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHold5.Location = new System.Drawing.Point(81, 296);
			this.lblHold5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblHold5.Name = "lblHold5";
			this.lblHold5.Size = new System.Drawing.Size(36, 13);
			this.lblHold5.TabIndex = 36;
			this.lblHold5.Text = "Held";
			this.lblHold5.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(9, 6);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 16);
			this.label2.TabIndex = 24;
			this.label2.Text = "Player Name:";
			// 
			// lblHold4
			// 
			this.lblHold4.AutoSize = true;
			this.lblHold4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHold4.Location = new System.Drawing.Point(81, 243);
			this.lblHold4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblHold4.Name = "lblHold4";
			this.lblHold4.Size = new System.Drawing.Size(36, 13);
			this.lblHold4.TabIndex = 35;
			this.lblHold4.Text = "Held";
			this.lblHold4.Visible = false;
			// 
			// lblHold3
			// 
			this.lblHold3.AutoSize = true;
			this.lblHold3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHold3.Location = new System.Drawing.Point(81, 189);
			this.lblHold3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblHold3.Name = "lblHold3";
			this.lblHold3.Size = new System.Drawing.Size(36, 13);
			this.lblHold3.TabIndex = 34;
			this.lblHold3.Text = "Held";
			this.lblHold3.Visible = false;
			// 
			// lblHold2
			// 
			this.lblHold2.AutoSize = true;
			this.lblHold2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHold2.Location = new System.Drawing.Point(81, 138);
			this.lblHold2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblHold2.Name = "lblHold2";
			this.lblHold2.Size = new System.Drawing.Size(36, 13);
			this.lblHold2.TabIndex = 33;
			this.lblHold2.Text = "Held";
			this.lblHold2.Visible = false;
			// 
			// lblHold1
			// 
			this.lblHold1.AutoSize = true;
			this.lblHold1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHold1.Location = new System.Drawing.Point(81, 89);
			this.lblHold1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblHold1.Name = "lblHold1";
			this.lblHold1.Size = new System.Drawing.Size(36, 13);
			this.lblHold1.TabIndex = 32;
			this.lblHold1.Text = "Held";
			this.lblHold1.Visible = false;
			// 
			// label70
			// 
			this.label70.AutoSize = true;
			this.label70.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
			this.label70.Location = new System.Drawing.Point(27, 370);
			this.label70.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label70.Name = "label70";
			this.label70.Size = new System.Drawing.Size(54, 17);
			this.label70.TabIndex = 31;
			this.label70.Text = "Roll #";
			// 
			// lblRollNumber
			// 
			this.lblRollNumber.AutoSize = true;
			this.lblRollNumber.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
			this.lblRollNumber.Location = new System.Drawing.Point(97, 369);
			this.lblRollNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblRollNumber.Name = "lblRollNumber";
			this.lblRollNumber.Size = new System.Drawing.Size(18, 17);
			this.lblRollNumber.TabIndex = 30;
			this.lblRollNumber.Text = "0";
			// 
			// btnRoll
			// 
			this.btnRoll.Location = new System.Drawing.Point(42, 330);
			this.btnRoll.Margin = new System.Windows.Forms.Padding(2);
			this.btnRoll.Name = "btnRoll";
			this.btnRoll.Size = new System.Drawing.Size(56, 23);
			this.btnRoll.TabIndex = 29;
			this.btnRoll.Text = "Roll";
			this.btnRoll.UseVisualStyleBackColor = true;
			this.btnRoll.Click += new System.EventHandler(this.BtnRoolClick);
			// 
			// Dice5
			// 
			this.Dice5.Image = ((System.Drawing.Image)(resources.GetObject("Dice5.Image")));
			this.Dice5.Location = new System.Drawing.Point(26, 271);
			this.Dice5.Margin = new System.Windows.Forms.Padding(2);
			this.Dice5.Name = "Dice5";
			this.Dice5.Size = new System.Drawing.Size(42, 42);
			this.Dice5.TabIndex = 28;
			this.Dice5.TabStop = false;
			this.Dice5.Tag = "4";
			this.Dice5.Click += new System.EventHandler(this.DiceClick);
			// 
			// Dice1
			// 
			this.Dice1.Image = ((System.Drawing.Image)(resources.GetObject("Dice1.Image")));
			this.Dice1.Location = new System.Drawing.Point(26, 61);
			this.Dice1.Margin = new System.Windows.Forms.Padding(2);
			this.Dice1.Name = "Dice1";
			this.Dice1.Size = new System.Drawing.Size(42, 42);
			this.Dice1.TabIndex = 26;
			this.Dice1.TabStop = false;
			this.Dice1.Tag = "0";
			this.Dice1.Click += new System.EventHandler(this.DiceClick);
			// 
			// Dice4
			// 
			this.Dice4.Image = ((System.Drawing.Image)(resources.GetObject("Dice4.Image")));
			this.Dice4.Location = new System.Drawing.Point(26, 218);
			this.Dice4.Margin = new System.Windows.Forms.Padding(2);
			this.Dice4.Name = "Dice4";
			this.Dice4.Size = new System.Drawing.Size(42, 42);
			this.Dice4.TabIndex = 25;
			this.Dice4.TabStop = false;
			this.Dice4.Tag = "3";
			this.Dice4.Click += new System.EventHandler(this.DiceClick);
			// 
			// Dice3
			// 
			this.Dice3.Image = ((System.Drawing.Image)(resources.GetObject("Dice3.Image")));
			this.Dice3.Location = new System.Drawing.Point(26, 166);
			this.Dice3.Margin = new System.Windows.Forms.Padding(2);
			this.Dice3.Name = "Dice3";
			this.Dice3.Size = new System.Drawing.Size(42, 42);
			this.Dice3.TabIndex = 23;
			this.Dice3.TabStop = false;
			this.Dice3.Tag = "2";
			this.Dice3.Click += new System.EventHandler(this.DiceClick);
			// 
			// Dice2
			// 
			this.Dice2.Image = ((System.Drawing.Image)(resources.GetObject("Dice2.Image")));
			this.Dice2.Location = new System.Drawing.Point(26, 113);
			this.Dice2.Margin = new System.Windows.Forms.Padding(2);
			this.Dice2.Name = "Dice2";
			this.Dice2.Size = new System.Drawing.Size(42, 42);
			this.Dice2.TabIndex = 22;
			this.Dice2.TabStop = false;
			this.Dice2.Tag = "1";
			this.Dice2.Click += new System.EventHandler(this.DiceClick);
			// 
			// gvResults
			// 
			this.gvResults.AllowUserToAddRows = false;
			this.gvResults.AllowUserToDeleteRows = false;
			this.gvResults.AllowUserToResizeColumns = false;
			this.gvResults.AllowUserToResizeRows = false;
			this.gvResults.BackgroundColor = System.Drawing.SystemColors.Control;
			this.gvResults.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
			this.gvResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle28.BackColor = System.Drawing.Color.Maroon;
			dataGridViewCellStyle28.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle28.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle28.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
			dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
			this.gvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.colResults,
									this.colValue});
			this.gvResults.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gvResults.EnableHeadersVisualStyles = false;
			this.gvResults.GridColor = System.Drawing.SystemColors.ControlText;
			this.gvResults.Location = new System.Drawing.Point(0, 417);
			this.gvResults.Margin = new System.Windows.Forms.Padding(2);
			this.gvResults.MinimumSize = new System.Drawing.Size(0, 195);
			this.gvResults.MultiSelect = false;
			this.gvResults.Name = "gvResults";
			this.gvResults.ReadOnly = true;
			this.gvResults.RowHeadersVisible = false;
			this.gvResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle31.Font = new System.Drawing.Font("Verdana", 6F);
			this.gvResults.RowsDefaultCellStyle = dataGridViewCellStyle31;
			this.gvResults.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.gvResults.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.SteelBlue;
			this.gvResults.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gvResults.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
			this.gvResults.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
			this.gvResults.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
			this.gvResults.RowTemplate.Height = 20;
			this.gvResults.RowTemplate.ReadOnly = true;
			this.gvResults.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.gvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvResults.Size = new System.Drawing.Size(184, 223);
			this.gvResults.StandardTab = true;
			this.gvResults.TabIndex = 13;
			this.gvResults.TabStop = false;
			// 
			// colResults
			// 
			this.colResults.DataPropertyName = "colResults";
			dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle29.Font = new System.Drawing.Font("Verdana", 6F);
			this.colResults.DefaultCellStyle = dataGridViewCellStyle29;
			this.colResults.HeaderText = "Results";
			this.colResults.MinimumWidth = 125;
			this.colResults.Name = "colResults";
			this.colResults.ReadOnly = true;
			this.colResults.Width = 125;
			// 
			// colValue
			// 
			this.colValue.DataPropertyName = "colValue";
			dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle30.Font = new System.Drawing.Font("Verdana", 6F);
			this.colValue.DefaultCellStyle = dataGridViewCellStyle30;
			this.colValue.HeaderText = "Value";
			this.colValue.MinimumWidth = 75;
			this.colValue.Name = "colValue";
			this.colValue.ReadOnly = true;
			this.colValue.Width = 75;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.gvHighScore);
			this.panel1.Controls.Add(this.pictureBox12);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.MinimumSize = new System.Drawing.Size(121, 635);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(204, 642);
			this.panel1.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(11, 347);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 23);
			this.label1.TabIndex = 15;
			this.label1.Text = "High Scores:";
			// 
			// gvHighScore
			// 
			this.gvHighScore.AllowUserToAddRows = false;
			this.gvHighScore.AllowUserToDeleteRows = false;
			this.gvHighScore.AllowUserToResizeColumns = false;
			this.gvHighScore.AllowUserToResizeRows = false;
			dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.Silver;
			this.gvHighScore.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle32;
			this.gvHighScore.AutoGenerateColumns = false;
			this.gvHighScore.BackgroundColor = System.Drawing.SystemColors.Control;
			this.gvHighScore.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
			this.gvHighScore.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle33.BackColor = System.Drawing.Color.Maroon;
			dataGridViewCellStyle33.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle33.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle33.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
			dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gvHighScore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
			this.gvHighScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvHighScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.colPlayerNameDataGridViewTextBoxColumn,
									this.colScoreDataGridViewTextBoxColumn,
									this.colIsCompleteDataGridViewCheckBoxColumn});
			this.gvHighScore.DataMember = "dtGameData";
			this.gvHighScore.DataSource = this.dsGameData;
			this.gvHighScore.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gvHighScore.EnableHeadersVisualStyles = false;
			this.gvHighScore.GridColor = System.Drawing.SystemColors.ControlText;
			this.gvHighScore.Location = new System.Drawing.Point(0, 395);
			this.gvHighScore.Margin = new System.Windows.Forms.Padding(2);
			this.gvHighScore.MinimumSize = new System.Drawing.Size(0, 195);
			this.gvHighScore.MultiSelect = false;
			this.gvHighScore.Name = "gvHighScore";
			this.gvHighScore.ReadOnly = true;
			this.gvHighScore.RowHeadersVisible = false;
			this.gvHighScore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle36.Font = new System.Drawing.Font("Verdana", 6F);
			this.gvHighScore.RowsDefaultCellStyle = dataGridViewCellStyle36;
			this.gvHighScore.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.gvHighScore.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.SteelBlue;
			this.gvHighScore.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gvHighScore.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
			this.gvHighScore.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
			this.gvHighScore.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
			this.gvHighScore.RowTemplate.Height = 20;
			this.gvHighScore.RowTemplate.ReadOnly = true;
			this.gvHighScore.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.gvHighScore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvHighScore.Size = new System.Drawing.Size(202, 245);
			this.gvHighScore.TabIndex = 14;
			this.gvHighScore.TabStop = false;
			// 
			// colPlayerNameDataGridViewTextBoxColumn
			// 
			this.colPlayerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.colPlayerNameDataGridViewTextBoxColumn.DataPropertyName = "colPlayerName";
			dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
			dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.colPlayerNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle34;
			this.colPlayerNameDataGridViewTextBoxColumn.HeaderText = "Player Name";
			this.colPlayerNameDataGridViewTextBoxColumn.Name = "colPlayerNameDataGridViewTextBoxColumn";
			this.colPlayerNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.colPlayerNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.colPlayerNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.colPlayerNameDataGridViewTextBoxColumn.Width = 125;
			// 
			// colScoreDataGridViewTextBoxColumn
			// 
			this.colScoreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.colScoreDataGridViewTextBoxColumn.DataPropertyName = "colScore";
			dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.colScoreDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle35;
			this.colScoreDataGridViewTextBoxColumn.HeaderText = "Score";
			this.colScoreDataGridViewTextBoxColumn.Name = "colScoreDataGridViewTextBoxColumn";
			this.colScoreDataGridViewTextBoxColumn.ReadOnly = true;
			this.colScoreDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.colScoreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.colScoreDataGridViewTextBoxColumn.Width = 75;
			// 
			// colIsCompleteDataGridViewCheckBoxColumn
			// 
			this.colIsCompleteDataGridViewCheckBoxColumn.DataPropertyName = "colIsComplete";
			this.colIsCompleteDataGridViewCheckBoxColumn.HeaderText = "colIsComplete";
			this.colIsCompleteDataGridViewCheckBoxColumn.Name = "colIsCompleteDataGridViewCheckBoxColumn";
			this.colIsCompleteDataGridViewCheckBoxColumn.ReadOnly = true;
			this.colIsCompleteDataGridViewCheckBoxColumn.Visible = false;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(12, 2);
			this.pictureBox12.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(180, 307);
			this.pictureBox12.TabIndex = 12;
			this.pictureBox12.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.AutoScroll = true;
			this.panel2.Controls.Add(this.pnlLowerScore);
			this.panel2.Controls.Add(this.label55);
			this.panel2.Controls.Add(this.pnlUpperScore);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(204, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(2);
			this.panel2.MaximumSize = new System.Drawing.Size(404, 635);
			this.panel2.MinimumSize = new System.Drawing.Size(404, 635);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(404, 635);
			this.panel2.TabIndex = 13;
			// 
			// pnlLowerScore
			// 
			this.pnlLowerScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlLowerScore.Controls.Add(this.panel8);
			this.pnlLowerScore.Controls.Add(this.r16c1);
			this.pnlLowerScore.Controls.Add(this.r16c2);
			this.pnlLowerScore.Controls.Add(this.r16c3);
			this.pnlLowerScore.Controls.Add(this.r16c4);
			this.pnlLowerScore.Controls.Add(this.r16c5);
			this.pnlLowerScore.Controls.Add(this.panel32);
			this.pnlLowerScore.Controls.Add(this.r10c3);
			this.pnlLowerScore.Controls.Add(this.r17c1);
			this.pnlLowerScore.Controls.Add(this.r17c2);
			this.pnlLowerScore.Controls.Add(this.r17c3);
			this.pnlLowerScore.Controls.Add(this.r17c4);
			this.pnlLowerScore.Controls.Add(this.r17c5);
			this.pnlLowerScore.Controls.Add(this.panel132);
			this.pnlLowerScore.Controls.Add(this.panel133);
			this.pnlLowerScore.Controls.Add(this.r18c1);
			this.pnlLowerScore.Controls.Add(this.r18c2);
			this.pnlLowerScore.Controls.Add(this.r18c3);
			this.pnlLowerScore.Controls.Add(this.r18c4);
			this.pnlLowerScore.Controls.Add(this.r18c5);
			this.pnlLowerScore.Controls.Add(this.panel101);
			this.pnlLowerScore.Controls.Add(this.panel110);
			this.pnlLowerScore.Controls.Add(this.panel88);
			this.pnlLowerScore.Controls.Add(this.r15c1);
			this.pnlLowerScore.Controls.Add(this.r15c2);
			this.pnlLowerScore.Controls.Add(this.r15c3);
			this.pnlLowerScore.Controls.Add(this.r15c4);
			this.pnlLowerScore.Controls.Add(this.r15c5);
			this.pnlLowerScore.Controls.Add(this.panel143);
			this.pnlLowerScore.Controls.Add(this.panel74);
			this.pnlLowerScore.Controls.Add(this.panel75);
			this.pnlLowerScore.Controls.Add(this.panel76);
			this.pnlLowerScore.Controls.Add(this.panel77);
			this.pnlLowerScore.Controls.Add(this.panel78);
			this.pnlLowerScore.Controls.Add(this.r19c1);
			this.pnlLowerScore.Controls.Add(this.r14c1);
			this.pnlLowerScore.Controls.Add(this.r13c1);
			this.pnlLowerScore.Controls.Add(this.r12c1);
			this.pnlLowerScore.Controls.Add(this.r11c1);
			this.pnlLowerScore.Controls.Add(this.r10c1);
			this.pnlLowerScore.Controls.Add(this.r9c1);
			this.pnlLowerScore.Controls.Add(this.r19c2);
			this.pnlLowerScore.Controls.Add(this.r14c2);
			this.pnlLowerScore.Controls.Add(this.r13c2);
			this.pnlLowerScore.Controls.Add(this.r12c2);
			this.pnlLowerScore.Controls.Add(this.r11c2);
			this.pnlLowerScore.Controls.Add(this.r10c2);
			this.pnlLowerScore.Controls.Add(this.r9c2);
			this.pnlLowerScore.Controls.Add(this.r19c3);
			this.pnlLowerScore.Controls.Add(this.r14c3);
			this.pnlLowerScore.Controls.Add(this.r13c3);
			this.pnlLowerScore.Controls.Add(this.r12c3);
			this.pnlLowerScore.Controls.Add(this.r11c3);
			this.pnlLowerScore.Controls.Add(this.r9c3);
			this.pnlLowerScore.Controls.Add(this.r19c4);
			this.pnlLowerScore.Controls.Add(this.r14c4);
			this.pnlLowerScore.Controls.Add(this.r13c4);
			this.pnlLowerScore.Controls.Add(this.r12c4);
			this.pnlLowerScore.Controls.Add(this.r11c4);
			this.pnlLowerScore.Controls.Add(this.r10c4);
			this.pnlLowerScore.Controls.Add(this.r9c4);
			this.pnlLowerScore.Controls.Add(this.r19c5);
			this.pnlLowerScore.Controls.Add(this.r14c5);
			this.pnlLowerScore.Controls.Add(this.r13c5);
			this.pnlLowerScore.Controls.Add(this.r12c5);
			this.pnlLowerScore.Controls.Add(this.r11c5);
			this.pnlLowerScore.Controls.Add(this.r10c5);
			this.pnlLowerScore.Controls.Add(this.r9c5);
			this.pnlLowerScore.Controls.Add(this.panel128);
			this.pnlLowerScore.Controls.Add(this.panel131);
			this.pnlLowerScore.Controls.Add(this.panel134);
			this.pnlLowerScore.Controls.Add(this.panel135);
			this.pnlLowerScore.Controls.Add(this.panel136);
			this.pnlLowerScore.Controls.Add(this.panel137);
			this.pnlLowerScore.Controls.Add(this.panel138);
			this.pnlLowerScore.Controls.Add(this.panel139);
			this.pnlLowerScore.Controls.Add(this.panel140);
			this.pnlLowerScore.Location = new System.Drawing.Point(7, 305);
			this.pnlLowerScore.Margin = new System.Windows.Forms.Padding(2);
			this.pnlLowerScore.Name = "pnlLowerScore";
			this.pnlLowerScore.Size = new System.Drawing.Size(374, 312);
			this.pnlLowerScore.TabIndex = 10;
			// 
			// panel8
			// 
			this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel8.Controls.Add(this.pictureBox13);
			this.panel8.Location = new System.Drawing.Point(102, 203);
			this.panel8.Margin = new System.Windows.Forms.Padding(2);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(60, 29);
			this.panel8.TabIndex = 162;
			// 
			// pictureBox13
			// 
			this.pictureBox13.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
			this.pictureBox13.Location = new System.Drawing.Point(0, 0);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(58, 27);
			this.pictureBox13.TabIndex = 10;
			this.pictureBox13.TabStop = false;
			// 
			// r16c1
			// 
			this.r16c1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r16c1.Location = new System.Drawing.Point(162, 203);
			this.r16c1.Margin = new System.Windows.Forms.Padding(2);
			this.r16c1.Name = "r16c1";
			this.r16c1.Size = new System.Drawing.Size(42, 29);
			this.r16c1.TabIndex = 161;
			this.r16c1.Tag = "YAHTZEE BONUS";
			this.r16c1.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r16c1.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r16c1.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r16c1.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r16c1.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r16c2
			// 
			this.r16c2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r16c2.Location = new System.Drawing.Point(204, 203);
			this.r16c2.Margin = new System.Windows.Forms.Padding(2);
			this.r16c2.Name = "r16c2";
			this.r16c2.Size = new System.Drawing.Size(42, 29);
			this.r16c2.TabIndex = 160;
			this.r16c2.Tag = "YAHTZEE BONUS";
			this.r16c2.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r16c2.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r16c2.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r16c2.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r16c2.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r16c3
			// 
			this.r16c3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r16c3.Location = new System.Drawing.Point(246, 203);
			this.r16c3.Margin = new System.Windows.Forms.Padding(2);
			this.r16c3.Name = "r16c3";
			this.r16c3.Size = new System.Drawing.Size(42, 29);
			this.r16c3.TabIndex = 159;
			this.r16c3.Tag = "YAHTZEE BONUS";
			this.r16c3.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r16c3.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r16c3.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r16c3.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r16c3.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r16c4
			// 
			this.r16c4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r16c4.Location = new System.Drawing.Point(288, 203);
			this.r16c4.Margin = new System.Windows.Forms.Padding(2);
			this.r16c4.Name = "r16c4";
			this.r16c4.Size = new System.Drawing.Size(42, 29);
			this.r16c4.TabIndex = 158;
			this.r16c4.Tag = "YAHTZEE BONUS";
			this.r16c4.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r16c4.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r16c4.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r16c4.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r16c4.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r16c5
			// 
			this.r16c5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r16c5.Location = new System.Drawing.Point(330, 203);
			this.r16c5.Margin = new System.Windows.Forms.Padding(2);
			this.r16c5.Name = "r16c5";
			this.r16c5.Size = new System.Drawing.Size(42, 29);
			this.r16c5.TabIndex = 157;
			this.r16c5.Tag = "YAHTZEE BONUS";
			this.r16c5.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r16c5.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r16c5.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r16c5.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r16c5.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// panel32
			// 
			this.panel32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel32.Controls.Add(this.pictureBox14);
			this.panel32.Location = new System.Drawing.Point(0, 203);
			this.panel32.Margin = new System.Windows.Forms.Padding(2);
			this.panel32.Name = "panel32";
			this.panel32.Size = new System.Drawing.Size(102, 29);
			this.panel32.TabIndex = 156;
			// 
			// pictureBox14
			// 
			this.pictureBox14.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
			this.pictureBox14.Location = new System.Drawing.Point(0, 0);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(100, 27);
			this.pictureBox14.TabIndex = 6;
			this.pictureBox14.TabStop = false;
			// 
			// r10c3
			// 
			this.r10c3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r10c3.Location = new System.Drawing.Point(246, 29);
			this.r10c3.Margin = new System.Windows.Forms.Padding(2);
			this.r10c3.Name = "r10c3";
			this.r10c3.Size = new System.Drawing.Size(42, 29);
			this.r10c3.TabIndex = 85;
			this.r10c3.Tag = "4 Of a Kind";
			this.r10c3.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r10c3.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r10c3.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r10c3.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r10c3.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r17c1
			// 
			this.r17c1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r17c1.Location = new System.Drawing.Point(162, 232);
			this.r17c1.Margin = new System.Windows.Forms.Padding(2);
			this.r17c1.Name = "r17c1";
			this.r17c1.Size = new System.Drawing.Size(42, 26);
			this.r17c1.TabIndex = 155;
			// 
			// r17c2
			// 
			this.r17c2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r17c2.Location = new System.Drawing.Point(204, 232);
			this.r17c2.Margin = new System.Windows.Forms.Padding(2);
			this.r17c2.Name = "r17c2";
			this.r17c2.Size = new System.Drawing.Size(42, 26);
			this.r17c2.TabIndex = 154;
			// 
			// r17c3
			// 
			this.r17c3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r17c3.Location = new System.Drawing.Point(246, 232);
			this.r17c3.Margin = new System.Windows.Forms.Padding(2);
			this.r17c3.Name = "r17c3";
			this.r17c3.Size = new System.Drawing.Size(42, 26);
			this.r17c3.TabIndex = 153;
			// 
			// r17c4
			// 
			this.r17c4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r17c4.Location = new System.Drawing.Point(288, 232);
			this.r17c4.Margin = new System.Windows.Forms.Padding(2);
			this.r17c4.Name = "r17c4";
			this.r17c4.Size = new System.Drawing.Size(42, 26);
			this.r17c4.TabIndex = 152;
			// 
			// r17c5
			// 
			this.r17c5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r17c5.Location = new System.Drawing.Point(330, 232);
			this.r17c5.Margin = new System.Windows.Forms.Padding(2);
			this.r17c5.Name = "r17c5";
			this.r17c5.Size = new System.Drawing.Size(42, 26);
			this.r17c5.TabIndex = 151;
			// 
			// panel132
			// 
			this.panel132.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel132.Controls.Add(this.pictureBox11);
			this.panel132.Location = new System.Drawing.Point(102, 232);
			this.panel132.Margin = new System.Windows.Forms.Padding(2);
			this.panel132.Name = "panel132";
			this.panel132.Size = new System.Drawing.Size(60, 26);
			this.panel132.TabIndex = 150;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(1, 4);
			this.pictureBox11.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(57, 17);
			this.pictureBox11.TabIndex = 5;
			this.pictureBox11.TabStop = false;
			// 
			// panel133
			// 
			this.panel133.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel133.Controls.Add(this.pictureBox48);
			this.panel133.Location = new System.Drawing.Point(0, 232);
			this.panel133.Margin = new System.Windows.Forms.Padding(2);
			this.panel133.Name = "panel133";
			this.panel133.Size = new System.Drawing.Size(102, 26);
			this.panel133.TabIndex = 149;
			// 
			// pictureBox48
			// 
			this.pictureBox48.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox48.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox48.Image")));
			this.pictureBox48.Location = new System.Drawing.Point(0, 0);
			this.pictureBox48.Name = "pictureBox48";
			this.pictureBox48.Size = new System.Drawing.Size(100, 24);
			this.pictureBox48.TabIndex = 4;
			this.pictureBox48.TabStop = false;
			// 
			// r18c1
			// 
			this.r18c1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r18c1.Location = new System.Drawing.Point(162, 258);
			this.r18c1.Margin = new System.Windows.Forms.Padding(2);
			this.r18c1.Name = "r18c1";
			this.r18c1.Size = new System.Drawing.Size(42, 26);
			this.r18c1.TabIndex = 148;
			// 
			// r18c2
			// 
			this.r18c2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r18c2.Location = new System.Drawing.Point(204, 258);
			this.r18c2.Margin = new System.Windows.Forms.Padding(2);
			this.r18c2.Name = "r18c2";
			this.r18c2.Size = new System.Drawing.Size(42, 26);
			this.r18c2.TabIndex = 147;
			// 
			// r18c3
			// 
			this.r18c3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r18c3.Location = new System.Drawing.Point(246, 258);
			this.r18c3.Margin = new System.Windows.Forms.Padding(2);
			this.r18c3.Name = "r18c3";
			this.r18c3.Size = new System.Drawing.Size(42, 26);
			this.r18c3.TabIndex = 146;
			// 
			// r18c4
			// 
			this.r18c4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r18c4.Location = new System.Drawing.Point(288, 258);
			this.r18c4.Margin = new System.Windows.Forms.Padding(2);
			this.r18c4.Name = "r18c4";
			this.r18c4.Size = new System.Drawing.Size(42, 26);
			this.r18c4.TabIndex = 145;
			// 
			// r18c5
			// 
			this.r18c5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r18c5.Location = new System.Drawing.Point(330, 258);
			this.r18c5.Margin = new System.Windows.Forms.Padding(2);
			this.r18c5.Name = "r18c5";
			this.r18c5.Size = new System.Drawing.Size(42, 26);
			this.r18c5.TabIndex = 144;
			// 
			// panel101
			// 
			this.panel101.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel101.Controls.Add(this.pictureBox10);
			this.panel101.Location = new System.Drawing.Point(102, 258);
			this.panel101.Margin = new System.Windows.Forms.Padding(2);
			this.panel101.Name = "panel101";
			this.panel101.Size = new System.Drawing.Size(60, 26);
			this.panel101.TabIndex = 143;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(1, 4);
			this.pictureBox10.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(57, 17);
			this.pictureBox10.TabIndex = 5;
			this.pictureBox10.TabStop = false;
			// 
			// panel110
			// 
			this.panel110.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel110.Controls.Add(this.pictureBox49);
			this.panel110.Location = new System.Drawing.Point(0, 258);
			this.panel110.Margin = new System.Windows.Forms.Padding(2);
			this.panel110.Name = "panel110";
			this.panel110.Size = new System.Drawing.Size(102, 26);
			this.panel110.TabIndex = 142;
			// 
			// pictureBox49
			// 
			this.pictureBox49.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox49.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox49.Image")));
			this.pictureBox49.Location = new System.Drawing.Point(0, 0);
			this.pictureBox49.Name = "pictureBox49";
			this.pictureBox49.Size = new System.Drawing.Size(100, 24);
			this.pictureBox49.TabIndex = 4;
			this.pictureBox49.TabStop = false;
			// 
			// panel88
			// 
			this.panel88.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel88.Controls.Add(this.pictureBox40);
			this.panel88.Location = new System.Drawing.Point(102, 174);
			this.panel88.Margin = new System.Windows.Forms.Padding(2);
			this.panel88.Name = "panel88";
			this.panel88.Size = new System.Drawing.Size(60, 29);
			this.panel88.TabIndex = 122;
			// 
			// pictureBox40
			// 
			this.pictureBox40.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox40.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox40.Image")));
			this.pictureBox40.Location = new System.Drawing.Point(0, 0);
			this.pictureBox40.Name = "pictureBox40";
			this.pictureBox40.Size = new System.Drawing.Size(58, 27);
			this.pictureBox40.TabIndex = 10;
			this.pictureBox40.TabStop = false;
			// 
			// r15c1
			// 
			this.r15c1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r15c1.Location = new System.Drawing.Point(162, 174);
			this.r15c1.Margin = new System.Windows.Forms.Padding(2);
			this.r15c1.Name = "r15c1";
			this.r15c1.Size = new System.Drawing.Size(42, 29);
			this.r15c1.TabIndex = 121;
			this.r15c1.Tag = "Chance";
			this.r15c1.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r15c1.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r15c1.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r15c1.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r15c1.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r15c2
			// 
			this.r15c2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r15c2.Location = new System.Drawing.Point(204, 174);
			this.r15c2.Margin = new System.Windows.Forms.Padding(2);
			this.r15c2.Name = "r15c2";
			this.r15c2.Size = new System.Drawing.Size(42, 29);
			this.r15c2.TabIndex = 120;
			this.r15c2.Tag = "Chance";
			this.r15c2.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r15c2.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r15c2.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r15c2.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r15c2.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r15c3
			// 
			this.r15c3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r15c3.Location = new System.Drawing.Point(246, 174);
			this.r15c3.Margin = new System.Windows.Forms.Padding(2);
			this.r15c3.Name = "r15c3";
			this.r15c3.Size = new System.Drawing.Size(42, 29);
			this.r15c3.TabIndex = 119;
			this.r15c3.Tag = "Chance";
			this.r15c3.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r15c3.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r15c3.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r15c3.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r15c3.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r15c4
			// 
			this.r15c4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r15c4.Location = new System.Drawing.Point(288, 174);
			this.r15c4.Margin = new System.Windows.Forms.Padding(2);
			this.r15c4.Name = "r15c4";
			this.r15c4.Size = new System.Drawing.Size(42, 29);
			this.r15c4.TabIndex = 118;
			this.r15c4.Tag = "Chance";
			this.r15c4.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r15c4.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r15c4.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r15c4.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r15c4.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r15c5
			// 
			this.r15c5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r15c5.Location = new System.Drawing.Point(330, 174);
			this.r15c5.Margin = new System.Windows.Forms.Padding(2);
			this.r15c5.Name = "r15c5";
			this.r15c5.Size = new System.Drawing.Size(42, 29);
			this.r15c5.TabIndex = 117;
			this.r15c5.Tag = "Chance";
			this.r15c5.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r15c5.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r15c5.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r15c5.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r15c5.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// panel143
			// 
			this.panel143.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel143.Controls.Add(this.pictureBox47);
			this.panel143.Location = new System.Drawing.Point(0, 174);
			this.panel143.Margin = new System.Windows.Forms.Padding(2);
			this.panel143.Name = "panel143";
			this.panel143.Size = new System.Drawing.Size(102, 29);
			this.panel143.TabIndex = 116;
			// 
			// pictureBox47
			// 
			this.pictureBox47.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox47.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox47.Image")));
			this.pictureBox47.Location = new System.Drawing.Point(0, 0);
			this.pictureBox47.Name = "pictureBox47";
			this.pictureBox47.Size = new System.Drawing.Size(100, 27);
			this.pictureBox47.TabIndex = 6;
			this.pictureBox47.TabStop = false;
			// 
			// panel74
			// 
			this.panel74.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel74.Controls.Add(this.pictureBox39);
			this.panel74.Location = new System.Drawing.Point(102, 145);
			this.panel74.Margin = new System.Windows.Forms.Padding(2);
			this.panel74.Name = "panel74";
			this.panel74.Size = new System.Drawing.Size(60, 29);
			this.panel74.TabIndex = 115;
			// 
			// pictureBox39
			// 
			this.pictureBox39.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox39.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox39.Image")));
			this.pictureBox39.Location = new System.Drawing.Point(0, 0);
			this.pictureBox39.Name = "pictureBox39";
			this.pictureBox39.Size = new System.Drawing.Size(58, 27);
			this.pictureBox39.TabIndex = 9;
			this.pictureBox39.TabStop = false;
			// 
			// panel75
			// 
			this.panel75.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel75.Controls.Add(this.pictureBox38);
			this.panel75.Location = new System.Drawing.Point(102, 116);
			this.panel75.Margin = new System.Windows.Forms.Padding(2);
			this.panel75.Name = "panel75";
			this.panel75.Size = new System.Drawing.Size(60, 29);
			this.panel75.TabIndex = 114;
			// 
			// pictureBox38
			// 
			this.pictureBox38.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox38.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox38.Image")));
			this.pictureBox38.Location = new System.Drawing.Point(0, 0);
			this.pictureBox38.Name = "pictureBox38";
			this.pictureBox38.Size = new System.Drawing.Size(58, 27);
			this.pictureBox38.TabIndex = 9;
			this.pictureBox38.TabStop = false;
			// 
			// panel76
			// 
			this.panel76.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel76.Controls.Add(this.pictureBox37);
			this.panel76.Location = new System.Drawing.Point(102, 87);
			this.panel76.Margin = new System.Windows.Forms.Padding(2);
			this.panel76.Name = "panel76";
			this.panel76.Size = new System.Drawing.Size(60, 29);
			this.panel76.TabIndex = 19;
			// 
			// pictureBox37
			// 
			this.pictureBox37.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox37.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox37.Image")));
			this.pictureBox37.Location = new System.Drawing.Point(0, 0);
			this.pictureBox37.Name = "pictureBox37";
			this.pictureBox37.Size = new System.Drawing.Size(58, 27);
			this.pictureBox37.TabIndex = 8;
			this.pictureBox37.TabStop = false;
			// 
			// panel77
			// 
			this.panel77.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel77.Controls.Add(this.pictureBox36);
			this.panel77.Location = new System.Drawing.Point(102, 58);
			this.panel77.Margin = new System.Windows.Forms.Padding(2);
			this.panel77.Name = "panel77";
			this.panel77.Size = new System.Drawing.Size(60, 29);
			this.panel77.TabIndex = 19;
			// 
			// pictureBox36
			// 
			this.pictureBox36.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox36.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox36.Image")));
			this.pictureBox36.Location = new System.Drawing.Point(0, 0);
			this.pictureBox36.Name = "pictureBox36";
			this.pictureBox36.Size = new System.Drawing.Size(58, 27);
			this.pictureBox36.TabIndex = 8;
			this.pictureBox36.TabStop = false;
			// 
			// panel78
			// 
			this.panel78.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel78.Controls.Add(this.pictureBox35);
			this.panel78.Location = new System.Drawing.Point(102, 29);
			this.panel78.Margin = new System.Windows.Forms.Padding(2);
			this.panel78.Name = "panel78";
			this.panel78.Size = new System.Drawing.Size(60, 29);
			this.panel78.TabIndex = 113;
			// 
			// pictureBox35
			// 
			this.pictureBox35.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox35.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox35.Image")));
			this.pictureBox35.Location = new System.Drawing.Point(0, 0);
			this.pictureBox35.Name = "pictureBox35";
			this.pictureBox35.Size = new System.Drawing.Size(58, 27);
			this.pictureBox35.TabIndex = 7;
			this.pictureBox35.TabStop = false;
			// 
			// r19c1
			// 
			this.r19c1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r19c1.Location = new System.Drawing.Point(162, 284);
			this.r19c1.Margin = new System.Windows.Forms.Padding(2);
			this.r19c1.Name = "r19c1";
			this.r19c1.Size = new System.Drawing.Size(42, 26);
			this.r19c1.TabIndex = 112;
			// 
			// r14c1
			// 
			this.r14c1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r14c1.Location = new System.Drawing.Point(162, 145);
			this.r14c1.Margin = new System.Windows.Forms.Padding(2);
			this.r14c1.Name = "r14c1";
			this.r14c1.Size = new System.Drawing.Size(42, 29);
			this.r14c1.TabIndex = 109;
			this.r14c1.Tag = "YAHTZEE";
			this.r14c1.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r14c1.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r14c1.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r14c1.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r14c1.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r13c1
			// 
			this.r13c1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r13c1.Location = new System.Drawing.Point(162, 116);
			this.r13c1.Margin = new System.Windows.Forms.Padding(2);
			this.r13c1.Name = "r13c1";
			this.r13c1.Size = new System.Drawing.Size(42, 29);
			this.r13c1.TabIndex = 108;
			this.r13c1.Tag = "Large Straight";
			this.r13c1.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r13c1.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r13c1.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r13c1.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r13c1.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r12c1
			// 
			this.r12c1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r12c1.Location = new System.Drawing.Point(162, 87);
			this.r12c1.Margin = new System.Windows.Forms.Padding(2);
			this.r12c1.Name = "r12c1";
			this.r12c1.Size = new System.Drawing.Size(42, 29);
			this.r12c1.TabIndex = 107;
			this.r12c1.Tag = "Small Straight";
			this.r12c1.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r12c1.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r12c1.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r12c1.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r12c1.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r11c1
			// 
			this.r11c1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r11c1.Location = new System.Drawing.Point(162, 58);
			this.r11c1.Margin = new System.Windows.Forms.Padding(2);
			this.r11c1.Name = "r11c1";
			this.r11c1.Size = new System.Drawing.Size(42, 29);
			this.r11c1.TabIndex = 106;
			this.r11c1.Tag = "Full House";
			this.r11c1.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r11c1.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r11c1.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r11c1.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r11c1.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r10c1
			// 
			this.r10c1.BackColor = System.Drawing.SystemColors.Control;
			this.r10c1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r10c1.Location = new System.Drawing.Point(162, 29);
			this.r10c1.Margin = new System.Windows.Forms.Padding(2);
			this.r10c1.Name = "r10c1";
			this.r10c1.Size = new System.Drawing.Size(42, 29);
			this.r10c1.TabIndex = 105;
			this.r10c1.Tag = "4 Of a Kind";
			this.r10c1.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r10c1.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r10c1.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r10c1.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r10c1.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r9c1
			// 
			this.r9c1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r9c1.Location = new System.Drawing.Point(162, 0);
			this.r9c1.Margin = new System.Windows.Forms.Padding(2);
			this.r9c1.Name = "r9c1";
			this.r9c1.Size = new System.Drawing.Size(42, 29);
			this.r9c1.TabIndex = 104;
			this.r9c1.Tag = "3 Of a Kind";
			this.r9c1.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r9c1.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r9c1.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r9c1.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r9c1.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r19c2
			// 
			this.r19c2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r19c2.Location = new System.Drawing.Point(204, 284);
			this.r19c2.Margin = new System.Windows.Forms.Padding(2);
			this.r19c2.Name = "r19c2";
			this.r19c2.Size = new System.Drawing.Size(42, 26);
			this.r19c2.TabIndex = 102;
			// 
			// r14c2
			// 
			this.r14c2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r14c2.Location = new System.Drawing.Point(204, 145);
			this.r14c2.Margin = new System.Windows.Forms.Padding(2);
			this.r14c2.Name = "r14c2";
			this.r14c2.Size = new System.Drawing.Size(42, 29);
			this.r14c2.TabIndex = 99;
			this.r14c2.Tag = "YAHTZEE";
			this.r14c2.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r14c2.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r14c2.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r14c2.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r14c2.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r13c2
			// 
			this.r13c2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r13c2.Location = new System.Drawing.Point(204, 116);
			this.r13c2.Margin = new System.Windows.Forms.Padding(2);
			this.r13c2.Name = "r13c2";
			this.r13c2.Size = new System.Drawing.Size(42, 29);
			this.r13c2.TabIndex = 98;
			this.r13c2.Tag = "Large Straight";
			this.r13c2.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r13c2.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r13c2.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r13c2.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r13c2.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r12c2
			// 
			this.r12c2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r12c2.Location = new System.Drawing.Point(204, 87);
			this.r12c2.Margin = new System.Windows.Forms.Padding(2);
			this.r12c2.Name = "r12c2";
			this.r12c2.Size = new System.Drawing.Size(42, 29);
			this.r12c2.TabIndex = 97;
			this.r12c2.Tag = "Small Straight";
			this.r12c2.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r12c2.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r12c2.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r12c2.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r12c2.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r11c2
			// 
			this.r11c2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r11c2.Location = new System.Drawing.Point(204, 58);
			this.r11c2.Margin = new System.Windows.Forms.Padding(2);
			this.r11c2.Name = "r11c2";
			this.r11c2.Size = new System.Drawing.Size(42, 29);
			this.r11c2.TabIndex = 96;
			this.r11c2.Tag = "Full House";
			this.r11c2.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r11c2.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r11c2.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r11c2.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r11c2.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r10c2
			// 
			this.r10c2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r10c2.Location = new System.Drawing.Point(204, 29);
			this.r10c2.Margin = new System.Windows.Forms.Padding(2);
			this.r10c2.Name = "r10c2";
			this.r10c2.Size = new System.Drawing.Size(42, 29);
			this.r10c2.TabIndex = 95;
			this.r10c2.Tag = "4 Of a Kind";
			this.r10c2.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r10c2.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r10c2.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r10c2.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r10c2.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r9c2
			// 
			this.r9c2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r9c2.Location = new System.Drawing.Point(204, 0);
			this.r9c2.Margin = new System.Windows.Forms.Padding(2);
			this.r9c2.Name = "r9c2";
			this.r9c2.Size = new System.Drawing.Size(42, 29);
			this.r9c2.TabIndex = 94;
			this.r9c2.Tag = "3 Of a Kind";
			this.r9c2.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r9c2.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r9c2.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r9c2.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r9c2.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r19c3
			// 
			this.r19c3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r19c3.Location = new System.Drawing.Point(246, 284);
			this.r19c3.Margin = new System.Windows.Forms.Padding(2);
			this.r19c3.Name = "r19c3";
			this.r19c3.Size = new System.Drawing.Size(42, 26);
			this.r19c3.TabIndex = 92;
			// 
			// r14c3
			// 
			this.r14c3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r14c3.Location = new System.Drawing.Point(246, 145);
			this.r14c3.Margin = new System.Windows.Forms.Padding(2);
			this.r14c3.Name = "r14c3";
			this.r14c3.Size = new System.Drawing.Size(42, 29);
			this.r14c3.TabIndex = 89;
			this.r14c3.Tag = "YAHTZEE";
			this.r14c3.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r14c3.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r14c3.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r14c3.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r14c3.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r13c3
			// 
			this.r13c3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r13c3.Location = new System.Drawing.Point(246, 116);
			this.r13c3.Margin = new System.Windows.Forms.Padding(2);
			this.r13c3.Name = "r13c3";
			this.r13c3.Size = new System.Drawing.Size(42, 29);
			this.r13c3.TabIndex = 88;
			this.r13c3.Tag = "Large Straight";
			this.r13c3.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r13c3.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r13c3.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r13c3.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r13c3.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r12c3
			// 
			this.r12c3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r12c3.Location = new System.Drawing.Point(246, 87);
			this.r12c3.Margin = new System.Windows.Forms.Padding(2);
			this.r12c3.Name = "r12c3";
			this.r12c3.Size = new System.Drawing.Size(42, 29);
			this.r12c3.TabIndex = 87;
			this.r12c3.Tag = "Small Straight";
			this.r12c3.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r12c3.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r12c3.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r12c3.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r12c3.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r11c3
			// 
			this.r11c3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r11c3.Location = new System.Drawing.Point(246, 58);
			this.r11c3.Margin = new System.Windows.Forms.Padding(2);
			this.r11c3.Name = "r11c3";
			this.r11c3.Size = new System.Drawing.Size(42, 29);
			this.r11c3.TabIndex = 86;
			this.r11c3.Tag = "Full House";
			this.r11c3.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r11c3.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r11c3.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r11c3.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r11c3.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r9c3
			// 
			this.r9c3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r9c3.Location = new System.Drawing.Point(246, 0);
			this.r9c3.Margin = new System.Windows.Forms.Padding(2);
			this.r9c3.Name = "r9c3";
			this.r9c3.Size = new System.Drawing.Size(42, 29);
			this.r9c3.TabIndex = 84;
			this.r9c3.Tag = "3 Of a Kind";
			this.r9c3.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r9c3.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r9c3.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r9c3.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r9c3.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r19c4
			// 
			this.r19c4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r19c4.Location = new System.Drawing.Point(288, 284);
			this.r19c4.Margin = new System.Windows.Forms.Padding(2);
			this.r19c4.Name = "r19c4";
			this.r19c4.Size = new System.Drawing.Size(42, 26);
			this.r19c4.TabIndex = 82;
			// 
			// r14c4
			// 
			this.r14c4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r14c4.Location = new System.Drawing.Point(288, 145);
			this.r14c4.Margin = new System.Windows.Forms.Padding(2);
			this.r14c4.Name = "r14c4";
			this.r14c4.Size = new System.Drawing.Size(42, 29);
			this.r14c4.TabIndex = 79;
			this.r14c4.Tag = "YAHTZEE";
			this.r14c4.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r14c4.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r14c4.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r14c4.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r14c4.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r13c4
			// 
			this.r13c4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r13c4.Location = new System.Drawing.Point(288, 116);
			this.r13c4.Margin = new System.Windows.Forms.Padding(2);
			this.r13c4.Name = "r13c4";
			this.r13c4.Size = new System.Drawing.Size(42, 29);
			this.r13c4.TabIndex = 78;
			this.r13c4.Tag = "Large Straight";
			this.r13c4.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r13c4.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r13c4.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r13c4.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r13c4.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r12c4
			// 
			this.r12c4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r12c4.Location = new System.Drawing.Point(288, 87);
			this.r12c4.Margin = new System.Windows.Forms.Padding(2);
			this.r12c4.Name = "r12c4";
			this.r12c4.Size = new System.Drawing.Size(42, 29);
			this.r12c4.TabIndex = 77;
			this.r12c4.Tag = "Small Straight";
			this.r12c4.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r12c4.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r12c4.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r12c4.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r12c4.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r11c4
			// 
			this.r11c4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r11c4.Location = new System.Drawing.Point(288, 58);
			this.r11c4.Margin = new System.Windows.Forms.Padding(2);
			this.r11c4.Name = "r11c4";
			this.r11c4.Size = new System.Drawing.Size(42, 29);
			this.r11c4.TabIndex = 76;
			this.r11c4.Tag = "Full House";
			this.r11c4.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r11c4.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r11c4.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r11c4.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r11c4.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r10c4
			// 
			this.r10c4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r10c4.Location = new System.Drawing.Point(288, 29);
			this.r10c4.Margin = new System.Windows.Forms.Padding(2);
			this.r10c4.Name = "r10c4";
			this.r10c4.Size = new System.Drawing.Size(42, 29);
			this.r10c4.TabIndex = 75;
			this.r10c4.Tag = "4 Of a Kind";
			this.r10c4.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r10c4.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r10c4.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r10c4.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r10c4.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r9c4
			// 
			this.r9c4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r9c4.Location = new System.Drawing.Point(288, 0);
			this.r9c4.Margin = new System.Windows.Forms.Padding(2);
			this.r9c4.Name = "r9c4";
			this.r9c4.Size = new System.Drawing.Size(42, 29);
			this.r9c4.TabIndex = 74;
			this.r9c4.Tag = "3 Of a Kind";
			this.r9c4.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r9c4.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r9c4.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r9c4.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r9c4.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r19c5
			// 
			this.r19c5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r19c5.Location = new System.Drawing.Point(330, 284);
			this.r19c5.Margin = new System.Windows.Forms.Padding(2);
			this.r19c5.Name = "r19c5";
			this.r19c5.Size = new System.Drawing.Size(42, 26);
			this.r19c5.TabIndex = 72;
			// 
			// r14c5
			// 
			this.r14c5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r14c5.Location = new System.Drawing.Point(330, 145);
			this.r14c5.Margin = new System.Windows.Forms.Padding(2);
			this.r14c5.Name = "r14c5";
			this.r14c5.Size = new System.Drawing.Size(42, 29);
			this.r14c5.TabIndex = 57;
			this.r14c5.Tag = "YAHTZEE";
			this.r14c5.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r14c5.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r14c5.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r14c5.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r14c5.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r13c5
			// 
			this.r13c5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r13c5.Location = new System.Drawing.Point(330, 116);
			this.r13c5.Margin = new System.Windows.Forms.Padding(2);
			this.r13c5.Name = "r13c5";
			this.r13c5.Size = new System.Drawing.Size(42, 29);
			this.r13c5.TabIndex = 52;
			this.r13c5.Tag = "Large Straight";
			this.r13c5.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r13c5.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r13c5.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r13c5.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r13c5.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r12c5
			// 
			this.r12c5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r12c5.Location = new System.Drawing.Point(330, 87);
			this.r12c5.Margin = new System.Windows.Forms.Padding(2);
			this.r12c5.Name = "r12c5";
			this.r12c5.Size = new System.Drawing.Size(42, 29);
			this.r12c5.TabIndex = 47;
			this.r12c5.Tag = "Small Straight";
			this.r12c5.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r12c5.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r12c5.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r12c5.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r12c5.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r11c5
			// 
			this.r11c5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r11c5.Location = new System.Drawing.Point(330, 58);
			this.r11c5.Margin = new System.Windows.Forms.Padding(2);
			this.r11c5.Name = "r11c5";
			this.r11c5.Size = new System.Drawing.Size(42, 29);
			this.r11c5.TabIndex = 42;
			this.r11c5.Tag = "Full House";
			this.r11c5.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r11c5.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r11c5.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r11c5.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r11c5.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r10c5
			// 
			this.r10c5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r10c5.Location = new System.Drawing.Point(330, 29);
			this.r10c5.Margin = new System.Windows.Forms.Padding(2);
			this.r10c5.Name = "r10c5";
			this.r10c5.Size = new System.Drawing.Size(42, 29);
			this.r10c5.TabIndex = 37;
			this.r10c5.Tag = "4 Of a Kind";
			this.r10c5.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r10c5.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r10c5.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r10c5.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r10c5.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r9c5
			// 
			this.r9c5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r9c5.Location = new System.Drawing.Point(330, 0);
			this.r9c5.Margin = new System.Windows.Forms.Padding(2);
			this.r9c5.Name = "r9c5";
			this.r9c5.Size = new System.Drawing.Size(42, 29);
			this.r9c5.TabIndex = 32;
			this.r9c5.Tag = "3 Of a Kind";
			this.r9c5.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r9c5.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r9c5.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r9c5.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r9c5.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// panel128
			// 
			this.panel128.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel128.Controls.Add(this.pictureBox9);
			this.panel128.Location = new System.Drawing.Point(102, 284);
			this.panel128.Margin = new System.Windows.Forms.Padding(2);
			this.panel128.Name = "panel128";
			this.panel128.Size = new System.Drawing.Size(60, 26);
			this.panel128.TabIndex = 27;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(1, 4);
			this.pictureBox9.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(57, 17);
			this.pictureBox9.TabIndex = 5;
			this.pictureBox9.TabStop = false;
			// 
			// panel131
			// 
			this.panel131.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel131.Controls.Add(this.pictureBox50);
			this.panel131.Location = new System.Drawing.Point(0, 284);
			this.panel131.Margin = new System.Windows.Forms.Padding(2);
			this.panel131.Name = "panel131";
			this.panel131.Size = new System.Drawing.Size(102, 26);
			this.panel131.TabIndex = 24;
			// 
			// pictureBox50
			// 
			this.pictureBox50.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox50.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox50.Image")));
			this.pictureBox50.Location = new System.Drawing.Point(0, 0);
			this.pictureBox50.Name = "pictureBox50";
			this.pictureBox50.Size = new System.Drawing.Size(100, 24);
			this.pictureBox50.TabIndex = 5;
			this.pictureBox50.TabStop = false;
			// 
			// panel134
			// 
			this.panel134.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel134.Controls.Add(this.pictureBox46);
			this.panel134.Location = new System.Drawing.Point(0, 145);
			this.panel134.Margin = new System.Windows.Forms.Padding(2);
			this.panel134.Name = "panel134";
			this.panel134.Size = new System.Drawing.Size(102, 29);
			this.panel134.TabIndex = 16;
			// 
			// pictureBox46
			// 
			this.pictureBox46.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox46.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox46.Image")));
			this.pictureBox46.Location = new System.Drawing.Point(0, 0);
			this.pictureBox46.Name = "pictureBox46";
			this.pictureBox46.Size = new System.Drawing.Size(100, 27);
			this.pictureBox46.TabIndex = 6;
			this.pictureBox46.TabStop = false;
			// 
			// panel135
			// 
			this.panel135.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel135.Controls.Add(this.pictureBox45);
			this.panel135.Location = new System.Drawing.Point(0, 116);
			this.panel135.Margin = new System.Windows.Forms.Padding(2);
			this.panel135.Name = "panel135";
			this.panel135.Size = new System.Drawing.Size(102, 29);
			this.panel135.TabIndex = 15;
			// 
			// pictureBox45
			// 
			this.pictureBox45.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox45.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox45.Image")));
			this.pictureBox45.Location = new System.Drawing.Point(0, 0);
			this.pictureBox45.Name = "pictureBox45";
			this.pictureBox45.Size = new System.Drawing.Size(100, 27);
			this.pictureBox45.TabIndex = 5;
			this.pictureBox45.TabStop = false;
			// 
			// panel136
			// 
			this.panel136.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel136.Controls.Add(this.pictureBox44);
			this.panel136.Location = new System.Drawing.Point(0, 87);
			this.panel136.Margin = new System.Windows.Forms.Padding(2);
			this.panel136.Name = "panel136";
			this.panel136.Size = new System.Drawing.Size(102, 29);
			this.panel136.TabIndex = 14;
			// 
			// pictureBox44
			// 
			this.pictureBox44.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox44.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox44.Image")));
			this.pictureBox44.Location = new System.Drawing.Point(0, 0);
			this.pictureBox44.Name = "pictureBox44";
			this.pictureBox44.Size = new System.Drawing.Size(100, 27);
			this.pictureBox44.TabIndex = 5;
			this.pictureBox44.TabStop = false;
			// 
			// panel137
			// 
			this.panel137.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel137.Controls.Add(this.pictureBox43);
			this.panel137.Location = new System.Drawing.Point(0, 58);
			this.panel137.Margin = new System.Windows.Forms.Padding(2);
			this.panel137.Name = "panel137";
			this.panel137.Size = new System.Drawing.Size(102, 29);
			this.panel137.TabIndex = 13;
			// 
			// pictureBox43
			// 
			this.pictureBox43.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox43.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox43.Image")));
			this.pictureBox43.Location = new System.Drawing.Point(0, 0);
			this.pictureBox43.Name = "pictureBox43";
			this.pictureBox43.Size = new System.Drawing.Size(100, 27);
			this.pictureBox43.TabIndex = 5;
			this.pictureBox43.TabStop = false;
			// 
			// panel138
			// 
			this.panel138.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel138.Controls.Add(this.pictureBox34);
			this.panel138.Location = new System.Drawing.Point(102, 0);
			this.panel138.Margin = new System.Windows.Forms.Padding(2);
			this.panel138.Name = "panel138";
			this.panel138.Size = new System.Drawing.Size(60, 29);
			this.panel138.TabIndex = 12;
			// 
			// pictureBox34
			// 
			this.pictureBox34.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox34.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox34.Image")));
			this.pictureBox34.Location = new System.Drawing.Point(0, 0);
			this.pictureBox34.Name = "pictureBox34";
			this.pictureBox34.Size = new System.Drawing.Size(58, 27);
			this.pictureBox34.TabIndex = 6;
			this.pictureBox34.TabStop = false;
			// 
			// panel139
			// 
			this.panel139.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel139.Controls.Add(this.pictureBox42);
			this.panel139.Location = new System.Drawing.Point(0, 29);
			this.panel139.Margin = new System.Windows.Forms.Padding(2);
			this.panel139.Name = "panel139";
			this.panel139.Size = new System.Drawing.Size(102, 29);
			this.panel139.TabIndex = 11;
			// 
			// pictureBox42
			// 
			this.pictureBox42.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox42.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox42.Image")));
			this.pictureBox42.Location = new System.Drawing.Point(0, 0);
			this.pictureBox42.Name = "pictureBox42";
			this.pictureBox42.Size = new System.Drawing.Size(100, 27);
			this.pictureBox42.TabIndex = 4;
			this.pictureBox42.TabStop = false;
			// 
			// panel140
			// 
			this.panel140.AutoSize = true;
			this.panel140.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel140.Controls.Add(this.pictureBox41);
			this.panel140.Location = new System.Drawing.Point(0, 0);
			this.panel140.Margin = new System.Windows.Forms.Padding(2);
			this.panel140.Name = "panel140";
			this.panel140.Size = new System.Drawing.Size(102, 29);
			this.panel140.TabIndex = 10;
			// 
			// pictureBox41
			// 
			this.pictureBox41.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox41.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox41.Image")));
			this.pictureBox41.Location = new System.Drawing.Point(0, 0);
			this.pictureBox41.Name = "pictureBox41";
			this.pictureBox41.Size = new System.Drawing.Size(100, 27);
			this.pictureBox41.TabIndex = 4;
			this.pictureBox41.TabStop = false;
			// 
			// label55
			// 
			this.label55.AutoSize = true;
			this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label55.Location = new System.Drawing.Point(11, 287);
			this.label55.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label55.Name = "label55";
			this.label55.Size = new System.Drawing.Size(132, 16);
			this.label55.TabIndex = 9;
			this.label55.Text = "LOWER SECTION";
			// 
			// pnlUpperScore
			// 
			this.pnlUpperScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlUpperScore.Controls.Add(this.r1c1);
			this.pnlUpperScore.Controls.Add(this.r0c2);
			this.pnlUpperScore.Controls.Add(this.r0c1);
			this.pnlUpperScore.Controls.Add(this.r5c3);
			this.pnlUpperScore.Controls.Add(this.panel4);
			this.pnlUpperScore.Controls.Add(this.panel21);
			this.pnlUpperScore.Controls.Add(this.panel20);
			this.pnlUpperScore.Controls.Add(this.panel19);
			this.pnlUpperScore.Controls.Add(this.panel18);
			this.pnlUpperScore.Controls.Add(this.panel17);
			this.pnlUpperScore.Controls.Add(this.r8c1);
			this.pnlUpperScore.Controls.Add(this.r7c1);
			this.pnlUpperScore.Controls.Add(this.r6c1);
			this.pnlUpperScore.Controls.Add(this.r5c1);
			this.pnlUpperScore.Controls.Add(this.r4c1);
			this.pnlUpperScore.Controls.Add(this.r3c1);
			this.pnlUpperScore.Controls.Add(this.r2c1);
			this.pnlUpperScore.Controls.Add(this.panel72);
			this.pnlUpperScore.Controls.Add(this.r8c2);
			this.pnlUpperScore.Controls.Add(this.r7c2);
			this.pnlUpperScore.Controls.Add(this.r6c2);
			this.pnlUpperScore.Controls.Add(this.r5c2);
			this.pnlUpperScore.Controls.Add(this.r4c2);
			this.pnlUpperScore.Controls.Add(this.r3c2);
			this.pnlUpperScore.Controls.Add(this.r2c2);
			this.pnlUpperScore.Controls.Add(this.r1c2);
			this.pnlUpperScore.Controls.Add(this.panel60);
			this.pnlUpperScore.Controls.Add(this.r8c3);
			this.pnlUpperScore.Controls.Add(this.r7c3);
			this.pnlUpperScore.Controls.Add(this.r6c3);
			this.pnlUpperScore.Controls.Add(this.r4c3);
			this.pnlUpperScore.Controls.Add(this.r3c3);
			this.pnlUpperScore.Controls.Add(this.r2c3);
			this.pnlUpperScore.Controls.Add(this.r1c3);
			this.pnlUpperScore.Controls.Add(this.r0c3);
			this.pnlUpperScore.Controls.Add(this.panel47);
			this.pnlUpperScore.Controls.Add(this.r8c4);
			this.pnlUpperScore.Controls.Add(this.r7c4);
			this.pnlUpperScore.Controls.Add(this.r6c4);
			this.pnlUpperScore.Controls.Add(this.r5c4);
			this.pnlUpperScore.Controls.Add(this.r4c4);
			this.pnlUpperScore.Controls.Add(this.r3c4);
			this.pnlUpperScore.Controls.Add(this.r2c4);
			this.pnlUpperScore.Controls.Add(this.r1c4);
			this.pnlUpperScore.Controls.Add(this.r0c4);
			this.pnlUpperScore.Controls.Add(this.panel35);
			this.pnlUpperScore.Controls.Add(this.r8c5);
			this.pnlUpperScore.Controls.Add(this.r7c5);
			this.pnlUpperScore.Controls.Add(this.r6c5);
			this.pnlUpperScore.Controls.Add(this.r5c5);
			this.pnlUpperScore.Controls.Add(this.r4c5);
			this.pnlUpperScore.Controls.Add(this.r3c5);
			this.pnlUpperScore.Controls.Add(this.r2c5);
			this.pnlUpperScore.Controls.Add(this.r1c5);
			this.pnlUpperScore.Controls.Add(this.r0c5);
			this.pnlUpperScore.Controls.Add(this.panel27);
			this.pnlUpperScore.Controls.Add(this.panel26);
			this.pnlUpperScore.Controls.Add(this.panel25);
			this.pnlUpperScore.Controls.Add(this.panel24);
			this.pnlUpperScore.Controls.Add(this.panel23);
			this.pnlUpperScore.Controls.Add(this.panel22);
			this.pnlUpperScore.Controls.Add(this.panel16);
			this.pnlUpperScore.Controls.Add(this.panel15);
			this.pnlUpperScore.Controls.Add(this.panel14);
			this.pnlUpperScore.Controls.Add(this.panel13);
			this.pnlUpperScore.Controls.Add(this.panel12);
			this.pnlUpperScore.Controls.Add(this.panel11);
			this.pnlUpperScore.Controls.Add(this.panel5);
			this.pnlUpperScore.Controls.Add(this.panel10);
			this.pnlUpperScore.Controls.Add(this.panel6);
			this.pnlUpperScore.Location = new System.Drawing.Point(7, 4);
			this.pnlUpperScore.Margin = new System.Windows.Forms.Padding(0);
			this.pnlUpperScore.Name = "pnlUpperScore";
			this.pnlUpperScore.Size = new System.Drawing.Size(374, 280);
			this.pnlUpperScore.TabIndex = 8;
			// 
			// r1c1
			// 
			this.r1c1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r1c1.Location = new System.Drawing.Point(162, 55);
			this.r1c1.Margin = new System.Windows.Forms.Padding(2);
			this.r1c1.Name = "r1c1";
			this.r1c1.Size = new System.Drawing.Size(42, 29);
			this.r1c1.TabIndex = 105;
			this.r1c1.Tag = "Twos";
			this.r1c1.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r1c1.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r1c1.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r1c1.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r1c1.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r0c2
			// 
			this.r0c2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r0c2.Location = new System.Drawing.Point(204, 26);
			this.r0c2.Margin = new System.Windows.Forms.Padding(2);
			this.r0c2.Name = "r0c2";
			this.r0c2.Size = new System.Drawing.Size(42, 29);
			this.r0c2.TabIndex = 94;
			this.r0c2.Tag = "Ones";
			this.r0c2.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r0c2.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r0c2.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r0c2.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r0c2.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r0c1
			// 
			this.r0c1.BackColor = System.Drawing.SystemColors.Control;
			this.r0c1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r0c1.Location = new System.Drawing.Point(162, 26);
			this.r0c1.Margin = new System.Windows.Forms.Padding(2);
			this.r0c1.Name = "r0c1";
			this.r0c1.Size = new System.Drawing.Size(42, 29);
			this.r0c1.TabIndex = 104;
			this.r0c1.Tag = "Ones";
			this.r0c1.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r0c1.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r0c1.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r0c1.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r0c1.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r5c3
			// 
			this.r5c3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r5c3.Location = new System.Drawing.Point(246, 171);
			this.r5c3.Margin = new System.Windows.Forms.Padding(2);
			this.r5c3.Name = "r5c3";
			this.r5c3.Size = new System.Drawing.Size(42, 29);
			this.r5c3.TabIndex = 89;
			this.r5c3.Tag = "Sixes";
			this.r5c3.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r5c3.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r5c3.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r5c3.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r5c3.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.pictureBox30);
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Margin = new System.Windows.Forms.Padding(2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(102, 26);
			this.panel4.TabIndex = 2;
			// 
			// pictureBox30
			// 
			this.pictureBox30.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox30.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox30.Image")));
			this.pictureBox30.Location = new System.Drawing.Point(0, 0);
			this.pictureBox30.Name = "pictureBox30";
			this.pictureBox30.Size = new System.Drawing.Size(100, 24);
			this.pictureBox30.TabIndex = 2;
			this.pictureBox30.TabStop = false;
			// 
			// panel21
			// 
			this.panel21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel21.Controls.Add(this.pictureBox22);
			this.panel21.Location = new System.Drawing.Point(102, 171);
			this.panel21.Margin = new System.Windows.Forms.Padding(2);
			this.panel21.Name = "panel21";
			this.panel21.Size = new System.Drawing.Size(60, 29);
			this.panel21.TabIndex = 115;
			// 
			// pictureBox22
			// 
			this.pictureBox22.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
			this.pictureBox22.Location = new System.Drawing.Point(0, 0);
			this.pictureBox22.MaximumSize = new System.Drawing.Size(60, 29);
			this.pictureBox22.MinimumSize = new System.Drawing.Size(60, 29);
			this.pictureBox22.Name = "pictureBox22";
			this.pictureBox22.Size = new System.Drawing.Size(60, 29);
			this.pictureBox22.TabIndex = 2;
			this.pictureBox22.TabStop = false;
			// 
			// panel20
			// 
			this.panel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel20.Controls.Add(this.pictureBox21);
			this.panel20.Location = new System.Drawing.Point(102, 142);
			this.panel20.Margin = new System.Windows.Forms.Padding(2);
			this.panel20.MaximumSize = new System.Drawing.Size(60, 29);
			this.panel20.MinimumSize = new System.Drawing.Size(60, 29);
			this.panel20.Name = "panel20";
			this.panel20.Size = new System.Drawing.Size(60, 29);
			this.panel20.TabIndex = 114;
			// 
			// pictureBox21
			// 
			this.pictureBox21.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
			this.pictureBox21.Location = new System.Drawing.Point(0, 0);
			this.pictureBox21.Name = "pictureBox21";
			this.pictureBox21.Size = new System.Drawing.Size(58, 27);
			this.pictureBox21.TabIndex = 2;
			this.pictureBox21.TabStop = false;
			// 
			// panel19
			// 
			this.panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel19.Controls.Add(this.pictureBox20);
			this.panel19.Location = new System.Drawing.Point(102, 113);
			this.panel19.Margin = new System.Windows.Forms.Padding(2);
			this.panel19.MaximumSize = new System.Drawing.Size(60, 29);
			this.panel19.MinimumSize = new System.Drawing.Size(60, 29);
			this.panel19.Name = "panel19";
			this.panel19.Size = new System.Drawing.Size(60, 29);
			this.panel19.TabIndex = 19;
			// 
			// pictureBox20
			// 
			this.pictureBox20.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
			this.pictureBox20.Location = new System.Drawing.Point(0, 0);
			this.pictureBox20.Name = "pictureBox20";
			this.pictureBox20.Size = new System.Drawing.Size(58, 27);
			this.pictureBox20.TabIndex = 2;
			this.pictureBox20.TabStop = false;
			// 
			// panel18
			// 
			this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel18.Controls.Add(this.pictureBox19);
			this.panel18.Location = new System.Drawing.Point(102, 84);
			this.panel18.Margin = new System.Windows.Forms.Padding(2);
			this.panel18.MaximumSize = new System.Drawing.Size(60, 29);
			this.panel18.MinimumSize = new System.Drawing.Size(60, 29);
			this.panel18.Name = "panel18";
			this.panel18.Size = new System.Drawing.Size(60, 29);
			this.panel18.TabIndex = 19;
			// 
			// pictureBox19
			// 
			this.pictureBox19.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
			this.pictureBox19.Location = new System.Drawing.Point(0, 0);
			this.pictureBox19.Name = "pictureBox19";
			this.pictureBox19.Size = new System.Drawing.Size(58, 27);
			this.pictureBox19.TabIndex = 2;
			this.pictureBox19.TabStop = false;
			// 
			// panel17
			// 
			this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel17.Controls.Add(this.pictureBox18);
			this.panel17.Location = new System.Drawing.Point(102, 55);
			this.panel17.Margin = new System.Windows.Forms.Padding(2);
			this.panel17.MaximumSize = new System.Drawing.Size(60, 29);
			this.panel17.MinimumSize = new System.Drawing.Size(60, 29);
			this.panel17.Name = "panel17";
			this.panel17.Size = new System.Drawing.Size(60, 29);
			this.panel17.TabIndex = 113;
			// 
			// pictureBox18
			// 
			this.pictureBox18.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
			this.pictureBox18.Location = new System.Drawing.Point(0, 0);
			this.pictureBox18.Name = "pictureBox18";
			this.pictureBox18.Size = new System.Drawing.Size(58, 27);
			this.pictureBox18.TabIndex = 1;
			this.pictureBox18.TabStop = false;
			// 
			// r8c1
			// 
			this.r8c1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r8c1.Location = new System.Drawing.Point(162, 252);
			this.r8c1.Margin = new System.Windows.Forms.Padding(2);
			this.r8c1.Name = "r8c1";
			this.r8c1.Size = new System.Drawing.Size(42, 26);
			this.r8c1.TabIndex = 112;
			// 
			// r7c1
			// 
			this.r7c1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r7c1.Location = new System.Drawing.Point(162, 226);
			this.r7c1.Margin = new System.Windows.Forms.Padding(2);
			this.r7c1.Name = "r7c1";
			this.r7c1.Size = new System.Drawing.Size(42, 26);
			this.r7c1.TabIndex = 111;
			// 
			// r6c1
			// 
			this.r6c1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r6c1.Location = new System.Drawing.Point(162, 200);
			this.r6c1.Margin = new System.Windows.Forms.Padding(2);
			this.r6c1.Name = "r6c1";
			this.r6c1.Size = new System.Drawing.Size(42, 26);
			this.r6c1.TabIndex = 110;
			// 
			// r5c1
			// 
			this.r5c1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r5c1.Location = new System.Drawing.Point(162, 171);
			this.r5c1.Margin = new System.Windows.Forms.Padding(2);
			this.r5c1.Name = "r5c1";
			this.r5c1.Size = new System.Drawing.Size(42, 29);
			this.r5c1.TabIndex = 109;
			this.r5c1.Tag = "Sixes";
			this.r5c1.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r5c1.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r5c1.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r5c1.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r5c1.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r4c1
			// 
			this.r4c1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r4c1.Location = new System.Drawing.Point(162, 142);
			this.r4c1.Margin = new System.Windows.Forms.Padding(2);
			this.r4c1.Name = "r4c1";
			this.r4c1.Size = new System.Drawing.Size(42, 29);
			this.r4c1.TabIndex = 108;
			this.r4c1.Tag = "Fives";
			this.r4c1.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r4c1.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r4c1.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r4c1.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r4c1.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r3c1
			// 
			this.r3c1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r3c1.Location = new System.Drawing.Point(162, 113);
			this.r3c1.Margin = new System.Windows.Forms.Padding(2);
			this.r3c1.Name = "r3c1";
			this.r3c1.Size = new System.Drawing.Size(42, 29);
			this.r3c1.TabIndex = 107;
			this.r3c1.Tag = "Fours";
			this.r3c1.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r3c1.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r3c1.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r3c1.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r3c1.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r2c1
			// 
			this.r2c1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r2c1.Location = new System.Drawing.Point(162, 84);
			this.r2c1.Margin = new System.Windows.Forms.Padding(2);
			this.r2c1.Name = "r2c1";
			this.r2c1.Size = new System.Drawing.Size(42, 29);
			this.r2c1.TabIndex = 106;
			this.r2c1.Tag = "Threes";
			this.r2c1.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r2c1.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r2c1.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r2c1.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r2c1.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// panel72
			// 
			this.panel72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel72.Controls.Add(this.pictureBox25);
			this.panel72.Location = new System.Drawing.Point(162, 0);
			this.panel72.Margin = new System.Windows.Forms.Padding(2);
			this.panel72.Name = "panel72";
			this.panel72.Size = new System.Drawing.Size(42, 26);
			this.panel72.TabIndex = 103;
			// 
			// pictureBox25
			// 
			this.pictureBox25.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox25.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox25.Image")));
			this.pictureBox25.Location = new System.Drawing.Point(0, 0);
			this.pictureBox25.Name = "pictureBox25";
			this.pictureBox25.Size = new System.Drawing.Size(40, 24);
			this.pictureBox25.TabIndex = 3;
			this.pictureBox25.TabStop = false;
			// 
			// r8c2
			// 
			this.r8c2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r8c2.Location = new System.Drawing.Point(204, 252);
			this.r8c2.Margin = new System.Windows.Forms.Padding(2);
			this.r8c2.Name = "r8c2";
			this.r8c2.Size = new System.Drawing.Size(42, 26);
			this.r8c2.TabIndex = 102;
			// 
			// r7c2
			// 
			this.r7c2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r7c2.Location = new System.Drawing.Point(204, 226);
			this.r7c2.Margin = new System.Windows.Forms.Padding(2);
			this.r7c2.Name = "r7c2";
			this.r7c2.Size = new System.Drawing.Size(42, 26);
			this.r7c2.TabIndex = 101;
			// 
			// r6c2
			// 
			this.r6c2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r6c2.Location = new System.Drawing.Point(204, 200);
			this.r6c2.Margin = new System.Windows.Forms.Padding(2);
			this.r6c2.Name = "r6c2";
			this.r6c2.Size = new System.Drawing.Size(42, 26);
			this.r6c2.TabIndex = 100;
			// 
			// r5c2
			// 
			this.r5c2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r5c2.Location = new System.Drawing.Point(204, 171);
			this.r5c2.Margin = new System.Windows.Forms.Padding(2);
			this.r5c2.Name = "r5c2";
			this.r5c2.Size = new System.Drawing.Size(42, 29);
			this.r5c2.TabIndex = 99;
			this.r5c2.Tag = "Sixes";
			this.r5c2.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r5c2.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r5c2.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r5c2.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r5c2.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r4c2
			// 
			this.r4c2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r4c2.Location = new System.Drawing.Point(204, 142);
			this.r4c2.Margin = new System.Windows.Forms.Padding(2);
			this.r4c2.Name = "r4c2";
			this.r4c2.Size = new System.Drawing.Size(42, 29);
			this.r4c2.TabIndex = 98;
			this.r4c2.Tag = "Fives";
			this.r4c2.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r4c2.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r4c2.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r4c2.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r4c2.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r3c2
			// 
			this.r3c2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r3c2.Location = new System.Drawing.Point(204, 113);
			this.r3c2.Margin = new System.Windows.Forms.Padding(2);
			this.r3c2.Name = "r3c2";
			this.r3c2.Size = new System.Drawing.Size(42, 29);
			this.r3c2.TabIndex = 97;
			this.r3c2.Tag = "Fours";
			this.r3c2.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r3c2.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r3c2.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r3c2.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r3c2.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r2c2
			// 
			this.r2c2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r2c2.Location = new System.Drawing.Point(204, 84);
			this.r2c2.Margin = new System.Windows.Forms.Padding(2);
			this.r2c2.Name = "r2c2";
			this.r2c2.Size = new System.Drawing.Size(42, 29);
			this.r2c2.TabIndex = 96;
			this.r2c2.Tag = "Threes";
			this.r2c2.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r2c2.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r2c2.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r2c2.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r2c2.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r1c2
			// 
			this.r1c2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r1c2.Location = new System.Drawing.Point(204, 55);
			this.r1c2.Margin = new System.Windows.Forms.Padding(2);
			this.r1c2.Name = "r1c2";
			this.r1c2.Size = new System.Drawing.Size(42, 29);
			this.r1c2.TabIndex = 95;
			this.r1c2.Tag = "Twos";
			this.r1c2.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r1c2.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r1c2.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r1c2.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r1c2.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// panel60
			// 
			this.panel60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel60.Controls.Add(this.pictureBox26);
			this.panel60.Location = new System.Drawing.Point(204, 0);
			this.panel60.Margin = new System.Windows.Forms.Padding(2);
			this.panel60.Name = "panel60";
			this.panel60.Size = new System.Drawing.Size(42, 26);
			this.panel60.TabIndex = 93;
			// 
			// pictureBox26
			// 
			this.pictureBox26.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox26.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox26.Image")));
			this.pictureBox26.Location = new System.Drawing.Point(0, 0);
			this.pictureBox26.Name = "pictureBox26";
			this.pictureBox26.Size = new System.Drawing.Size(40, 24);
			this.pictureBox26.TabIndex = 4;
			this.pictureBox26.TabStop = false;
			// 
			// r8c3
			// 
			this.r8c3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r8c3.Location = new System.Drawing.Point(246, 252);
			this.r8c3.Margin = new System.Windows.Forms.Padding(2);
			this.r8c3.Name = "r8c3";
			this.r8c3.Size = new System.Drawing.Size(42, 26);
			this.r8c3.TabIndex = 92;
			// 
			// r7c3
			// 
			this.r7c3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r7c3.Location = new System.Drawing.Point(246, 226);
			this.r7c3.Margin = new System.Windows.Forms.Padding(2);
			this.r7c3.Name = "r7c3";
			this.r7c3.Size = new System.Drawing.Size(42, 26);
			this.r7c3.TabIndex = 91;
			// 
			// r6c3
			// 
			this.r6c3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r6c3.Location = new System.Drawing.Point(246, 200);
			this.r6c3.Margin = new System.Windows.Forms.Padding(2);
			this.r6c3.Name = "r6c3";
			this.r6c3.Size = new System.Drawing.Size(42, 26);
			this.r6c3.TabIndex = 90;
			// 
			// r4c3
			// 
			this.r4c3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r4c3.Location = new System.Drawing.Point(246, 142);
			this.r4c3.Margin = new System.Windows.Forms.Padding(2);
			this.r4c3.Name = "r4c3";
			this.r4c3.Size = new System.Drawing.Size(42, 29);
			this.r4c3.TabIndex = 88;
			this.r4c3.Tag = "Fives";
			this.r4c3.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r4c3.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r4c3.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r4c3.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r4c3.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r3c3
			// 
			this.r3c3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r3c3.Location = new System.Drawing.Point(246, 113);
			this.r3c3.Margin = new System.Windows.Forms.Padding(2);
			this.r3c3.Name = "r3c3";
			this.r3c3.Size = new System.Drawing.Size(42, 29);
			this.r3c3.TabIndex = 87;
			this.r3c3.Tag = "Fours";
			this.r3c3.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r3c3.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r3c3.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r3c3.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r3c3.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r2c3
			// 
			this.r2c3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r2c3.Location = new System.Drawing.Point(246, 84);
			this.r2c3.Margin = new System.Windows.Forms.Padding(2);
			this.r2c3.Name = "r2c3";
			this.r2c3.Size = new System.Drawing.Size(42, 29);
			this.r2c3.TabIndex = 86;
			this.r2c3.Tag = "Threes";
			this.r2c3.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r2c3.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r2c3.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r2c3.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r2c3.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r1c3
			// 
			this.r1c3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r1c3.Location = new System.Drawing.Point(246, 55);
			this.r1c3.Margin = new System.Windows.Forms.Padding(2);
			this.r1c3.Name = "r1c3";
			this.r1c3.Size = new System.Drawing.Size(42, 29);
			this.r1c3.TabIndex = 85;
			this.r1c3.Tag = "Twos";
			this.r1c3.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r1c3.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r1c3.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r1c3.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r1c3.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r0c3
			// 
			this.r0c3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r0c3.Location = new System.Drawing.Point(246, 26);
			this.r0c3.Margin = new System.Windows.Forms.Padding(2);
			this.r0c3.Name = "r0c3";
			this.r0c3.Size = new System.Drawing.Size(42, 29);
			this.r0c3.TabIndex = 84;
			this.r0c3.Tag = "Ones";
			this.r0c3.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r0c3.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r0c3.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r0c3.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r0c3.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// panel47
			// 
			this.panel47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel47.Controls.Add(this.pictureBox27);
			this.panel47.Location = new System.Drawing.Point(246, 0);
			this.panel47.Margin = new System.Windows.Forms.Padding(2);
			this.panel47.Name = "panel47";
			this.panel47.Size = new System.Drawing.Size(42, 26);
			this.panel47.TabIndex = 83;
			// 
			// pictureBox27
			// 
			this.pictureBox27.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox27.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox27.Image")));
			this.pictureBox27.Location = new System.Drawing.Point(0, 0);
			this.pictureBox27.Name = "pictureBox27";
			this.pictureBox27.Size = new System.Drawing.Size(40, 24);
			this.pictureBox27.TabIndex = 6;
			this.pictureBox27.TabStop = false;
			// 
			// r8c4
			// 
			this.r8c4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r8c4.Location = new System.Drawing.Point(288, 252);
			this.r8c4.Margin = new System.Windows.Forms.Padding(2);
			this.r8c4.Name = "r8c4";
			this.r8c4.Size = new System.Drawing.Size(42, 26);
			this.r8c4.TabIndex = 82;
			// 
			// r7c4
			// 
			this.r7c4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r7c4.Location = new System.Drawing.Point(288, 226);
			this.r7c4.Margin = new System.Windows.Forms.Padding(2);
			this.r7c4.Name = "r7c4";
			this.r7c4.Size = new System.Drawing.Size(42, 26);
			this.r7c4.TabIndex = 81;
			// 
			// r6c4
			// 
			this.r6c4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r6c4.Location = new System.Drawing.Point(288, 200);
			this.r6c4.Margin = new System.Windows.Forms.Padding(2);
			this.r6c4.Name = "r6c4";
			this.r6c4.Size = new System.Drawing.Size(42, 26);
			this.r6c4.TabIndex = 80;
			// 
			// r5c4
			// 
			this.r5c4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r5c4.Location = new System.Drawing.Point(288, 171);
			this.r5c4.Margin = new System.Windows.Forms.Padding(2);
			this.r5c4.Name = "r5c4";
			this.r5c4.Size = new System.Drawing.Size(42, 29);
			this.r5c4.TabIndex = 79;
			this.r5c4.Tag = "Sixes";
			this.r5c4.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r5c4.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r5c4.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r5c4.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r5c4.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r4c4
			// 
			this.r4c4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r4c4.Location = new System.Drawing.Point(288, 142);
			this.r4c4.Margin = new System.Windows.Forms.Padding(2);
			this.r4c4.Name = "r4c4";
			this.r4c4.Size = new System.Drawing.Size(42, 29);
			this.r4c4.TabIndex = 78;
			this.r4c4.Tag = "Fives";
			this.r4c4.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r4c4.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r4c4.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r4c4.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r4c4.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r3c4
			// 
			this.r3c4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r3c4.Location = new System.Drawing.Point(288, 113);
			this.r3c4.Margin = new System.Windows.Forms.Padding(2);
			this.r3c4.Name = "r3c4";
			this.r3c4.Size = new System.Drawing.Size(42, 29);
			this.r3c4.TabIndex = 77;
			this.r3c4.Tag = "Fours";
			this.r3c4.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r3c4.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r3c4.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r3c4.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r3c4.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r2c4
			// 
			this.r2c4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r2c4.Location = new System.Drawing.Point(288, 84);
			this.r2c4.Margin = new System.Windows.Forms.Padding(2);
			this.r2c4.Name = "r2c4";
			this.r2c4.Size = new System.Drawing.Size(42, 29);
			this.r2c4.TabIndex = 76;
			this.r2c4.Tag = "Threes";
			this.r2c4.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r2c4.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r2c4.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r2c4.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r2c4.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r1c4
			// 
			this.r1c4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r1c4.Location = new System.Drawing.Point(288, 55);
			this.r1c4.Margin = new System.Windows.Forms.Padding(2);
			this.r1c4.Name = "r1c4";
			this.r1c4.Size = new System.Drawing.Size(42, 29);
			this.r1c4.TabIndex = 75;
			this.r1c4.Tag = "Twos";
			this.r1c4.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r1c4.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r1c4.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r1c4.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r1c4.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r0c4
			// 
			this.r0c4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r0c4.Location = new System.Drawing.Point(288, 26);
			this.r0c4.Margin = new System.Windows.Forms.Padding(2);
			this.r0c4.Name = "r0c4";
			this.r0c4.Size = new System.Drawing.Size(42, 29);
			this.r0c4.TabIndex = 74;
			this.r0c4.Tag = "Ones";
			this.r0c4.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r0c4.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r0c4.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r0c4.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r0c4.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// panel35
			// 
			this.panel35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel35.Controls.Add(this.pictureBox28);
			this.panel35.Location = new System.Drawing.Point(288, 0);
			this.panel35.Margin = new System.Windows.Forms.Padding(2);
			this.panel35.Name = "panel35";
			this.panel35.Size = new System.Drawing.Size(42, 26);
			this.panel35.TabIndex = 73;
			// 
			// pictureBox28
			// 
			this.pictureBox28.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox28.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox28.Image")));
			this.pictureBox28.Location = new System.Drawing.Point(0, 0);
			this.pictureBox28.Name = "pictureBox28";
			this.pictureBox28.Size = new System.Drawing.Size(40, 24);
			this.pictureBox28.TabIndex = 6;
			this.pictureBox28.TabStop = false;
			// 
			// r8c5
			// 
			this.r8c5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r8c5.Location = new System.Drawing.Point(330, 252);
			this.r8c5.Margin = new System.Windows.Forms.Padding(2);
			this.r8c5.Name = "r8c5";
			this.r8c5.Size = new System.Drawing.Size(42, 26);
			this.r8c5.TabIndex = 72;
			// 
			// r7c5
			// 
			this.r7c5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r7c5.Location = new System.Drawing.Point(330, 226);
			this.r7c5.Margin = new System.Windows.Forms.Padding(2);
			this.r7c5.Name = "r7c5";
			this.r7c5.Size = new System.Drawing.Size(42, 26);
			this.r7c5.TabIndex = 67;
			// 
			// r6c5
			// 
			this.r6c5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r6c5.Location = new System.Drawing.Point(330, 200);
			this.r6c5.Margin = new System.Windows.Forms.Padding(2);
			this.r6c5.Name = "r6c5";
			this.r6c5.Size = new System.Drawing.Size(42, 26);
			this.r6c5.TabIndex = 62;
			// 
			// r5c5
			// 
			this.r5c5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r5c5.Location = new System.Drawing.Point(330, 171);
			this.r5c5.Margin = new System.Windows.Forms.Padding(2);
			this.r5c5.Name = "r5c5";
			this.r5c5.Size = new System.Drawing.Size(42, 29);
			this.r5c5.TabIndex = 57;
			this.r5c5.Tag = "Sixes";
			this.r5c5.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r5c5.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r5c5.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r5c5.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r5c5.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r4c5
			// 
			this.r4c5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r4c5.Location = new System.Drawing.Point(330, 142);
			this.r4c5.Margin = new System.Windows.Forms.Padding(2);
			this.r4c5.Name = "r4c5";
			this.r4c5.Size = new System.Drawing.Size(42, 29);
			this.r4c5.TabIndex = 52;
			this.r4c5.Tag = "Fives";
			this.r4c5.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r4c5.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r4c5.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r4c5.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r4c5.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r3c5
			// 
			this.r3c5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r3c5.Location = new System.Drawing.Point(330, 113);
			this.r3c5.Margin = new System.Windows.Forms.Padding(2);
			this.r3c5.Name = "r3c5";
			this.r3c5.Size = new System.Drawing.Size(42, 29);
			this.r3c5.TabIndex = 47;
			this.r3c5.Tag = "Fours";
			this.r3c5.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r3c5.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r3c5.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r3c5.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r3c5.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r2c5
			// 
			this.r2c5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r2c5.Location = new System.Drawing.Point(330, 84);
			this.r2c5.Margin = new System.Windows.Forms.Padding(2);
			this.r2c5.Name = "r2c5";
			this.r2c5.Size = new System.Drawing.Size(42, 29);
			this.r2c5.TabIndex = 42;
			this.r2c5.Tag = "Threes";
			this.r2c5.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r2c5.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r2c5.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r2c5.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r2c5.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r1c5
			// 
			this.r1c5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r1c5.Location = new System.Drawing.Point(330, 55);
			this.r1c5.Margin = new System.Windows.Forms.Padding(2);
			this.r1c5.Name = "r1c5";
			this.r1c5.Size = new System.Drawing.Size(42, 29);
			this.r1c5.TabIndex = 37;
			this.r1c5.Tag = "Twos";
			this.r1c5.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r1c5.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r1c5.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r1c5.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r1c5.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// r0c5
			// 
			this.r0c5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r0c5.Location = new System.Drawing.Point(330, 26);
			this.r0c5.Margin = new System.Windows.Forms.Padding(2);
			this.r0c5.Name = "r0c5";
			this.r0c5.Size = new System.Drawing.Size(42, 29);
			this.r0c5.TabIndex = 32;
			this.r0c5.Tag = "Ones";
			this.r0c5.MouseLeave += new System.EventHandler(this.ScoreCard_MouseLeave);
			this.r0c5.Click += new System.EventHandler(this.ScoreCard_Click);
			this.r0c5.MouseEnter += new System.EventHandler(this.ScoreCard_MouseEnter);
			this.r0c5.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.r0c5.MouseHover += new System.EventHandler(this.ScoreCard_MouseHover);
			// 
			// panel27
			// 
			this.panel27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel27.Controls.Add(this.pictureBox8);
			this.panel27.Location = new System.Drawing.Point(102, 252);
			this.panel27.Margin = new System.Windows.Forms.Padding(2);
			this.panel27.Name = "panel27";
			this.panel27.Size = new System.Drawing.Size(60, 26);
			this.panel27.TabIndex = 27;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(1, 4);
			this.pictureBox8.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(57, 17);
			this.pictureBox8.TabIndex = 4;
			this.pictureBox8.TabStop = false;
			// 
			// panel26
			// 
			this.panel26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel26.Controls.Add(this.pictureBox23);
			this.panel26.Location = new System.Drawing.Point(102, 226);
			this.panel26.Margin = new System.Windows.Forms.Padding(2);
			this.panel26.Name = "panel26";
			this.panel26.Size = new System.Drawing.Size(60, 26);
			this.panel26.TabIndex = 26;
			// 
			// pictureBox23
			// 
			this.pictureBox23.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox23.Image")));
			this.pictureBox23.Location = new System.Drawing.Point(0, 0);
			this.pictureBox23.MaximumSize = new System.Drawing.Size(60, 29);
			this.pictureBox23.MinimumSize = new System.Drawing.Size(60, 29);
			this.pictureBox23.Name = "pictureBox23";
			this.pictureBox23.Size = new System.Drawing.Size(60, 29);
			this.pictureBox23.TabIndex = 3;
			this.pictureBox23.TabStop = false;
			// 
			// panel25
			// 
			this.panel25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel25.Controls.Add(this.pictureBox7);
			this.panel25.Location = new System.Drawing.Point(102, 200);
			this.panel25.Margin = new System.Windows.Forms.Padding(2);
			this.panel25.MaximumSize = new System.Drawing.Size(60, 26);
			this.panel25.MinimumSize = new System.Drawing.Size(60, 26);
			this.panel25.Name = "panel25";
			this.panel25.Size = new System.Drawing.Size(60, 26);
			this.panel25.TabIndex = 25;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(1, 4);
			this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(57, 17);
			this.pictureBox7.TabIndex = 4;
			this.pictureBox7.TabStop = false;
			// 
			// panel24
			// 
			this.panel24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel24.Controls.Add(this.pictureBox33);
			this.panel24.Location = new System.Drawing.Point(0, 252);
			this.panel24.Margin = new System.Windows.Forms.Padding(2);
			this.panel24.Name = "panel24";
			this.panel24.Size = new System.Drawing.Size(102, 26);
			this.panel24.TabIndex = 24;
			// 
			// pictureBox33
			// 
			this.pictureBox33.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox33.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox33.Image")));
			this.pictureBox33.Location = new System.Drawing.Point(0, 0);
			this.pictureBox33.Name = "pictureBox33";
			this.pictureBox33.Size = new System.Drawing.Size(100, 24);
			this.pictureBox33.TabIndex = 3;
			this.pictureBox33.TabStop = false;
			// 
			// panel23
			// 
			this.panel23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel23.Controls.Add(this.pictureBox32);
			this.panel23.Location = new System.Drawing.Point(0, 226);
			this.panel23.Margin = new System.Windows.Forms.Padding(2);
			this.panel23.Name = "panel23";
			this.panel23.Size = new System.Drawing.Size(102, 26);
			this.panel23.TabIndex = 23;
			// 
			// pictureBox32
			// 
			this.pictureBox32.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox32.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox32.Image")));
			this.pictureBox32.Location = new System.Drawing.Point(0, 0);
			this.pictureBox32.Name = "pictureBox32";
			this.pictureBox32.Size = new System.Drawing.Size(100, 24);
			this.pictureBox32.TabIndex = 3;
			this.pictureBox32.TabStop = false;
			// 
			// panel22
			// 
			this.panel22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel22.Controls.Add(this.pictureBox31);
			this.panel22.Location = new System.Drawing.Point(0, 200);
			this.panel22.Margin = new System.Windows.Forms.Padding(2);
			this.panel22.Name = "panel22";
			this.panel22.Size = new System.Drawing.Size(102, 26);
			this.panel22.TabIndex = 22;
			// 
			// pictureBox31
			// 
			this.pictureBox31.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox31.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox31.Image")));
			this.pictureBox31.Location = new System.Drawing.Point(0, 0);
			this.pictureBox31.Name = "pictureBox31";
			this.pictureBox31.Size = new System.Drawing.Size(100, 24);
			this.pictureBox31.TabIndex = 3;
			this.pictureBox31.TabStop = false;
			// 
			// panel16
			// 
			this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel16.Controls.Add(this.pictureBox6);
			this.panel16.Location = new System.Drawing.Point(0, 171);
			this.panel16.Margin = new System.Windows.Forms.Padding(2);
			this.panel16.Name = "panel16";
			this.panel16.Size = new System.Drawing.Size(102, 29);
			this.panel16.TabIndex = 16;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(0, 0);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(100, 27);
			this.pictureBox6.TabIndex = 5;
			this.pictureBox6.TabStop = false;
			// 
			// panel15
			// 
			this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel15.Controls.Add(this.pictureBox5);
			this.panel15.Location = new System.Drawing.Point(0, 142);
			this.panel15.Margin = new System.Windows.Forms.Padding(2);
			this.panel15.Name = "panel15";
			this.panel15.Size = new System.Drawing.Size(102, 29);
			this.panel15.TabIndex = 15;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(0, 0);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(100, 27);
			this.pictureBox5.TabIndex = 5;
			this.pictureBox5.TabStop = false;
			// 
			// panel14
			// 
			this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel14.Controls.Add(this.pictureBox4);
			this.panel14.Location = new System.Drawing.Point(0, 113);
			this.panel14.Margin = new System.Windows.Forms.Padding(2);
			this.panel14.Name = "panel14";
			this.panel14.Size = new System.Drawing.Size(102, 29);
			this.panel14.TabIndex = 14;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(0, 0);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(100, 27);
			this.pictureBox4.TabIndex = 5;
			this.pictureBox4.TabStop = false;
			// 
			// panel13
			// 
			this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel13.Controls.Add(this.pictureBox3);
			this.panel13.Location = new System.Drawing.Point(0, 84);
			this.panel13.Margin = new System.Windows.Forms.Padding(2);
			this.panel13.Name = "panel13";
			this.panel13.Size = new System.Drawing.Size(102, 29);
			this.panel13.TabIndex = 13;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(0, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(100, 27);
			this.pictureBox3.TabIndex = 5;
			this.pictureBox3.TabStop = false;
			// 
			// panel12
			// 
			this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel12.Controls.Add(this.pictureBox17);
			this.panel12.Location = new System.Drawing.Point(102, 26);
			this.panel12.Margin = new System.Windows.Forms.Padding(2);
			this.panel12.MaximumSize = new System.Drawing.Size(60, 29);
			this.panel12.MinimumSize = new System.Drawing.Size(60, 29);
			this.panel12.Name = "panel12";
			this.panel12.Size = new System.Drawing.Size(60, 29);
			this.panel12.TabIndex = 12;
			// 
			// pictureBox17
			// 
			this.pictureBox17.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
			this.pictureBox17.Location = new System.Drawing.Point(0, 0);
			this.pictureBox17.Name = "pictureBox17";
			this.pictureBox17.Size = new System.Drawing.Size(58, 27);
			this.pictureBox17.TabIndex = 0;
			this.pictureBox17.TabStop = false;
			// 
			// panel11
			// 
			this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel11.Controls.Add(this.pictureBox2);
			this.panel11.Location = new System.Drawing.Point(0, 55);
			this.panel11.Margin = new System.Windows.Forms.Padding(2);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(102, 29);
			this.panel11.TabIndex = 11;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 27);
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// panel5
			// 
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel5.Controls.Add(this.pictureBox1);
			this.panel5.Location = new System.Drawing.Point(0, 26);
			this.panel5.Margin = new System.Windows.Forms.Padding(2);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(102, 29);
			this.panel5.TabIndex = 10;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 27);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// panel10
			// 
			this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel10.Controls.Add(this.pictureBox29);
			this.panel10.Location = new System.Drawing.Point(330, 0);
			this.panel10.Margin = new System.Windows.Forms.Padding(2);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(42, 26);
			this.panel10.TabIndex = 9;
			// 
			// pictureBox29
			// 
			this.pictureBox29.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox29.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox29.Image")));
			this.pictureBox29.Location = new System.Drawing.Point(0, 0);
			this.pictureBox29.Name = "pictureBox29";
			this.pictureBox29.Size = new System.Drawing.Size(40, 24);
			this.pictureBox29.TabIndex = 7;
			this.pictureBox29.TabStop = false;
			// 
			// panel6
			// 
			this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel6.Controls.Add(this.pictureBox24);
			this.panel6.Location = new System.Drawing.Point(102, 0);
			this.panel6.Margin = new System.Windows.Forms.Padding(2);
			this.panel6.MaximumSize = new System.Drawing.Size(60, 26);
			this.panel6.MinimumSize = new System.Drawing.Size(60, 26);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(60, 26);
			this.panel6.TabIndex = 4;
			// 
			// pictureBox24
			// 
			this.pictureBox24.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox24.Image")));
			this.pictureBox24.Location = new System.Drawing.Point(0, 0);
			this.pictureBox24.Name = "pictureBox24";
			this.pictureBox24.Size = new System.Drawing.Size(58, 24);
			this.pictureBox24.TabIndex = 2;
			this.pictureBox24.TabStop = false;
			// 
			// toolStrip1
			// 
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newToolStripButton,
									this.openToolStripButton,
									this.saveToolStripButton,
									this.toolStripSeparator1,
									this.helpToolStripButton,
									this.updatesToolStripButton,
									this.toolStripButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(817, 36);
			this.toolStrip1.Stretch = true;
			this.toolStrip1.TabIndex = 14;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// newToolStripButton
			// 
			this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
			this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripButton.Name = "newToolStripButton";
			this.newToolStripButton.Size = new System.Drawing.Size(32, 33);
			this.newToolStripButton.Text = "&New";
			this.newToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.newToolStripButton.Click += new System.EventHandler(this.TbNewClick);
			// 
			// openToolStripButton
			// 
			this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
			this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openToolStripButton.Name = "openToolStripButton";
			this.openToolStripButton.Size = new System.Drawing.Size(37, 33);
			this.openToolStripButton.Text = "&Open";
			this.openToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.openToolStripButton.Click += new System.EventHandler(this.TbOpenClick);
			// 
			// saveToolStripButton
			// 
			this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
			this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveToolStripButton.Name = "saveToolStripButton";
			this.saveToolStripButton.Size = new System.Drawing.Size(35, 33);
			this.saveToolStripButton.Text = "&Save";
			this.saveToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.saveToolStripButton.Click += new System.EventHandler(this.TbSaveClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
			// 
			// helpToolStripButton
			// 
			this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
			this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.helpToolStripButton.Name = "helpToolStripButton";
			this.helpToolStripButton.Size = new System.Drawing.Size(40, 33);
			this.helpToolStripButton.Text = "&About";
			this.helpToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.helpToolStripButton.Click += new System.EventHandler(this.TbAboutClick);
			// 
			// updatesToolStripButton
			// 
			this.updatesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("updatesToolStripButton.Image")));
			this.updatesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.updatesToolStripButton.Name = "updatesToolStripButton";
			this.updatesToolStripButton.Size = new System.Drawing.Size(51, 33);
			this.updatesToolStripButton.Text = "Updates";
			this.updatesToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.updatesToolStripButton.Click += new System.EventHandler(this.TbUpdateClick);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(31, 33);
			this.toolStripButton1.Text = "&Quit";
			this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.toolStripButton1.Click += new System.EventHandler(this.TbExitClick);
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.panel2);
			this.panel7.Controls.Add(this.panel1);
			this.panel7.Controls.Add(this.panel157);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(0, 36);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(817, 642);
			this.panel7.TabIndex = 15;
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoScrollMargin = new System.Drawing.Size(0, 600);
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(817, 678);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.toolStrip1);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(654, 570);
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Yahtzee Sharp";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dsGameData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dtGameData)).EndInit();
			this.panel157.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Dice5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dice1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dice4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dice3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Dice2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvResults)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvHighScore)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.pnlLowerScore.ResumeLayout(false);
			this.pnlLowerScore.PerformLayout();
			this.panel8.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
			this.panel32.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
			this.panel132.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
			this.panel133.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).EndInit();
			this.panel101.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
			this.panel110.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).EndInit();
			this.panel88.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
			this.panel143.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).EndInit();
			this.panel74.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
			this.panel75.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
			this.panel76.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
			this.panel77.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
			this.panel78.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
			this.panel128.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
			this.panel131.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).EndInit();
			this.panel134.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).EndInit();
			this.panel135.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).EndInit();
			this.panel136.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).EndInit();
			this.panel137.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).EndInit();
			this.panel138.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
			this.panel139.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).EndInit();
			this.panel140.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).EndInit();
			this.pnlUpperScore.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
			this.panel21.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
			this.panel20.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
			this.panel19.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
			this.panel18.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
			this.panel17.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
			this.panel72.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
			this.panel60.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
			this.panel47.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
			this.panel35.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
			this.panel27.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			this.panel26.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
			this.panel25.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			this.panel24.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
			this.panel23.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
			this.panel22.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
			this.panel16.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			this.panel15.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.panel14.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.panel13.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.panel12.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
			this.panel11.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel10.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
			this.panel6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox14;
		private System.Windows.Forms.Panel panel32;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.ToolStripButton updatesToolStripButton;
		private System.Windows.Forms.DataGridView gvHighScore;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colIsCompleteDataGridViewCheckBoxColumn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn colScoreDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPlayerNameDataGridViewTextBoxColumn;
		private System.Data.DataColumn dataColumn5;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton helpToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton saveToolStripButton;
		private System.Windows.Forms.ToolStripButton openToolStripButton;
		private System.Windows.Forms.ToolStripButton newToolStripButton;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.PictureBox pictureBox50;
		private System.Windows.Forms.PictureBox pictureBox49;
		private System.Windows.Forms.PictureBox pictureBox48;
		private System.Windows.Forms.PictureBox pictureBox41;
		private System.Windows.Forms.PictureBox pictureBox42;
		private System.Windows.Forms.PictureBox pictureBox43;
		private System.Windows.Forms.PictureBox pictureBox44;
		private System.Windows.Forms.PictureBox pictureBox45;
		private System.Windows.Forms.PictureBox pictureBox46;
		private System.Windows.Forms.PictureBox pictureBox47;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox34;
		private System.Windows.Forms.PictureBox pictureBox35;
		private System.Windows.Forms.PictureBox pictureBox36;
		private System.Windows.Forms.PictureBox pictureBox37;
		private System.Windows.Forms.PictureBox pictureBox38;
		private System.Windows.Forms.PictureBox pictureBox39;
		private System.Windows.Forms.PictureBox pictureBox40;
		private System.Windows.Forms.PictureBox pictureBox32;
		private System.Windows.Forms.PictureBox pictureBox33;
		private System.Windows.Forms.PictureBox pictureBox18;
		private System.Windows.Forms.PictureBox pictureBox19;
		private System.Windows.Forms.PictureBox pictureBox20;
		private System.Windows.Forms.PictureBox pictureBox21;
		private System.Windows.Forms.PictureBox pictureBox22;
		private System.Windows.Forms.PictureBox pictureBox17;
		private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
		private System.Windows.Forms.ToolStripContentPanel ContentPanel;
		private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
		private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
		private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
		private System.Data.DataColumn dataColumn4;
		private System.Data.DataColumn dataColumn3;
		private System.Data.DataColumn dataColumn2;
		private System.Data.DataColumn dataColumn1;
		private System.Data.DataTable dtGameData;
		private System.Data.DataSet dsGameData;
		private System.Windows.Forms.Label lblHold1;
		private System.Windows.Forms.Label lblHold2;
		private System.Windows.Forms.Label lblHold3;
		private System.Windows.Forms.Label lblHold4;
        private System.Windows.Forms.Label lblHold5;
		private System.Windows.Forms.Panel r19c2;
		private System.Windows.Forms.Panel r9c5;
		private System.Windows.Forms.Panel r10c5;
		private System.Windows.Forms.Panel r11c5;
		private System.Windows.Forms.Panel r9c4;
		private System.Windows.Forms.Panel r10c4;
		private System.Windows.Forms.Panel r11c4;
		private System.Windows.Forms.Panel r9c3;
		private System.Windows.Forms.Panel r10c3;
		private System.Windows.Forms.Panel r11c3;
		private System.Windows.Forms.Panel r9c2;
		private System.Windows.Forms.Panel r10c2;
		private System.Windows.Forms.Panel r11c2;
		private System.Windows.Forms.Panel r9c1;
		private System.Windows.Forms.Panel r10c1;
		private System.Windows.Forms.Panel r11c1;
		private System.Windows.Forms.Panel r12c5;
		private System.Windows.Forms.Panel r13c5;
		private System.Windows.Forms.Panel r14c5;
		private System.Windows.Forms.Panel r12c4;
		private System.Windows.Forms.Panel r13c4;
		private System.Windows.Forms.Panel r14c4;
		private System.Windows.Forms.Panel r12c3;
		private System.Windows.Forms.Panel r13c3;
		private System.Windows.Forms.Panel r14c3;
		private System.Windows.Forms.Panel r12c2;
		private System.Windows.Forms.Panel r13c2;
		private System.Windows.Forms.Panel r14c2;
		private System.Windows.Forms.Panel r12c1;
		private System.Windows.Forms.Panel r13c1;
		private System.Windows.Forms.Panel r14c1;
		private System.Windows.Forms.Panel r15c5;
		private System.Windows.Forms.Panel r15c4;
		private System.Windows.Forms.Panel r15c3;
		private System.Windows.Forms.Panel r15c2;
		private System.Windows.Forms.Panel r15c1;
		private System.Windows.Forms.Panel r17c5;
		private System.Windows.Forms.Panel r17c4;
		private System.Windows.Forms.Panel r17c3;
		private System.Windows.Forms.Panel r17c2;
		private System.Windows.Forms.Panel r17c1;
		private System.Windows.Forms.Panel r18c5;
		private System.Windows.Forms.Panel r18c4;
		private System.Windows.Forms.Panel r18c3;
		private System.Windows.Forms.Panel r18c2;
		private System.Windows.Forms.Panel r18c1;
		private System.Windows.Forms.Panel r19c5;
		private System.Windows.Forms.Panel r19c4;
		private System.Windows.Forms.Panel r19c3;
		private System.Windows.Forms.Panel r19c1;
		private System.Windows.Forms.Panel r16c5;
		private System.Windows.Forms.Panel r16c4;
		private System.Windows.Forms.Panel r16c3;
		private System.Windows.Forms.Panel r16c2;
		private System.Windows.Forms.Panel r16c1;
		private System.Windows.Forms.Panel r5c1;
		private System.Windows.Forms.Panel r5c2;
		private System.Windows.Forms.Panel r5c3;
		private System.Windows.Forms.Panel r5c4;
		private System.Windows.Forms.Panel r8c1;
		private System.Windows.Forms.Panel r7c1;
		private System.Windows.Forms.Panel r6c1;
		private System.Windows.Forms.Panel r8c2;
		private System.Windows.Forms.Panel r7c2;
		private System.Windows.Forms.Panel r6c2;
		private System.Windows.Forms.Panel r8c3;
		private System.Windows.Forms.Panel r7c3;
		private System.Windows.Forms.Panel r6c3;
		private System.Windows.Forms.Panel r8c4;
		private System.Windows.Forms.Panel r7c4;
		private System.Windows.Forms.Panel r6c4;
		private System.Windows.Forms.Panel r8c5;
		private System.Windows.Forms.Panel r7c5;
		private System.Windows.Forms.Panel r6c5;
		private System.Windows.Forms.Panel r5c5;
		private System.Windows.Forms.Panel r0c1;
		private System.Windows.Forms.Panel r4c1;
		private System.Windows.Forms.Panel r3c1;
		private System.Windows.Forms.Panel r2c1;
		private System.Windows.Forms.Panel r1c1;
		private System.Windows.Forms.Panel r4c2;
		private System.Windows.Forms.Panel r3c2;
		private System.Windows.Forms.Panel r2c2;
		private System.Windows.Forms.Panel r1c2;
		private System.Windows.Forms.Panel r0c2;
		private System.Windows.Forms.Panel r4c3;
		private System.Windows.Forms.Panel r3c3;
		private System.Windows.Forms.Panel r2c3;
		private System.Windows.Forms.Panel r1c3;
		private System.Windows.Forms.Panel r0c3;
		private System.Windows.Forms.Panel r4c4;
		private System.Windows.Forms.Panel r3c4;
		private System.Windows.Forms.Panel r2c4;
		private System.Windows.Forms.Panel r1c4;
		private System.Windows.Forms.Panel r0c4;
		private System.Windows.Forms.Panel r0c5;
		private System.Windows.Forms.Panel r4c5;
		private System.Windows.Forms.Panel r3c5;
		private System.Windows.Forms.Panel r2c5;
		private System.Windows.Forms.Panel r1c5;
		private System.Windows.Forms.Panel pnlUpperScore;
		private System.Windows.Forms.Panel pnlLowerScore;
		private System.Windows.Forms.Label lblRollNumber;
        private System.Windows.Forms.Label label70;
		private System.Windows.Forms.DataGridView gvResults;
		private System.Windows.Forms.Button btnRoll;
		private System.Windows.Forms.Timer mTimer;
		private System.Windows.Forms.PictureBox Dice5;
		private System.Windows.Forms.PictureBox Dice1;
		private System.Windows.Forms.PictureBox Dice4;
		private System.Windows.Forms.PictureBox Dice3;
		private System.Windows.Forms.PictureBox Dice2;
		private System.Windows.Forms.Panel panel157;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.Panel panel140;
		private System.Windows.Forms.Panel panel139;
		private System.Windows.Forms.Panel panel138;
		private System.Windows.Forms.Panel panel137;
		private System.Windows.Forms.Panel panel136;
		private System.Windows.Forms.Panel panel135;
		private System.Windows.Forms.Panel panel134;
		private System.Windows.Forms.Panel panel133;
		private System.Windows.Forms.Panel panel132;
		private System.Windows.Forms.Panel panel131;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.Panel panel128;
		private System.Windows.Forms.Panel panel110;
		private System.Windows.Forms.Panel panel101;
		private System.Windows.Forms.Panel panel78;
		private System.Windows.Forms.Panel panel77;
		private System.Windows.Forms.Panel panel76;
		private System.Windows.Forms.Panel panel75;
		private System.Windows.Forms.Panel panel74;
		private System.Windows.Forms.Panel panel143;
		private System.Windows.Forms.Panel panel88;
        private System.Windows.Forms.Label label55;
		private System.Windows.Forms.Panel panel21;
		private System.Windows.Forms.Panel panel35;
		private System.Windows.Forms.Panel panel47;
		private System.Windows.Forms.Panel panel60;
		private System.Windows.Forms.Panel panel72;
		private System.Windows.Forms.Panel panel17;
		private System.Windows.Forms.Panel panel18;
		private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
		private System.Windows.Forms.Panel panel22;
		private System.Windows.Forms.Panel panel23;
		private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel panel25;
		private System.Windows.Forms.Panel panel26;
		private System.Windows.Forms.Panel panel27;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.Panel panel12;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Panel panel13;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Panel panel14;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Panel panel15;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.PictureBox pictureBox25;
        private System.Windows.Forms.PictureBox pictureBox26;
        private System.Windows.Forms.PictureBox pictureBox27;
        private System.Windows.Forms.PictureBox pictureBox28;
        private System.Windows.Forms.PictureBox pictureBox30;
        private System.Windows.Forms.PictureBox pictureBox31;
        private System.Windows.Forms.PictureBox pictureBox29;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
	}
}
