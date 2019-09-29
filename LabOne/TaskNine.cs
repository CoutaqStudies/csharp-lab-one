using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//written by Coutaq
namespace LabOne
{
    class TaskNine
    {
        public static void Do()
        {
            int[] a = new int[3];
            int[] b = new int[3];
            int[] c = new int[3];
            int[] d = new int[3];
            for(int i = 0;i<4;i++){
                for(int j = 0;j<a.Length;j++){
                    switch(i){
                        case 0:
                        Console.Write("Please enter a"+(j+1)+": ");
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
                        Console.Write("Please enter b"+(j+1)+": ");
                         tryAgain = true;
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
                        Console.Write("Please enter c"+(j+1)+": ");
                         tryAgain = true;
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
                            case 3:
                        Console.Write("Please enter d"+(j+1)+": ");
                         tryAgain = true;
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
           int delta = a[0] * b[1] * c[2] + a[2] * b[0] * c[1] + a[1] * b[2] * c[0]- a[2] * b[1] * c[0] - a[0] * b[2] * c[1] - a[1] * b[0] * c[2];
            if (delta != 0)
            {
                int deltaX = d[0] * b[1] * c[2] + d[2] * b[0] * c[1] + d[1] * b[2] * c[0] - d[2] * b[1] * c[0] - d[0] * b[2] * c[1] - d[1] * b[0] * c[2];
                int deltaY = a[0] * d[1] * c[2] + a[2] * d[0] * c[1] + a[1] * d[2] * c[0] - a[2] * d[1] * c[0] - a[0] * d[2] * c[1] - a[1] * d[0] * c[2];
                int deltaZ = a[0] * b[1] * d[2] + a[2] * b[0] * d[1] + a[1] * b[2] * d[0] - a[2] * b[1] * d[0] - a[0] * b[2] * d[1] - a[1] * b[0] * d[2];

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

