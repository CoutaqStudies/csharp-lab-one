using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne
{
    class TaskThree
    {
        public static void Do()
        {
            int hours = 0;
            int minutes = 0;
            int seconds = 0;
            Console.Write("Please enter the hours: ");
            bool tryAgain = true;
            while (tryAgain)
            {
                try
                {
                    hours = int.Parse(Console.ReadLine());
                    if (hours > 11 || hours < 0)
                    {
                        throw new FormatException();
                    }
                    tryAgain = false;
                }
                catch (FormatException e)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            Console.Write("Please enter the minutes: ");
            tryAgain = true;
            while (tryAgain)
            {
                try
                {
                    minutes = int.Parse(Console.ReadLine());
                    if (minutes > 59 || minutes < 0)
                    {
                        throw new FormatException();
                    }
                    tryAgain = false;
                }
                catch (FormatException e)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            Console.Write("Please enter the seconds: ");
            tryAgain = true;
            while (tryAgain)
            {
                try
                {
                    seconds = int.Parse(Console.ReadLine());
                    if (seconds > 59 || seconds < 0)
                    {
                        throw new FormatException();
                    }
                    tryAgain = false;
                }
                catch (FormatException e)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            double degrees = ((hours * 30) +( minutes / 2) + (seconds / 120));
            Console.WriteLine(degrees + " degrees.");
        
        }
    }
}
