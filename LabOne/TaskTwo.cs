using System;

namespace LabOne
{
    class TaskTwo
    {
        public static void Do()
        {
            TimeSpan now = DateTime.Now.TimeOfDay;
            int seconds = (int)now.TotalSeconds;
            int hours = seconds / 3600;
            int minutes=(seconds-(hours*3600))/ 60;
            Console.WriteLine("Hours: " + hours);
            Console.WriteLine("Minutes: " + minutes);
        }

    }
}
