/*
 * Created by: Yarrith Devos, Vladimir Popovic
 * Date: 01/12/2010
 */

using System;
using Gtk;
using System.Windows.Forms;

namespace YahtzeeSharp
{
	/// <summary>
	/// Description of csPosScore.
	/// </summary>
	public class csPosScore
	{
		private int[] dice = new int[5];
		private bool YahtzeeBonus = false;
			
		///<summary>
		/// set up the layout of the dice
		///</summary>
		public csPosScore(int[] tDice, bool YahtzeeBonus)
		{
			dice[0] = tDice[0] + 1;
			dice[1] = tDice[1] + 1;
			dice[2] = tDice[2] + 1;
			dice[3] = tDice[3] + 1;
			dice[4] = tDice[4] + 1;
			this.YahtzeeBonus = YahtzeeBonus;
		}
		
		/// <summary>
		/// cacluates the values that will be usable to select from 
        /// based on the roll
		/// </summary>
		/// <returns>
		/// A <see cref="ListStore"/>
		/// </returns>
		public ListStore SetReturnOptions()
		{
			Gtk.ListStore mListStore = new Gtk.ListStore(typeof (string), typeof (string));
			string tmpScore = null;
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
				
								
				// is it a Yahtzee Bonus
				if(((Ones == 5)||(Twos == 5)||(Threes == 5) || (Fours == 5) ||(Fives == 5) || (Sixes == 5)) && (YahtzeeBonus == true))
				{
					mListStore.AppendValues("YAHTZEE BONUS", "100");
					
				}
				
				// is it a Yahtzee
				if(((Ones == 5)||(Twos == 5)||(Threes == 5) || (Fours == 5) ||(Fives == 5) || (Sixes == 5)) && (YahtzeeBonus == false))
				{
					mListStore.AppendValues("YAHTZEE", "50");
					
				}
				
				// is it a large straight
				if(((Ones == 1)&&(Twos == 1)&&(Threes == 1) && (Fours == 1) &&(Fives == 1)) ||((Twos == 1)&&(Threes == 1) && (Fours == 1) &&(Fives == 1)&& (Sixes == 1)))
				{
					mListStore.AppendValues("Large Straight", "40");
					
				}
				
				// is it a small straight
				if(((Ones >= 1)&&(Twos >= 1)&&(Threes >= 1) && (Fours >= 1)) ||((Twos >= 1)&&(Threes >= 1) && (Fours >= 1) &&(Fives >= 1)) || ((Threes >= 1) && (Fours >= 1) &&(Fives >= 1) && (Sixes >= 1)))
				{
					mListStore.AppendValues("Small Straight", "30");
					
				}
				
				
				// is it a 4 or a kind
				if((Ones >= 4)||(Twos >= 4)||(Threes >= 4) || (Fours >= 4) ||(Fives >= 4) || (Sixes >= 4))
				{
					tmpScore = ((Ones * 1) + (Twos * 2) + (Threes * 3) + (Fours * 4) + (Fives* 5) + (Sixes * 6)).ToString();
					mListStore.AppendValues("4 Of a Kind", tmpScore);
					
				}	
				
				// is it a 3 of a kind
				if((Ones >= 3)||(Twos >= 3)||(Threes >= 3) || (Fours >= 3) ||(Fives >= 3) || (Sixes >= 3))
				{
					tmpScore = ((Ones * 1) + (Twos * 2) + (Threes * 3) + (Fours * 4) + (Fives* 5) + (Sixes * 6)).ToString();
					mListStore.AppendValues("3 Of a Kind", tmpScore);
					
				}
				
				// is it a full house
				if(((Ones == 3)||(Twos == 3)||(Threes == 3) || (Fours == 3) ||(Fives == 3) || (Sixes == 3)) && ((Ones == 2)||(Twos == 2)||(Threes == 2) || (Fours == 2) ||(Fives == 2) || (Sixes == 2)))
				{
					mListStore.AppendValues("Full House", "25");
					
				}
				
				if(Sixes > 0)
				{
					mListStore.AppendValues("Sixes", (Sixes * 6).ToString());
					
				}
				if(Fives > 0)
				{
					mListStore.AppendValues("Fives", (Fives * 5).ToString());
					
				}
				if(Fours > 0)
				{
					mListStore.AppendValues("Fours", (Fours * 4).ToString());
					
				}
				if(Threes > 0)
				{
					mListStore.AppendValues("Threes", (Threes * 3).ToString());
					
				}
				if(Twos > 0)
				{
					mListStore.AppendValues("Twos", (Twos * 2).ToString());
					
				}
				
				if(Ones > 0)
				{
					mListStore.AppendValues("Ones", (Ones * 1).ToString());
					
				}
				
				tmpScore = ((Ones * 1) + (Twos * 2) + (Threes * 3) + (Fours * 4) + (Fives* 5) + (Sixes * 6)).ToString();
				mListStore.AppendValues("Chance", tmpScore);
				mListStore.AppendValues("Scratch", "0");
				
				
			}
			catch(System.Exception ex)
		 	{
		 		frmError eForm = new frmError(ex.ToString());
		 		eForm.Show();
		 	}
			
			
			return mListStore;
		}
		
		
	}
}
