/*
 * Author: Oscar Mendez
 * Course: COMP-003A
 * Purpose: Lecture Activity 4
 */

using System.Net.Http.Headers;

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

            for (int counter = 0; counter < limit; counter++)
            {
                // this code block will execute every loop
                Console.WriteLine($"\tCurrent counter: {counter}");
            }

            Console.WriteLine("\n"); // new line
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("foreach statement");
            Console.WriteLine("".PadRight(50, '*'));

            // this is a simple array with 10 items in it. you will learn more about arrays on module 7
            string[] simpleArray = new string[]
            {
                "eleifend","donec","pretium","vulputate","sapien","nec","sagittis","aliquam","malesuada","bibendum"
            };

            // enumerates the elements of a collection and executes its body for each element of the collection
            foreach (var item in simpleArray)
            {
                Console.WriteLine($"\tCurrent item: {item} ");
            }

            Console.WriteLine("\n"); // new line
            Console.WriteLine("".PadRight(50,'*'));
            Console.WriteLine("do-while statemenet");
            Console.WriteLine("".PadRight(50, '*'));

            /*
             * The do statement executes a statement or a block of statements while a specified
             * Boolean expression evaluates to true. Because that expression is evaluated after
             * each execution of the loop, a do loop executes one or more times. the do
             * statement differs from a while loop, which executes zero or more times.
             */

            int counter2 = 0; //intitial counter2 value
        }
    }
}
