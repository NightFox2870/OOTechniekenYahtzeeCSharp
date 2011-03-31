/*
 * Created by SharpDevelop.
 * User: Spoody Goon
 * Date: 2/9/2007
 * Time: 9:48 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace YahtzeeSharp
{
	/// <summary>
	/// Description of frmAboutHelper.
	/// </summary>
	public partial class frmAboutHelper : Form
	{
		public frmAboutHelper(string mFile, string mTitle)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.Text = mTitle;
            if (File.Exists(mFile))
                rtbReleaseNotes.LoadFile(mFile);

            rtbReleaseNotes.Refresh();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnOkClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
