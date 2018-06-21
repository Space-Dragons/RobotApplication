using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonoBrickFirmware.Movement;

namespace Robot_Project.Encoders
{
	public delegate void MotorEncoder_Callback(int degrees);

	class TMotorEncoder
	{
		public Motor EncMotor;
		public MotorEncoder_Callback Func = null;
		public int Degrees;
		public int Delay = 50;

		private void Move_Thread()
		{

		}

	}
}
