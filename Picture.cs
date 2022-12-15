using System;

namespace Day6
{
    class Picture
    {
        Squre _squre;
        Squre[] _sqList = new Squre[0];

        public Picture(){}
        public Picture(Squre s)
        {
            Sq = s;
        }

        public Picture(Squre[] s)
        {
            SqList = s;
        }

        public Squre Sq
        {
            get => new Squre(_squre);
            set => _squre = new Squre(value);
        }

        public Squre[] SqList
        {
            get => _sqList;
            set
            {
                _sqList = new Squre[value.Length];
                for (int i = 0; i < value.Length; i++)
                {
                    _sqList[i] = value[i];
                }
            }
        }

        public Rectangle r {get; set;}

        public double c(Cicle a)
        {
            return a.Calc();
        }

        public int CalcRectangel()
        {
            try
            {
                return (r.Width + r.Hight) * 2;
            }
            catch (NullReferenceException)
            {
                return 0;
            }
        }

        public void Display()
        {
            Squre[] s = SqList;
            if (s.Length > 0)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    Console.WriteLine($"Size of Picture {i+1} is: {s[i].Calc() + CalcRectangel()}");
                }
                return;
            }
           Console.WriteLine($"Size of Picture is: {Sq.Calc() + CalcRectangel()}");
        }

    }
}
