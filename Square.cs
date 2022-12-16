using System;

namespace Day6
{

   class BaseSquare
   {
        public int Dim {get; set;}

        public static int GetSize(BaseSquare square) => square.Dim * square.Dim;

        public static int GetSize(BaseSquare[] arr)
        {
            int size = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                size += BaseSquare.GetSize(arr[i]);
            }
            return size;
        }

        public static BaseSquare DeepCopy(BaseSquare sqr) => new BaseSquare(sqr);

        public static BaseSquare[] DeepCopy(BaseSquare[] sqrArr)
        {

            BaseSquare[] arr = new BaseSquare[sqrArr.Length];
            for (int i = 0; i < sqrArr.Length; i++)
            {
                arr[i] = new BaseSquare(sqrArr[i]);
            }
            return arr;
        }

        public static BaseSquare[] ToSquareArray(int[] data)
        {
            BaseSquare[] temp = new BaseSquare[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                temp[i] = new BaseSquare(data[i]);
            }
            return temp;
        }

        public BaseSquare() {}

        public BaseSquare(int dim) => Dim = dim;

        #region Chaing
        public BaseSquare(BaseSquare s) : this(s.Dim) {}
        #endregion

        public static implicit operator BaseSquare (int value) => new BaseSquare(value);

        public static implicit operator int (BaseSquare value) => value.Dim;

    }

}
