using System;

namespace Day6
{
    class Cicle
    {
        int _raduis;

        public int Raduis
        {
            get => _raduis;
            set => _raduis = value;
        }

        public double Calc()
        {
            double pi = 3.14159;
            double area = pi * Raduis * Raduis;
            return area;
        }
    }
}
