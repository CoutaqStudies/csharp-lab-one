using System;
//written by Coutaq
namespace LabOne
{
    internal class TaskSeven
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
                    if (number < 100 || number > 999)
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
            int firstDigit = number / 100;
            int secondDigit = (number % 100) / 10;
            int thirdDigit = (number % 100) % 10;
            int reversed = thirdDigit * 100 + secondDigit * 10 + firstDigit;
            Console.WriteLine(reversed);
        }

    }
}
