using System;

namespace Day6
{
    class Program
    {
        public static void Main()
        {
            Picture pic = new Picture();
            Squre sq = new Squre(1, 3);
            pic.Sq = sq;
            pic.Display();

            Squre s1 = new Squre(1, 2);
            Squre s2 = new Squre(2,3);
            Squre[] ss = new Squre[2] {s1, s2};
            Rectangle rec = new Rectangle(10, 6);

            pic = new Picture(ss);
            pic.r = rec;
            pic.Display();

            Cicle c = new Cicle();
            c.Raduis = 10;
            Console.WriteLine(pic.c(c));
        }
    }
}
