
using System;
using System.Windows.Forms;
using System.Data;
using System.Xml;
using System.IO;
using Gtk;

namespace YahtzeeSharp
{
	
	public partial class frmMain : Gtk.Window
	{
		private static string SavePath = System.Environment.GetEnvironmentVariable("HOME") + "/.YahtzeeSharp/";
		private Gdk.Pixbuf[] DiceArray = new Gdk.Pixbuf[6] ;
		private static string PlayerName;
		private int intRollNumber = 0;
		private int intRollCountDown = 1000;
		private int intRollCountModifier = 1000;
		private static int GameNumber = 0;
		private DataSet dsScoreCard = new DataSet();
		private DataTable dtScoreCard;
		private bool IsGameSaved = true;
		private bool mIsFinished = false;
		private int[] mDice = new int[5];
		private DataSet dsGameData;
		bool OpenOk = false;
		private bool HasResults = false;
		private bool blnAllowHold = false;
						
		public frmMain() : 
				base("")
		{
			Build();
			try
			{
				// if the game directory does not exist for this user
				// then create it under users home directory
				if(!Directory.Exists(SavePath))
					Directory.CreateDirectory(SavePath);
					
				DiceArray[0] = Gdk.Pixbuf.LoadFromResource("dice1.png");
				DiceArray[1] = Gdk.Pixbuf.LoadFromResource("dice2.png");
				DiceArray[2] = Gdk.Pixbuf.LoadFromResource("dice3.png");
				DiceArray[3] = Gdk.Pixbuf.LoadFromResource("dice4.png");
				DiceArray[4] = Gdk.Pixbuf.LoadFromResource("dice5.png");
				DiceArray[5] = Gdk.Pixbuf.LoadFromResource("dice6.png");
				
				this.pnlUpperScore.RowSpacing = 0;
				this.pnlUpperScore.ColumnSpacing = 0;
				this.pnlLowerScore.RowSpacing = 0;
				this.pnlLowerScore.ColumnSpacing = 0;
				this.tblDice.RowSpacing = 2;
				this.tblDice.ColumnSpacing = 2;
				
				SetUpTreeViews();
				
				// set up the dataset/datatable for scoring
				dtScoreCard = dtSC();
				dsScoreCard.Tables.Add(dtScoreCard);
				InitScoreCard();
				dsGameData = mGameData();
				
				SetHighScores();
				
				// initially set the enabled features to false until the new or open button is pushed
				SetEnabled(false);
			}
			catch(System.Exception ex)
		 	{
		 		MessageBox.Show(ex.ToString());
						frmError eForm = new frmError(ex.ToString());
				 		eForm.Show();
		 	}
		}

				private void SetUpTreeViews()
				{
					//
					// Results TreeView
					//
					// Create a column for the Result type
					Gtk.TreeViewColumn colResults = new Gtk.TreeViewColumn ();
					colResults.Title = "Results";

					// Create a column for the values
					Gtk.TreeViewColumn colValues = new Gtk.TreeViewColumn ();
					colValues.Alignment = 0.5f;
					colValues.Title = "Values";

					// Add the columns to the TreeView
					gvResults.AppendColumn (colResults);
					gvResults.AppendColumn (colValues);
				  
				  	// Create the text cell that will display the players name
					Gtk.CellRendererText cellResults = new Gtk.CellRendererText ();
					cellResults.Width = 150;
					colResults.PackStart (cellResults, true);
					
				 
				  	// Set the values cell
				  	Gtk.CellRendererText cellValues = new Gtk.CellRendererText ();
				  	cellValues.Xalign = 0.8f;
				  	cellValues.Width = 50;
				 	colValues.PackStart (cellValues, true);
				 	 
				 	// Tell the Cell Renderers which items in the model to display
					colResults.AddAttribute (cellResults, "text", 0);
					colValues.AddAttribute (cellValues, "text", 1);
					
					
					//
					// High Score TreeView
					//
					// Create a column for the artist name
					Gtk.TreeViewColumn colPlayerName = new Gtk.TreeViewColumn ();
					colPlayerName.Title = "Player Name";

					// Create a column for the song title
					Gtk.TreeViewColumn colScore = new Gtk.TreeViewColumn ();
					colScore.Alignment = 0.2f;
					colScore.Title = "Score";

					// Add the columns to the TreeView
					gvHighScore.AppendColumn (colPlayerName);
					gvHighScore.AppendColumn (colScore);
				  
				  	// Create the text cell that will display the artist name
					Gtk.CellRendererText cellPlayerName = new Gtk.CellRendererText ();
					cellPlayerName.Xalign = 0.1f;
					cellPlayerName.Width = 150;
					colPlayerName.PackStart (cellPlayerName, true);
					
				 
				  	// Do the same for the song title column
				  	Gtk.CellRendererText cellScore = new Gtk.CellRendererText ();
				  	cellScore.Xalign =0.7f;
				  	cellScore.Width = 50;
				 	colScore.PackStart (cellScore, true);
					
					// Tell the Cell Renderers which items in the model to display
					colPlayerName.AddAttribute (cellPlayerName, "text", 0);
					colScore.AddAttribute (cellScore, "text", 1);
					
					
				}
				
