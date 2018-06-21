
using System;
using System.Threading;
using MonoBrickFirmware.Display;
using MonoBrickFirmware.UserInput;
using MonoBrickFirmware.Movement;
using Direction_Main;
using MonoBrickFirmware.Sensors;
using System.IO;
using MonoBrick;
using LuaInterface;
using Robot_Project.Motion;
using Field_Generated;
using Robot_Project.Path;
using MonoBrickFirmware.Sound;
using MonoBrickFirmware.Sensors;
using System.IO.Ports;

namespace Robot_Main
{
  public class TRobot
  {
		// Vars
		public static bool IsRobot = false;
		public static Random RandGen = new Random();
		public static string PathForExe = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase.Split(new string[] { "///" }, StringSplitOptions.None)[1]) + "/";

		public static Thread Emergency = new Thread(EmergencyThread);
		public static Thread Thread_Main = new Thread(MainThread);

		public static string LogFile = PathForExe + "/log.txt";
		public static StreamWriter LogFileWriter = File.AppendText(LogFile);

		public static ushort BIOS_Tone = 1000;

		public static void Log(string Msg)
		{
			if (!(LogFileWriter == null))
			{
				LogFileWriter.WriteLine($"[{DateTime.Now.ToString()}]: " + Msg);
				LogFileWriter.Flush();
			}
		}

		public static void EmergencyThread()
		{
			while (true)
			{
				if (IsRobot)
				{
					if (MonoBrickFirmware.UserInput.Buttons.GetKeypress() == Buttons.ButtonStates.Escape)
					{
						Thread_Main.Abort();
						FinalizePRogram();
						Environment.Exit(0);
					}
				}
				else
				{
					if (Console.ReadKey(true).Key == ConsoleKey.Escape)
					{
						Thread_Main.Abort();
						FinalizePRogram();
						Environment.Exit(0);
					}
				}
				Thread.Sleep(50);
			}
		}

		public static void BIOS_Beep()
		{
			Speaker speak = new Speaker(10);
			//speak.Beep(100);
			speak.PlayTone(BIOS_Tone, 700);
			speak.PlayTone(BIOS_Tone, 200);
			speak.PlayTone(BIOS_Tone, 200);
			speak.PlayTone(BIOS_Tone, 200);
		}

		public static void MainThread()
		{
			// All in one thread
			Init();
			SetColor(ConsoleColor.Red);
			LogFileWriter.WriteLine("");
			Log("New log file started.");
			try
			{
				TRobot.Writeln(PathForExe);
				if (IsRobot)
				{
					Emergency.Start();
					FinalizePRogram();
					LogFileWriter = File.AppendText(LogFile);
					BIOS_Beep();

					// MonoBrick.EV3.Mailbox mail = new MonoBrick.EV3.Mailbox();
					// Thread.Sleep(1000000);
					/*string[] arr = MonoBrick.Bluetooth<BrickCommand, BrickReply>.GetPortNames();
					for (int i = 0; i < arr.Length; i++)
					{
						Writeln(arr[i]);
					}
					Thread.Sleep(100000);*/

					Motor TestMotor = new Motor(MotorPort.OutD);
					Writeln(TestMotor.GetTachoCount().ToString());
					TestMotor.SetSpeed(100);
					Thread.Sleep(1000);
					TestMotor.Brake();
					Writeln(TestMotor.GetTachoCount().ToString());
					// Thread.Sleep(100000);

					// System.IO.Ports.SerialPort serialPort = new SerialPort();
					string[] ARR = SerialPort.GetPortNames();
					for (int i = 0; i < ARR.Length; i++)
					{
						Writeln($"Serial {ARR[i]}");
					}

					Writeln("Hello from Robot");

					long A = 0;

					TDirectionizer directionizer = new TDirectionizer(SensorPort.In2, SensorPort.In3);
					Motor Left = new Motor(MotorPort.OutC);
					Motor Right = new Motor(MotorPort.OutB);

					/*while (true)
					{
						int[] res = directionizer.Directionize();
						LcdConsole.Clear();
						TRobot.Writeln($"Motorl: {res[0]}; Motorr: {res[1]};");
						Left.SetPower((sbyte)res[0]);
						Right.SetPower((sbyte)res[1]);
						Thread.Sleep(50);
					}*/

					TMotivator vec = new TMotivator(MotorPort.OutC, MotorPort.OutB);
					EV3UltrasonicSensor ultrasonicSensor = new EV3UltrasonicSensor(SensorPort.In1, UltraSonicMode.Centimeter);

					Motor Test = new Motor(MotorPort.OutB);
					Writeln($"Prev tacho: {Test.GetTachoCount()}");
					vec.MoveForward(50, 360);
					Writeln($"Tacho: {Test.GetTachoCount()}");
					Thread.Sleep(100000);


					/*while (true)
					{
						A++;
						vec.MoveForward_mm(50, 300);
						vec.TurnLeft(20, 180);
						vec.MoveForward_mm(50, 300);
						vec.TurnRight(20, 180);
						if (A >= 4)
							break;
					}*/

				}

				TField Fld = Field_Generated_Class.Generate();
				TDijkstra djk = new TDijkstra(new TPoint(1, 1), new TPoint(2, 0), Fld);
				TRobot.Writeln(djk.Search_Way().ToString() + $" steps {djk.CountSteps}");
				djk.Way.Reverse();
				for (int i = 0; i < djk.Way.Count; i++)
				{
					TRobot.Writeln($"[{djk.Way[i].Position.X}, {djk.Way[i].Position.Y}]");
				}
			}
			catch (Exception E)
			{
				string Str = ($"[EXCEPTION][{E.GetType().Name}]: " + E.Message);
				File.WriteAllLines(PathForExe + "last_exception.txt", new string[] { Str });
				TRobot.Writeln(Str);
			}
			TRobot.Writeln("Press any key to continue...");
			TRobot.Read();
			if (IsRobot)
			{
				for (MotorPort i = MotorPort.OutA; i <= MotorPort.OutD; i++)
				{
					Motor mot = new Motor(i);
					mot.Brake();
					mot.SetPower(0);
				}
			}
			FinalizePRogram();
		}

