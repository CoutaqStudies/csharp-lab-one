﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne
{
    class TaskNine
    {
        public static void Do()
        {
            double x = 0;
            Console.Write("Please enter your number: ");
            bool tryAgain = true;
            while (tryAgain)
            {
                try
                {
                    x = double.Parse(Console.ReadLine());
                    tryAgain = false;
                }
                catch (FormatException e)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            int d = (int)Math.Round((x % 1) * 10);
            Console.WriteLine(d);
        }
    }
}