using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//written by Coutaq
namespace LabOne
{
    class TaskEleven
    {
        public static void Do()
        {
            int x = 0;
            int a = 0;
            int b = 0;
            int c = 0;
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
                tryAgain = true;
                Console.Write("Please enter c: ");
                while (tryAgain)
                {
                    try
                    {
                        c = int.Parse(Console.ReadLine());
                        tryAgain = false;
                    }
                    catch (FormatException e)
                    {
                        Console.Write("Incorrect input, try again: ");
                    }
                }
                double ln = Math.Log((a + x * x), Math.E);
                double sin = Math.Sin(x / b)*Math.Sin(x/b);
                double f = ln + sin; //D= {x element R : a + x^2>0}
                Console.WriteLine("f="+f);
                double upRoot = Math.Sqrt(x + a);
                double downRoot = Math.Sqrt(Math.Sqrt((x * x - 2 * x * b + b * b)));
                double numerator = x + upRoot;
                double denomenator = x - downRoot;
                double z = numerator / denomenator * Math.Pow(Math.E, -c*x);
                Console.WriteLine("z="+z);
            }

        }
    }
}
