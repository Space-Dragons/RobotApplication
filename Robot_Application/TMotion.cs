using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Robot_Main;
using Robot_Project.Path;
using MonoBrickFirmware;
using MonoBrickFirmware.Movement;
using MonoBrick;
//using MonoBrick.EV3;

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
					//this[i].On((sbyte) Speed);
					this[i].SetSpeed((sbyte) Speed);
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
	
	/*class TMotivator : Object
	{ 

    void ThreadedMotion()
		{
			
		}

		public int ForwardMotor_Index_Start = 0;
		public int ForwardMotor_Index_Stop = 0;
		public int BackwardMotor_Index_Start = 1;
		public int BackwardMotor_Index_Stop = 1;

		public int Radius = 30;

		public TMotorMultiple Motors = new TMotorMultiple();
		protected Thread Moving;

		public void MoveForward(sbyte Speed)
		{
			for (int i = ForwardMotor_Index_Start; i <= ForwardMotor_Index_Stop; i++)
			{
				Motors[i].SetSpeed(Speed);
			}
			for (int i = BackwardMotor_Index_Start; i <= BackwardMotor_Index_Stop; i++)
			{
				Motors[i].SetSpeed((sbyte) - Speed);
			}
		}

		public void MoveBackward(sbyte Speed)
		{
			MoveForward((sbyte) - Speed);
		}

		public TMotorsWait MoveForward_Degree(UInt32 Angle, Int32 Speed)
		{
			TMotorsWait Storage = new TMotorsWait();
			for (int i = ForwardMotor_Index_Start; i <= ForwardMotor_Index_Stop; i++)
			{
				//Storage.Add(Motors[i].SpeedProfile((sbyte)Speed, Angle, Speed, 0, true));
				// Motors[i].On((sbyte)Speed, Angle, true);
			}
			for (int i = BackwardMotor_Index_Start; i <= BackwardMotor_Index_Stop; i++)
			{
				//Storage.Add(Motors[i].SpeedProfile((sbyte)Speed, 0, Speed, Angle, true));
				//Motors[i].On((sbyte)-Speed, Angle, true);
			}
			return Storage;
		}

		public void MoveForward_Mm(UInt32 mm, Int32 Speed)
		{
			double Len = 2 * Math.PI * Radius;
			UInt32 Angle = (UInt32)Math.Round((mm * 360) / Len);
			MoveForward_Degree(Angle, Speed);
		}

		public void MoveBackward_Mm(UInt32 mm, Int32 Speed)
		{
			MoveForward_Mm(mm, - Speed);
		}

		public void MoveBackward_Deegre(UInt32 Angle, Int32 Speed)
		{
			MoveForward_Degree(Angle, -Speed);
		}

		public void MoveForward_Degree_Sync(UInt32 Angle, Int32 Speed)
		{
			TMotorsWait Store = MoveForward_Degree(Angle, Speed);
			Store.WaitForAll();
		}

		public TMotivator(Motor[] ForwardMotors, Motor[] BackwardMotors)
		{
			Moving = new Thread(this.ThreadedMotion);
			for (int i = 0; i < ForwardMotors.Length; i++)
			{
				Motors.Add(ForwardMotors[i]);
			}
			ForwardMotor_Index_Start = 0;
			ForwardMotor_Index_Stop = ForwardMotors.Length - 1;
			for (int i = 0; i < BackwardMotors.Length; i ++)
			{
				Motors.Add(BackwardMotors[i]);
			}
			BackwardMotor_Index_Start = ForwardMotors.Length;
			BackwardMotor_Index_Stop = BackwardMotor_Index_Start + BackwardMotors.Length - 1;
		}
	} */

	class TDirectionizer
	{
		public MonoBrickFirmware.Sensors.EV3UltrasonicSensor SensorLeft;
		public MonoBrickFirmware.Sensors.EV3UltrasonicSensor SensorRight;

		public sbyte DefaultSpeed = 30;
		public int X = 40;
		public int Y = 3;
		public int Dist = 150;
		public int[] Multiple = new int[2] {-60, 60};

		public int[] Directionize()
		{
			int[] Result = new int[2];

			long sensLeft = SensorLeft.Read();
			long sensRight = SensorRight.Read();

			long Substract = sensLeft - sensRight;
			if ((Substract >= Multiple[0]) && (Substract <= Multiple[1]))
			{
				Result[1] = (int)(X + Substract * Y * 0.1); // Right
				Result[0] = (int)(X - Substract * Y * 0.1); // Left
			}
			else if ((sensRight < Dist) || (sensLeft < Dist))
			{
				long res = (sensRight < Dist) ? (90 - sensRight) : (90 - sensLeft);
				double mult = (sensRight < Dist) ? (1 * 0.1) : (-1 * 0.1);
				Result[1] = (int)((X + res * Y * mult)); // Right
				Result[0] = (int)((X + res * Y * mult * -1)); // Left
			}
			else
			{
				Result[1] = (int)DefaultSpeed;
				Result[0] = (int)DefaultSpeed;
			}

			return Result;
		}

		public TDirectionizer(MonoBrickFirmware.Sensors.SensorPort SensorLeft, MonoBrickFirmware.Sensors.SensorPort SensorRight)
		{
			this.SensorLeft = new MonoBrickFirmware.Sensors.EV3UltrasonicSensor(SensorLeft);
			this.SensorRight = new MonoBrickFirmware.Sensors.EV3UltrasonicSensor(SensorRight);
		}
	}

  class TMotivator: Object
	{
		public Vehicle vehicle;
		public double K = (float)430 / (float)180;
		public uint Radius = 27;
		protected double Temp;

		public void MoveForward(sbyte speed, uint Degrees)
		{
			vehicle.Forward(speed, Degrees, true).WaitOne();
		}

		public void MoveForward_mm(sbyte speed, uint mm)
		{
			this.MoveForward(speed, (uint)(mm / Temp));
		}

		public void MoveBackward(sbyte speed, uint degrees)
		{
			vehicle.Backward(speed, degrees, true).WaitOne();
		}

		public void TurnLeft(sbyte Speed, uint degrees)
		{
			vehicle.SpinLeft(Speed, (UInt32)(degrees * K), true).WaitOne();
		}

		public void TurnRight(sbyte Speed, uint degrees)
		{
			vehicle.SpinRight(Speed, (uint)(degrees * K), true).WaitOne();
		}

		public TMotivator(MotorPort MotorLeft, MotorPort MotorRight)
		{
			vehicle = new Vehicle(MotorLeft, MotorRight);
			Temp = (Math.PI * 2 * Radius) / 360;
		} 
	}

	class TMotion
	{
	}
}
