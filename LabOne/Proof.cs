using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne
{
    class Proof
    {
        public static void Do()
        {
            int a,b;
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
            int abs = Math.Abs(a - b);
            int alt = (int)Math.Sqrt(a * a - 2 * a * b + b * b);
            Console.WriteLine(abs + "=" + alt);
        }
    }
}
