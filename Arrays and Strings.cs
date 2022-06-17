/*
The program you are given defines an array with 10 words and takes a letter as input.
Write a program to iterate through the array and output words containing the taken letter.
If there is no such word, the program should output "No match". 
*/

using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();

            int count = 0;
            
            //your code goes here
            foreach (string x in words)
            {
                if (x.Contains(letter))
                {
                    Console.WriteLine(x);
                }
                else
                {
                    count += 1;
                }


            }

            if (count == words.Length)
                {
                    Console.WriteLine("No match");
                }
            
        }
    }
}
