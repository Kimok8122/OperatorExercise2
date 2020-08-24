﻿using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            //write out the results of addition, subtraction, multiplication, division operations. 

            var a = 17;
            var b = 4;

            var div = a / b;
            var add = a + b;
            var minus = a - b;
            var times = a * b;
            var mod = a % b;

            Console.WriteLine("Here we go!");
            Console.WriteLine($"{a}/{b} is {div}");
            Console.WriteLine($"{a}+{b} is {add}");
            Console.WriteLine($"{a}-{b} is {minus}");
            Console.WriteLine($"{a}*{b} is {times}");
            Console.WriteLine($"{a}/{b} is {div} remainder being {mod}");

            var radius = double.Parse(Console.ReadLine());

            var r = 20;
            var pi = Math.PI;

            var areaOfCircle = pi * (r * r);
            var areaOfCircleInput = radius;

            Console.WriteLine($"The area of a circle with radius of {r} is {areaOfCircle}");
            Console.WriteLine($"However, the area of a circle with radius of {radius} is {areaOfCircleInput}");

        }
    }
}