				private void SetEnabled(Boolean mBool)
				 {
				 	try
				 	{
					 	pnlUpperScore.CanFocus = mBool;
					 	pnlLowerScore.CanFocus= mBool;
				 		
				 		
				 		btnRoll.Sensitive  = mBool;
			 		}
				 	catch(System.Exception ex)
				 	{
				 		frmError eForm = new frmError(ex.ToString());
				 		eForm.Show();
				 	}
		
		 }
				protected virtual void OnNewActivated(object sender, System.EventArgs e)
				{
					try
					{
					
						// check if current game is saved
						if(this.IsGameSaved == false)
						{
							MessageDialog md = new MessageDialog (this, DialogFlags.DestroyWithParent, MessageType.Question,  ButtonsType.YesNo, "Do you want to save this game\n\rBefore closing?");
     
							ResponseType result = (ResponseType)md.Run ();

		                 	if (result == ResponseType.Yes)
		                 	{
		                 		SaveGameData();
								SaveScoreCard();
								
		                 	}
		                 	md.Destroy();
						}
						
						Gtk.Frame mFrame;
						Gtk.Label mLabel;
						// get rid of the data in the current scorecare.
						
						// set all the neccisary labels on the score card to the
						// default button
						
						// upper scord card buttons
						for(int i = 0;i<=5;i++)
					    {
					    	for(int j = 1; j <=5; j++)
					    	{
					    		mFrame = FindFrame("r" + i.ToString() + "c" + j.ToString());
					    		if(mFrame.Child.GetType() == typeof(Gtk.Label))
					    		{
					    			mFrame.Child.Destroy();
					    			mFrame.Add(DefaultButton());
					    			
					    		}
								
					    	}
					    }
					    
					    // lower scord card buttons
						for(int i = 9;i<=16;i++)
					    {
					    	for(int j = 1; j <=5; j++)
					    	{
					    		mFrame = FindFrame("r" + i.ToString() + "c" + j.ToString());
					    		if(mFrame.Child.GetType() == typeof(Gtk.Label))
					    		{
					    			mFrame.Child.Destroy();
					    			mFrame.Add(DefaultButton());
					    			
					    		}
								
					    	}
					    }
					    
					    // clear the labels
					    // upper scord card labels
						for(int i = 6;i<=8;i++)
					    {
					    	for(int j = 1; j <=5; j++)
					    	{
					    		mLabel = FindControl("r" + i.ToString() + "c" + j.ToString(), true);
					    		mLabel.Text = "";
					    		
					    	}
					    }
					    
					    // clear the labels
					    // lower scord card labels
						for(int i = 17;i<=19;i++)
					    {
					    	for(int j = 1; j <=5; j++)
					    	{
					    		mLabel = FindControl("r" + i.ToString() + "c" + j.ToString(), false);
					    		mLabel.Text = "";
					    		
					    	}
					    }
					    
						GameNumber = 0;
						dsScoreCard.Clear();
						InitScoreCard();
						SetEnabled(true);
						IsGameSaved = false;
						NewRollGroup();
					}
				 	catch(System.Exception ex)
				 	{
				 		frmError eForm = new frmError(ex.ToString());
				 		eForm.Show();
				 	}
				}
				
				private Gtk.Frame FindFrame(string strFrameName)
				{
					
					Gtk.Frame mFrame;
					Gtk.Widget[] mWidget;
					// scan the upper table for the frame we are looking for
				     mWidget = pnlUpperScore.Children;
					for(int i = 0; i < mWidget.Length; i++)
					{
						mFrame = (Gtk.Frame)mWidget[i];
						
						if((mFrame.GetType() == typeof (Gtk.Frame)) && (mFrame.Name == strFrameName))
						{
							return mFrame;
							
						}
					}
					
					// scan the lower table for the frame we are looking for
				    mWidget = pnlLowerScore.Children;
					for(int i = 0; i < mWidget.Length; i++)
					{
						mFrame = (Gtk.Frame)mWidget[i];
						
						if((mFrame.GetType() == typeof (Gtk.Frame)) && (mFrame.Name == strFrameName))
						{
							return mFrame;
							
						}
					}
					return new Gtk.Frame();
					
				}

				protected virtual void OnBtnRollClicked(object sender, System.EventArgs e)
				{
				try
				{
					intRollCountModifier = 1;
					intRollCountDown = 10;
					uint IsDone =0;
					while(IsDone == 0)
					{
						IsDone =   GLib.Timeout.Add((uint)intRollCountDown, new GLib.TimeoutHandler(mTimer_Tick));
						System.Diagnostics.Debug.WriteLine("IsDone = " + IsDone.ToString());
					}
					
					
				
				}
				catch(System.Exception ex)
				{
					frmError eForm = new frmError(ex.ToString());
					eForm.Show();
				}
			}
		
