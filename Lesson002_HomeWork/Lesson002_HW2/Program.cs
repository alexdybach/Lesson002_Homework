﻿using System;

namespace Lesson002_HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12, z = 3;
            Console.WriteLine($"1) x+=y-x++*z:\t {x += y - x++ * z}");

            x = 10;
            y = 12;
            z = 3;
            Console.WriteLine($"2) z=--x-y*5:\t {z = --x - y * 5}");

            x = 10;
            y = 12;
            z = 3;
            Console.WriteLine($"3) y/=x+5%z:\t {y /= x + 5 % z}");

            x = 10;
            y = 12;
            z = 3;
            Console.WriteLine($"4) z=x++ +y*5:\t {z = x++ + y * 5}");

            x = 10;
            y = 12;
            z = 3;
            Console.WriteLine($"5) x=y-x++*z:\t {x = y - x++ * z}");
        }
    }
}
