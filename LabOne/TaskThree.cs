using System;
//written by Coutaq
namespace LabOne
{
    internal class TaskThree
    {
        public static void Do()
        {
            int hours;
            int minutes;
            int seconds;
            Console.Write("Please enter the hours: ");
            while (true)
            {
                try
                {
                    hours = int.Parse(Console.ReadLine());
                    if (hours > 11 || hours < 0)
                    {
                        throw new FormatException();
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            Console.Write("Please enter the minutes: ");
            while (true)
            {
                try
                {
                    minutes = int.Parse(Console.ReadLine());
                    if (minutes > 59 || minutes < 0)
                    {
                        throw new FormatException();
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            Console.Write("Please enter the seconds: ");
            while (true)
            {
                try
                {
                    seconds = int.Parse(Console.ReadLine());
                    if (seconds > 59 || seconds < 0)
                    {
                        throw new FormatException();
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            double degrees = ((hours * 30) + (minutes / 2) + (seconds / 120));
            Console.WriteLine(degrees + " degrees.");
        }
    }
}