			private bool mTimer_Tick()
			{
				try
				{
					
						Random random = new Random();
						if(lblHold1.Text != "Hold")
						{	
							mDice[0] = random.Next(0, 6);
							Dice1.Pixbuf  = DiceArray[mDice[0]];
						}
							
						if(lblHold2.Text != "Hold")
						{	
							mDice[1] = random.Next(0, 6);
							Dice2.Pixbuf  = DiceArray[mDice[1]];
							
						}
						
						if(lblHold3.Text != "Hold")
						{	
							mDice[2] = random.Next(0, 6);
							Dice3.Pixbuf  = DiceArray[mDice[2]];
						}
						
						if(lblHold4.Text != "Hold")
						{	
							mDice[3] = random.Next(0, 6);
							Dice4.Pixbuf  = DiceArray[mDice[3]];
						}
						
						if(lblHold5.Text != "Hold")
						{
							mDice[4] = random.Next(0, 6);
							Dice5.Pixbuf  = DiceArray[mDice[4]];
						}	
				}
				catch(System.Exception ex)
				{
					frmError eForm = new frmError(ex.ToString());
					eForm.Show();
				}
				intRollCountModifier++;
				intRollCountDown += (10 * intRollCountModifier);
				if(intRollCountDown > 10000)
				{
						SetEnabled(true);
						intRollNumber++;
						lblRollNumber.Text = intRollNumber.ToString();
						
				 		if(intRollNumber == 3)
						{
							SetEnabled(false);
						}					
						
						csPosScore mScore = new csPosScore(mDice, YahtzeeFilled());
						this.gvResults.Model = mScore.SetReturnOptions();
						HasResults = true;
						blnAllowHold = true;
			 			this.ShowAll();
						return false;
					}
					else
					{
						return true;
					}
				}
			
				public void SetGameNumber(int tGameNum, string tPlayerName, bool tOpenOK)
				{
					GameNumber = tGameNum;
					PlayerName = tPlayerName;
					OpenOk = tOpenOK;
				}
				
				protected virtual void OnOpenActivated(object sender, System.EventArgs e)
				{
					
					try
					{	
						
						// check if current game is saved
						if(this.IsGameSaved == false)
						{
							MessageDialog md = new MessageDialog (this, DialogFlags.DestroyWithParent, MessageType.Question,  ButtonsType.YesNo, "Do you want to save this game\n\rBefore closing?");
     
							ResponseType result = (ResponseType)md.Run ();

		                 	if (result == ResponseType.Yes)
		                 	{
		                 		SaveGameData();
								SaveScoreCard();
								
		                 	}
		                 	md.Destroy();
						}

						
						dlgOpen fm = new dlgOpen();
						fm.SetParent(this);
						fm.Modal = true;
						
						
						if((Gtk.ResponseType)fm.Run() == Gtk.ResponseType.Ok)
						{
							txtPlayerName.Text = PlayerName;
							lblRollNumber.Text = "0";

					 		LoadSavedGame();
							intRollNumber = 0;
						 	SetEnabled(true);
							NewRollGroup();
						
						}
						fm.Destroy();
						SetHighScores();
						IsGameSaved = true;
					}
				 	catch(System.Exception ex)
				 	{
				 			frmError eForm = new frmError(ex.ToString());
				 			eForm.Show();
				 	}
					
				}

				private void LoadSavedGame()
				{
					try
					{
						string tmpString = null;
						Gtk.Frame mFrame;
						Gtk.Label mLabel;
						string SaveFile =  SavePath +  @"/saves/g" + GameNumber.ToString() + ".xml";
						dsScoreCard.Clear();
						dsScoreCard.ReadXml(SaveFile);
						DataTable dt = dsScoreCard.Tables["dtScoreCard"];
						
						// set the values from the dataset to the scorecard
						
						// start with the top buttons
						 for(int i = 0;i<=5;i++)
					    {
					    	for(int j = 1; j <=5; j++)
					    	{
					    		mFrame = FindFrame("r" + i.ToString() + "c" + j.ToString());
					    		
					    		// at this point destroy the child no matter the situation so we can place the correct one in the frame
					    			mFrame.Child.Destroy();
						    		
					    			tmpString = dt.Rows[i].ItemArray[j].ToString();
						    		
						    		if(( dt.Rows[i].ItemArray[j].ToString() == null ) || ( dt.Rows[i].ItemArray[j].ToString() == "" ))
						    		{
						    			mFrame.Add(DefaultButton());
							    		
						    		}
						    		else
						    		{
						    			// if there is a value in the dataset 
						    			// then set a label there with the correct value
						    			mLabel = new Gtk.Label(tmpString);
										mLabel.Justify = Justification.Center;
										mFrame.Add(mLabel);										
						    		}
						    		
						    				    		
					    	}					    	
					    }
					    
					    // then the botton buttons
					   for(int i = 6;i<=8;i++)
					    {
					    	for(int j = 1; j <=5; j++)
					    	{
					    		mFrame = FindFrame("r" + i.ToString() + "c" + j.ToString());
					    							    		
				    			// at this point destroy the child no matter the situation so we can place the correct one in the frame
				    			mFrame.Child.Destroy();
					    		tmpString = dt.Rows[i].ItemArray[j].ToString();
					    		
				    			// if there is a value in the dataset 
				    			// then set a label there with the correct value
				    			mLabel = new Gtk.Label(tmpString);
								mLabel.Justify = Justification.Center;
								mFrame.Add(mLabel);										
						    			    		
					    	}					    	
					    }
					    
					    // now for the lower buttons
					   for(int i = 9;i<=16;i++)
					    {
					    	for(int j = 1; j <=5; j++)
					    	{
					    		mFrame = FindFrame("r" + i.ToString() + "c" + j.ToString());
					    		
					    		// at this point destroy the child no matter the situation so we can place the correct one in the frame
					    			mFrame.Child.Destroy();
						    		
					    			tmpString = dt.Rows[i].ItemArray[j].ToString();
						    		
						    		if(( dt.Rows[i].ItemArray[j].ToString() == null ) || ( dt.Rows[i].ItemArray[j].ToString() == "" ))
						    		{
						    			mFrame.Add(DefaultButton());
							    		
						    		}
						    		else
						    		{
						    			// if there is a value in the dataset 
						    			// then set a label there with the correct value
						    			mLabel = new Gtk.Label(tmpString);
										mLabel.Justify = Justification.Center;
										mFrame.Add(mLabel);										
						    		}
						    						    		
					    	}					    	
					    }
					    
					    // finally the lower labels
					   for(int i = 17;i<=19;i++)
					    {
					    	for(int j = 1; j <=5; j++)
					    	{
					    		mFrame = FindFrame("r" + i.ToString() + "c" + j.ToString());
					    							    		
				    			// at this point destroy the child no matter the situation so we can place the correct one in the frame
				    			mFrame.Child.Destroy();
					    		tmpString = dt.Rows[i].ItemArray[j].ToString();
					    		
				    			// if there is a value in the dataset 
				    			// then set a label there with the correct value
				    			mLabel = new Gtk.Label(tmpString);
								mLabel.Justify = Justification.Center;
								mFrame.Add(mLabel);			    						    		
					    	}					    	
					    }
					    this.ShowAll();
					    
					    // after loading calculate all the columns
					    for(int i = 1; i < 6; i++)
					    {
					    	this.mCalcTotals(i);
					    }
						    	ToggleYahtzeeBonus(this.YahtzeeFilled());		
					}
				 	catch(System.Exception ex)
				 	{
				 		frmError eForm = new frmError(ex.ToString());
				 		eForm.Show();
				 	}
					
				}	
				
