
// This file has been generated by the GUI designer. Do not modify.
namespace YahtzeeSharp
{
	public partial class dlgOpen
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Label lblfilter;

		private global::Gtk.Entry txtFilter;

		private global::Gtk.Button btnClearFilter;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.ScrolledWindow scrolledwindow1;

		private global::Gtk.TreeView gvOpen;

		private global::Gtk.HSeparator hseparator2;

		private global::Gtk.Button btnClose;

		private global::Gtk.Button btnOpen;

		private global::Gtk.Button btnDelete;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget YahtzeeSharp.dlgOpen
			this.Events = ((global::Gdk.EventMask)(256));
			this.Name = "YahtzeeSharp.dlgOpen";
			this.Title = global::Mono.Unix.Catalog.GetString ("Open");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.BorderWidth = ((uint)(4));
			// Internal child YahtzeeSharp.dlgOpen.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Events = ((global::Gdk.EventMask)(256));
			w1.Name = "dialog_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			// Container child hbox1.Gtk.Box+BoxChild
			this.lblfilter = new global::Gtk.Label ();
			this.lblfilter.WidthRequest = 48;
			this.lblfilter.Name = "lblfilter";
			this.lblfilter.LabelProp = "Filter";
			this.hbox1.Add (this.lblfilter);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.lblfilter]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			w2.Padding = ((uint)(8));
			// Container child hbox1.Gtk.Box+BoxChild
			this.txtFilter = new global::Gtk.Entry ();
			this.txtFilter.CanFocus = true;
			this.txtFilter.Name = "txtFilter";
			this.txtFilter.IsEditable = true;
			this.txtFilter.InvisibleChar = '●';
			this.hbox1.Add (this.txtFilter);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.txtFilter]));
			w3.Position = 1;
			w3.Padding = ((uint)(3));
			// Container child hbox1.Gtk.Box+BoxChild
			this.btnClearFilter = new global::Gtk.Button ();
			this.btnClearFilter.CanFocus = true;
			this.btnClearFilter.Name = "btnClearFilter";
			this.btnClearFilter.Label = "Clear Filter";
			this.hbox1.Add (this.btnClearFilter);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.btnClearFilter]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			w4.Padding = ((uint)(14));
			// Container child hbox1.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.WidthRequest = 100;
			this.hseparator1.Name = "hseparator1";
			this.hbox1.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.hseparator1]));
			w5.Position = 3;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			w6.Padding = ((uint)(7));
			// Container child vbox2.Gtk.Box+BoxChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			this.gvOpen = new global::Gtk.TreeView ();
			this.gvOpen.CanFocus = true;
			this.gvOpen.Name = "gvOpen";
			this.gvOpen.RulesHint = true;
			this.scrolledwindow1.Add (this.gvOpen);
			this.vbox2.Add (this.scrolledwindow1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.scrolledwindow1]));
			w8.Position = 1;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(w1[this.vbox2]));
			w9.Position = 0;
			// Container child dialog_VBox.Gtk.Box+BoxChild
			this.hseparator2 = new global::Gtk.HSeparator ();
			this.hseparator2.Name = "hseparator2";
			w1.Add (this.hseparator2);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(w1[this.hseparator2]));
			w10.PackType = ((global::Gtk.PackType)(1));
			w10.Position = 2;
			w10.Expand = false;
			w10.Fill = false;
			w10.Padding = ((uint)(5));
			// Internal child YahtzeeSharp.dlgOpen.ActionArea
			global::Gtk.HButtonBox w11 = this.ActionArea;
			w11.Events = ((global::Gdk.EventMask)(256));
			w11.Name = "YahtzeeSharp.dlgOpen_ActionArea";
			w11.Spacing = 10;
			w11.BorderWidth = ((uint)(5));
			w11.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(1));
			// Container child YahtzeeSharp.dlgOpen_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.btnClose = new global::Gtk.Button ();
			this.btnClose.CanDefault = true;
			this.btnClose.CanFocus = true;
			this.btnClose.Name = "btnClose";
			this.btnClose.UseUnderline = true;
			this.btnClose.Label = global::Mono.Unix.Catalog.GetString ("Close");
			this.AddActionWidget (this.btnClose, -9);
			global::Gtk.ButtonBox.ButtonBoxChild w12 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w11[this.btnClose]));
			w12.Expand = false;
			w12.Fill = false;
			// Container child YahtzeeSharp.dlgOpen_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.btnOpen = new global::Gtk.Button ();
			this.btnOpen.CanDefault = true;
			this.btnOpen.CanFocus = true;
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.UseUnderline = true;
			this.btnOpen.Label = global::Mono.Unix.Catalog.GetString ("Open");
			this.AddActionWidget (this.btnOpen, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w13 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w11[this.btnOpen]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			// Container child YahtzeeSharp.dlgOpen_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.btnDelete = new global::Gtk.Button ();
			this.btnDelete.CanDefault = true;
			this.btnDelete.CanFocus = true;
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.UseUnderline = true;
			this.btnDelete.Label = global::Mono.Unix.Catalog.GetString ("Delete");
			this.AddActionWidget (this.btnDelete, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w14 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w11[this.btnDelete]));
			w14.Position = 2;
			w14.Expand = false;
			w14.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 651;
			this.DefaultHeight = 382;
			this.Show ();
			this.txtFilter.Changed += new global::System.EventHandler (this.OnTxtFilterChanged);
			this.btnClearFilter.Clicked += new global::System.EventHandler (this.OnBtnClearFilterClicked);
			this.btnClose.Clicked += new global::System.EventHandler (this.OnBtnCloseClicked);
			this.btnOpen.Clicked += new global::System.EventHandler (this.OnBtnOpenClicked);
			this.btnDelete.Clicked += new global::System.EventHandler (this.OnBtnDeleteClicked);
		}
	}
}
