using System;

namespace Day6
{
    class BaseRectangle
    {
        public int Width {get; set;}

        public int Higth {get; set;}

        public int GetSize() => Width * Higth;

        public static int GetSize(BaseRectangle[] r)
        {
            int res = 0;
            for (int i = 0; i < r.Length; i++)
            {
                res += r[i].GetSize();
            }
           return res;
        }

        public BaseRectangle() {}

        public BaseRectangle(BaseRectangle r) : this(r.Width, r.Higth) {}

        public BaseRectangle(int w, int h)
        {
            Width = w;
            Higth = h;
        }

    }
}
