using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Robot_Main;
using Robot_Project.Path;
using MonoBrickFirmware;
//using MonoBrickFirmware.Movement;
using MonoBrick.EV3;

namespace Robot_Project.Motion
{
	class TMotorMultiple: List<Motor>
	{
		public void StopAll()
		{
			for (int i = 0; i < Count; i++)
			{
				try
				{
					this[i].Brake();
				}
				catch (Exception E)
				{
					TRobot.Writeln($"Motor is not working properly [index {i.ToString()}]: " + E.Message);
				}
			}
		}

		public void SetSpeed(int Speed)
		{
			for (int i = 0; i < Count; i++)
			{
				try
				{
					this[i].On((sbyte) Speed);
				}
				catch (Exception E)
				{
					TRobot.Writeln($"Motor is not working properly [index {i.ToString()}]: " + E.Message);
				}
			}
		}
	}

	class TMotorsWait : List<WaitHandle>
	{
		public void WaitForAll()
		{
			WaitHandle[] Store = new WaitHandle[Count];
			for (int i = 0; i < Count; i++)
			{
				Store[i] = this[i];
			}
			WaitHandle.WaitAll(Store);
		}
	}
	
	class TMotivator : Object
	{ 

    void ThreadedMotion()
		{
			
		}

		public int ForwardMotor_Index_Start = 0;
		public int ForwardMotor_Index_Stop = 0;
		public int BackwardMotor_Index_Start = 1;
		public int BackwardMotor_Index_Stop = 1;

		public TMotorMultiple Motors = new TMotorMultiple();
		protected Thread Moving;

		public void MoveForward(sbyte Speed)
		{
			for (int i = ForwardMotor_Index_Start; i <= ForwardMotor_Index_Stop; i++)
			{
				Motors[i].On(Speed);
			}
			for (int i = BackwardMotor_Index_Start; i <= BackwardMotor_Index_Stop; i++)
			{
				Motors[i].On((sbyte) - Speed);
			}
		}

		public void MoveBackward(sbyte Speed)
		{
			MoveForward((sbyte) - Speed);
		}

		public TMotorsWait MoveForward_Degree(UInt32 Angle, UInt32 Speed)
		{
			TMotorsWait Storage = new TMotorsWait();
			for (int i = ForwardMotor_Index_Start; i <= ForwardMotor_Index_Stop; i++)
			{
				//Storage.Add(Motors[i].SpeedProfile((sbyte)Speed, Angle, Speed, 0, true));
			}
			for (int i = BackwardMotor_Index_Start; i <= BackwardMotor_Index_Stop; i++)
			{
				//Storage.Add(Motors[i].SpeedProfile((sbyte)Speed, 0, Speed, Angle, true));
			}
			return Storage;
		}

		//public TMotorsWait MoveBackward_Degree(UInt32 Angle, UInt32 Speed)
		//{
			
		//}

		public void MoveForward_Degree_Sync(UInt32 Angle, UInt32 Speed)
		{
			TMotorsWait Store = MoveForward_Degree(Angle, Speed);
			Store.WaitForAll();
		}

		public TMotivator()
		{
			Moving = new Thread(this.ThreadedMotion);
		}
	}

	class TMotion
	{
	}
}
