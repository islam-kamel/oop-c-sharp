using System;

namespace Day6
{
    class BasePicture
    {
        int[] _array_of_circle;
        BaseSquare[] _array_of_square;
        BaseSquare _square;

        public BaseRectangle Rect {get; set;}

        public BaseRectangle[] ArrayOfRect {get; set;}

        public BaseSquare Square
        {
            get => BaseSquare.DeepCopy(_square);

            set => _square= BaseSquare.DeepCopy(value);
        }

        public BaseSquare[] ArraySqr
        {
            get => BaseSquare.DeepCopy(_array_of_square);
            set => _array_of_square = BaseSquare.DeepCopy(value);
        }

        public int Circle(int raduis) => new BaseCircle(raduis).GetSize();

        public int[] ArrayOfCircle
        {
            get => _array_of_circle;
            set => _array_of_circle = BaseCircle.CalaArray(value);
        }

        public int GetPicSize()
        {
            int res = 0;

            try
            {
                res += BaseSquare.GetSize(ArraySqr);
                res += BaseSquare.GetSize(Square);
                res += BaseRectangle.GetSize(ArrayOfRect);
                res += BaseCircle.GetSize(ArrayOfCircle);
                res += Rect.GetSize();
                return res;
            }
            catch (NullReferenceException) {return res;}

        }

        public static BaseSquare[] ToSquareArray(int[] data) => BaseSquare.ToSquareArray(data);

        public BasePicture() {}

        public BasePicture(int dim)
        {
            _square = new BaseSquare(dim);
        }

        public BasePicture(BaseSquare s) : this(s.Dim) {}

        public BasePicture(BaseSquare[] s) => ArraySqr = s;

        public static implicit operator BasePicture (BaseSquare[] s) => new BasePicture(s);

    }




    class Picture : BasePicture
    {

        public Picture()
        {
            Square = new BaseSquare(0);
        }

        public Picture(int dim)
        {
            Square = new BaseSquare(dim);
            ArraySqr = new BaseSquare[1] {new BaseSquare()};
        }

        public Picture(BaseSquare s) : this(s.Dim) {}

        public Picture(BaseSquare[] s) => ArraySqr = s;

        public static implicit operator Picture (int[] data)
        {
            Picture pic = new Picture();
            pic.ArraySqr = Picture.ToSquareArray(data);
            return pic;
        }

        public static implicit operator Picture (int dim) => new Picture(dim);

        public static implicit operator Picture (BaseSquare[] s) => new Picture(s);

        public static Picture operator + (Picture pic, int dim)
        {
            pic.Square = new BaseSquare(pic.Square.Dim + dim);
            return pic;
        }

        public static Picture operator + (Picture pic, int[] data)
        {
            pic.ArraySqr = Picture.ToSquareArray(data);
            return pic;
        }

        public static Picture operator + (Picture pic, int[,] data)
        {
            BaseRectangle[] rec = new BaseRectangle[data.GetLength(0)];
            for (int i = 0; i < data.GetLength(0); i++)
            {
                rec[i] = new BaseRectangle();
                rec[i].Width = data[i, 0];
                rec[i].Higth = data[i, 1];
            }
            pic.ArrayOfRect = rec;
            return pic;
        }
    }
}

