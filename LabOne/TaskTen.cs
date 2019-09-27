using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne
{
    class TaskTen
    {
        public static void Do()
        {
            int numOfCountries = 0;
            Console.Write("Please enter how much countries: ");
            bool tryAgain = true;
            while (tryAgain)
            {
                try
                {
                    numOfCountries = int.Parse(Console.ReadLine());
                    if (numOfCountries < 1)
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
            GeographicalUnit[] countries = new GeographicalUnit[numOfCountries];
            for(int i = 0; i < numOfCountries; i++)
            {
                Console.Write("Please enter the country: ");
                String country = Console.ReadLine();
                Console.Write("Please enter the capital: ");
                String capital = Console.ReadLine();
                int population = 0;
                tryAgain = true;
                while (tryAgain)
                {
                    try
                    {
                        Console.Write("Please enter the population: ");
                        population = int.Parse(Console.ReadLine());
                        if (population < 0)
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
                String formString = "";
                GeographicalUnit.formOfGov form;
                Console.Write("Please enter the form of government: ");
                formString = Console.ReadLine();
                if (formString == "US")
                {
                    form = GeographicalUnit.formOfGov.US;
                }
                else
                {
                    form = GeographicalUnit.formOfGov.F;
                }
                  
            }
        }
    }
}
