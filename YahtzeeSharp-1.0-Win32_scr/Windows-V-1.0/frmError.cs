/*
 * Created by SharpDevelop.
 * User: Spoody Goon
 * Date: 2/7/2007
 * Time: 8:18 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace EmailError
{
	/// <summary>
	/// Description of frmError.
	/// </summary>
	public partial class frmError : Form
	{
        private static string mVersion = null;
		public frmError(string mError, string tVersion)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			rtbError.Text = tVersion + "\n\r" + "-------------------------------------------------------\n\r" + mError;
            mVersion = tVersion;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnCopyErrorClick(object sender, EventArgs e)
		{
			Clipboard.Clear();
			string tmpString = this.rtbError.Text;
			Clipboard.SetText(this.rtbError.Text);
		}
		
		
		
		void LbnSendEmailLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string	EmailLink = "mailto:" + this.lbnSendEmail.Text;
        	System.Diagnostics.Process.Start(EmailLink);
		}
	}
}
