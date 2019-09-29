using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne
{
    class TaskNine
    {
        public static void Do()
        {
            Console.WriteLine("ninen");
            int[] a = new int[3];
            int[] b = new int[3];
            int[] c = new int[3];
            int[] d = new int[3];
            for(int i = 0;i<4;i++){
                for(int j = 0;j<a.Length;j++){
                    switch(i){
                        case 0:
                        Console.Write("Please enter a"+j+": ");
                        bool tryAgain = true;
                        while (tryAgain)
                        {
                            try
                            {
                                a[j] = int.Parse(Console.ReadLine());
                                tryAgain = false;
                            }
                            catch (FormatException e)
                            {
                                Console.Write("Incorrect input, try again: ");
                            }
                        }
                        break;
                            case 1:
                        Console.Write("Please enter b"+j+": ");
                        bool tryAgain = true;
                        while (tryAgain)
                        {
                            try
                            {
                                b[j] = int.Parse(Console.ReadLine());
                                tryAgain = false;
                            }
                            catch (FormatException e)
                            {
                                Console.Write("Incorrect input, try again: ");
                            }
                        }
                        break;
                            case 2:
                        Console.Write("Please enter c"+j+": ");
                        bool tryAgain = true;
                        while (tryAgain)
                        {
                            try
                            {
                                c[j] = int.Parse(Console.ReadLine());
                                tryAgain = false;
                            }
                            catch (FormatException e)
                            {
                                Console.Write("Incorrect input, try again: ");
                            }
                        }
                        break;
                            case 0:
                        Console.Write("Please enter d"+j+": ");
                        bool tryAgain = true;
                        while (tryAgain)
                        {
                            try
                            {
                                d[j] = int.Parse(Console.ReadLine());
                                tryAgain = false;
                            }
                            catch (FormatException e)
                            {
                                Console.Write("Incorrect input, try again: ");
                            }
                        }
                        break;
                            }
                }
            }
           int delta = a1 * b2 * c3 + a3 * b1 * c2 + a2 * b3 * c1 - a3 * b2 * c1 - a1 * b3 * c2 - a2 * b1 * c3;
            if (delta != 0)
            {
                int deltaX = d1 * b2 * c3 + d3 * b1 * c2 + d2 * b3 * c1 - d3 * b2 * c1 - d1 * b3 * c2 - d2 * b1 * c3;
                int deltaY = a1 * d2 * c3 + a3 * d1 * c2 + a2 * d3 * c1 - a3 * d2 * c1 - a1 * d3 * c2 - a2 * d1 * c3;
                int deltaZ = a1 * b2 * d3 + a3 * b1 * d2 + a2 * b3 * d1 - a3 * b2 * d1 - a1 * b3 * d2 - a2 * b1 * d3;

                int x = deltaX / delta;
                int y = deltaY / delta;
                int z = deltaZ / delta;

                Console.WriteLine("x = " + x);
                Console.WriteLine("y = " + y);
                Console.WriteLine("z = " + z);
            }
            else
                Console.WriteLine("Error");
                
            Console.ReadKey();
        }
        
    }
}

