﻿using System;
//written by Coutaq
namespace LabOne
{
    internal class TaskNine
    {
        public static void Do()
        {
            int[] a = new int[3];
            int[] b = new int[3];
            int[] c = new int[3];
            int[] d = new int[3];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    switch (i)
                    {
                        case 0:
                            Console.Write("Please enter a" + (j + 1) + ": ");
                            while (true)
                            {
                                try
                                {
                                    a[j] = int.Parse(Console.ReadLine());
                                    break;
                                }
                                catch (FormatException)
                                {
                                    Console.Write("Incorrect input, try again: ");
                                }
                            }
                            break;
                        case 1:
                            Console.Write("Please enter b" + (j + 1) + ": ");
                            while (true)
                            {
                                try
                                {
                                    b[j] = int.Parse(Console.ReadLine());
                                    break;
                                }
                                catch (FormatException)
                                {
                                    Console.Write("Incorrect input, try again: ");
                                }
                            }
                            break;
                        case 2:
                            Console.Write("Please enter c" + (j + 1) + ": ");
                            while (true)
                            {
                                try
                                {
                                    c[j] = int.Parse(Console.ReadLine());
                                    break;
                                }
                                catch (FormatException)
                                {
                                    Console.Write("Incorrect input, try again: ");
                                }
                            }
                            break;
                        case 3:
                            Console.Write("Please enter d" + (j + 1) + ": ");

                            while (true)
                            {
                                try
                                {
                                    d[j] = int.Parse(Console.ReadLine());
                                    break;
                                }
                                catch (FormatException)
                                {
                                    Console.Write("Incorrect input, try again: ");
                                }
                            }
                            break;
                    }
                }
            }
            //the hard part:
            //let's start by finding the determinant
            int delta = a[0] * ((b[1] * c[2]) - (c[1] * b[2])) - b[0] * ((a[1] * c[2]) - (a[2] * c[1])) + c[0] * ((a[1] * b[2]) - (b[1] * a[2]));
            Console.WriteLine("delta: " + delta);
            if (delta != 0)
            {
                //now we need to find the determinant for other matricies 
                int deltaX = d[0] * ((b[1] * c[2]) - (c[1] * b[2])) - b[0] * ((d[1] * c[2]) - (d[2] * c[1])) + c[0] * ((d[1] * b[2]) - (b[1] * d[2]));
                int deltaY = a[0] * ((d[1] * c[2]) - (c[1] * d[2])) - d[0] * ((a[1] * c[2]) - (a[2] * c[1])) + c[0] * ((a[1] * d[2]) - (d[1] * a[2]));
                int deltaZ = a[0] * ((b[1] * d[2]) - (d[1] * b[2])) - b[0] * ((a[1] * d[2]) - (a[2] * d[1])) + d[0] * ((a[1] * b[2]) - (b[1] * a[2]));
                //now we find the thingies(whatever they're called i dont fucking remember and cant be bothered googling) using the cramer formula
                int x = deltaX / delta;
                int y = deltaY / delta;
                int z = deltaZ / delta;

                Console.WriteLine("x = " + x);
                Console.WriteLine("y = " + y);
                Console.WriteLine("z = " + z);
            }
            else
            {
                Console.WriteLine("Hell no! You can't divide by zero, try again.");
            }
            TaskNine.Do();
        }
    }
}

