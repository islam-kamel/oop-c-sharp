using System;

namespace Day6
{
    class Rectangle
    {
        int _width;
        int _hight;

        public Rectangle(int w, int h)
        {
            Width = w;
            Hight = h;
        }

        public int Width
        {
            get => _width;
            set => _width = value;
        }

        public int Hight
        {
            get => _hight;
            set => _hight = value;
        }

        public int Calc()
        {
            return (Width * 2) + (Hight * 2);
        }
    }
}
