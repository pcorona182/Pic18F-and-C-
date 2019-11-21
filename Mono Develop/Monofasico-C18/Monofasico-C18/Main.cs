using System;
using Gtk;
using System.IO.Ports;
using System.Timers;
using System.Threading;

namespace MonofasicoC18
{

	class MainClass
	{
		
		
		public static void Main (string[] args)
		{	
		
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			
			Application.Run ();
			
		}
		
	
	}

	
}
