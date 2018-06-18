using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using Robot_Main;


namespace Direction_Main
{
	class Constants
	{
		public static int FieldSection_Every = 50;
		public static int FieldSection_Free = 0;
		public static int FieldSection_Blocked = 1;

		public static int Direction_NORTH = 0;
		public static int Direction_WEST = 1;
		public static int Direction_SOUTH = 2;
		public static int Direction_EAST = 3;

		public static int Direction_Forward = 0;
		public static int Direction_Right = 1;
		public static int Direction_Backward = 2;
		public static int Direction_Left = 3;
	}

  class TDirection
  {
		public int State = Constants.Direction_NORTH;

		public void NextRight()
		{
			State = (State + 1) % 4;
		}

		public void NextLeft()
		{
			State = State - 1;
			if (State < 0)
				State = 3;
		}

		public TDirection(int State)
		{
			this.State = State;
		}
  }

	class TPosition
	{
		int X = 0;
		int Y = 0;

		public TPosition(int X = 0, int Y = 0)
		{
			this.X = X;
			this.Y = Y;
		}
	}

  class TPoint : Object
  {
    public int X = 0;
    public int Y = 0;

		public static TPoint operator +(TPoint First, TPoint Second)
		{
			return new TPoint(First.X + Second.X, First.Y + Second.Y);
		}

		public static TPoint operator -(TPoint First, TPoint Second)
		{
			return new TPoint(First.X - Second.X, First.Y - Second.Y);
		}

		public static bool operator ==(TPoint First, TPoint Second)
		{
			return ((First.X == Second.X) && (First.Y == Second.Y));
		}

		public static bool operator !=(TPoint First, TPoint Second)
		{
			return !(First == Second);
		}

		public bool isValid()
		{
			return ((X >= 0) && (Y >= 0));
		}

		public bool isValid(int MaxX, int MaxY)
		{
			return (isValid() && (X <= MaxX) && (Y <= MaxY));
		}

		public bool isValid(int Len)
		{
			return isValid(Len, Len);
		}

		public TPoint(int X = 0, int Y = 0)
    {
      this.X = X;
      this.Y = Y;
    }
  }

  class TField: TMatrix.IMatrixIndexer_Object<TFieldSection>
	{
		public TMatrix.TClassesMatrixObject<TFieldSection> Field;
		public int Length;

		public TFieldSection this[int X, int Y]
		{
			get
			{
				return Field[X, Y];
			}
			set
			{
				this.Field[X, Y] = value;
			}
		}

		public TFieldSection this[TPoint X]
		{
			get
			{
				return this[X.X, X.Y];
			}
			set
			{
				this[X.X, X.Y] = value;
			}
		}

		public TField(int Rows, int Columns)
		{
			int Max = Rows;
			int MaxVal = 0;
			if (Columns > Max)
			{
				Max = Columns;
				MaxVal = 1;
			}
			Field = new TMatrix.TClassesMatrixObject<TFieldSection>(Max, Max);
			Length = Max;
		}
	};

  class TFieldSection : Object
  {
    // Public
    public TPoint Coordinates = new TPoint(0, 0);
		public TDirection Direction = new TDirection(Constants.Direction_NORTH);
    public TField Control;

		private int[] Walls = new int[4];

		public int Forward_Wall
		{
			get
			{
				int State = (this.Direction.State + Constants.Direction_Forward) % 4;
				return Walls[State];
			}
			set
			{
				int State = (this.Direction.State + Constants.Direction_Forward) % 4;
				Walls[State] = value;
			}
		}
		
		public int Right_Wall
		{
			get
			{
				int State = (this.Direction.State + Constants.Direction_Right) % 4;
				return Walls[State];
			}
			set
			{
				int State = (this.Direction.State + Constants.Direction_Right) % 4;
				Walls[State] = value;
			}
		}

		public int Backward_Wall
		{
			get
			{
				int State = (this.Direction.State + Constants.Direction_Backward) % 4;
				return Walls[State];
			}
			set
			{
				int State = (this.Direction.State + Constants.Direction_Backward) % 4;
				Walls[State] = value;
			}
		}

