
using System;
using System.Configuration;

namespace YahtzeeSharp
{
	
	public partial class frmAbout : Gtk.Dialog
	{
		private string AppPath = System.Windows.Forms.Application.StartupPath;
		
		public frmAbout()
		{
			Build();	
		}

		protected virtual void OnBtnChangeLogClicked(object sender, System.EventArgs e)
		{
			frmAboutHelper fm = new frmAboutHelper(AppPath + "/docs/change-log.txt", "Change Log");
            fm.Show();
		}

		protected virtual void OnBtnKnownIssuesClicked(object sender, System.EventArgs e)
		{
			frmAboutHelper fm = new frmAboutHelper(AppPath  + "/docs/known-issues.txt", "Known Issues");
            fm.Show();
		}

		protected virtual void OnBtnLicenceTextClicked(object sender, System.EventArgs e)
		{
			frmAboutHelper fm = new frmAboutHelper(AppPath + "/docs/gpl.txt", "GPL License Text");
            fm.Show();
		}

		protected virtual void OnBtnOkClicked(object sender, System.EventArgs e)
		{
			this.Destroy();
		}
	}
	
}
