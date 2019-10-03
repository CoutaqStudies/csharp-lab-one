using System;
//written by Coutaq
namespace LabOne
{
    internal class TaskEleven
    {
        public static void Do()
        {
            int x = 0;
            int a = 0;
            int b = 0;
            int c = 0;
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
            Console.Write("Please enter a: ");
            while (true)
             {
                try
                {
                    a = int.Parse(Console.ReadLine());
                    break;
                }
                 catch (FormatException)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            Console.Write("Please enter b: ");
            while (true)
            {
                try
                {
                    b = int.Parse(Console.ReadLine());
                    break;
                }
                 catch (FormatException)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            Console.Write("Please enter c: ");
            while (true)
            {
                try
                {
                    c = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                        Console.Write("Incorrect input, try again: ");
                }
            }
            double ln = Math.Log((a + x * x), Math.E);
            double sin = Math.Sin(x / b) * Math.Sin(x / b);
            double f = ln + sin;
            Console.WriteLine("f=" + f);
            double upRoot = Math.Sqrt(x + a);
            double downRoot = Math.Sqrt(Math.Sqrt((x * x - 2 * x * b + b * b)));  //Math.sqrt(Math.abs(x-b)) if you're nasty (see Proof.cs for further details)
            double numerator = x + upRoot;
            double denomenator = x - downRoot;
            double z = numerator / denomenator * Math.Pow(Math.E, -c * x);
                Console.WriteLine("z=" + z);
        }
    }
}
