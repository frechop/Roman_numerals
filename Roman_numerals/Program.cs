using System;
using Roman_Numerals;

namespace Roman_numerals
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter a valid integer in the range of 1 - 3999");
                    Console.WriteLine(Roman.ConvertToRoman(int.Parse(Console.ReadLine())));
                }
                catch
                {
                    Console.WriteLine("Invalid input, please try again");
                }
            }
        }
    }
}
