using System;
using Gtk;
using System.IO.Ports;
using System.Timers;
using System.Threading;

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
	{
		String Dato="";
		
		USBSerial Conexion = new USBSerial();
		Conexion.USBSerialOpen();
		Conexion.USBSerialSend("IC");
		Dato=Conexion.USBSerialRecive();
		
		Conexion.USBSerialClose();	
	//Console.WriteLine("Received a callback, the time is {0}", e.SignalTime);
	}
	 
	public static void OurTimerDisposed(object source, EventArgs e)
	{
	//Console.WriteLine("Called when the timer is disposed off");
	}
}

public class USBSerial
{
	private SerialPort myUSBSerial;
	
	//constructor
	public USBSerial(){
	}
	
	public void USBSerialOpen()
	{
		if (myUSBSerial != null)
			if (myUSBSerial.IsOpen)
				myUSBSerial.Close();
 
		myUSBSerial = new SerialPort("/dev/ttyACM0", 38400);
		myUSBSerial.Open();
		myUSBSerial.ReadTimeout = 400;
		//SendData("ATI3\r");
 
                // Should output some information about your modem firmware
		//Console.WriteLine(ReadData());  
	}
	
	public void USBSerialClose()
	{
		myUSBSerial.Close();
	}
	
	public bool USBSerialSend(string Data)
	{
		myUSBSerial.Write(Data);
		return true;
	}
	
	public string USBSerialRecive(){
		//byte tmpByte;
		string rxString = "";
 
		//tmpByte = (byte) myUSBSerial.ReadByte();
		//while (tmpByte != 255) {
		//	rxString += ((char) tmpByte);
		//	tmpByte = (byte) mySerial.ReadByte();			
		//}
 		rxString=myUSBSerial.ReadLine();
		return rxString;
	}
}
public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		TimerE TimerTi = new TimerE();			
		TimerTi.IniTimer();
		
		Build ();
		
		
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		USBSerial Conexion = new USBSerial();
		Conexion.USBSerialOpen();
		Conexion.USBSerialSend("P"+"0"+"M");
		Conexion.USBSerialClose();
		
		Application.Quit ();
		a.RetVal = true;
	}

	

	protected void OnButton1Clicked (object sender, System.EventArgs e)
	{
		
		USBSerial Conexion = new USBSerial();
		Conexion.USBSerialOpen();
		Conexion.USBSerialSend("P"+combobox5.Active+"M");
		
		Conexion.USBSerialClose();
	}
	
	
}