		public int Left_Wall
		{
			get
			{
				int State = (this.Direction.State + Constants.Direction_Left) % 4;
				return Walls[State];
			}
			set
			{
				int State = (this.Direction.State + Constants.Direction_Left) % 4;
				Walls[State] = value;
			}
		}

		public int Forward_Wall_Raw
		{
			get
			{
				return Walls[Constants.Direction_Forward];
			}
			set
			{
				Walls[Constants.Direction_Forward] = value;
			}
		}

		public int Right_Wall_Raw
		{
			get
			{
				return Walls[Constants.Direction_Right];
			}
			set
			{
				Walls[Constants.Direction_Right] = value;
			}
		}

		public int Backward_Wall_Raw
		{
			get
			{
				return Walls[Constants.Direction_Backward];
			}
			set
			{
				Walls[Constants.Direction_Backward] = value;
			}
		}

		public int Left_Wall_Raw
		{
			get
			{
				return Walls[Constants.Direction_Left];
			}
			set
			{
				Walls[Constants.Direction_Left] = value;
			}
		}

		// Methods

		public int getWall(int Side)
		{
			int State = (Side + Direction.State) % 4;
			if (State == Constants.Direction_Forward)
				return Forward_Wall_Raw;
			else if (State == Constants.Direction_Right)
				return Right_Wall_Raw;
			else if (State == Constants.Direction_Backward)
				return Backward_Wall_Raw;
			else if (State == Constants.Direction_Left)
				return Left_Wall_Raw;
			else
				throw new Exception("Unknown direction.");
		}

		public int getWallRaw(int Side)
		{
			int State = (Side) % 4;
			if (State == Constants.Direction_Forward)
				return Forward_Wall_Raw;
			else if (State == Constants.Direction_Right)
				return Right_Wall_Raw;
			else if (State == Constants.Direction_Backward)
				return Backward_Wall_Raw;
			else if (State == Constants.Direction_Left)
				return Left_Wall_Raw;
			else
				throw new Exception("Unknown direction.");
		}

		public bool isBlocked(int Side)
		{
			return (getWall(Side) == Constants.FieldSection_Blocked);
		}

		public bool isBlockedRaw(int Side)
		{
			return (getWallRaw(Side) == Constants.FieldSection_Blocked);
		}

		public TPoint getForwardRaw()
		{
			return Control[Coordinates - new TPoint(1, 0)].Coordinates;
		}

		public TPoint getRightRaw()
		{
			return Control[Coordinates + new TPoint(0, 1)].Coordinates;
		}

		public TPoint getBackwardRaw()
		{
			return Control[Coordinates + new TPoint(1, 0)].Coordinates;
		}

		public TPoint getLeftRaw()
		{
			return Control[Coordinates - new TPoint(0, 1)].Coordinates;
		}

		public TPoint getPositionRaw(int State)
		{
			if (State == Constants.Direction_Forward)
				return this.getForwardRaw();
			else if (State == Constants.Direction_Right)
				return this.getRightRaw();
			else if (State == Constants.Direction_Backward)
				return this.getBackwardRaw();
			else if (State == Constants.Direction_Left)
				return this.getLeftRaw();
			else
				throw new Exception("Unknown direction");
		}

    public TPoint getForward()
    {
			int State = (this.Direction.State + Constants.Direction_Forward) % 4;
      return this.getPositionRaw(State);
    }

		public TPoint getLeft()
		{
			int State = (this.Direction.State + Constants.Direction_Left) % 4;
			return this.getPositionRaw(State);
		}

		public TPoint getBackward()
		{
			int State = (this.Direction.State + Constants.Direction_Backward) % 4;
			return this.getPositionRaw(State);
		}

		public TPoint getRight()
		{
			int State = (this.Direction.State + Constants.Direction_Right) % 4;
			return this.getPositionRaw(State);
		}

		public TFieldSection(TField Parent)
		{
			this.Control = Parent;
		}
  }

  class TMatrix
  {
    public static TMatrixObject RotateRight(ref TMatrixObject thise)
    {
      int Len = thise.GetLength();
      TMatrixObject Result = new TMatrixObject(Len, Len);
      for (int i = Len - 1; i >= 0; --i)
      {
        for (int j = 0; j < Len; ++j)
        {
          Result[j, (Len - 1) - i] = thise[i, j];
        }
      }
      return Result;
    }

