/*
 * Created by SharpDevelop.
 * User: Spoody Goon
 * Date: 2/18/2007
 * Time: 5:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace YahtzeeSharp
{
	/// <summary>
	/// Description of frmFinish.
	/// </summary>
	public partial class frmFinish : Form
	{
		public frmFinish(string tScore)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			lblScore.Text = tScore;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnNewGameClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnNoNewGameClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
