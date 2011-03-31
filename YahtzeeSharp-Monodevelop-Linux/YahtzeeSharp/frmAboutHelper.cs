
using System;

namespace YahtzeeSharp
{
	
	
	public partial class frmAboutHelper : Gtk.Window
	{
		
		
		public frmAboutHelper(string mTextFile, string mTitle) : 
				base(Gtk.WindowType.Toplevel)
		{
			Build();
			
			try
			{
				this.Title = mTitle;
				System.IO.StreamReader sr = new System.IO.StreamReader(mTextFile);
				Gtk.TextBuffer mBuff = txtText.Buffer;
				mBuff.Text = sr.ReadToEnd();
			}
			catch(System.Exception ex)
		 	{
		 		frmError eForm = new frmError(ex.ToString());
		 		eForm.Show();
		 	}
			
		}

				protected virtual void OnBtnOkClicked(object sender, System.EventArgs e)
				{
					this.Destroy();
				}
		
	}
}
