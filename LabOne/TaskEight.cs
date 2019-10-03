using System;
//written by Coutaq
namespace LabOne
{
    internal class TaskEight
    {
        public static void Do()
        {
            Console.Write("Please enter your number: ");
            double x;
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
            double answer = 7 + x * (-1 + x * (2 + x * (-5 + 3 * x)));
            Console.WriteLine(answer);
        }
    }
}
