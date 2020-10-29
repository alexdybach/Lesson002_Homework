using System;

namespace Lesson002_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 3;
            int addition = a + b;
            int subtraction = a - b;
            float division = (float)a / b;
            int multiplication = a * b;
            int percent = a % b;

            Console.WriteLine($"a = {a}\t b = {b}\nAddition:\t{addition}\nSubtraction:\t{subtraction}\nDivision:\t{division}\nMultiplication:\t{multiplication}\nPercent:\t{percent}");
        }
    }
}
