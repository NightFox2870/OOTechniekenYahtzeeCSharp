/*
 * Created by: Yarrith Devos, Vladimir Popovich
 * Date: 01/12/2010
 */
using System;
using Gtk;

class MainClass
{
	public static void Main (string[] args)
	{
		Application.Init ();
		new YahtzeeSharp.frmMain ();
		Application.Run ();
	}
}