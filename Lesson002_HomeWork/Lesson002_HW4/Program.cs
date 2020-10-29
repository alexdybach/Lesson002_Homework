using System;

namespace Lesson002_HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159265359;
            double r = 5;
            double s = pi * Math.Pow(r, 2);
            Console.WriteLine($"Площа круга (при r = {r}):  {s}");
        }
    }
}