    public interface IMatrixIndexer_Int
    {
      int this[int X, int Y]
      {
        get;
        set;
      }
    }

    public interface IMatrixIndexer_Object<T>
    {
      T this[int X, int Y]
      {
        set;
        get;
      }
    }

    public class TClassesMatrixObject<T> : Object, IMatrixIndexer_Object<T>
    {

      private Object[,] MatrixArray;
      public T this[int X, int Y]
      {
        get
        {
          return (T)MatrixArray[X, Y];
        }
        set
        {
          MatrixArray[X, Y] = value;
        }
      }

      public int GetLength(int Dim = 0)
      { 
        return MatrixArray.GetLength(Dim);
      }

      public void RotateRight()
      {
        int Len = this.GetLength();
        TClassesMatrixObject<T> Result = new TClassesMatrixObject<T>(Len, Len);
        for (int i = Len - 1; i >= 0; --i)
        {
          for (int j = 0; j < Len; ++j)
          {
            Result[j, (Len - 1) - i] = this[i, j];
          }
        }
        for (int i = 0; i < Len; i++)
        {
          for (int k = 0; k < Len; k++)
          {
            this[i, k] = Result[i, k];
          }
        }
      }

      public void FillWith(T Value)
      {
        int Len = this.GetLength();
        for (int i = 0; i < Len; i++)
        {
          for (int k = 0; k < Len; k++)
          {
            this[i, k] = Value;
          }
        }
      }

      public TClassesMatrixObject(int X = 0, int Y = 0)
      {
        MatrixArray = new Object[X, Y];
      }
    }

    public class TMatrixObject : Object, IMatrixIndexer_Int
    {

      private int[,] MatrixArray;
      public int this[int X, int Y]
      {
        get
        {
          return MatrixArray[X, Y];
        }
        set
        {
          MatrixArray[X, Y] = value;
        }
      }

      public int GetLength(int Dim = 0)
      {
        return MatrixArray.GetLength(Dim);
      }

      public void FillWith(int Value)
      {
        int Len = this.GetLength();
        for (int i = 0; i < Len; i++)
        {
          for (int k = 0; k < Len; k++)
          {
            this[i, k] = Value;
          }
        }
      }

      public void RotateRight()
      {
        int Len = this.GetLength();
        TMatrixObject Result = new TMatrixObject(Len, Len);
        for (int i = Len - 1; i >= 0; --i)
        {
          for (int j = 0; j < Len; ++j)
          {
            Result[j, (Len - 1) - i] = this[i, j];
          }
        }
        for (int i = 0; i < Len; i++)
        {
          for (int k = 0; k < Len; k++)
          {
            this[i, k] = Result[i, k];
          }
        }
      }

      public static void Print(ref TMatrixObject Matr)
      {
        int Rows = Matr.GetLength(0);
        int Cols = Matr.GetLength(1);
        TRobot.Writeln("{");
        for (int i = 0; i < Rows; i++)
        {
          string str = " ";
          for (int k = 0; k < Cols; k++)
          {
            str += Matr[i, k].ToString() + ", ";
          }
          TRobot.Writeln(str);
        }
        TRobot.Writeln("};");
      }

      public void Print()
      {
        int Rows = GetLength(0);
        int Cols = GetLength(1);
        TRobot.Writeln("{");
        for (int i = 0; i < Rows; i++) {
          string Str = " ";
          for (int k = 0; k < Cols; k++)
            Str += this[i, k].ToString() + ", ";
          TRobot.Writeln(Str);
        }
        TRobot.Writeln("};");
      }

      public TMatrixObject(int X = 0, int Y = 0)
      {
        MatrixArray = new int[X, Y];
      }
    }

    class TField : Object
    {
      public int[,] Field;
      public TField(int Rows = 0, int Columns = 0)
      {
        int Max = Rows;
        if (Columns > Max)
          Max = Columns;
        this.Field = new int[Max, Max];

      }
    }
  }
}
