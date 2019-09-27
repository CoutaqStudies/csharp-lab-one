using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne
{
    class TaskSix
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
                    if(number < 1000 || number > 9999)
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
            int firstDigit = number / 1000;
            int secondDigit = (number / 100) % 10;
            int thirdDigit = (number % 100)/10;
            int fourthDigit = (number&100)%10;
            Console.WriteLine(firstDigit*secondDigit*thirdDigit*fourthDigit);
        }

    }
}
