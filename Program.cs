using System;
using System.Collections.Generic;

namespace Currency_Format_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Decimal?> amounts = new List<Decimal?>();

            //i defines the number of times the loop has been run in addition to the position in the array
            for (int i = 0; i < 3 ; i++)
            {
                amounts.Add(null);

                //run the try catch until the user gives us what we want
                while (amounts[i] == null)
                {
                    if (i == 0)
                        Console.WriteLine("Welcome to the adding machine.");
                    try
                    {
                        Console.WriteLine("Please enter value #{0} in the format of XXX.XX.",i + 1);
                        string response = Console.ReadLine();
                        amounts[i] = decimal.Parse(response);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("That is not the correct format. Please try again.");
                    }
                }
            }

            //math out the min, max, and avg
            Decimal min;
            Decimal max;
            Decimal avg;

            amounts.Sort();
            min = amounts[0].Value;

            max = amounts[amounts.Count-1].Value;

            decimal total = 0;
            for (int i = 0; i < amounts.Count; i++)
            {
                total = total + amounts[i].Value;
            }
            avg = total / amounts.Count;
            Console.WriteLine($@"min: {min}
max: {max}
avg: {avg}");
        }
    }
}
