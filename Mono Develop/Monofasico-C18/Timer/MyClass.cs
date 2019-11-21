using System;
using System.Timers;
using System.Threading;

namespace Timer
{
	public class TimerE
	{
		private System.Timers.Timer TheTimer;
		//constructor
		public TimerE()
		{
		}
		
		public void IniTimer()
		{
		TheTimer = new System.Timers.Timer();
		
		TheTimer.Elapsed += new ElapsedEventHandler(OurTimerCallback);
		TheTimer.Disposed += new EventHandler(OurTimerDisposed);
		TheTimer.Interval = 1000;
		TheTimer.Enabled = true;
		//TheTimer.Dispose();
		}
		public  void StopTimer(){
			TheTimer.Dispose();
		}
		
		public static void OurTimerCallback(object source, ElapsedEventArgs e)
		//public static void OurTimerCallback(object source)
		{
			//String Dato="";
			//USBSerial Conexion = new USBSerial();
			//Conexion.USBSerialOpen();
			//Conexion.USBSerialSend("IC");
			//Dato=Conexion.USBSerialRecive();
			//Conexion.USBSerialClose();	
		//Console.WriteLine("Received a callback, the time is {0}", e.SignalTime);
		}
		 
		public static void OurTimerDisposed(object source, EventArgs e)
		{
		//Console.WriteLine("Called when the timer is disposed off");
		}
	}
	
	
}

