﻿using Direction_Main;

namespace Field_Generated
{
	class Field_Generated_Class
	{
		public static TField Generate()
		{
			int Len = 10;
			TField Result = new TField(Len, Len);

			Result[0, 0] = new TFieldSection(Result);
			Result[0, 0].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[0, 0].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[0, 0].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[0, 0].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[0, 1] = new TFieldSection(Result);
			Result[0, 1].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[0, 1].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[0, 1].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[0, 1].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[0, 2] = new TFieldSection(Result);
			Result[0, 2].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[0, 2].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[0, 2].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[0, 2].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[0, 3] = new TFieldSection(Result);
			Result[0, 3].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[0, 3].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[0, 3].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[0, 3].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[0, 4] = new TFieldSection(Result);
			Result[0, 4].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[0, 4].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[0, 4].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[0, 4].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[0, 5] = new TFieldSection(Result);
			Result[0, 5].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[0, 5].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[0, 5].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[0, 5].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[0, 6] = new TFieldSection(Result);
			Result[0, 6].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[0, 6].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[0, 6].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[0, 6].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[0, 7] = new TFieldSection(Result);
			Result[0, 7].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[0, 7].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[0, 7].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[0, 7].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[0, 8] = new TFieldSection(Result);
			Result[0, 8].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[0, 8].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[0, 8].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[0, 8].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[0, 9] = new TFieldSection(Result);
			Result[0, 9].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[0, 9].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[0, 9].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[0, 9].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 0] = new TFieldSection(Result);
			Result[1, 0].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 0].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 0].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[1, 0].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[1, 1] = new TFieldSection(Result);
			Result[1, 1].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[1, 1].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 1].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 1].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 2] = new TFieldSection(Result);
			Result[1, 2].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 2].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 2].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[1, 2].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 3] = new TFieldSection(Result);
			Result[1, 3].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[1, 3].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 3].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 3].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 4] = new TFieldSection(Result);
			Result[1, 4].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 4].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 4].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[1, 4].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 5] = new TFieldSection(Result);
			Result[1, 5].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[1, 5].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 5].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 5].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 6] = new TFieldSection(Result);
			Result[1, 6].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 6].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 6].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[1, 6].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 7] = new TFieldSection(Result);
			Result[1, 7].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[1, 7].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 7].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 7].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 8] = new TFieldSection(Result);
			Result[1, 8].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 8].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 8].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[1, 8].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 9] = new TFieldSection(Result);
			Result[1, 9].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[1, 9].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[1, 9].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[1, 9].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[2, 0] = new TFieldSection(Result);
			Result[2, 0].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[2, 0].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[2, 0].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[2, 0].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[2, 1] = new TFieldSection(Result);
			Result[2, 1].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[2, 1].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[2, 1].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[2, 1].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[2, 2] = new TFieldSection(Result);
			Result[2, 2].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[2, 2].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[2, 2].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[2, 2].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[2, 3] = new TFieldSection(Result);
			Result[2, 3].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[2, 3].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[2, 3].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[2, 3].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[2, 4] = new TFieldSection(Result);
			Result[2, 4].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[2, 4].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[2, 4].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[2, 4].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[2, 5] = new TFieldSection(Result);
			Result[2, 5].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[2, 5].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[2, 5].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[2, 5].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[2, 6] = new TFieldSection(Result);
			Result[2, 6].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[2, 6].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[2, 6].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[2, 6].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[2, 7] = new TFieldSection(Result);
			Result[2, 7].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[2, 7].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[2, 7].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[2, 7].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[2, 8] = new TFieldSection(Result);
			Result[2, 8].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[2, 8].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[2, 8].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[2, 8].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[2, 9] = new TFieldSection(Result);
			Result[2, 9].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[2, 9].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[2, 9].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[2, 9].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[3, 0] = new TFieldSection(Result);
			Result[3, 0].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[3, 0].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[3, 0].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[3, 0].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[3, 1] = new TFieldSection(Result);
			Result[3, 1].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[3, 1].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[3, 1].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[3, 1].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[3, 2] = new TFieldSection(Result);
			Result[3, 2].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[3, 2].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[3, 2].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[3, 2].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[3, 3] = new TFieldSection(Result);
			Result[3, 3].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[3, 3].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[3, 3].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[3, 3].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[3, 4] = new TFieldSection(Result);
			Result[3, 4].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[3, 4].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[3, 4].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[3, 4].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[3, 5] = new TFieldSection(Result);
			Result[3, 5].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[3, 5].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[3, 5].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[3, 5].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[3, 6] = new TFieldSection(Result);
			Result[3, 6].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[3, 6].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[3, 6].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[3, 6].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[3, 7] = new TFieldSection(Result);
			Result[3, 7].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[3, 7].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[3, 7].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[3, 7].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[3, 8] = new TFieldSection(Result);
			Result[3, 8].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[3, 8].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[3, 8].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[3, 8].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[3, 9] = new TFieldSection(Result);
			Result[3, 9].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[3, 9].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[3, 9].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[3, 9].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[4, 0] = new TFieldSection(Result);
			Result[4, 0].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[4, 0].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[4, 0].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[4, 0].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[4, 1] = new TFieldSection(Result);
			Result[4, 1].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[4, 1].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[4, 1].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[4, 1].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[4, 2] = new TFieldSection(Result);
			Result[4, 2].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[4, 2].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[4, 2].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[4, 2].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[4, 3] = new TFieldSection(Result);
			Result[4, 3].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[4, 3].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[4, 3].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[4, 3].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[4, 4] = new TFieldSection(Result);
			Result[4, 4].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[4, 4].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[4, 4].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[4, 4].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[4, 5] = new TFieldSection(Result);
			Result[4, 5].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[4, 5].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[4, 5].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[4, 5].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[4, 6] = new TFieldSection(Result);
			Result[4, 6].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[4, 6].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[4, 6].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[4, 6].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[4, 7] = new TFieldSection(Result);
			Result[4, 7].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[4, 7].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[4, 7].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[4, 7].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[4, 8] = new TFieldSection(Result);
			Result[4, 8].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[4, 8].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[4, 8].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[4, 8].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[4, 9] = new TFieldSection(Result);
			Result[4, 9].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[4, 9].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[4, 9].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[4, 9].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 0] = new TFieldSection(Result);
			Result[5, 0].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 0].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 0].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[5, 0].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[5, 1] = new TFieldSection(Result);
			Result[5, 1].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[5, 1].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 1].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 1].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 2] = new TFieldSection(Result);
			Result[5, 2].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 2].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 2].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[5, 2].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 3] = new TFieldSection(Result);
			Result[5, 3].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[5, 3].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 3].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 3].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 4] = new TFieldSection(Result);
			Result[5, 4].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 4].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 4].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[5, 4].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 5] = new TFieldSection(Result);
			Result[5, 5].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[5, 5].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 5].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 5].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 6] = new TFieldSection(Result);
			Result[5, 6].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 6].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 6].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[5, 6].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 7] = new TFieldSection(Result);
			Result[5, 7].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[5, 7].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 7].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 7].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 8] = new TFieldSection(Result);
			Result[5, 8].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 8].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 8].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[5, 8].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 9] = new TFieldSection(Result);
			Result[5, 9].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[5, 9].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[5, 9].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[5, 9].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[6, 0] = new TFieldSection(Result);
			Result[6, 0].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[6, 0].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[6, 0].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[6, 0].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[6, 1] = new TFieldSection(Result);
			Result[6, 1].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[6, 1].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[6, 1].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[6, 1].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[6, 2] = new TFieldSection(Result);
			Result[6, 2].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[6, 2].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[6, 2].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[6, 2].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[6, 3] = new TFieldSection(Result);
			Result[6, 3].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[6, 3].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[6, 3].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[6, 3].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[6, 4] = new TFieldSection(Result);
			Result[6, 4].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[6, 4].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[6, 4].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[6, 4].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[6, 5] = new TFieldSection(Result);
			Result[6, 5].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[6, 5].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[6, 5].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[6, 5].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[6, 6] = new TFieldSection(Result);
			Result[6, 6].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[6, 6].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[6, 6].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[6, 6].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[6, 7] = new TFieldSection(Result);
			Result[6, 7].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[6, 7].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[6, 7].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[6, 7].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[6, 8] = new TFieldSection(Result);
			Result[6, 8].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[6, 8].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[6, 8].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[6, 8].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[6, 9] = new TFieldSection(Result);
			Result[6, 9].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[6, 9].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[6, 9].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[6, 9].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[7, 0] = new TFieldSection(Result);
			Result[7, 0].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[7, 0].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[7, 0].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[7, 0].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[7, 1] = new TFieldSection(Result);
			Result[7, 1].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[7, 1].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[7, 1].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[7, 1].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[7, 2] = new TFieldSection(Result);
			Result[7, 2].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[7, 2].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[7, 2].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[7, 2].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[7, 3] = new TFieldSection(Result);
			Result[7, 3].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[7, 3].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[7, 3].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[7, 3].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[7, 4] = new TFieldSection(Result);
			Result[7, 4].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[7, 4].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[7, 4].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[7, 4].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[7, 5] = new TFieldSection(Result);
			Result[7, 5].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[7, 5].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[7, 5].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[7, 5].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[7, 6] = new TFieldSection(Result);
			Result[7, 6].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[7, 6].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[7, 6].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[7, 6].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[7, 7] = new TFieldSection(Result);
			Result[7, 7].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[7, 7].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[7, 7].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[7, 7].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[7, 8] = new TFieldSection(Result);
			Result[7, 8].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[7, 8].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[7, 8].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[7, 8].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[7, 9] = new TFieldSection(Result);
			Result[7, 9].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[7, 9].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[7, 9].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[7, 9].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[8, 0] = new TFieldSection(Result);
			Result[8, 0].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[8, 0].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[8, 0].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[8, 0].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[8, 1] = new TFieldSection(Result);
			Result[8, 1].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[8, 1].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[8, 1].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[8, 1].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[8, 2] = new TFieldSection(Result);
			Result[8, 2].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[8, 2].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[8, 2].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[8, 2].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[8, 3] = new TFieldSection(Result);
			Result[8, 3].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[8, 3].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[8, 3].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[8, 3].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[8, 4] = new TFieldSection(Result);
			Result[8, 4].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[8, 4].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[8, 4].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[8, 4].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[8, 5] = new TFieldSection(Result);
			Result[8, 5].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[8, 5].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[8, 5].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[8, 5].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[8, 6] = new TFieldSection(Result);
			Result[8, 6].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[8, 6].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[8, 6].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[8, 6].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[8, 7] = new TFieldSection(Result);
			Result[8, 7].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[8, 7].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[8, 7].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[8, 7].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[8, 8] = new TFieldSection(Result);
			Result[8, 8].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[8, 8].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[8, 8].Backward_Wall_Raw = Constants.FieldSection_Free;
			Result[8, 8].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[8, 9] = new TFieldSection(Result);
			Result[8, 9].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[8, 9].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[8, 9].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[8, 9].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[9, 0] = new TFieldSection(Result);
			Result[9, 0].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[9, 0].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[9, 0].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[9, 0].Left_Wall_Raw = Constants.FieldSection_Blocked;
			Result[9, 1] = new TFieldSection(Result);
			Result[9, 1].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[9, 1].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[9, 1].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[9, 1].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[9, 2] = new TFieldSection(Result);
			Result[9, 2].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[9, 2].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[9, 2].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[9, 2].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[9, 3] = new TFieldSection(Result);
			Result[9, 3].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[9, 3].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[9, 3].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[9, 3].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[9, 4] = new TFieldSection(Result);
			Result[9, 4].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[9, 4].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[9, 4].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[9, 4].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[9, 5] = new TFieldSection(Result);
			Result[9, 5].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[9, 5].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[9, 5].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[9, 5].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[9, 6] = new TFieldSection(Result);
			Result[9, 6].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[9, 6].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[9, 6].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[9, 6].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[9, 7] = new TFieldSection(Result);
			Result[9, 7].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[9, 7].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[9, 7].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[9, 7].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[9, 8] = new TFieldSection(Result);
			Result[9, 8].Forward_Wall_Raw = Constants.FieldSection_Free;
			Result[9, 8].Right_Wall_Raw = Constants.FieldSection_Free;
			Result[9, 8].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[9, 8].Left_Wall_Raw = Constants.FieldSection_Free;
			Result[9, 9] = new TFieldSection(Result);
			Result[9, 9].Forward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[9, 9].Right_Wall_Raw = Constants.FieldSection_Blocked;
			Result[9, 9].Backward_Wall_Raw = Constants.FieldSection_Blocked;
			Result[9, 9].Left_Wall_Raw = Constants.FieldSection_Free;

			return Result;
		}
	}
}