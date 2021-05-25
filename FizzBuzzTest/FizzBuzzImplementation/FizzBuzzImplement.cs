using System;

namespace FizzBuzzImplementation
{
    public static class FizzBuzzImplement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number between 1 and 100 to find the FizzBuzz");
            Console.WriteLine("The multiples of 3 will appear under the text Fizz");
            Console.WriteLine("and the multiples of 5 under the text Buzz");
            var number = Convert.ToInt32(Console.ReadLine());
            RunSequence(number);
            Console.ReadKey();
        }



        public static int RunSequence(int number)
        {
            var fizzBuzzes = 0;
            for (var i = 0; i < number; i++)
            {
                var output = GetValue(i);
                if (output == "FIZZBUZZ")
                {
                    fizzBuzzes++;
                }
                Console.WriteLine(output);
            }
            return fizzBuzzes;
        }


        public static string GetValue(int input)
        {
            var oper1 = input % 3 == 0;
            var oper2 = input % 5 == 0;
            var text = "";
            if (oper1)
                text += "FIZZ";
            if (oper2)
                text += "BUZZ";
            if (text.Length == 0)
                text = "" + input;
            return text;

        }
    }
}
