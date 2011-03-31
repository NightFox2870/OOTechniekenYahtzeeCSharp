// dlgFinished.cs created with MonoDevelop
// User: andy at 6:55 PM 11/25/2007
//
// To change standard headers go to Edit->Preferences->Coding->Standard Headers
//

using System;

namespace YahtzeeSharp
{
	
	
	public partial class dlgFinished : Gtk.Dialog
	{
		
		public dlgFinished()
		{
			this.Build();
			this.cmdYes.GrabFocus();
		}

		protected virtual void OnCmdNoClicked (object sender, System.EventArgs e)
		{
			this.Dispose();
			this.Visible = false;
		}

		protected virtual void OnCmdYesClicked (object sender, System.EventArgs e)
		{
			this.Dispose();
			this.Visible = false;
		}
		
		public void SetPlayerName(string strPlayerName)
		{
			this.lblPlayerName.Text = strPlayerName;
		}
		
		public void SetScore(string strScore)
		{
			this.lblScore.Text = strScore;
		}
	}
}