				private void ToggleYahtzeeBonus(bool blnSetYahtzeeBonus)
				{
					try
					{
						Gtk.Frame mFrame;
						if(blnSetYahtzeeBonus == true)
						{
							mFrame = FindFrame("r16c1");
							mFrame.Sensitive = true;
							mFrame = FindFrame("r16c2");
							mFrame.Sensitive = true;
							mFrame = FindFrame("r16c3");
							mFrame.Sensitive = true;
							mFrame = FindFrame("r16c4");
							mFrame.Sensitive = true;
							mFrame = FindFrame("r16c5");
							mFrame.Sensitive = true;
						}
						else
						{							
							mFrame = FindFrame("r16c1");
							mFrame.Sensitive = false;
							mFrame = FindFrame("r16c2");
							mFrame.Sensitive = false;
							mFrame = FindFrame("r16c3");
							mFrame.Sensitive = false;
							mFrame = FindFrame("r16c4");
							mFrame.Sensitive = false;
							mFrame = FindFrame("r16c5");
							mFrame.Sensitive = false;
							}
					}
					catch(System.Exception ex)
				 	{
				 		frmError eForm = new frmError(ex.ToString());
				 		eForm.Show();
				 	}
				}
				
				protected virtual void OnSaveActivated(object sender, System.EventArgs e)
				{
				
					try
					{
						SaveGameData();
						SaveScoreCard();
						SetHighScores();
						IsGameSaved = true;
						MessageDialog md = new MessageDialog (this, DialogFlags.DestroyWithParent, MessageType.Info,  ButtonsType.Ok, "Game Saved");
     					md.Run ();
     					md.Destroy();
					}
					catch(System.Exception ex)
				 	{
				 		frmError eForm = new frmError(ex.ToString());
				 		eForm.Show();
				 	}
				}

				protected virtual void OnAboutActivated(object sender, System.EventArgs e)
				{
					frmAbout fm = new frmAbout();
					fm.Show();
				}

				protected virtual void OnQuitActivated(object sender, System.EventArgs e)
				{
						try
						{
						
							// check if current game is saved
							if(this.IsGameSaved == false)
							{
								MessageDialog md = new MessageDialog (this, DialogFlags.DestroyWithParent, MessageType.Question,  ButtonsType.YesNo, "Do you want to save this game\n\rBefore closing?");
	     
								ResponseType result = (ResponseType)md.Run ();

			                 	if (result == ResponseType.Yes)
			                 	{
			                 		SaveGameData();
									SaveScoreCard();
									
			                 	}
							}
							
							Gtk.Application.Quit();
						}
						catch(System.Exception ex)
				 	{
				 		frmError eForm = new frmError(ex.ToString());
				 		eForm.Show();
				 	}
				}

				 protected virtual void OnDeleteEvent(object o, Gtk.DeleteEventArgs args)
			 {
			 	Gtk.Application.Quit();
			 }

			#region "Mouse Events and Freinds"

			private Gtk.Button DefaultButton()
			{
				Gtk.Button mButton = new Gtk.Button();
				mButton.WidthRequest = 30;
				mButton.HeightRequest = 27;
				mButton.BorderWidth = 0;
				mButton.Relief = Gtk.ReliefStyle.None; 
				mButton.Label = "";
				
				// create the signals
				mButton.Clicked += ScoreCard_Click;
				mButton.Entered += ScoreCard_MouseHover;
				mButton.Left += ScoreCard_MouseLeave;
				
				return mButton;
				
			}
			
				
			 protected virtual void ScoreCard_MouseLeave(object sender, System.EventArgs e)
			 {
				 
				 Gtk.Button mButton = (Gtk.Button)sender;
			 		mButton.Label = "";
			 }

