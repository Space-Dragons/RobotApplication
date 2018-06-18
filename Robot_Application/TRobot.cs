using System;
using System.Threading;
using MonoBrickFirmware.Display;
using MonoBrickFirmware.UserInput;
using MonoBrickFirmware.Movement;
using Direction_Main;
using MonoBrickFirmware.Sensors;

namespace Robot_Main
{
  public class TRobot
  {

    // Service
    // Vars
    public static bool IsRobot = false;
    public static Random RandGen = new Random();

    // Functions
    public static void Read()
    {
      if (IsRobot)
      {
        
      }
      else
      {

      }
    }

		public static void SetColor()
		{

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
      Init();
      try
      {
        if (IsRobot)
        {
          Motor TestMotor = new Motor(MotorPort.OutD);
          TestMotor.SetSpeed(100);
          Thread.Sleep(1000);
          TestMotor.Brake();
        }
				LuaScripting.TLuaEngine Machine = new LuaScripting.TLuaEngine();
				if (Machine.ExecuteScript("do " +
																	"  api:Writeln('Hello world from Lua Machine!');" +
																	"  print('Delete');" +
																	"  for i = 1, 1000 do io.write(i) end; print();" +
																	"end;"))
				{
					Writeln("All is OK.");
				}
				else
				{
					Writeln("All is not OK. Error: " + Machine.GetLastError().ErrorToString());
				}
				LuaScripting.LuaSharp.TLuaSharp Machine1 = new LuaScripting.LuaSharp.TLuaSharp();
				Machine1.RunString("print('Hello world from Lua');  local str = io.read(); print('Hello: '..str);");
				
      }
      catch (Exception E)
      {
        TRobot.Writeln($"[EXCEPTION][{E.GetType().Name}]: " + E.Message);
        // Thread.Sleep(100000);
      }
    }

  }
}