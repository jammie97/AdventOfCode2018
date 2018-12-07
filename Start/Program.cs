﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            const int TotalDays = 6;
            while (number != -1)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("~         Menu         -");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("");
                // Display options
                Console.WriteLine("Pick an option:");
                for(int i = 1; i <= TotalDays; i++)
                {
                    Console.WriteLine($"Day\t{i}");
                }
                Console.WriteLine("\nExit\t-1");

                // Take user input
                Console.Write("Option:\t");
                string input = Console.ReadLine();
                // Parse user input
                Int32.TryParse(input, out number);

                Console.WriteLine("\n");

                // Do process depending on user input
                switch (number)
                {
                    case -1:
                        Console.WriteLine("Exiting..");
                        System.Threading.Thread.Sleep(600);
                        break;
                    case 1:
                        Day1 one = new Day1();
                        one.Execute();
                        break;
                    case 2:
                        Day2 two = new Day2();
                        two.Execute();
                        break;
                    case 3:
                        Day3 three = new Day3();
                        three.Execute();
                        break;
                    case 4:
                        Day4 four = new Day4();
                        four.Execute();
                        break;
                    case 5:
                        Day5 five = new Day5();
                        five.Execute();
                        break;
                    case 6:
                        Day6 six = new Day6();
                        six.Execute();
                        break;
                    default:
                        Console.WriteLine("Unknown value entered!");
                        break;

                }

                Console.WriteLine("\n");


            }
        }
    }
}
