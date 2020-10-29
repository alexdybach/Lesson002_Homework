using System;
using System.Text;

namespace Lesson002_HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            const double pi = 3.14159265359;
            double r = 3, h = 5;

            double v = pi * Math.Pow(r, 2) * h;
            double s = 2 * pi * r * (r + h);

            Console.WriteLine($"Площа поверхні циліндра (при r = {r}; h = {h}):  {s}");
            Console.WriteLine($"Об'єм циліндра:  {v}");
        }
    }
}
