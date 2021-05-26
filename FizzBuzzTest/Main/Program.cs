using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Write a number between 1 and 100 to find the FizzBuzz");
                Console.WriteLine("The multiples of 3 will appear under the text Fizz");
                Console.WriteLine("and the multiples of 5 under the text Buzz");
                GetConsoleValue(Console.ReadLine());
            }
        }

        public static void GetConsoleValue(string inputValue)
        {
            var isNumeric = int.TryParse(inputValue, out int number);
            if (!isNumeric)
                Console.WriteLine("***Error: The value is not an integer***");
            else if (number < 1 || number > 100)
                Console.WriteLine("***Error: The value is out of range***");
            else
            {
                RunSequence(number);
                Console.WriteLine("Press any key to start again");
                Console.ReadKey();
                Console.WriteLine("\n");
            }
        }


        public static int RunSequence(int number)
        {
            var fizzBuzzes = 0;
            for (var i = 0; i < number; i++)
            {
                if (GetValue(i) == "FIZZBUZZ") fizzBuzzes++;
                Console.WriteLine(GetValue(i));
            }
            return fizzBuzzes;
        }


        public static string GetValue(int input)
        {
            string text = input % 3 == 0 ? "FIZZ" : "";
            text += input % 5 == 0 ? "BUZZ" : "";
            return text.Length == 0 ? input.ToString() : text;
        }
    }

}
