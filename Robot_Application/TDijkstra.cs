using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Direction_Main;

namespace Robot_Project.Path
{
	class TNodeRecord
	{
		public Direction_Main.TPoint Position = new TPoint(0, 0);

		public TNodeRecord(int X = 0, int Y = 0)
		{
			Position = new TPoint(X, Y);
		}

		public TNodeRecord(TPoint Position)
		{
			this.Position.X = Position.X;
			this.Position.Y = Position.Y;
		}
	}

	class TNodesList: List<TNodeRecord>
	{
		public bool nodeExists(TNodeRecord Node)
		{
			for (int i = 0; i < this.Count; i++)
			{
				if (Node.Position == this[i].Position)
					return true;
			}
			return false;
		}
	}

	class TNode
	{
		public static int State_None = 0;
		public static int State_Found = 1;

		// public List<TNode> Ways;
		public TNodeRecord Position;
		public TDijkstra Dijkstra;
		public TNode ParentNode;

		public int NextStep()
		{
			int Result = State_None;
			return Result;
		} 

		public List<TNode> ScanAround()
		{
			List<TNode> Result = new List<TNode>();
			TPoint Current = this.Position.Position;
			TFieldSection Self = Dijkstra.Field[Current];
			TPoint ForwardRaw = Current + new TPoint(1, 0);
			TPoint RightRaw = Current + new TPoint(0, 1);
			TPoint BackwardRaw = Current - new TPoint(1, 0);
			TPoint LeftRaw = Current - new TPoint(0, 1);
			int Length = Dijkstra.Field.Length;

			this.Dijkstra.Nodes.Add(this.Position);

			if (ForwardRaw.isValid(Length - 1) && !Self.isBlockedRaw(Constants.Direction_Forward))
			{
				TPoint Copied = ForwardRaw;
				TNodeRecord Rec = new TNodeRecord(Copied.X, Copied.Y);
				if (!Dijkstra.Nodes.nodeExists(Rec))
					Result.Add(new TNode(Rec, Dijkstra, this));
			}
			if (RightRaw.isValid(Length - 1) && !Self.isBlockedRaw(Constants.Direction_Right))
			{
				TPoint Copied = ForwardRaw;
				TNodeRecord Rec = new TNodeRecord(Copied.X, Copied.Y);
				if (!Dijkstra.Nodes.nodeExists(Rec))
					Result.Add(new TNode(Rec, Dijkstra, this));
			}
			if (BackwardRaw.isValid(Length - 1) && !Self.isBlockedRaw(Constants.Direction_Backward))
			{
				TPoint Copied = ForwardRaw;
				TNodeRecord Rec = new TNodeRecord(Copied.X, Copied.Y);
				if (!Dijkstra.Nodes.nodeExists(Rec))
					Result.Add(new TNode(Rec, Dijkstra, this));
			}
			if (LeftRaw.isValid(Length - 1) && !Self.isBlockedRaw(Constants.Direction_Left))
			{
				TPoint Copied = ForwardRaw;
				TNodeRecord Rec = new TNodeRecord(Copied.X, Copied.Y);
				if (!Dijkstra.Nodes.nodeExists(Rec))
					Result.Add(new TNode(Rec, Dijkstra, this));
			} 
			return Result;
		}
		
		public TNode(TNodeRecord Position, TDijkstra Dijkstra, TNode ParentNode)
		{
			this.Position = Position;
			this.Dijkstra = Dijkstra;
			this.ParentNode = ParentNode;
		}
	}

	class TWay: List<TNodeRecord>
	{
		
	}

	class TDijkstra
	{
		public TNodesList Nodes;
		public TField Field;

		public TPoint StartPosition;
		public TPoint StopPosition;

		public TWay Way;

		public bool Search_Way()
		{
			// Big and difficult

			TNodeRecord RecFirst = new TNodeRecord(StartPosition);
			TNode FinishNode = null;
			List<TNode> Storage = new List<TNode>();
			List<TNode> Maintance = new List<TNode>();

			Storage.Add(new TNode(RecFirst, this, null)); // First node.

			bool Check = false;

			while (!Check && (Storage.Count > 0))
			{
				Maintance.Clear();
				Maintance = Storage[0].ScanAround();
				Storage.RemoveAt(0); // Clearing this point
				for (int i = 0; i < Maintance.Count; i++)
				{
					if (Maintance[i].Position.Position == StopPosition)
					{
						FinishNode = Maintance[i]; // Memorize!
						Check = true;
						break;
					}
					else
						Storage.Add(Maintance[i]);
				}
				if (Check)
					break;
			}

			if (Check)
			{
				// We need to recreate path
				TNode Current = FinishNode;
				while (Current != null)
				{
					this.Way.Add(new TNodeRecord(Current.Position.Position));
					Current = Current.ParentNode;
				}
				if (Way.Count <= 0)
					throw new Exception("Way s almost empty.");
			}

			return Check;
		}

		public TDijkstra(TPoint Start, TPoint Finish, TField Field)
		{
			Way = new TWay();
			Way.Clear();
			Nodes = new TNodesList();
			StartPosition = Start;
			StopPosition = Finish;
			this.Field = Field;
		}
	}
}
