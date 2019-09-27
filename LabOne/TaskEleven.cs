using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne
{
    class TaskEleven
    {
        public static void Do()
        {
            int x = 0;
            int a = 0;
            int b = 0;
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
                tryAgain = true;
                Console.Write("Please enter a: ");
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
                tryAgain = true;
                Console.Write("Please enter b: ");
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

                double ln = Math.Log((a + x * x), Math.E);
                double sin = Math.Sin(x / b)*Math.Sin(x/b);
                double f = ln + sin;
                Console.WriteLine(f);
            }

        }
    }
}
