﻿/*
 * Author: Oscar Mendez
 * Course: COMP-003A
 * Purpose: Lecture Activity 4
 */

namespace COMP003A.LectureActivity4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadRight(50,'*'));
            Console.WriteLine("for-loop statement");
            Console.WriteLine("".PadRight(50, '*'));

            //count 0-9
            int limit = 10;// variable limit for the loop
            
            /*
             * The for statement: executes its body while a specified Boolean expression evaluates to true.
             * there are 3 parts in the for loop statement
             * 1. int counter = 0; => loop variable initialization
             * 2. counter < limit; => condition
             * 3. counter++ => iterator
             */

            for (int couunter = 0; couunter < limit; couunter++)
            {
                // this code block will execute every loop
                Console.WriteLine($"\tCurrent counter: {counter}");
            }

            Console.WriteLine("\n"); // new line
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("foreach statement");
            Console.WriteLine("".PadRight(50, '*'));

            // this is a simple array with 10 items in it. you will learn more about arrays on module 7
        }
    }
}
