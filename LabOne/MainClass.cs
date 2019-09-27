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
                    TaskOne.Do();
                    break;
                case 2:
                    TaskTwo.Do();
                    break;
                case 3:
                    TaskThree.Do();
                    break;
                case 4:
                    TaskFour.Do();
                    break;
                case 5:
                    TaskFive.Do();
                    break;
                case 6:
                    TaskSix.Do();
                    break;
                case 7:
                    TaskSeven.Do();
                    break;
                case 8:
                    TaskEight.Do();
                    break;
                case 9:
                    TaskNine.Do();
                    break;
                case 10:
                    TaskTen.Do();
                    break;
                case 11:
                    TaskEleven.Do();
                    break;
            }
        }

    }
}