			 protected virtual void ScoreCard_MouseHover(object sender, System.EventArgs e)
			 {
			 	try
			 	{
				 	Gtk.Button mButton = (Gtk.Button)sender;
				 	if(HasResults == true) 
				 	{
				 		mButton.State = Gtk.StateType.Normal;
				 		mButton.Label = GetResultsValue(EnumGetScoreRow(mButton.Parent.Name));				 		
				}
				    else
				{
					mButton.State = Gtk.StateType.Active;
				}
				 	
			 	}
			 	catch(System.Exception ex)
			 	{
			 		frmError eForm = new frmError(ex.ToString());
			 		eForm.Show();
			 	}
			 }

			 protected virtual void ScoreCard_Click(object sender, System.EventArgs e)
			 {
			 	try
			 	{
				// FIXME Yahtzee Bonus should not be allow until all yahtzees are filled
			 		Gtk.Button mButton = (Gtk.Button)sender;
				 		if(HasResults != false)
				 		{
					 		
					 		Gtk.Frame mFrame = (Gtk.Frame)mButton.Parent;
					 		Gtk.Label mLabel = new Gtk.Label(GetResultsValue(EnumGetScoreRow(mButton.Parent.Name)));
					 		mLabel.Name = mButton.Name;
					 		mFrame.Remove(mButton);
					 		mFrame.Add((Gtk.Widget)mLabel);
					 		
					 		 // add the value to the dataset
			               //parse out the rows and columns 
			               int mCol = int.Parse(mFrame.Name.Substring(mFrame.Name.LastIndexOf("c") + 1, 1));
			               int mRow = int.Parse(mFrame.Name.Substring(1, mFrame.Name.LastIndexOf("c")- 1));
			               dtScoreCard.Rows[mRow][mCol] = mLabel.Text;
				                    
						 	mFrame.ShowAll();
						 	IsGameSaved = false;
						 	HasResults = false;
						 	int tmpCol = int.Parse(mLabel.Parent.Name.Substring(mLabel.Parent.Name.LastIndexOf("c") + 1, 1));
					 		mCalcTotals(tmpCol);
					 		NewRollGroup();
					 		IsFinished();
					 		ToggleYahtzeeBonus(this.YahtzeeFilled());		
			 		}
		 		}
		 		catch(System.Exception ex)
			 	{
			 		frmError eForm = new frmError(ex.ToString());
			 		eForm.Show();
			 	}
			 	
			 }

			private string EnumGetScoreRow(string mVal)
			{
				
				try
				{
					mVal = mVal.Substring(mVal.IndexOf("r") + 1, mVal.IndexOf("c") - mVal.IndexOf("r") - 1);
					switch(mVal)
					{
						case "0":
							return "Ones";
						case "1":
							return "Twos";
						case "2":
							return "Threes";
						case "3":
							return "Fours";
						case "4":
							return "Fives";
						case "5":
							return "Sixes";
						case "9":
							return "3 Of a Kind";
						case "10":
							return "4 Of a Kind";
						case "11":
							return "Full House";
						case "12":
							return "Small Straight";
						case "13":
							return "Large Straight";
						case "14":
							return "YAHTZEE";
						case "15":
							return "Chance";
						case "16":
							return "YAHTZEE BONUS";
						
						default:
							return "Error";
							
					}
				}
				catch(System.Exception ex)
			 	{
			 		frmError eForm = new frmError(ex.ToString());
			 		eForm.Show();
			 	}
			 	return "Error";
				 	
			}
			
			
			private string findVal;
			private string foundResult;

			private bool ForeachFindItem (TreeModel model, TreePath path, TreeIter iter)
			{

				string foundValue = (string) model.GetValue (iter, 0);

				if (findVal == foundValue) 
				{
					foundResult = (string) model.GetValue (iter, 1);;
					return true;
				}

				return false;

			}

