using System;

namespace Currency_Format_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Decimal?[] amounts = new Decimal?[3];

            //i defines the number of times the loop has been run in addition to the position in the array
            for (int i = 0; i < amounts.Length; i++)
            {
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
                    //take this out before submitting
                    Console.WriteLine($"{amounts[0].ToString()} {amounts[1].ToString()} {amounts[2].ToString()}");
                }
            }
        }
    }
}
