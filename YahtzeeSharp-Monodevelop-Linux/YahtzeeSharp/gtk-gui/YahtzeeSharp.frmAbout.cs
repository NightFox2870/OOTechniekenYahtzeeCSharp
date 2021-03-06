
// This file has been generated by the GUI designer. Do not modify.
namespace YahtzeeSharp
{
	public partial class frmAbout
	{
		private global::Gtk.HBox hbox2;

		private global::Gtk.VBox vbox4;

		private global::Gtk.Image image3;

		private global::Gtk.Button btnChangeLog;

		private global::Gtk.Button btnKnownIssues;

		private global::Gtk.Button btnLicenceText;

		private global::Gtk.VBox vbox5;

		private global::Gtk.Label label4;

		private global::Gtk.Label lblVersion;

		private global::Gtk.Label label6;

		private global::Gtk.Label label3;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.Frame frame1;

		private global::Gtk.TextView textview1;

		private global::Gtk.Button btnOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget YahtzeeSharp.frmAbout
			this.WidthRequest = 450;
			this.HeightRequest = 300;
			this.Events = ((global::Gdk.EventMask)(256));
			this.Name = "YahtzeeSharp.frmAbout";
			this.Title = global::Mono.Unix.Catalog.GetString ("About Yahtzee Sharp");
			this.Icon = global::Gdk.Pixbuf.LoadFromResource ("YSlogo.png");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.BorderWidth = ((uint)(2));
			this.Resizable = false;
			this.AllowGrow = false;
			this.DefaultWidth = 450;
			this.DefaultHeight = 300;
			this.DestroyWithParent = true;
			this.SkipPagerHint = true;
			this.SkipTaskbarHint = true;
			// Internal child YahtzeeSharp.frmAbout.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Events = ((global::Gdk.EventMask)(256));
			w1.Name = "dialog_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog_VBox.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			// Container child vbox4.Gtk.Box+BoxChild
			this.image3 = new global::Gtk.Image ();
			this.image3.Name = "image3";
			this.image3.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("YSlogo.png");
			this.vbox4.Add (this.image3);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.image3]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			w2.Padding = ((uint)(13));
			// Container child vbox4.Gtk.Box+BoxChild
			this.btnChangeLog = new global::Gtk.Button ();
			this.btnChangeLog.HeightRequest = 26;
			this.btnChangeLog.CanFocus = true;
			this.btnChangeLog.Name = "btnChangeLog";
			this.btnChangeLog.UseUnderline = true;
			this.btnChangeLog.Label = global::Mono.Unix.Catalog.GetString ("Change Log");
			this.vbox4.Add (this.btnChangeLog);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.btnChangeLog]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.btnKnownIssues = new global::Gtk.Button ();
			this.btnKnownIssues.HeightRequest = 26;
			this.btnKnownIssues.CanFocus = true;
			this.btnKnownIssues.Name = "btnKnownIssues";
			this.btnKnownIssues.UseUnderline = true;
			this.btnKnownIssues.Label = global::Mono.Unix.Catalog.GetString ("Known Issues");
			this.vbox4.Add (this.btnKnownIssues);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.btnKnownIssues]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			w4.Padding = ((uint)(5));
			// Container child vbox4.Gtk.Box+BoxChild
			this.btnLicenceText = new global::Gtk.Button ();
			this.btnLicenceText.HeightRequest = 26;
			this.btnLicenceText.CanFocus = true;
			this.btnLicenceText.Name = "btnLicenceText";
			this.btnLicenceText.UseUnderline = true;
			this.btnLicenceText.Label = global::Mono.Unix.Catalog.GetString ("  GPL Licence Text  ");
			this.vbox4.Add (this.btnLicenceText);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.btnLicenceText]));
			w5.Position = 3;
			w5.Expand = false;
			w5.Fill = false;
			this.hbox2.Add (this.vbox4);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox4]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.BorderWidth = ((uint)(9));
			// Container child vbox5.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Ypad = 3;
			this.label4.LabelProp = "Yahtzee Sharp - Mono";
			this.vbox5.Add (this.label4);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.label4]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.lblVersion = new global::Gtk.Label ();
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Ypad = 3;
			this.lblVersion.LabelProp = "Version: 0.1.0- Beta";
			this.vbox5.Add (this.lblVersion);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.lblVersion]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Ypad = 3;
			this.label6.LabelProp = "License: GPL";
			this.vbox5.Add (this.label6);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.label6]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Ypad = 3;
			this.label3.LabelProp = "  Yarrith Devos";
			this.vbox5.Add (this.label3);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.label3]));
			w10.Position = 3;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.WidthRequest = 250;
			this.hseparator1.HeightRequest = 10;
			this.hseparator1.Name = "hseparator1";
			this.vbox5.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hseparator1]));
			w11.Position = 4;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			this.frame1.BorderWidth = ((uint)(2));
			// Container child frame1.Gtk.Container+ContainerChild
			this.textview1 = new global::Gtk.TextView ();
			this.textview1.Buffer.Text = "\nAn open source Yahtzee game written in C#\n\nIntended to be laid out exactly like the game we all used to play around the kitchen table.\n\n";
			this.textview1.Sensitive = false;
			this.textview1.CanFocus = true;
			this.textview1.Name = "textview1";
			this.textview1.Editable = false;
			this.textview1.AcceptsTab = false;
			this.textview1.WrapMode = ((global::Gtk.WrapMode)(2));
			this.textview1.PixelsAboveLines = 3;
			this.frame1.Add (this.textview1);
			this.vbox5.Add (this.frame1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.frame1]));
			w13.Position = 5;
			this.hbox2.Add (this.vbox5);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox5]));
			w14.Position = 1;
			w1.Add (this.hbox2);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(w1[this.hbox2]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Internal child YahtzeeSharp.frmAbout.ActionArea
			global::Gtk.HButtonBox w16 = this.ActionArea;
			w16.Events = ((global::Gdk.EventMask)(256));
			w16.Name = "YahtzeeSharp.frmAbout_ActionArea";
			w16.Spacing = 10;
			w16.BorderWidth = ((uint)(5));
			w16.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(1));
			// Container child YahtzeeSharp.frmAbout_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.btnOk = new global::Gtk.Button ();
			this.btnOk.HeightRequest = 31;
			this.btnOk.CanDefault = true;
			this.btnOk.CanFocus = true;
			this.btnOk.Name = "btnOk";
			this.btnOk.Label = global::Mono.Unix.Catalog.GetString (" Ok ");
			this.AddActionWidget (this.btnOk, 0);
			global::Gtk.ButtonBox.ButtonBoxChild w17 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w16[this.btnOk]));
			w17.Expand = false;
			w17.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.btnChangeLog.Clicked += new global::System.EventHandler (this.OnBtnChangeLogClicked);
			this.btnKnownIssues.Clicked += new global::System.EventHandler (this.OnBtnKnownIssuesClicked);
			this.btnLicenceText.Clicked += new global::System.EventHandler (this.OnBtnLicenceTextClicked);
			this.btnOk.Clicked += new global::System.EventHandler (this.OnBtnOkClicked);
		}
	}
}