		public static void BIOS_FINALE_BEEP()
		{
			Speaker beep = new Speaker(10);
			for (int i = 0; i < 2; i ++)
			{
				beep.PlayTone(BIOS_Tone, 600);
				Thread.Sleep(300);
			}
		}

		public static void FinalizePRogram()
		{
			BIOS_FINALE_BEEP();
			Writeln("Finalization called!");
			if (IsRobot)
			{
				for (MotorPort i = MotorPort.OutA; i <= MotorPort.OutD; i++)
				{
					// Turn off all motors
					Motor FinaleMotor = new Motor(i);
					FinaleMotor.Brake();
					FinaleMotor.ResetTacho();
					FinaleMotor.Off();
				}
				for (SensorPort i = SensorPort.In1; i <= SensorPort.In4; i++)
				{
					// Cannot finalize all sensors
				}
			}
			else
			{
				// Windows
			}
			Writeln("Finalization finished.");
			LogFileWriter.Close();
			LogFileWriter = null;
		}

    // Service

    // Functions
    public static void Read()
    {
      if (IsRobot)
      {
				MonoBrickFirmware.UserInput.Buttons.GetKeypress();
      }
      else
      {
				Console.Read();
      }
    }

		public static void SetColor(ConsoleColor Fore, ConsoleColor Back = ConsoleColor.Black)
		{
			if (!IsRobot)
			{
				Console.ForegroundColor = Fore;
				Console.BackgroundColor = Back;
			}
		}

    public static void Writeln(string str)
    {
      if (IsRobot)
      {
        LcdConsole.WriteLine(str);
      }
      else
      {
        Console.WriteLine(str);
      }
			Log(str);
    }

    public static void Init()
    {
      try
      {
        MonoBrickFirmware.Display.LcdConsole.WriteLine("Initialize!");
        IsRobot = true;
      }
      catch (Exception E)
      {
        try
        {
          Console.WriteLine("Initialize!");
          IsRobot = false;
        }
        catch
        {
          throw new Exception("Cannot initialize!");
        }
      }
      Writeln("Inited. Robot state: " + IsRobot.ToString());
		}

    // Working

    public static void Main(string[] args)
    {
			try
			{
				Thread_Main.Start();
				while (true)
					Thread.Sleep(200);
			}
			catch (Exception E)
			{

			}
    }
  }
}