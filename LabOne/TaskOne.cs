using System;
//written by Coutaq
namespace LabOne
{
    internal class TaskOne
    {
        public static void Do()
        {
            double x ;
            Console.Write("Please enter your number: ");
            while (true)
            {
                try
                {
                    x = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            int d = (int)Math.Round((x % 1) * 10);
            Console.WriteLine(d);
        }
    }
}
