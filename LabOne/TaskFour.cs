using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//written by Coutaq
namespace LabOne
{
    class TaskFour
    {
        public static void Do()
        {
            int x = 0;
            int y = 0;
            Console.Write("Please enter x: ");
            bool tryAgain = true;
            while (tryAgain)
            {
                try
                {
                    x = int.Parse(Console.ReadLine());
                    tryAgain = false;
                }
                catch (FormatException e)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            Console.Write("Please enter y: ");
            tryAgain = true;
            while (tryAgain)
            {
                try
                {
                    y = int.Parse(Console.ReadLine());
                    tryAgain = false;
                }
                catch (FormatException e)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }

            y = x-y;
            x = x-y;
            y = x+y;
            Console.WriteLine("X: " + x + "; Y: " + y);
        }
    }
}
