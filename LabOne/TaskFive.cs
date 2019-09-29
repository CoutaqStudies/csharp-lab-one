using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//written by Coutaq
namespace LabOne
{
    class TaskFive
    {
        public static void Do()
        {
            int a = 0;
            int b = 0;
            Console.Write("Please enter a: ");
            bool tryAgain = true;
            while (tryAgain)
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                    tryAgain = false;
                }
                catch (FormatException e)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            Console.Write("Please enter b: ");
            tryAgain = true;
            while (tryAgain)
            {
                try
                {
                    b = int.Parse(Console.ReadLine());
                    tryAgain = false;
                }
                catch (FormatException e)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            double area = a * b / 2;
            double perimeter = a + b + Math.Sqrt(a * a + b * b);
            Console.WriteLine("Area: " + area + "; Perimeter: " + perimeter);

        }
    }
}
