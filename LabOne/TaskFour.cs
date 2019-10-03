using System;
//written by Coutaq
namespace LabOne
{
    internal class TaskFour
    {
        public static void Do()
        {
            int x, y;
            Console.Write("Please enter x: ");
            while (true)
            {
                try
                {
                    x = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            Console.Write("Please enter y: ");
            while (true)
            {
                try
                {
                    y = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            y -= x;
            x -= y;
            y += x;
            Console.WriteLine("X: " + x + "; Y: " + y);
        }
    }
}
