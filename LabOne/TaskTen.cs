using System;
using System.Collections.Generic;
using System.Data;
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
                Console.WriteLine("Country " + (i+1)+":");
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
                string upperString = "";
                GeographicalUnit.formOfGov form;
                tryAgain = true;
                while (tryAgain)
                {
                    try
                    {
                        Console.Write("Please enter the form of government: ");
                        formString = Console.ReadLine();
                        upperString = (formString.ToUpper()).ToString();
                        if(upperString != "US" && upperString != "F")
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
                
                if (upperString == "F")
                {
                    form = GeographicalUnit.formOfGov.F;
                }
                else
                {
                    form = GeographicalUnit.formOfGov.US;
                }
                countries[i] = new GeographicalUnit(country, capital, population, form);
                  
            }
            String output = "\n---------------------------------\n";
            for (int i = 0; i < numOfCountries; i++)
            {
                output += (countries[i].getInfoTable());
                output += "\n---------------------------------\n";
               
            }
            Console.WriteLine(output);
        }
    }

}
