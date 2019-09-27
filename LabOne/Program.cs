using System;

namespace LabOne
{
    class MainClass
    {
        public static void Main(string[] args)
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
                    Console.WriteLine("Incorrect input!");
                }
            }
            int d = Double ((x%1)* 10);
            Console.WriteLine(d);
        }

    }
}
