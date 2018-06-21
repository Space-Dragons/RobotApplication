using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoonSharp;

namespace Robot_Main.LuaScripting.LuaSharp
{
	class TLuaSharp
	{
		public MoonSharp.Interpreter.Script Machine = new MoonSharp.Interpreter.Script();

		public void RunString(string Script)
		{
			Machine.DoString(Script);
		}
	}
}
