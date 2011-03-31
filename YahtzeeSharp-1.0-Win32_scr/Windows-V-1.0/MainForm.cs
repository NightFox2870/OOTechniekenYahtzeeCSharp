/*
 * Created by SharpDevelop.
 * User: Spoody Goon
 * Date: 1/12/2007
 * Time: 7:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace YahtzeeSharp
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private static string AppPath = Application.StartupPath;
		private static Image[] DiceArray = new Image[6];
		private static string PlayerName;
		private static int intRollNumber =0;
		private static int GameNumber = 0;
		private DataSet dsScoreCard = new DataSet();
		private DataTable dtScoreCard;
		private static string CurrFrameValue;
		private bool mIsFinished = false;
		private static string mVersion = "Alpha 0.2";
		private bool IsGameSaved = true;
		private static string EnterVal = null;
		
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
			
		}
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			// seem redundant but it can hurt to make sure it is sopp
			this.mTimer.Stop();
			SetHighScores();
		
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			// set up the images into their array
			
			// load the dice from the images
			
		for(int i = 1; i <= 6; i++)
			{
				Image mImage = Image.FromFile(AppPath + "/images/dice" + i.ToString() + ".png");
				mImage.Tag = i.ToString();
				DiceArray[i - 1] = mImage;
			} 
			 dtScoreCard = dtSC();
			 dsScoreCard.Tables.Add(dtScoreCard);
		}
		
		#region "Form Events Open/Close"
		
		private void MainFormLoad(object sender, EventArgs e)
		{
		 	try
		 	{
		 		InitScoreCard();
			 	SetEnabled(false);
			 	this.mTimer.Stop();
		 	}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
		 	
		}
		
		 void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			// if the game has not been save since it was last played
			// check to see if the use wants to save
		
			if(IsGameSaved == false)
			{
				try
				{
					DialogResult dResult = MessageBox.Show("Do you want to save this game\n\rBefor closing?", "Save Game?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				
                 	if(dResult == DialogResult.Yes)
                 	{
                 		SaveGameData();
						SaveScoreCard();
				
                 	}
                 	else if(dResult == DialogResult.Cancel)
                 	{
                 		e.Cancel = true;
                 	}
                 	
				}
				catch(System.Exception ex)
			 	{
			 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
			 		eForm.ShowDialog();
			 	}
			}
		}
		
		#endregion
		
		#region "Roll Related"
		 
		private void BtnRoolClick(object sender, EventArgs e)
		{
			
		   try
		   {
				mTimer.Interval = 1;
				mTimer.Start();
				SetEnabled(false);
		  	}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
		   
		}
		
		 private int RandomNumber(int PriNum)
		{	
		 	int i=111;
		 	string mTempString;
		 	try
		 	{
		 		
			 	while(i > 5)
			 	{
				 	Random random = new Random();
				 	int mRand = random.Next(0, 14);
				 	mTempString = (PriNum/Math.PI).ToString();
				 	if(mTempString.Length > (mRand - 1))
				 	{
				 		i = int.Parse(System.Text.RegularExpressions.Regex.Replace(mTempString,"[^0-9]","")[mRand].ToString());
				 	}
				 	else
				 	{
				 		i = 23;
				 	}
			 	}
		 	}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
		 	return i;
		 }
		
		 private void mTimer_Tick(object sender, System.EventArgs e)
		{
		 	
			try
			{
				
				if((lblHold1.Visible == false)&& (mTimer.Interval < 34))
					Dice1.Image = DiceArray[RandomNumber(33)];
				
				if((lblHold2.Visible == false)&& (mTimer.Interval < 29))
					Dice2.Image = DiceArray[RandomNumber(6)];
				
				if((lblHold3.Visible == false)&& (mTimer.Interval < 32))
					Dice3.Image = DiceArray[RandomNumber(76)];
				
				if((lblHold4.Visible == false)&& (mTimer.Interval < 25))
					Dice4.Image = DiceArray[RandomNumber(54)];
				
				if((lblHold5.Visible == false)&& (mTimer.Interval < 22))
					Dice5.Image = DiceArray[RandomNumber(49)];
					
				mTimer.Interval = mTimer.Interval + 2;
				if(mTimer.Interval > 35)
				{
					mTimer.Stop();
					
					// for testing yahtzee bonus
//					Dice1.Image = DiceArray[1];
//					Dice2.Image = DiceArray[1];
//					Dice3.Image = DiceArray[1];
//					Dice4.Image = DiceArray[1];
//					Dice5.Image = DiceArray[1];
					// End testing code
					
					SetEnabled(true);
					intRollNumber++;
					lblRollNumber.Text = intRollNumber.ToString();
					if(intRollNumber ==3)
					{
						btnRoll.Enabled = false;
						intRollNumber = 0;
					}
					Results();
				}
			}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
			
		}
		 
		 #endregion
		
		private void Results()
		 {
	 	
		 	try
		 	{
		 		csPosScore mScore = new csPosScore(int.Parse(Dice1.Image.Tag.ToString()), int.Parse(Dice2.Image.Tag.ToString()), int.Parse(Dice3.Image.Tag.ToString()), int.Parse(Dice4.Image.Tag.ToString()), int.Parse(Dice5.Image.Tag.ToString()), YahtzeeFilled());
			 	
			 	this.gvResults.DataSource = mScore.SetReturnOptions();
			 	this.gvResults.DataMember = "dtResults";
			 	this.gvResults.Refresh();
			 	this.btnRoll.Focus();
		 	}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
		 }
		 
		private void SetEnabled(Boolean mBool)
		 {
		 	try
		 	{
			 	pnlUpperScore.Enabled = mBool;
			 	pnlLowerScore.Enabled = mBool;
		 		Dice1.Enabled = mBool;
		 		Dice2.Enabled = mBool;
		 		Dice3.Enabled = mBool;
		 		Dice4.Enabled = mBool;
		 		Dice5.Enabled = mBool;
		 		btnRoll.Enabled = mBool;
	 		}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
		
		 }
		
		private void NewRollGroup()
		 {
		 	try
		 	{
		 		lblRollNumber.Text = "0";
			 	intRollNumber = 0;
			 	lblHold1.Visible = false;
			 	lblHold2.Visible = false;
			 	lblHold3.Visible = false;
			 	lblHold4.Visible = false;
			 	lblHold5.Visible = false;
			 	Dice1.Enabled = false;
			 	Dice2.Enabled = false;
			 	Dice3.Enabled = false;
			 	Dice4.Enabled = false;
			 	Dice5.Enabled = false;
			 	
			 	btnRoll.Enabled = true;
			 	if(gvResults.DataSource != null)
			 	{
				 	DataSet ds = (DataSet)gvResults.DataSource;
				 	DataTable dt = ds.Tables[gvResults.DataMember];
				 	dt.Clear();
			 	}
			 	
			 	gvResults.Refresh();
		 	}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
		 }
		 
		private void SetValue_Click(object sender, EventArgs e)
		{
			try
			{
				Panel mPanel = (Panel)sender;
				SetValue(mPanel);
			}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
		}		
		
		public void SetValue(Panel mPanel)
		{
			try
			{
				if((mPanel.Controls.Count > 0)&&(gvResults.Rows.Count > 0 ))
				{
					DataSet ds = (DataSet)gvResults.DataSource;
				
					DataTable dt = ds.Tables["dtResults"];
					DataRow dr = dt.Rows.Find(mPanel.Tag.ToString());
					if(dr != null)
					{
						string mVal = dr["colValue"].ToString();
							
						
						mPanel.Controls.Add(lblScore(mVal, mPanel.Width, mPanel.Height));
						mPanel.Refresh();
						
						// parse out the label name to get the
						// row and column it is in
						int mCol = int.Parse(mPanel.Name.Substring(mPanel.Name.Length-1));
						int mRow = int.Parse(mPanel.Name.Substring(1, mPanel.Name.Length - 3));
						dr = this.dsScoreCard.Tables["dtScoreCard"].Rows[mRow];
						dr[mCol] = mVal;
						
						mCalcTotals(mCol);
						// clean the SetValue and SetItem so
						// no further values can be add until a new roll group is started
						NewRollGroup();
					}
				}
			}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
			
		}
		
		private Label lblScore(string val,int pWidth, int pHeight)
		{
			Label mLabel = new Label();
			try
			{
				int intCenter = 0;
				if(val.Length == 2)
					intCenter = 5;
				if(val.Length == 3)
					intCenter = 10;
				
				
				mLabel.AutoSize = true;
				mLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				mLabel.Name = "r17c1";
				mLabel.Size = new System.Drawing.Size(17, 16);
				mLabel.Location = new System.Drawing.Point((pWidth/2) - (mLabel.Size.Width/2)- intCenter, (pHeight/2) - (mLabel.Size.Height/2));
				mLabel.TabIndex = 4;
				mLabel.Text = val;
			}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
			
			return mLabel;
		}
		
		#region "DataSets and DataTables"
		
		private DataTable dtSC()
		{
			DataTable dt = new DataTable("dtScoreCard");
			
			try
			{
				DataColumn dc0 = new DataColumn("RowTitle",System.Type.GetType("System.String"));
				DataColumn dc1 = new DataColumn("Game1",System.Type.GetType("System.Int32"));
				dc1.AllowDBNull = true;
				DataColumn dc2 = new DataColumn("Game2",System.Type.GetType("System.Int32"));
				dc2.AllowDBNull = true;
				DataColumn dc3 = new DataColumn("Game3",System.Type.GetType("System.Int32"));
				dc3.AllowDBNull = true;
				DataColumn dc4 = new DataColumn("Game4",System.Type.GetType("System.Int32"));
				dc4.AllowDBNull = true;
				DataColumn dc5 = new DataColumn("Game5",System.Type.GetType("System.Int32"));
				dc5.AllowDBNull = true;
				DataColumn[] priKey = new DataColumn[1] { dc0 };
				
				dt.Columns.Add(dc0);
				dt.Columns.Add(dc1);
				dt.Columns.Add(dc2);
				dt.Columns.Add(dc3);
				dt.Columns.Add(dc4);
				dt.Columns.Add(dc5);
				dt.PrimaryKey = priKey;
			
			}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
			return dt;
				
		}
		
		private void InitScoreCard()
		{
			try
			{
				// set the start vaules for the basic score card
				// the RowTitle will be used as a primary key incase we need to use datatable.find
				DataTable dt = dtScoreCard;
				DataRow dr = dt.NewRow();
				dr["RowTitle"] = "Aces";
				dt.Rows.Add(dr);
				dr = dt.NewRow();
				dr["RowTitle"] = "Twos";
				dt.Rows.Add(dr);
				dr = dt.NewRow();
				dr["RowTitle"] = "Threes";
				dt.Rows.Add(dr);
				dr = dt.NewRow();
				dr["RowTitle"] = "Fours";
				dt.Rows.Add(dr);
				dr = dt.NewRow();
				dr["RowTitle"] = "Fives";
				dt.Rows.Add(dr);
				dr = dt.NewRow();
				dr["RowTitle"] = "Sixes";
				dt.Rows.Add(dr);
				dr = dt.NewRow();
				dr["RowTitle"] = "TOTAL SCORE";
				dt.Rows.Add(dr);
				dr = dt.NewRow();
				dr["RowTitle"] = "BONUS";
				dt.Rows.Add(dr);
				dr = dt.NewRow();
				dr["RowTitle"] = "TOTAL UPPER";
				dt.Rows.Add(dr);
				dr = dt.NewRow();
				dr["RowTitle"] = "3 of a kind";
				dt.Rows.Add(dr);
				dr = dt.NewRow();
				dr["RowTitle"] = "4 of a kind";
				dt.Rows.Add(dr);
				dr = dt.NewRow();
				dr["RowTitle"] = "Full House";
				dt.Rows.Add(dr);
				dr = dt.NewRow();
				dr["RowTitle"] = "Small Straight";
				dt.Rows.Add(dr);
				dr = dt.NewRow();
				dr["RowTitle"] = "Large Straight";
				dt.Rows.Add(dr);
				dr = dt.NewRow();
				dr["RowTitle"] = "YAHTZEE";
				dt.Rows.Add(dr);
				dr = dt.NewRow();
				dr["RowTitle"] = "Chance";
				dt.Rows.Add(dr);
				dr = dt.NewRow();
				dr["RowTitle"] = "YAHTZEE BONUS";
				dt.Rows.Add(dr);
				dr = dt.NewRow();
				dr["RowTitle"] = "TOTAL LOWER";
				dt.Rows.Add(dr);
				dr = dt.NewRow();
				dr["RowTitle"] = "TOTAL UPPER2";
				dt.Rows.Add(dr);
				dr = dt.NewRow();
				dr["RowTitle"] = "GRAND TOTAL";
				dt.Rows.Add(dr);
				
			}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
		
		}
		
		#endregion
		
		private Control FindControl(string strControlName)
        {
            if (strControlName.Length == 0 || this.Controls.Find(strControlName, true).Length == 0)
                return null;

            return this.Controls.Find(strControlName, true)[0];
        }
		
		#region "Calculations and Scoring"
		
		private void mCalcTotals(int mCol)
		{
			try
			{
				Label mLabel;
				Panel mPanel;
				string pnlName;
				int UpperTS = 0;
				int UpperBonus = 0;
				int UpperTotal = 0;
				int LowerTotal = 0;
				int GrandTotal = 0;
				
				// start by calculating the upper total score
				// row 6 is the upper total score row
				for(int i = 0; i < 6; i++)
				{
					pnlName = "r" + i.ToString() + "c" + mCol.ToString();
					mPanel = (Panel)FindControl(pnlName);
					int mcount = mPanel.Controls.Count;
					if(mPanel.Controls.Count > 0)
					{
						mLabel = (Label)mPanel.Controls[0];
						UpperTS += int.Parse(mLabel.Text);
					}
				}
				
				// update the score card datatable and label
				// for the upper Total Score
				pnlName = "r6" + "c" + mCol.ToString();
				mPanel = (Panel)FindControl(pnlName);
				mPanel.Controls.Clear();
				mPanel.Controls.Add(lblScore(UpperTS.ToString(), mPanel.Width, mPanel.Height));
				mPanel.Refresh();
				dtScoreCard.Rows[6][mCol] = UpperTS.ToString();
				
				// give a bonus if upper total score is 63 or over
				if(UpperTS >= 63)
					UpperBonus = 35;
				
				// update the score card datatable and label
				// for the bonus row
				pnlName = "r7" + "c" + mCol.ToString();
				mPanel = (Panel)FindControl(pnlName);
				mPanel.Controls.Clear();
				mPanel.Controls.Add(lblScore(UpperBonus.ToString(), mPanel.Width, mPanel.Height));
				mPanel.Refresh();
				dtScoreCard.Rows[7][mCol] = UpperBonus.ToString();
							
				// total of the upper section
				UpperTotal = UpperBonus + UpperTS;
				
				// update the score card datatable and label
				// total of the upper section
				pnlName = "r8" + "c" + mCol.ToString();
				mPanel = (Panel)FindControl(pnlName);
				mPanel.Controls.Clear();
				mPanel.Controls.Add(lblScore(UpperTotal.ToString(), mPanel.Width, mPanel.Height));
				mPanel.Refresh();
				dtScoreCard.Rows[8][mCol] = UpperTotal.ToString();
				
				// also the label on the for the Upper total on the
				// lower section
				pnlName = "r18" + "c" + mCol.ToString();
				mPanel = (Panel)FindControl(pnlName);
				mPanel.Controls.Clear();
				mPanel.Controls.Add(lblScore(UpperTotal.ToString(), mPanel.Width, mPanel.Height));
				mPanel.Refresh();
				dtScoreCard.Rows[18][mCol] = UpperTotal.ToString();
				
				
				// calculate the total of the lower section
				// which starts on row 9 and ends on row 17
				for(int i = 9; i < 17; i++)
				{
					pnlName = "r" + i.ToString() + "c" + mCol.ToString();
					mPanel = (Panel)FindControl(pnlName);
					if(mPanel.Controls.Count > 0)
					{
						mLabel = (Label)mPanel.Controls[0];
						LowerTotal += int.Parse(mLabel.Text);
					}
				}
				
				// update the score card datatable and label
				// for the lower Score
				pnlName = "r17" + "c" + mCol.ToString();
				mPanel = (Panel)FindControl(pnlName);
				mPanel.Controls.Clear();
				mPanel.Controls.Add(lblScore(LowerTotal.ToString(), mPanel.Width, mPanel.Height));
				mPanel.Refresh();
				dtScoreCard.Rows[17][mCol] = LowerTotal.ToString();
				
				// set the grand total
				GrandTotal = UpperTotal + LowerTotal;
				
				// update the score card datatable and label
				// for the grand total
				pnlName = "r19" + "c" + mCol.ToString();
				mPanel = (Panel)FindControl(pnlName);
				mPanel.Controls.Clear();
				mPanel.Controls.Add(lblScore(GrandTotal.ToString(), mPanel.Width, mPanel.Height));
				mPanel.Refresh();
				dtScoreCard.Rows[19][mCol] = GrandTotal.ToString();
			}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
		}
		
		private void SetHighScores()
		{
			
			try
			{
				if(!File.Exists("GameData.xml"))
					dsGameData.WriteXml("GameData.xml");
				
				this.dsGameData.Clear();
				this.dsGameData.ReadXml("GameData.xml");
				DataView dv = new DataView(this.dtGameData);
				dv.Sort = "colScore Desc";
				gvHighScore.DataSource = null;
				gvHighScore.DataSource = dv;
				gvHighScore.Refresh();
						
				for(int i = gvHighScore.Rows.Count; i > 10; i--)
				{
					gvHighScore.Rows.RemoveAt(gvHighScore.Rows.Count-1);
				}
				
			}
			catch(Exception ex)
			{
				EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
			}
		}
		 
		#endregion
		
		private void SaveScoreCard()
		{
			try
			{
                if(!Directory.Exists("saves"))
                    Directory.CreateDirectory("saves");

				string SaveFile = Application.StartupPath + @"\saves\g" + GameNumber.ToString() + ".xml";
				dsScoreCard.WriteXml(SaveFile);
			}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
		}
		
		#region "ToolBar"
		
		private void TbNewClick(object sender, EventArgs e)
		{			
			
			try
			{
				// get rid of the data in the current dsScoreCard.
				for(int i = 0;i<=19;i++)
				    {
				    	for(int j = 1; j <=5; j++)
				    	{
				    		//MessageBox.Show("r" + i.ToString() + "c" + j.ToString ());
				    		Panel mPanel = (Panel)FindControl("r" + i.ToString() + "c" + j.ToString());
				    		mPanel.Controls.Clear();
				    	}
				    }
				GameNumber = 0;
				dsScoreCard.Clear();
				InitScoreCard();
				this.SetEnabled(true);
				IsGameSaved = false;
				this.NewRollGroup();
			}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
			
		}
				
		private void TbOpenClick(object sender, EventArgs e)
		{
			try
			{	
				// check if current game is saved
				if(this.IsGameSaved == false)
				{
					DialogResult dResult = MessageBox.Show("Do you want to save this game\n\rBefore opening another one?", "Save Game?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			
                 	if(dResult == DialogResult.Yes)
                 	{
                 		SaveGameData();
						SaveScoreCard();
						
                 	}
				}
				frmOpen mf = new frmOpen();
				mf.ShowDialog();
				if(mf.DialogResult == DialogResult.OK)
				{
					
					txtPlayerName.Text = PlayerName;
					lblRollNumber.Text = "0";
				 	intRollNumber = 0;
				 	lblHold1.Visible = false;
				 	lblHold2.Visible = false;
				 	lblHold3.Visible = false;
				 	lblHold4.Visible = false;
				 	lblHold5.Visible = false;
				 	btnRoll.Enabled = true;
			 		LoadSavedGame();
					SetEnabled(true);
					NewRollGroup();
				
				}
				SetHighScores();
				IsGameSaved = true;
			}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
		}
		
		private void TbSaveClick(object sender, EventArgs e)
		{
			try
			{
				SaveGameData();
				SaveScoreCard();
				
				SetHighScores();
				IsGameSaved = true;	
				MessageBox.Show("Game Saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
		}
		
		private void TbAboutClick(object sender, EventArgs e)
        {
            frmAbout fa = new frmAbout();
            fa.ShowDialog();
        }

		private void TbExitClick(object sender, EventArgs e)
		{
			// if the game has not been save since it was last played
			// check to see if the use wants to save
		
			if(IsGameSaved == false)
			{
				try
				{
					DialogResult dResult = MessageBox.Show("Do you want to save this game\n\rBefore closing?", "Save Game?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				
                 	if(dResult == DialogResult.Yes)
                 	{
                 		SaveGameData();
						SaveScoreCard();
				
                 	}
                 	else if(dResult == DialogResult.No)
                 	{
                 		// fool the  program into thinking it is saved
                 		// so the we dont' get a messagebox loop
                 		IsGameSaved = true;
                 		this.Close();
                 	}
                 	
                 	
					}
					catch(System.Exception ex)
				 	{
				 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
				 		eForm.ShowDialog();
				 	}
				}
				else
				{
					Application.Exit();
				}
				
		}
		 
		private void TbUpdateClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(@"http://www.brdstudio.net/yahtzeesharp/update.php?version=1.0.0");
		}	
		
		#endregion
		
		#region "Loading/Saving Game"
		
		private void SaveGameData()
		{
			try
			{
				dsGameData.Clear();
				// first load the current data
				if(File.Exists("GameData.xml"))
				    dsGameData.ReadXml("GameData.xml");
				         
				// if the GameNumber is 0 this is a new game
				if(GameNumber == 0)
				{
					Label mLabel;
					Panel mPanel;
					string pnlName;
					DataTable dt = dsGameData.Tables["dtGameData"];
					DataRow dr = dt.NewRow();
					dr["colPlayerName"] = txtPlayerName.Text;
					int tmpScore = 0;
					for(int i = 1; i <= 5; i++)
					{
						pnlName = "r19c" + i.ToString();
						mPanel = (Panel)FindControl(pnlName);
						if(mPanel.HasChildren == true)
						{
							mLabel = (Label)mPanel.Controls[0];
							tmpScore += int.Parse(mLabel.Text);
						}
					
					}
					dr["colScore"] = tmpScore;
					dr["colDate"] = DateTime.Now.ToShortDateString();
					dr["colIsComplete"] = mIsFinished;
					dt.Rows.Add(dr);
					GameNumber = (int)dr["colGameID"];
					
				}
				else
				{
					Label mLabel;
					Panel mPanel;
					string pnlName;
					DataTable dt = dsGameData.Tables["dtGameData"];
					DataRow dr = dt.Rows.Find(GameNumber);
					dr["colPlayerName"] = txtPlayerName.Text;
					int tmpScore = 0;
					for(int i = 1; i <= 5; i++)
					{
						pnlName = "r19c" + i.ToString();
						mPanel = (Panel)FindControl(pnlName);
						if(mPanel.HasChildren == true)
						{
							mLabel = (Label)mPanel.Controls[0];
							tmpScore += int.Parse(mLabel.Text);
						}
					
					}
					dr["colScore"] = tmpScore;
					dr["colDate"] = DateTime.Now.ToShortDateString();
					dr["colIsComplete"] = mIsFinished;
					
				}
				
				dsGameData.WriteXml("GameData.xml");
				
			}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
		}
		
		private void LoadSavedGame()
		{
			try
			{
				string tmpString = null;
				string SaveFile = Application.StartupPath + @"\saves\g" + GameNumber.ToString() + ".xml";
				this.dsScoreCard.Clear();
				dsScoreCard.ReadXml(SaveFile);
				DataTable dt = dsScoreCard.Tables["dtScoreCard"];
				// get rid of the data in the current dsScoreCard.
				for(int i = 0;i<=19;i++)
			    {
			    	for(int j = 1; j <=5; j++)
			    	{
			    		Panel mPanel = (Panel)FindControl("r" + i.ToString() + "c" + j.ToString());
			    		mPanel.Controls.Clear();
			    		tmpString = dt.Rows[i].ItemArray[j].ToString();
			    		if(tmpString.Trim() != "")
			    			mPanel.Controls.Add(lblScore(tmpString, mPanel.Width, mPanel.Height));
			    		
			    		mPanel.Refresh();
			    	}
			    }
			}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
			
		}
	
		public void SetGameNumber(int GameNum, string mPlayerName)
		{
			GameNumber = GameNum;
			PlayerName = mPlayerName;
		}
		
		#endregion
		
		private void DiceClick(object sender, EventArgs e)
		{
			try
			{
				PictureBox mPic = (PictureBox)sender;
				int i = 0;
				Label[] mLabel = new Label[5] { lblHold1, lblHold2, lblHold3, lblHold4, lblHold5 };
				i = int.Parse(mPic.Tag.ToString());
				if(mLabel[i].Visible == true)
				{
					mLabel[i].Visible = false;
				}
				else
				{
					mLabel[i].Visible = true;
				}
			}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
		}
		
		void ScoreCard_MouseHover(object sender, EventArgs e)
		{
			try
			{
				Panel mPanel = (Panel)sender;
				// if there is a control in the panel the field has already 
				// be use and the value set in the datatable
				// if there are no results in the datagrid then the
				// dice have not been rolled
				if((mPanel.HasChildren == false) && (gvResults.Rows.Count > 0))
				{
					DataSet ds = (DataSet)gvResults.DataSource;
					DataTable dt = ds.Tables["dtResults"];
					DataRow dr = dt.Rows.Find(mPanel.Tag.ToString());
					if(dr != null)
					{
						string mVal = dr["colValue"].ToString();
						
						mPanel.BackColor  = System.Drawing.SystemColors.MenuHighlight;
						CurrFrameValue = mVal;
						Invalidate();
				
					}
					else
					{
						// if there is not a valid score for this field
						// then it can be used for a scratch field
						if(mPanel.Tag.ToString() != "YAHTZEE BONUS")
						{
							string mVal = "0";
							mPanel.BackColor  = System.Drawing.SystemColors.MenuHighlight;
							CurrFrameValue = mVal;
							Invalidate();
						}
					}
				}
			}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
		}
		
		private Label lblScoreHover(string val,int pWidth, int pHeight)
		{
			Label mLabel = new Label();
			try
			{
				int intCenter = 0;
				if(val.Length == 2)
					intCenter = 10;
				if(val.Length == 3)
					intCenter = 15;
				
				mLabel.AutoSize = true;
				mLabel.ForeColor = System.Drawing.Color.Black;
				mLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				mLabel.Size = new System.Drawing.Size(17, 16);
				mLabel.Location = new System.Drawing.Point((pWidth/2) - (mLabel.Size.Width/2)- intCenter, (pHeight/2) - (mLabel.Size.Height/2));
				mLabel.TabIndex = 4;
				mLabel.Text = val;
			}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
			return mLabel;
		}
		
		void MainFormPaint(object sender, PaintEventArgs e)
		{
			try
			{
				int intCenter = 8;
				if(CurrFrameValue != null)
				{
					if(CurrFrameValue.Length == 2)
						intCenter = 13;
					if(CurrFrameValue.Length == 3)
						intCenter = 18;
				}
				
				Panel mPanel = (Panel)sender;
				Graphics g = e.Graphics ; 		
				SolidBrush blackBrush = new SolidBrush(Color.Yellow);		
				Font font = new Font("Verdana", 10, FontStyle.Bold);
				g.DrawString(CurrFrameValue, font, blackBrush, (mPanel.Width/2) - intCenter,  (mPanel.Width/2) - 15);
			}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}					
		}
		
		void ScoreCard_MouseLeave(object sender, EventArgs e)
		{
			try
			{
				Panel mPanel = (Panel)sender;
				CurrFrameValue = "";
				mPanel.BackColor = System.Drawing.SystemColors.Control;
				mPanel.Invalidate();
			}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
		}
		
		void ScoreCard_Click(object sender, EventArgs e)
		{
			try
			{
                Panel mPanel = (Panel)sender;
                if ((mPanel.HasChildren == false) && (gvResults.Rows.Count > 0))
                {
                	if((mPanel.Tag.ToString() != "YAHTZEE BONUS")||((mPanel.Tag.ToString() == "YAHTZEE BONUS") && (EnterVal == "100")))
                	{
                	
	                	mPanel.Controls.Add(lblScoreHover(EnterVal, mPanel.Width, mPanel.Height));
	                    mPanel.Invalidate();
	                    int tmpCol = int.Parse(mPanel.Name.Substring(mPanel.Name.LastIndexOf("c") + 1, 1));
	
	                    // add the value to the dataset
	                    //parse out the rows and columns 
	                    int mCol = int.Parse(mPanel.Name.Substring(mPanel.Name.LastIndexOf("c") + 1, 1));
	                    int mRow = int.Parse(mPanel.Name.Substring(1, mPanel.Name.LastIndexOf("c")- 1));
	                    dtScoreCard.Rows[mRow][mCol] = EnterVal;
	                    //MessageBox.Show(mPanel.Name.Substring(1, mPanel.Name.Length - mPanel.Name.LastIndexOf("c")-1));
	                    this.mCalcTotals(tmpCol);
	                    this.NewRollGroup();
	                    IsGameSaved = false;
	                    IsFinished();
                	}
                }
			}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
			                    
		}
		
		void ScoreCard_MouseEnter(object sender, EventArgs e)
		{
			// this function is similar to the mouse hover
			// except we wont be drawing anything
			// just set the value 
			try
			{
				Panel mPanel = (Panel)sender;
				// if there is a control in the panel the field has already 
				// be use and the value set in the datatable
				// if there are no results in the datagrid then the
				// dice have not been rolled
				if((mPanel.HasChildren == false) && (gvResults.Rows.Count > 0))
				{
					DataSet ds = (DataSet)gvResults.DataSource;
					DataTable dt = ds.Tables["dtResults"];
					DataRow dr = dt.Rows.Find(mPanel.Tag.ToString());
					if(dr != null)
					{
						string mVal = dr["colValue"].ToString();
						EnterVal = mVal;
						
					}
					else
					{
						// if there is not a valid score for this field
						// then it can be used for a scratch field
						string mVal = "0";
						EnterVal = mVal;
						
					}
				}
			}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
		}
	
		private bool YahtzeeFilled()
		{
			// this funtion checks to see if all the yahtzee have been filled
			// and if they have been NOT scratched so that a yahtzee bonus
			// is allowed
			try
			{
				DataRow dr = this.dtScoreCard.Rows.Find("YAHTZEE");
				if((dr[1].ToString() == "50") && (dr[2].ToString() == "50") && (dr[3].ToString() == "50") && (dr[4].ToString() == "50") && (dr[5].ToString() == "50"))
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
			return false;
						
		}
		
		private void IsFinished()
		{
			
			try
			{
				bool IsFinished = true;
				// iterate through all of the panel that make up the score card
				// with the exception of Yahtzee Bonus which can be blank
				// if they are all filled then the game is finished
				for(int i = 0;i<=19;i++)
			    {
			    	for(int j = 1; j <=5; j++)
			    	{
			    		Panel mPanel = (Panel)FindControl("r" + i.ToString() + "c" + j.ToString());
			    		if((mPanel.HasChildren == false) &&(i != 16))
			    			IsFinished = false;
			    	}
			    }
				
				if(IsFinished == true)
				{
					mIsFinished = true;
					this.SaveGameData();
					this.SaveScoreCard();
					int tmpScore = 0;
					Panel mPanel;
					Label mLabel;
					string pnlName;
					for(int i = 1; i <= 5; i++)
					{
						pnlName = "r19c" + i.ToString();
						mPanel = (Panel)FindControl(pnlName);
						if(mPanel.HasChildren == true)
						{
							mLabel = (Label)mPanel.Controls[0];
							tmpScore += int.Parse(mLabel.Text);
						}
					
					}
					// bring up the "your finished" form to give the user
					// the final score and ask for a new game
					frmFinish ff = new frmFinish(tmpScore.ToString());
					DialogResult mResult = ff.ShowDialog();
					if(mResult == DialogResult.Yes)
					{
						// start a new game
						// get rid of the data in the current dsScoreCard.
						for(int i = 0;i<=19;i++)
						    {
						    	for(int j = 1; j <=5; j++)
						    	{
						    		mPanel = (Panel)FindControl("r" + i.ToString() + "c" + j.ToString());
						    		mPanel.Controls.Clear();
						    	}
						    }
						GameNumber = 0;
						dsScoreCard.Clear();
						InitScoreCard();
						this.SetEnabled(true);
						IsGameSaved = true;
						NewRollGroup();
					}
					else if(mResult == DialogResult.No)
					{
						Application.Exit();
					}
				}
			}
			catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
		}
		
		
	}

}
