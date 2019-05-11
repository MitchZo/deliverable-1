using System;

namespace Currency_Format_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Decimal? amt1 = null;
            Decimal? amt2 = null;
            Decimal? amt3 = null;

            while (amt1 == null) 
            {
                try
                {
                    Console.WriteLine("Welcome to the adding machine. Please enter value #1 in the format of XXX.XX.";
                    string response = Console.ReadLine();
                    amt1 = decimal.Parse(response);
                }
                catch (Exception)
                {
                    Console.WriteLine("That is not the correct format. Please try again.");
                }
            }
        }
    }
}