			private string GetResultsValue (string SearchVal)
			{

				findVal = SearchVal;
				foundResult = "0";

				this.gvResults.Model.Foreach (new TreeModelForeachFunc (ForeachFindItem));

				
				return foundResult;

			} 
			
#endregion

 
		private void mCalcTotals(int mCol)
		{
			try
			{
				Gtk.Label mLabel;
				int UpperTS = 0;
				int UpperBonus = 0;
				int UpperTotal = 0;
				int LowerTotal = 0;
				int GrandTotal = 0;
				
				// start by calculating the upper total score
				// row 6 is the upper total score row
				for(int i = 0; i < 6; i++)
				{
					mLabel = FindControl("r" + i.ToString() + "c" + mCol.ToString(), true);
					UpperTS += int.Parse(mLabel.Text);
					
				}
				// update the score card datatable and label
				// for the upper Total Score
				mLabel = FindControl("r6c" + mCol.ToString(), true);
				mLabel.Text = UpperTS.ToString();
				dtScoreCard.Rows[6][mCol] = UpperTS.ToString();
				
				// give a bonus if upper total score is 63 or over
				if(UpperTS >= 63)
					UpperBonus = 35;
				
				// update the score card datatable and label
				// for the bonus row
				mLabel = FindControl("r7c" + mCol.ToString(), true);
				mLabel.Text = UpperBonus.ToString();				
				dtScoreCard.Rows[7][mCol] = UpperBonus.ToString();
							
				// total of the upper section
				UpperTotal = UpperBonus + UpperTS;
				
				// update the score card datatable and label
				// total of the upper section
				mLabel = FindControl("r8c" + mCol.ToString(), true);
				mLabel.Text = UpperTS.ToString();
				dtScoreCard.Rows[8][mCol] = UpperTotal.ToString();
				
				// also the label on the for the Upper total on the
				// lower section
				mLabel = FindControl("r17c" + mCol.ToString(), false);
				mLabel.Text = UpperTS.ToString();
				dtScoreCard.Rows[18][mCol] = UpperTotal.ToString();
				
				
				// calculate the total of the lower section
				// which starts on row 9 and ends on row 17
				for(int i = 9; i < 17; i++)
				{
					mLabel = FindControl("r" + i.ToString() + "c" + mCol.ToString(), false);
					LowerTotal += int.Parse(mLabel.Text);
					
				}
				
				// update the score card datatable and label
				// for the lower Score
				mLabel = FindControl("r18c" + mCol.ToString(), false);
				mLabel.Text = LowerTotal.ToString();
				dtScoreCard.Rows[17][mCol] = LowerTotal.ToString();
				
				// set the grand total
				GrandTotal = UpperTotal + LowerTotal;
				
				// update the score card datatable and label
				// for the grand total
				mLabel = FindControl("r19c" + mCol.ToString(), false);
				mLabel.Text = GrandTotal.ToString();
				dtScoreCard.Rows[19][mCol] = GrandTotal.ToString();
			}
		 	catch(System.Exception ex)
		 	{
		 		frmError eForm = new frmError(ex.ToString());
			 	eForm.Show();
		 	}
		}
		
		private void SetHighScores()
		{
			
			try
			{
				if(!File.Exists(SavePath + "GameData.xml"))
					dsGameData.WriteXml(SavePath + "GameData.xml");
				
				Gtk.ListStore mListStore = new Gtk.ListStore(typeof (string), typeof (string));
				dsGameData.Clear();
				
				
				dsGameData.ReadXml(SavePath + "GameData.xml");
				if(dsGameData.Tables["dtGameData"].Rows.Count > 0)
				{
					DataView dv = new DataView(dsGameData.Tables["dtGameData"]);
					dv.Sort = "colScore Desc";
					
					foreach(DataRowView dvr in dv)
					{
						mListStore.AppendValues(dvr["colPlayerName"].ToString(), dvr["colScore"].ToString() + " ");
						
					}
							
					gvHighScore.Model = mListStore;
				}
			}
			catch(Exception ex)
			{
				frmError eForm = new frmError(ex.ToString());
			 	eForm.Show();
			}
		}
		
		private Gtk.Label FindControl(string strControlName, bool UpperScore)
        {
           Gtk.Label rLabel = new Gtk.Label();
        	try
        	{
				if(UpperScore == true)
				{
					Gtk.Widget[] mWidget = pnlUpperScore.Children;
					for(int i = 0; i < mWidget.Length; i++)
					{
						Gtk.Frame mFrame = (Gtk.Frame)mWidget[i];
						
						if((mFrame.Child.GetType() == typeof (Gtk.Label)) && (mFrame.Name == strControlName))
						{
							return (Gtk.Label)mFrame.Child;
							
						}
					}
				}
				else
				{
					Gtk.Widget[] mWidget = this.pnlLowerScore.Children;
					for(int i = 0; i < mWidget.Length; i++)
					{
						// because we have the horizontal separators
						// we have to make sure we are dealing with a frame
						if(mWidget[i].GetType() == typeof (Gtk.Frame))
						{
							Gtk.Frame mFrame = (Gtk.Frame)mWidget[i];
							
							if((mFrame.Child.GetType() == typeof (Gtk.Label)) && (mFrame.Name == strControlName))
							{
								return (Gtk.Label)mFrame.Child;
								
							}
						}
					}
				}
				// if we get here create a new label with 
				// a text of 0 to add 0 to the total
				rLabel.Text = "0";
        	}
        	catch(System.Exception ex)
		 	{
		 		frmError eForm = new frmError(ex.ToString());
			 	eForm.Show();
		 	}
            return rLabel;
        }
        
        private void NewRollGroup()
		 {
		 	try
		 	{
		 		lblRollNumber.Text = "0";
			 	intRollNumber = 0;
			 	blnAllowHold = false;
			 	lblHold1.Text = "";
				lblHold2.Text = "";
				lblHold3.Text = "";
				lblHold4.Text = "";
			 	lblHold5.Text = "";
			 	
			 	btnRoll.Sensitive = true;
			 	this.gvResults.Model = null;
			 	HasResults = false;
			 	gvResults.ShowAll();
		 	}
		 	catch(System.Exception ex)
		 	{
		 		frmError eForm = new frmError(ex.ToString());
			 	eForm.Show();
		 	}
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
		 		frmError eForm = new frmError(ex.ToString());
			 	eForm.Show();
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
		 		frmError eForm = new frmError(ex.ToString());
			 	eForm.Show();
		 	}
		
		}
		
