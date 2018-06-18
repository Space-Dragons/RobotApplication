using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuaInterface;

namespace Robot_Main.LuaScripting
{

	class TErrorPackage
	{
		string Message;
		string Type;

		public bool isTyped(string Type)
		{
			return (Type.ToLower() == this.Type);
		}

		public string ErrorToString()
		{
			return ("[" + Type + "]: " + Message);
		}

		public TErrorPackage(string Message, string Type = "default")
		{
			this.Message = Message;
			this.Type = Type.ToLower();
		}
	}

	class TLuaEnviroment
	{
		// You can add your own functions to this API
		public class api
		{
			public void Writeln(string str)
			{
				TRobot.Writeln(str);
			}

			public void Sleep(int Ms = 1000)
			{
				System.Threading.Thread.Sleep(Ms);
			}
		}
	}

  class TLuaEngine
  {
		public static string LuaError_Type = "LuaError";
		public static string OtherError_Type = "UnknownError"; // Do not use it.

    public Lua LuaMachine;
		public List<TErrorPackage> Errors;

		public bool ExecuteScript(string Script)
		{
			try
			{
				LuaMachine.DoString(Script);
				return true;
			}
			catch (Exception E)
			{
				if (E is LuaException)
					Errors.Add(new TErrorPackage(E.Message, "LuaError"));
				else
					Errors.Add(new TErrorPackage(E.Message, E.GetType().Name));
				return false;
			}
		}

		public bool ExecuteFile(string FileName)
		{
			try
			{
				LuaMachine.DoFile(FileName);
				return true;
			}
			catch (Exception E)
			{
				if (E is LuaException)
					Errors.Add(new TErrorPackage(E.Message, LuaError_Type));
				else
					Errors.Add(new TErrorPackage(E.Message, E.GetType().Name));
				return false;
			}
		}

		public TErrorPackage GetLastError()
		{
			return Errors[Errors.Count - 1];
		}

    public TLuaEngine()
    {
			LuaMachine = new Lua();
			LuaMachine["api"] = new TLuaEnviroment.api();
			Errors = new List<TErrorPackage>();
			Errors.Clear();
    }

  }
}
