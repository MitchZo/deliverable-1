using System;

namespace Currency_Format_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amt1 = 0;
            decimal amt2 = 0;
            decimal amt3 = 0;

            Console.WriteLine("Welcome to the adding machine. Please enter your first value in the format of XXX.XX.");
            string response = Console.ReadLine();


                if (decimal.TryParse(response, out amt1))
                {
                amt1 = decimal.Parse(response);
                 Console.WriteLine("Please enter your second number in the format of XXX.XX.");
                }
                else
                {
                Console.WriteLine("That is not the correct format. Please try again.");
                Console.ReadLine()
                }
        }
    }
}
