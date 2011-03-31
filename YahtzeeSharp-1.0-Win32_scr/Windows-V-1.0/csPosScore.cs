/*
 * Created by SharpDevelop.
 * User: Spoody Goon
 * Date: 1/13/2007
 * Time: 7:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Data;
using System.Windows.Forms;

namespace YahtzeeSharp
{
	/// <summary>
	/// Description of csPosScore.
	/// </summary>
	public class csPosScore
	{
		private int[] dice = new int[5];
		private bool mYahtzeeBonus = false;
		private static string mVersion = "Alpha 0.2";
		
		public csPosScore(int d1, int d2, int d3, int d4 , int d5, bool tYahtzeeBonus)
		{
			dice[0] = d1;
			dice[1] = d2;
			dice[2] = d3;
			dice[3] = d4;
			dice[4] = d5;
			mYahtzeeBonus = tYahtzeeBonus;
			
		}
		
		public DataSet SetReturnOptions()
		{
			DataSet ds = dsResults();
			try
			{
				int Ones = 0;
				int Twos = 0;
				int Threes = 0;
				int Fours = 0;
				int Fives = 0;
				int Sixes = 0;
				
				foreach(int mD in dice)
				{
					if(mD == 1)
						Ones++;
					if(mD ==2)
						Twos++;
					if(mD == 3)
						Threes++;
					if(mD == 4)
						Fours++;
					if(mD == 5)
						Fives++;
					if(mD == 6)
						Sixes++;
				}
				
				DataTable dt = ds.Tables["dtResults"];
				DataRow dr;
				
				// is it a Yahtzee Bonus
				if(((Ones == 5)||(Twos == 5)||(Threes == 5) || (Fours == 5) ||(Fives == 5) || (Sixes == 5)) && (mYahtzeeBonus == true))
				{
					dr = dt.NewRow();
					dr["colResults"] = "YAHTZEE BONUS";
					dr["colValue"] = "100";
					dt.Rows.Add(dr);
				}
				
				// is it a Yahtzee
				if(((Ones == 5)||(Twos == 5)||(Threes == 5) || (Fours == 5) ||(Fives == 5) || (Sixes == 5)) && (mYahtzeeBonus == false))
				{
					dr = dt.NewRow();
					dr["colResults"] = "YAHTZEE";
					dr["colValue"] = "50";
					dt.Rows.Add(dr);
				}
				
				// is it a large straight
				if(((Ones == 1)&&(Twos == 1)&&(Threes == 1) && (Fours == 1) &&(Fives == 1)) ||((Twos == 1)&&(Threes == 1) && (Fours == 1) &&(Fives == 1)&& (Sixes == 1)))
				{
					dr = dt.NewRow();
					dr["colResults"] = "Large Straight";
					dr["colValue"] = "40";
					dt.Rows.Add(dr);
				}
				
				// is it a small straight
				if(((Ones >= 1)&&(Twos >= 1)&&(Threes >= 1) && (Fours >= 1)) ||((Twos >= 1)&&(Threes >= 1) && (Fours >= 1) &&(Fives >= 1)) || ((Threes >= 1) && (Fours >= 1) &&(Fives >= 1) && (Sixes >= 1)))
				{
					dr = dt.NewRow();
					dr["colResults"] = "Small Straight";
					dr["colValue"] = "30";
					dt.Rows.Add(dr);
				}
				
				
				// is it a 4 or a kind
				if((Ones >= 4)||(Twos >= 4)||(Threes >= 4) || (Fours >= 4) ||(Fives >= 4) || (Sixes >= 4))
				{
					dr = dt.NewRow();
					dr["colResults"] = "4 Of a Kind";
					dr["colValue"] = ((Ones * 1) + (Twos * 2) + (Threes * 3) + (Fours * 4) + (Fives* 5) + (Sixes * 6)).ToString();
					dt.Rows.Add(dr);
				}	
				
				// is it a 3 of a kind
				if((Ones >= 3)||(Twos >= 3)||(Threes >= 3) || (Fours >= 3) ||(Fives >= 3) || (Sixes >= 3))
				{
					dr = dt.NewRow();
					dr["colResults"] = "3 Of a Kind";
					dr["colValue"] = ((Ones * 1) + (Twos * 2) + (Threes * 3) + (Fours * 4) + (Fives* 5) + (Sixes * 6)).ToString();
					dt.Rows.Add(dr);
				}
				
				// is it a full house
				if(((Ones == 3)||(Twos == 3)||(Threes == 3) || (Fours == 3) ||(Fives == 3) || (Sixes == 3)) && ((Ones == 2)||(Twos == 2)||(Threes == 2) || (Fours == 2) ||(Fives == 2) || (Sixes == 2)))
				{
					dr = dt.NewRow();
					dr["colResults"] = "Full House";
					dr["colValue"] = "25";
					dt.Rows.Add(dr);
				}
				
				if(Sixes > 0)
				{
					dr = dt.NewRow();
					dr["colResults"] = "Sixes";
					dr["colValue"] = (Sixes * 6).ToString();
					dt.Rows.Add(dr);
				}
				if(Fives > 0)
				{
					dr = dt.NewRow();
					dr["colResults"] = "Fives";
					dr["colValue"] = (Fives * 5).ToString();
					dt.Rows.Add(dr);
				}
				if(Fours > 0)
				{
					dr = dt.NewRow();
					dr["colResults"] = "Fours";
					dr["colValue"] = (Fours * 4).ToString();
					dt.Rows.Add(dr);
				}
				if(Threes > 0)
				{
					dr = dt.NewRow();
					dr["colResults"] = "Threes";
					dr["colValue"] = (Threes * 3).ToString();
					dt.Rows.Add(dr);
				}
				if(Twos > 0)
				{
					dr = dt.NewRow();
					dr["colResults"] = "Twos";
					dr["colValue"] = (Twos * 2).ToString();
					dt.Rows.Add(dr);
				}
				
				if(Ones > 0)
				{
					dr = dt.NewRow();
					dr["colResults"] = "Ones";
					dr["colValue"] = (Ones * 1).ToString();
					dt.Rows.Add(dr);
				}
				
				dr = dt.NewRow();
				dr["colResults"] = "Chance";
				dr["colValue"] = ((Ones * 1) + (Twos * 2) + (Threes * 3) + (Fours * 4) + (Fives* 5) + (Sixes * 6)).ToString();
				dt.Rows.Add(dr);
				dr = dt.NewRow();
				dr["colResults"] = "Scratch";
				dr["colValue"] = 0;
				dt.Rows.Add(dr);
				dt.DefaultView.Sort="colValue DESC";
			}
			catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
			
			
			return ds;
		}
		
		private DataSet dsResults()
		{
			DataSet ds = new DataSet();
			try
			{
				// Create the dataset that will mimic the score card
				// the first row is a unique string for using find
				// the value of the first row coresponds to the score card
				DataTable dt = new DataTable("dtResults");
				DataColumn dc = new DataColumn("colResults", System.Type.GetType("System.String"));
				DataColumn dc2 = new DataColumn("colValue", System.Type.GetType("System.Int32"));
				DataColumn[] PriKey = new DataColumn[1] { dc};
				dt.Columns.Add(dc);
				dt.Columns.Add(dc2);
				dt.PrimaryKey = PriKey;
				ds.Tables.Add(dt);
				
			}
			catch(System.Exception ex)
		 	{
		 		EmailError.frmError eForm = new EmailError.frmError(ex.ToString(), mVersion);
		 		eForm.ShowDialog();
		 	}
			return ds;
		}
			
	}
}
