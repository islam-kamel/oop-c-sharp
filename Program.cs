using System;

namespace Day6
{
    class Program
    {
        public static void Print(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void Main()
        {
            Picture Pic = new Picture();
            Pic = 10;
            Pic += 10;
            Pic += new int[3] {10, 20, 30};
            Pic += new int[2,2] {{10,5},{5,2}};
            Pic.ArrayOfCircle = new int[3] {3, 10, 40};
            Console.WriteLine($"Pic Size: {Pic.GetPicSize()}");

            #region Composition
            Console.WriteLine("---Composition---");

            Picture MyPic = new Picture(5);
            BaseSquare Hack = MyPic.Square;

            Hack.Dim = 4;
            Console.WriteLine($"Size: After hack: {MyPic.Square.Dim}");
            Console.WriteLine($"Pic Size: {MyPic.GetPicSize()}");
            Console.WriteLine("---Composition---");
            #endregion

            #region implicit Square[] to Picture
            BaseSquare[] sqrArr = new BaseSquare[2] {12, 20};
            MyPic = sqrArr;

            sqrArr[0] = 3;
            sqrArr = MyPic.ArraySqr;
            Console.WriteLine($"Pic Size: {MyPic.GetPicSize()}");
            #endregion

            #region Array of Square
            Console.WriteLine("---Array of Square---");
            sqrArr = new BaseSquare[2] {12, 20};
            Console.WriteLine($"Square Size: {BaseSquare.GetSize(sqrArr)}");

            Console.WriteLine("---Array of Square---");
            #endregion

            #region Rectangle
            Console.WriteLine("-----Rectangle------");

            MyPic = new Picture();

            BaseRectangle[] MyRect = new BaseRectangle[1] {new BaseRectangle(10, 5)};

            MyPic.Rect = new BaseRectangle(10, 5);
            MyRect = new BaseRectangle[3];
            MyRect[0] = new BaseRectangle(20,10);
            MyRect[1] = new BaseRectangle(5,2);
            MyRect[2] = new BaseRectangle(2,1);

            MyPic.ArrayOfRect = MyRect;

            Print($"Pic Size all rect : {BaseRectangle.GetSize(MyPic.ArrayOfRect)}");
            Print($"Rect Size: {MyPic.Rect.GetSize()}");
            #endregion

        }
    }
}
