using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double radius;
            double answer;

            radius = Convert.ToDouble(Console.ReadLine());

            radius = radius * radius;

            answer = pi * radius;

            Console.WriteLine(answer);

        }
    }
}