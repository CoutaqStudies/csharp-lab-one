using System;

namespace LabOne
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int taskNumber = 1;
            Console.Write("Please select the task(1-11): ");
            bool tryAgain = true;
            while (tryAgain)
            {
                try
                {
                    taskNumber = int.Parse(Console.ReadLine());
                    if(taskNumber < 1 || taskNumber>11)
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
                switch (taskNumber)
            {
                case 1:
                    Console.WriteLine("ONE");
                    break;
                case 2:
                    Console.WriteLine("ONE");
                    TaskTwo.Do();
                    break;
                case 3:
                    Console.WriteLine("ONE");
                    TaskThree.Do();
                    break;
                case 4:
                    Console.WriteLine("ONE");
                    TaskFour.Do();
                    break;
                case 5:
                    Console.WriteLine("ONE");
                    TaskFive.Do();
                    break;
                case 6:
                    Console.WriteLine("ONE");
                    TaskSix.Do();
                    break;
                case 7:
                    Console.WriteLine("ONE");
                    TaskSeven.Do();
                    break;
                case 8:
                    Console.WriteLine("ONE");
                    TaskEight.Do();
                    break;
                case 9:
                    Console.WriteLine("no");
                    break;
                case 10:
                    Console.WriteLine("ONE");
                    TaskTen.Do();
                    break;
                case 11:
                    Console.WriteLine("ONE");
                    TaskEleven.Do();
                    break;
            }
        }

    }
}
