using System;
using Gtk;
using System.IO.Ports;
using System.Timers;
using System.Threading;



public partial class MainWindow: Gtk.Window
{	
	public System.Timers.Timer TimerTi;
	public SerialPort myUSBSerial;
	//public String [] DatoR;
	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{

			TimerTi = new System.Timers.Timer();
			TimerTi.Elapsed+= new ElapsedEventHandler(TimerTiTimerCallback);
			TimerTi.Interval=1000;
			TimerTi.Enabled=true;	
			//myUSBSerial = new SerialPort("/dev/ttyACM0", 38400);
		myUSBSerial = new SerialPort("/dev/ttyACM0",115200);
		USBSerialOpen();
		
		Build ();

		
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		//USBSerialOpen();
		USBSerialSend("P"+"0"+"M");
		USBSerialClose();
		Application.Quit ();
		a.RetVal = true;
	}

	

	protected void OnButton1Clicked (object sender, System.EventArgs e)
	{
		//USBSerialOpen();
		USBSerialSend("P"+combobox5.Active+"M");
		//USBSerialClose();
	}
	
	protected void TimerTiTimerCallback(object sender, ElapsedEventArgs e)
	{
		String Dato;
		char [] DatoA;
		int DatoS,a,x=0;
		//USBSerialOpen();
		USBSerialSend("IC");
		Dato=USBSerialRecive();
		
		DatoA=Dato.ToCharArray();
		DatoS=0;
		DatoS=DatoA[0]+DatoA[1];
		label5.LabelProp="RPM= "+DatoS.ToString();
		//USBSerialSend("CI");
		
		//USBSerialClose();
	}
	
	protected void USBSerialOpen()
	{
		//if (myUSBSerial.IsOpen)
		//	myUSBSerial.Close();
		myUSBSerial.BaudRate=115200;
		myUSBSerial.WriteTimeout=10;
		myUSBSerial.ReadTimeout =10;
		myUSBSerial.Open();
	}	

	protected void USBSerialClose()
	{
		myUSBSerial.Close();
	}	
	
	protected bool USBSerialSend(string Data)
	{
		myUSBSerial.Write(Data);
		return true;
		
	}
	
	protected String USBSerialRecive(){
		String tmpString=null;
		//if(myUSBSerial.ReadBufferSize !=0){
		//	tmpString=myUSBSerial.ReadExisting();
		//}
		tmpString=myUSBSerial.ReadExisting();
		return tmpString;
	}
}



