
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;
	private global::Gtk.Label label2;
	private global::Gtk.ComboBox combobox5;
	private global::Gtk.Label label3;
	private global::Gtk.Label label4;
	private global::Gtk.Label label5;
	private global::Gtk.Button button1;
	private global::Gtk.ProgressBar progressbar1;
	private global::Gtk.Button button2;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Velocidad");
		this.fixed1.Add (this.label2);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label2]));
		w1.X = 47;
		w1.Y = 99;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.combobox5 = global::Gtk.ComboBox.NewText ();
		this.combobox5.AppendText (global::Mono.Unix.Catalog.GetString ("Paso 0"));
		this.combobox5.AppendText (global::Mono.Unix.Catalog.GetString ("Paso 1"));
		this.combobox5.AppendText (global::Mono.Unix.Catalog.GetString ("Paso 2"));
		this.combobox5.AppendText (global::Mono.Unix.Catalog.GetString ("Paso 3"));
		this.combobox5.AppendText (global::Mono.Unix.Catalog.GetString ("Paso 4"));
		this.combobox5.AppendText (global::Mono.Unix.Catalog.GetString ("Paso 5"));
		this.combobox5.AppendText (global::Mono.Unix.Catalog.GetString ("Paso 6"));
		this.combobox5.AppendText (global::Mono.Unix.Catalog.GetString ("Paso 7"));
		this.combobox5.AppendText (global::Mono.Unix.Catalog.GetString ("Paso 8"));
		this.combobox5.AppendText (global::Mono.Unix.Catalog.GetString ("Paso 9"));
		this.combobox5.Name = "combobox5";
		this.combobox5.Active = 0;
		this.fixed1.Add (this.combobox5);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.combobox5]));
		w2.X = 43;
		w2.Y = 118;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Control de Velocidad de Motor por USB");
		this.fixed1.Add (this.label3);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label3]));
		w3.X = 203;
		w3.Y = 24;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("RPM");
		this.fixed1.Add (this.label4);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label4]));
		w4.X = 348;
		w4.Y = 97;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("0");
		this.fixed1.Add (this.label5);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label5]));
		w5.X = 501;
		w5.Y = 119;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button1 = new global::Gtk.Button ();
		this.button1.CanFocus = true;
		this.button1.Events = ((global::Gdk.EventMask)(256));
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString ("Aceptar");
		this.fixed1.Add (this.button1);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.button1]));
		w6.X = 124;
		w6.Y = 119;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.progressbar1 = new global::Gtk.ProgressBar ();
		this.progressbar1.Name = "progressbar1";
		this.fixed1.Add (this.progressbar1);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.progressbar1]));
		w7.X = 330;
		w7.Y = 124;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button2 = new global::Gtk.Button ();
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString ("Paro");
		this.fixed1.Add (this.button2);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.button2]));
		w8.X = 208;
		w8.Y = 179;
		this.Add (this.fixed1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 697;
		this.DefaultHeight = 437;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.button1.Clicked += new global::System.EventHandler (this.OnButton1Clicked);
	}
}
