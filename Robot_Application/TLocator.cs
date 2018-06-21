using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robot_Project.Path;
using Direction_Main;

namespace Robot_Project.Location
{
	class TLocalizer
	{
		private TDirection FDirection;

		public List<TFieldSection> Storage = new List<TFieldSection>();
		public TFieldSection Current;
		public TField Field_Main;
		public TDirection Direction
		{
			get 
			{
				return FDirection;
			}
			set
			{
				FDirection = value;
				Current.Direction.State = FDirection.State;
			}
		}
		public int MinX = 0;
		public int MaxX = 0;
		public int MinY = 0;
		public int MaxY = 0;

		private TField Field_Forward;
		private TField Field_Right;
		private TField Field_Backward;
		private TField Field_Left;

		public void BuildSystem()
		{
			int Len = Field_Main.Length;
			Field_Forward = new TField(Field_Main.Length, Field_Main.Length);
			Field_Right = new TField(Len, Len);
			Field_Backward = new TField(Len, Len);
			Field_Left = new TField(Len, Len);
			Field_Forward.Field = Field_Main.Field.Copy();
			Field_Right.Field = Field_Forward.Field.Copy();
			Field_Right.Field.RotateRight();
			Field_Backward.Field = Field_Right.Field.Copy();
			Field_Backward.Field.RotateRight();
			Field_Backward.Field.RotateRight();
			Field_Left.Field = Field_Backward.Field.Copy();
			Field_Left.Field.RotateRight();
			Field_Left.Field.RotateRight();
			Field_Left.Field.RotateRight();
		}

		public TFieldSection NextStep()
		{
			TFieldSection Result = new TFieldSection(null);
			Storage.Add(Result);
			Result.Direction.State = FDirection.State;
			if (Direction.State == (int)TDirection.TDirections.Forward)
			{
				Result.Coordinates = Result.Coordinates - new TPoint(1, 0);
			}
			else if (Direction.State == (int)TDirection.TDirections.Backward)
			{
				Result.Coordinates = Result.Coordinates + new TPoint(1, 0);
			}
			else if (Direction.State == (int)TDirection.TDirections.Left)
			{
				Result.Coordinates = Result.Coordinates - new TPoint(0, 1);
			}
			else if (Direction.State == (int)TDirection.TDirections.Right)
			{
				Result.Coordinates = Result.Coordinates + new TPoint(0, 1);
			}
			int X = Result.Coordinates.X;
			int Y = Result.Coordinates.Y;
			MinX = (X < MinX) ? X : MinX;
			MaxX = (X > MaxX) ? X : MaxX;
			MinY = (Y < MinY) ? Y : MinY;
			MaxX = (Y > MaxY) ? Y : MaxY;

			return Result;
		}

		public TLocalizer(TField FieldPointer)
		{
			Field_Main = FieldPointer;
			BuildSystem();
			Current = new TFieldSection(null);
			Storage.Add(Current);
			Current.Coordinates = new TPoint(0, 0);
		}
	}
}
