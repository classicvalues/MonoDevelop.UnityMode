
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Debugger.Soft.Unity
{
	public partial class GeneralOptionsPanel
	{
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.FileChooserButton unityChooser;
		
		private global::Gtk.CheckButton buildCB;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Debugger.Soft.Unity.GeneralOptionsPanel
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.Debugger.Soft.Unity.GeneralOptionsPanel";
			// Container child MonoDevelop.Debugger.Soft.Unity.GeneralOptionsPanel.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Editor Location");
			this.hbox1.Add (this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.unityChooser = new global::Gtk.FileChooserButton (global::Mono.Unix.Catalog.GetString ("Browse to the Unity editor"), ((global::Gtk.FileChooserAction)(0)));
			this.unityChooser.Name = "unityChooser";
			this.hbox1.Add (this.unityChooser);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.unityChooser]));
			w2.Position = 1;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.buildCB = new global::Gtk.CheckButton ();
			this.buildCB.CanFocus = true;
			this.buildCB.Name = "buildCB";
			this.buildCB.Label = global::Mono.Unix.Catalog.GetString ("_Build project in MonoDevelop");
			this.buildCB.DrawIndicator = true;
			this.buildCB.UseUnderline = true;
			this.vbox1.Add (this.buildCB);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.buildCB]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
