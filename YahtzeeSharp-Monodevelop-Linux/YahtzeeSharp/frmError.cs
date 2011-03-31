
using System;
using System.Windows.Forms;
using System.Configuration;

namespace YahtzeeSharp
{
	
	
	public partial class frmError : Gtk.Dialog
	{
		
		public frmError(string mError)
		{
			Build();
			 this.txtErrorDetails.Buffer.Text = "Version: 0.1.0- beta"  + "\n\r" + "-------------------------------------------------------\n\r" + mError;
		}

		protected virtual void OnBtnEmailClicked(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("mailto:yarrith.devos@student.kdg.be");
		}

		protected virtual void OnButton1Clicked(object sender, System.EventArgs e)
		{
			this.Destroy();
		}

		public virtual void OnBtnCopyErrorTextClicked(object sender, System.EventArgs e)
		{
			Gtk.Clipboard mClip = Gtk.Clipboard.GetForDisplay(Gdk.Display.Default, Gdk.Atom.Intern("CLIPBOARD", true));
			mClip.Text = this.txtErrorDetails.Buffer.Text;
		}
	}
}
