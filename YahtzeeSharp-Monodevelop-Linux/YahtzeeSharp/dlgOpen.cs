
using System;
using System.Data;
using System.IO;
using Gtk;

namespace YahtzeeSharp
{
	
	/// <summary>
	/// Dialog to manged and open games
	/// </summary>
	public partial class dlgOpen : Gtk.Dialog
	{
		private Gtk.TreeModelFilter filter;
		private static string SavePath = System.Environment.GetEnvironmentVariable("HOME") + "/.YahtzeeSharp/";
		private DataSet ds = new DataSet();
		private frmMain mParent;
		
		/// <summary>
		///  the main function for the open game dialog
		/// also set up the treeview and its elements
		/// </summary>
		public  dlgOpen()
		{
			Build();
			#region "Tree Layout"
			//
			// Open TreeView
			//
			

			// Create a column for the game ID title
			Gtk.TreeViewColumn colGameID = new Gtk.TreeViewColumn ();
			colGameID.Alignment = 0.5f;
			colGameID.Title = "ID";

			// Create a column for the player name title
			Gtk.TreeViewColumn colPlayerName = new Gtk.TreeViewColumn ();
			colPlayerName.Title = "Player Name";

			Gtk.TreeViewColumn colScore = new Gtk.TreeViewColumn ();
			colScore.Alignment = 0.5f;
			colScore.Title = "Score";
			
			// Create a column for the date title
			Gtk.TreeViewColumn colDate = new Gtk.TreeViewColumn ();
			colDate.Alignment = 0.5f;
			colDate.Title = "Date";
			
			// Create a column for the date title
			Gtk.TreeViewColumn colComplete = new Gtk.TreeViewColumn ();
			colComplete.Alignment = 0.5f;
			colComplete.Visible =false;
			colComplete.Title = "Finished";

			
			// Add the columns to the TreeView
			gvOpen.AppendColumn(colGameID);
			gvOpen.AppendColumn (colPlayerName);
			colPlayerName.Expand = true;
		  	gvOpen.AppendColumn (colScore);
			gvOpen.AppendColumn (colDate);
			gvOpen.AppendColumn (colComplete);
		 
		  	// set up the columns
		  	Gtk.CellRendererText cellGameID = new Gtk.CellRendererText ();
		  	cellGameID.Width = 25;
		  	cellGameID.Xalign = 0.5f;
		 	 colGameID.PackStart (cellGameID, true);
			
			Gtk.CellRendererText cellPlayerName = new Gtk.CellRendererText ();
		  	cellPlayerName.Width = 150;
		  	 colPlayerName.PackStart (cellPlayerName, true);
			
			Gtk.CellRendererText cellScore = new Gtk.CellRendererText ();
		  	cellScore.Width = 65;
		  	cellScore.Xalign = 1.0f;
		 	 colScore.PackStart (cellScore, true);
			
			Gtk.CellRendererText cellDate = new Gtk.CellRendererText ();
		  	cellDate.Width = 75;
		  	cellDate.Xalign =1.0f;
		 	 colDate.PackStart (cellDate, true);
			
			Gtk.CellRendererToggle cellComplete= new Gtk.CellRendererToggle ();
		  	cellComplete.Xalign =0.5f;
		  	cellComplete.Sensitive = true;
		 	 colComplete.PackStart (cellComplete, true);
			 
			// Tell the Cell Renderers which item(frmMain)s in the model to display
			colGameID.AddAttribute (cellGameID, "text", 0);
			colPlayerName.AddAttribute (cellPlayerName, "text", 1);
			colScore.AddAttribute (cellScore, "text", 2);
			colDate.AddAttribute (cellDate, "text", 3);
			colComplete.AddAttribute (cellComplete, "active", 4);
			
			#endregion
			
			gvOpen.Model = LoadTree();
		}

