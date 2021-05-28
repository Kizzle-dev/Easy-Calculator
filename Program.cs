using System;

namespace Easy_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Commencement of Application Operation -Beginning of a conversation with the user
            Console.WriteLine("Witaj w Aplikacji Kalkulator!");
            // First number
            Console.WriteLine("Podaj prosze pierwsza liczbe!");
            // Getting first number
            var numer1 = int.Parse(Console.ReadLine());
            // Second number
            Console.WriteLine("Podaj prosze druga liczbe!");
            // Getting second number
            var numer2 = int.Parse(Console.ReadLine());
            //Request for enforcement
            Console.WriteLine("Co chcesz wykonać? Możesz '+', '-', '*'  oraz '/'.");
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
                    throw new Exception("Niestety cos poszło nie tak");
            }

            // Wyświetlamy otrzymany wynik
            Console.WriteLine($"Wynik twojego dzialania to: {result}.");







        }
    }
}
