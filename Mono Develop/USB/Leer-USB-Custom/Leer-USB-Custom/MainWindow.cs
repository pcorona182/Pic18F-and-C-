using System;
using Gtk;
using System.IO.Ports;
using System.Timers;
using System.Threading;
using System.IO;

public partial class MainWindow: Gtk.Window
{	public System.Timers.Timer TimerTi;
	
	
	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		TimerTi = new System.Timers.Timer();
			TimerTi.Elapsed+= new ElapsedEventHandler(TimerTiTimerCallback);
			TimerTi.Interval=1000;
			TimerTi.Enabled=true;	
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	
	protected void TimerTiTimerCallback(object sender, ElapsedEventArgs e)
	{
	
	}
}
