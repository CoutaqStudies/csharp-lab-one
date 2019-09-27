using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne
{
    class TaskEight
    {
        public static void Do()
        {
            double x = 0;
            Console.Write("Please enter your number: ");
            bool tryAgain = true;
            while (tryAgain)
            {
                try
                {
                    x = double.Parse(Console.ReadLine());
                    tryAgain = false;
                }
                catch (FormatException e)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            double answer = 7+x*(-1+x*(2+x*(-5+3*x)));
            Console.WriteLine(answer);
        }
    }
}
