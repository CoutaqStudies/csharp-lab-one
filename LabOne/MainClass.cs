using System;
//written by Coutaq
namespace LabOne
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Please select the task(1-11): ");
            int taskNumber;
            while (true)
            {
                try
                {
                    taskNumber = int.Parse(Console.ReadLine());
                    if (taskNumber < 1 || taskNumber > 12)
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
            switch (taskNumber)
            {
                case 1:
                    TaskOne.Do();
                    MainClass.Main(args);
                    break;
                case 2:
                    TaskTwo.Do();
                    MainClass.Main(args);
                    break;
                case 3:
                    TaskThree.Do();
                    MainClass.Main(args);
                    break;
                case 4:
                    TaskFour.Do();
                    MainClass.Main(args);
                    break;
                case 5:
                    TaskFive.Do();
                    MainClass.Main(args);
                    break;
                case 6:
                    TaskSix.Do();
                    MainClass.Main(args);
                    break;
                case 7:
                    TaskSeven.Do();
                    MainClass.Main(args);
                    break;
                case 8:
                    TaskEight.Do();
                    MainClass.Main(args);
                    break;
                case 9:
                    TaskNine.Do();
                    MainClass.Main(args);
                    break;
                case 10:
                    TaskTen.Do();
                    MainClass.Main(args);
                    break;
                case 11:
                    TaskEleven.Do();
                    MainClass.Main(args);
                    break;
                case 12:
                    Proof.Do();
                    MainClass.Main(args);
                    break;
            }
        }
    }
}
