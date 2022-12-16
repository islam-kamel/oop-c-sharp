using System;

namespace Day6
{
    class BaseCircle
    {
        double _pi = 3.14159265359;

        public BaseCircle(int raduis) => Raduis = raduis;

        public int Raduis {get; set;}

        public double PI {get => _pi;}

        public int GetSize() => (int) PI * (Raduis * Raduis);

        public static int[] CalaArray(int[] data)
        {
            int[] arr = new int[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                arr[i] = new BaseCircle(data[i]).GetSize();
            }
            return arr;
        }

        public static int GetSize(int[] data)
        {
            int res = 0;
            for (int i = 0; i < data.Length; i++)
            {
                res += data[i];
            }
            return res;
        }
    }
}
