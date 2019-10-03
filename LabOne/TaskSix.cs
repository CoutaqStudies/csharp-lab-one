using System;
//written by Coutaq
namespace LabOne
{
    internal class TaskSix
    {
        public static void Do()
        {
            int number;
            Console.Write("Please enter your number: ");
            while (true)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    if (number < 1000 || number > 9999)
                    {
                        throw new FormatException();
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.Write("Incorrect input, try again: ");
                }
            }
            int firstDigit = number / 1000;
            int secondDigit = (number / 100) % 10;
            int thirdDigit = (number % 100) / 10;
            int fourthDigit = (number & 100) % 10;
            Console.WriteLine(firstDigit * secondDigit * thirdDigit * fourthDigit);
        }

    }
}
