using System;

namespace Day6
{
    class Squre
    {
        int _width;
        int _hight;
        Squre[] _List;

        public Squre(): this(1, 1){}
        public Squre(Squre s): this(s.Width, s.Hight){}
        public Squre(int w, int h)
        {
            Width = w;
            Hight = h;
        }
        public Squre(Squre[] s)
        {
            _List = new Squre[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                _List[i] = s[i];
            }
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
            return (Width + Hight) *  2;
        }

        public static implicit operator Squre(Squre[] s )
        {
            Squre[] List = new Squre[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                List[i] = s[i];
            }
            return List;
        }
    }
}