		private DataSet mGameData()
		{
			DataSet ds = new DataSet();
			try
			{
				ds.DataSetName = "dsGameData";
				DataTable dt = new DataTable("dtGameData");
				
				DataColumn dataColumn1 = new DataColumn(); 
				DataColumn dataColumn2 = new DataColumn(); 
				DataColumn dataColumn3 = new DataColumn(); 
				DataColumn dataColumn4 = new DataColumn(); 
				DataColumn dataColumn5 = new DataColumn();
				
				dataColumn1.AllowDBNull = false;
				dataColumn1.AutoIncrement = true;
				dataColumn1.AutoIncrementSeed = ((long)(1));
				dataColumn1.ColumnName = "colGameID";
				dataColumn1.DataType = typeof(int);
				
				dataColumn2.ColumnName = "colPlayerName";
				
				dataColumn3.ColumnName = "colScore";
				dataColumn3.DataType = typeof(int);
				
				dataColumn4.ColumnName = "colDate";
				dataColumn4.DataType = typeof(System.DateTime);
				
				dataColumn5.Caption = "Finished";
				dataColumn5.ColumnName = "colIsComplete";
				dataColumn5.DataType = typeof(bool);
				dataColumn5.DefaultValue = false;
				
				dt.Columns.AddRange(new System.Data.DataColumn[] {
										dataColumn1,
										dataColumn2,
										dataColumn3,
										dataColumn4,
										dataColumn5});
				
				dt.PrimaryKey = new System.Data.DataColumn[] {dataColumn1};
				ds.Tables.Add(dt);
			}
			catch(System.Exception ex)
		 	{
		 		frmError eForm = new frmError(ex.ToString());
			 	eForm.Show();
		 	}
			return ds;
		}
		
		#endregion
		
		#region "Loading/Saving Game"
		
		private void SaveGameData()
		{
			try
			{
				dsGameData.Clear();
				// first load the current data
				if(File.Exists(SavePath + "GameData.xml"))
				    dsGameData.ReadXml(SavePath + "GameData.xml");
				         
				// if the GameNumber is 0 this is a new game
				if(GameNumber == 0)
				{
					Gtk.Label mLabel;
					DataTable dt = dsGameData.Tables["dtGameData"];
					DataRow dr = dt.NewRow();
					dr["colPlayerName"] = txtPlayerName.Text;
					int tmpScore = 0;
					for(int i = 1; i <= 5; i++)
					{
						mLabel = FindControl("r19c" + i.ToString(), false);
						if(mLabel.Text != "")
							tmpScore += int.Parse(mLabel.Text);					
					}
					dr["colScore"] = tmpScore;
					dr["colDate"] = DateTime.Now.ToShortDateString();
					dr["colIsComplete"] = mIsFinished;
					dt.Rows.Add(dr);
					GameNumber = (int)dr["colGameID"];
					
				}
				else
				{
					Gtk.Label mLabel;
					DataTable dt = dsGameData.Tables["dtGameData"];
					DataRow dr = dt.Rows.Find(GameNumber);
					dr["colPlayerName"] = txtPlayerName.Text;
					int tmpScore = 0;
					for(int i = 1; i <= 5; i++)
					{
						mLabel = FindControl("r19c" + i.ToString(), false);
						tmpScore += int.Parse(mLabel.Text);						
					}
					dr["colScore"] = tmpScore;
					dr["colDate"] = DateTime.Now.ToShortDateString();
					dr["colIsComplete"] = mIsFinished;
					
				}
				
				dsGameData.WriteXml(SavePath + "GameData.xml");
				
			}
		 	catch(System.Exception ex)
		 	{
		 		frmError eForm = new frmError(ex.ToString());
			 	eForm.Show();
		 	}
		}
		
		private void SaveScoreCard()
		{
			try
			{
                if(!Directory.Exists(SavePath + "saves"))
                    Directory.CreateDirectory(SavePath + "saves");

				string SaveFile = SavePath +  @"/saves/g" + GameNumber.ToString() + ".xml";
				dsScoreCard.WriteXml(SaveFile);
			}
		 	catch(System.Exception ex)
		 	{
		 		frmError eForm = new frmError(ex.ToString());
			 	eForm.Show();
		 	}
		}

		protected virtual void OnCmdDice1Clicked (object sender, System.EventArgs e)
		{
			if(blnAllowHold != false)
			 {		 	
				if(lblHold1.Text == "")
					lblHold1.Text = "Hold";
				else
					lblHold1.Text = "";
					
					Gtk.Button mButton = (Gtk.Button)sender;
					mButton.State = Gtk.StateType.Normal;
			}
		}

		protected virtual void OnCmdDice1Entered (object sender, System.EventArgs e)
		{
			Gtk.Button mButton = (Gtk.Button)sender;
			mButton.State = Gtk.StateType.Normal;
		}

		protected virtual void OnCmdDice2Clicked (object sender, System.EventArgs e)
		{
			if(blnAllowHold != false)
			 {		 	
				if(lblHold2.Text == "")
					lblHold2.Text = "Hold";
				else
					lblHold2.Text = "";
					
					Gtk.Button mButton = (Gtk.Button)sender;
					mButton.State = Gtk.StateType.Normal;
				}
		}

		protected virtual void OnCmdDice3Clicked (object sender, System.EventArgs e)
		{
			if(blnAllowHold != false)
			 {		 	
				if(lblHold3.Text == "")
					lblHold3.Text = "Hold";
				else
					lblHold3.Text = "";
					
					Gtk.Button mButton = (Gtk.Button)sender;
					mButton.State = Gtk.StateType.Normal;
				}
		}