		private Gtk.TreeModelFilter  LoadTree()
				{
					
					ListStore mModel = new ListStore(typeof(string),typeof(string),typeof(string), typeof(string));
					try
					{
						ds.Clear();
						
						if(File.Exists(SavePath + "GameData.xml"))
							ds.ReadXml(SavePath + "GameData.xml");
						
						if(ds.Tables.Count > 0)
						{
							
							
							if(ds.Tables["dtGameData"].Rows.Count <1)
							{								
	     						MessageDialog md = new MessageDialog (this, DialogFlags.DestroyWithParent, MessageType.Info,  ButtonsType.Ok, "No Games have been saved at this time.");
	     						md.Run ();
	     						md.Destroy();
	     						this.Visible = false;
	     						this.ShowAll();
								this.Destroy();
							}
							
					     	foreach(DataRow dr in ds.Tables["dtGameData"].Rows)
					     	{
					     		DateTime mDate = DateTime.Parse(dr[3].ToString());
					     		mModel.AppendValues(dr.ItemArray[0].ToString(),dr.ItemArray[1].ToString(), dr.ItemArray[2].ToString(), mDate.ToShortDateString(), Convert.ToBoolean(dr.ItemArray[4].ToString()));
					     	}
					     	
					     	// Instead of assigning the ListStore model directly to the TreeStore, we create a TreeModelFilter
							// which sits between the Model (the ListStore) and the View (the TreeView) filtering what the model sees.
							// Some may say that this is a "Controller", even though the name and usage suggests that it is still part of
							// the Model.
							filter = new Gtk.TreeModelFilter (mModel, null);
							
							// Specify the function that determines which rows to filter out and which ones to display
							filter.VisibleFunc = new Gtk.TreeModelFilterVisibleFunc (FilterTree);
							
					      }
					      else
					      {
					      		MessageDialog md = new MessageDialog (this, DialogFlags.DestroyWithParent, MessageType.Info,  ButtonsType.Ok, "No Games have been saved at this time.");
	     						md.Run ();
	     						md.Destroy();
	     						this.Visible = false;
	     						this.ShowAll();
								this.Destroy();
								
						 }
				      }
				     catch(System.Exception ex)
				 	{
				 		frmError eForm = new frmError(ex.ToString());
				 		eForm.Show();
				 	}
				 	return filter;
				
				}

				private bool FilterTree (Gtk.TreeModel model, Gtk.TreeIter iter)
				{
					string PlayerName = model.GetValue (iter, 1).ToString();
			 		PlayerName = PlayerName.ToLower();
			 	
					if (txtFilter.Text == "")
						return true;
			 
					if (PlayerName.IndexOf (txtFilter.Text.ToLower()) > -1)
						return true;
					else
						return false;
				}
				
				
		protected virtual void OnBtnCloseClicked(object sender, System.EventArgs e)
		{
				this.Destroy();
		}

		protected virtual void OnBtnClearFilterClicked(object sender, System.EventArgs e)
		{
			txtFilter.Text = "";
		}

		protected virtual void OnTxtFilterChanged(object sender, System.EventArgs e)
		{
				filter.Refilter();
		}
		
		public void SetParent(frmMain mf)
		{
			mParent = mf;
		}
				
		/// <summary>
		///  a function to delete a game from the game data grid
		/// </summary>
		protected virtual void OnBtnDeleteClicked(object sender, System.EventArgs e)
		{
				try
			  	{
					string GameID = null;
					string UserName = null;
					TreeModel model;
					TreeIter mIter; 
					int i = 0;
					
					if(gvOpen.Selection.GetSelected (out model, out mIter)) 
					{
						i = gvOpen.Model.GetPath(mIter).Indices[0]; 
						UserName = gvOpen.Model.GetValue(mIter, 1).ToString();
						GameID = gvOpen.Model.GetValue(mIter, 0).ToString();
					} 
			  		
			  		MessageDialog md = new MessageDialog (this, DialogFlags.Modal, MessageType.Question,  ButtonsType.YesNo, "Are you sure you want to delete\n\r the game for " + UserName + "?", "DELETE?");

						ResponseType result = (ResponseType)md.Run ();
						if (result == ResponseType.Yes)
	                 	{
	                 		// remove the game from the game data file
	                 		DataRow dr = ds.Tables["dtGameData"].Rows[i];
	                 		dr.Delete();
	                 		
	                 		ds.WriteXml(SavePath + "GameData.xml");
	                 		
	                 		// remove the scorecard data from the saves folder
	                 		string SaveFile =  SavePath +  @"/saves/g" + GameID.ToString() + ".xml";
	                 		if(File.Exists(SaveFile))
	                 			File.Delete(SaveFile);
	                 			
	                 		gvOpen.Model = LoadTree();
	                 	}
	                 	
					md.Destroy();
	                 	
				  	
            	}
            	 catch(System.Exception ex)
			 	{
			 		frmError eForm = new frmError(ex.ToString());
			 		eForm.Show();
			 	}
			
		
		}

		/// <summary>
		///  Set the game we are looking to open returns the values needed to open a game
		///  and destoys the existing form.
		/// </summary>
		protected virtual void OnBtnOpenClicked(object sender, System.EventArgs e)
		{
			try
			  	{
					string GameID = null;
					string UserName = null;
					TreeModel model;
					TreeIter mIter;
					if(gvOpen.Selection.GetSelected (out model, out mIter)) 
					{
						UserName = gvOpen.Model.GetValue(mIter, 1).ToString();
						GameID = gvOpen.Model.GetValue(mIter, 0).ToString();
						this.Respond(Gtk.ResponseType.Ok);
								
						mParent.SetGameNumber(int.Parse(GameID), UserName, true);
						this.Destroy();
					} 					  	
            	}
            	 catch(System.Exception ex)
			 	{
			 		frmError eForm = new frmError(ex.ToString());
			 		eForm.Show();
			 	}
		}

		protected virtual void OnCbxOnlyUnfinishedActivated (object sender, System.EventArgs e)
		{
		}

		
	}
}
