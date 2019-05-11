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
            int value = 1;
            string response;

            Console.WriteLine("Welcome to the adding machine. Please enter value #{0} in the format of XXX.XX.", value);
            response = Console.ReadLine();

            try
            {
                amt1 = decimal.Parse(response);
            }
            catch (Exception)
            {
                while (decimal.TryParse(response, out amt1))
                {
                    Console.WriteLine("That is not the correct format. Please try again.");
                    //remove "+ amt1" before submitting 
                    Console.WriteLine("Please enter value #{0} in the format of XXX.XX." + amt1, value);
                    response = Console.ReadLine();
                }
            }
            finally
            {
                    value ++;
                //remove "+ amt1" before submitting
                Console.WriteLine("Please enter value #{0} in the format of XXX.XX." + amt1, value);
            }
        }
    }
}
