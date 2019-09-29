using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//written by Coutaq
namespace LabOne
{
    class TaskSeven
    {
        public static void Do()
        {
            int number = 0;
            Console.Write("Please enter your number: ");
            bool tryAgain = true;
            while (tryAgain)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    if (number < 100 || number > 999)
                    {
                        throw new FormatException();
                    }
                    tryAgain = false;
                }
                catch (FormatException e)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            int firstDigit = number / 100;
            int secondDigit = (number % 100)/10;
            int thirdDigit = (number % 100) % 10;
            int reversed = thirdDigit * 100 + secondDigit * 10 + firstDigit;
            Console.WriteLine(reversed);
        }

    }
}
