using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._0
{
    internal class NumbersToWords
    {
        static string[] units = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", " Eight", "Nine" };
        static string[] teens = {"", "Eleven", "Twelve", " Thirteen", " Fourteen", " Fifteen", "Sixteen", " Seventeen", " Eighteen", " Nineteen" };
        static string[] tens = {"", "Ten", "Twenty", "Thirty", "Fourty", " Fifty", "Sixty", " Seventy", " Ninety," };

        public static string ConvertNumbersToWords(int number)
        {


            if (number >= 1000)
            {
                return $"{units[number / 1000]} Thousand {ConvertNumbersToWords(number % 1000)}";
            }
            else if (number >= 100)
            {
                return $"{units[number / 100]} Hundred {ConvertNumbersToWords(number % 100)}";
            }
            else if (number >= 20)
            {
                return $"{tens[number / 10]} {units[number % 10]}";

            }
            else if (number >= 11)
            {
                return $"{teens[number - 10]}";
            }
            else
            {
                return $"{units[number]}";

            }
            static void Main(string[] args)
            {
                Console.WriteLine("Enter a four-digit number: ");
                int number = int.Parse(Console.ReadLine());

                if (number < 0 || number > 9999)
                {
                    Console.WriteLine("Enter a valid number");
                }
                else if (number == 0)
                {
                    Console.WriteLine("Zero");
                }
                else
                {
                    Console.WriteLine(NumbersToWords.ConvertNumbersToWords(number));
                }
            }
        }

    }
}   