		protected virtual void OnCmdDice4Clicked (object sender, System.EventArgs e)
		{
			if(blnAllowHold != false)
			 {		 	
				if(lblHold4.Text == "")
					lblHold4.Text = "Hold";
				else
					lblHold4.Text = "";
					
					Gtk.Button mButton = (Gtk.Button)sender;
					mButton.State = Gtk.StateType.Normal;
				}
		}

		protected virtual void OnCmdDice5Clicked (object sender, System.EventArgs e)
		{
			if(blnAllowHold != false)
			 {		 	
				if(lblHold5.Text == "")
					lblHold5.Text = "Hold";
				else
					lblHold5.Text = "";
					
					Gtk.Button mButton = (Gtk.Button)sender;
					mButton.State = Gtk.StateType.Normal;
				}
		}

		
		#endregion
		
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
		 		frmError eForm = new frmError(ex.ToString());
			 	eForm.Show();
		 	}
			return false;
						
		}
		
		private void IsFinished()
		{
			
			try
			{
				bool IsFinished = true;
				Gtk.Frame mFrame;
				// iterate through all of the panel that make up the score card
				// with the exception of Yahtzee Bonus which can be blank
				// if they are all filled then the game is finished
				for(int i = 0;i<=5;i++)
			    {
			    	for(int j = 1; j <=5; j++)
			    	{
			    			mFrame = FindFrame("r" + i.ToString() + "c" + j.ToString());
					    	
					    	// if there is a button and not a lable that means the score card is not full 
			    			if(mFrame.Child.GetType() == typeof(Gtk.Button))
				    					IsFinished = false;
			    			
			    	}
			    }
				
				for(int i = 9;i<=15;i++)
			    {
			    	for(int j = 1; j <=5; j++)
			    	{
			    			mFrame = FindFrame("r" + i.ToString() + "c" + j.ToString());
					    	
					    	// if there is a button and not a lable that means the score card is not full 
			    			if(mFrame.Child.GetType() == typeof(Gtk.Button))
				    					IsFinished = false;
			    			
			    	}
			    }
			    
				if(IsFinished == true)
				{
					mIsFinished = true;
					this.SaveGameData();
					this.SaveScoreCard();
					int tmpScore = 0;
					Gtk.Label mLabel;
					string pnlName;
					for(int i = 1; i <= 5; i++)
					{
						pnlName = "r19c" + i.ToString();
						mFrame = (Gtk.Frame)FindFrame(pnlName);
						if(mFrame.Child.GetType() == typeof (Gtk.Label))
						{
							mLabel =  (Gtk.Label)mFrame.Child;
							if(mLabel.Text != "")
								tmpScore += int.Parse(mLabel.Text);							
						}
					}					
				
					// bring up the "your finished" form to give the user
					// the final score and ask for a new game
					dlgFinished fm = new dlgFinished();
					fm.SetPlayerName(this.txtPlayerName.Text);
					fm.SetScore(tmpScore.ToString());
					ResponseType result = (ResponseType)fm.Run ();
                 	if (result == ResponseType.Yes)
                 	{
						// get rid of the data in the current scorecare.
						
						// set all the neccisary labels on the score card to the
						// default button
						
						// upper scord card buttons
						for(int i = 0;i<=5;i++)
					    {
					    	for(int j = 1; j <=5; j++)
					    	{
					    		mFrame = FindFrame("r" + i.ToString() + "c" + j.ToString());
					    		if(mFrame.Child.GetType() == typeof(Gtk.Label))
					    		{
					    			mFrame.Child.Destroy();
					    			mFrame.Add(DefaultButton());
					    			
					    		}
								
					    	}
					    }
					    
					    // lower scord card buttons
						for(int i = 9;i<=16;i++)
					    {
					    	for(int j = 1; j <=5; j++)
					    	{
					    		mFrame = FindFrame("r" + i.ToString() + "c" + j.ToString());
					    		if(mFrame.Child.GetType() == typeof(Gtk.Label))
					    		{
					    			mFrame.Child.Destroy();
					    			mFrame.Add(DefaultButton());
					    			
					    		}
								
					    	}
					    }
					    
					    // clear the labels
					    // upper scord card labels
						for(int i = 6;i<=8;i++)
					    {
					    	for(int j = 1; j <=5; j++)
					    	{
					    		mLabel = FindControl("r" + i.ToString() + "c" + j.ToString(), true);
					    		mLabel.Text = "";
					    		
					    	}
					    }
					    
					    // clear the labels
					    // lower scord card labels
						for(int i = 17;i<=19;i++)
					    {
					    	for(int j = 1; j <=5; j++)
					    	{
					    		mLabel = FindControl("r" + i.ToString() + "c" + j.ToString(), false);
					    		mLabel.Text = "";
					    		
					    	}
					    }
					    
						GameNumber = 0;
						dsScoreCard.Clear();
						InitScoreCard();
						SetEnabled(true);
						IsGameSaved = false;
						NewRollGroup();
					}
					else if (result == ResponseType.No)
					{
						Gtk.Application.Quit();
					}
				}
			}
			catch(System.Exception ex)
		 	{
		 		frmError eForm = new frmError(ex.ToString());
			 	eForm.Show();
		 	}
		}
		

	}
}
