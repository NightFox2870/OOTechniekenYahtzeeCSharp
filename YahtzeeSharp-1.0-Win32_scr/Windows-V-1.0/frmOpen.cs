/*
 * Created by SharpDevelop.
 * User: Spoody Goon
 * Date: 1/20/2007
 * Time: 6:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.IO;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace YahtzeeSharp
{
	/// <summary>
	/// Description of frmOpen.
	/// </summary>
	public partial class frmOpen : Form
	{
		private static string mVersion = "1.0.0";
		public frmOpen()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void btnClearFilterClick(object sender, EventArgs e)
		{
			txtSearch.Text = "";
		}
		
		void TxtSearchTextChanged(object sender, EventArgs e)
		{
			SetFilter();
		}
		
		void FrmOpenLoad(object sender, EventArgs e)
		{
			try
			{
                gvOpen.Columns["GameID"].Visible = false;
				if(File.Exists("GameData.xml"))
					dsGameData.ReadXml("GameData.xml");
				
				gvOpen.DataSource = dsGameData;
				gvOpen.DataMember = "dtGameData";
				gvOpen.Refresh();
				if(dsGameData.Tables["dtGameData"].Rows.Count <1)
				{
					MessageBox.Show("No Games have been saved at this time.");
					this.Close();
				}
			}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
		}
		
		void GvOpenCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView gv = (DataGridView)sender;
				int mRow = e.RowIndex;
				int mCol = e.ColumnIndex;
                if (gvOpen.Columns[mCol].Name == "btnOpen")
				{
                    MainForm mf = new MainForm();
					mf.SetGameNumber(int.Parse(gv.Rows[mRow].Cells["GameID"].Value.ToString()), gv.Rows[mRow].Cells["PlayerName"].Value.ToString());
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
                 if (gvOpen.Columns[mCol].Name == "colDelete")
                 {	
                 	string GameID = dtGameData.Rows[mRow]["colGameID"].ToString();
                 	string UserName = dtGameData.Rows[mRow]["colPlayerName"].ToString();
                 	DialogResult dResult = MessageBox.Show("Are you sure you want to delete\n\r the game for " + UserName + "?", "DELETE?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                 	if(dResult == DialogResult.Yes)
                 	{
                 		// remove the game from the game data file
                 		DataRow dr = dsGameData.Tables["dtGameData"].Rows[mRow];
                 		dr.Delete();
                 		gvOpen.Refresh();
                 		dsGameData.WriteXml("GameData.xml");
                 		
                 		// remove the scorecard data from the saves folder
                 		string SaveFile = Application.StartupPath + @"\saves\g" + GameID + ".xml";
                 		if(File.Exists(SaveFile))
                 			File.Delete(SaveFile);
                 	}
				}
			}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
		}
		
		private void SetFilter()
		{
			try
			{
				string mFilter = null;
				if((this.txtSearch.Text.Trim() != "") && (this.cbxIsComplete.Checked == true))
				{
					mFilter = "colPlayerName LIKE '%" + this.txtSearch.Text + "%' AND colIsComplete = false";
				}
				else if((this.txtSearch.Text.Trim() != "") && (this.cbxIsComplete.Checked != true))
				{
					mFilter = "colPlayerName LIKE '%" + this.txtSearch.Text + "%'";
				}
				else if(this.cbxIsComplete.Checked == true)
				{
					mFilter = "colIsComplete = false";
				}
				this.dsGameData.Tables["dtGameData"].DefaultView.RowFilter = mFilter;
				if (this.dsGameData.Tables["dtGameData"].DefaultView.Count >  0)
		        {
		          gvOpen.DataSource = this.dsGameData.Tables["dtGameData"].DefaultView;
		        }
				gvOpen.Refresh();
			}
		 	catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
		}
		
		void CbxIsCompleteCheckedChanged(object sender, EventArgs e)
		{
			SetFilter();			
		}
	}
}
