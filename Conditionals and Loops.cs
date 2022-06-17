/*
You are an elementary school teacher and explaining multiplication to students.
You are going to use multiplication by 3 as your example.
The program you are given takes N number as input. Write a program to output all numbers from 1 to N, replacing all numbers that are multiples of 3 by "*".
*/

using System;
using System.Collections.Generic;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());


            for (int x = 1; x <= N; x++)
            {
                if (x%3 == 0)
                {
                    Console.Write("*");
                }

                else
                {
                    Console.Write(x);
                }
            }

            
        }
    }
}
