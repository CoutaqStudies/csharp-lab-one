using System;

namespace LabOne
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int taskNumber = 1;
            Console.Write("Please select the task(1-10): ");
            bool tryAgain = true;
            while (tryAgain)
            {
                try
                {
                    taskNumber = int.Parse(Console.ReadLine());
                    if(taskNumber>10 || taskNumber < 1)
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
                /*case 1:
                    TaskOne.Do();
                    break;
                case 1:
                    TaskOne.Do();
                    break;
                case 1:
                    TaskOne.Do();
                    break;
                case 1:
                    TaskOne.Do();
                    break;
                case 1:
                    TaskOne.Do();
                    break;
                case 1:
                    TaskOne.Do();
                    break;
                    break;*/
            }
        }

    }
}
