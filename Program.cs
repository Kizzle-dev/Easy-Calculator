using System;

namespace Easy_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Commencement of Application Operation -Beginning of a conversation with the user
            Console.WriteLine("Welcome to the Calculator Application!");
            // First number
            Console.WriteLine("Please enter the first number!");
            // Getting first number
            var numer1 = int.Parse(Console.ReadLine());
            // Second number
            Console.WriteLine("Please enter the second number!");
            // Getting second number
            var numer2 = int.Parse(Console.ReadLine());
            //Request for enforcement
            Console.WriteLine("What do you want to do? You can '+', '-', '*' and '/'.");
            // Getting request for enforcement
            var operation = Console.ReadLine();
            // Calculations
            var result = 0;

            switch (operation)
            {
                case "+":
                    result = numer1 + numer2;
                    break;
                case "-":
                    result = numer1 - numer2;
                    break;
                case "*":
                    result = numer1 * numer2;
                    break;
                case "/":
                    result = numer1 / numer2;
                    break;
                default:
                    throw new Exception("Unfortunately, something went wrong");
            }

            //We display the result
            Console.WriteLine($"The result of your action is: {result}.");







        }
    }
}
