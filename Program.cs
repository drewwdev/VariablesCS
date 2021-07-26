using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCupsOfCoffee = 1;
            var fullName = "Drew Wilson";
            var today = DateTime.Today.DayOfWeek;
            Console.WriteLine($"My name is {fullName}. I drink {numberOfCupsOfCoffee} cup of coffee per day. Today is {today}.");

            Console.Write("What is your name? ");
            var userName = Console.ReadLine();

            if (userName == "Alice")
            {
                Console.WriteLine($"How was Wonderland, Alice");
            }
            else
            {
                Console.WriteLine($"Nice to meet you {userName}");
            }

            Console.Write("Give me a number ");
            var firstNumberAsString = Console.ReadLine();
            Console.Write("Give me a second number ");
            var secondNumberAsString = Console.ReadLine();

            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);

            var sum = firstOperand + secondOperand;
            Console.WriteLine($"The sum of {firstOperand} and {secondOperand} is {sum}");
            var difference = secondOperand - firstOperand;
            Console.WriteLine($"{secondOperand} minus {firstOperand} is equal to {difference}");
            var product = firstOperand * secondOperand;
            Console.WriteLine($"The product of {firstOperand} and {secondOperand} is equal to {product}");
            var quotient = firstOperand / secondOperand;
            Console.WriteLine($"The quotient of {firstOperand} divided by {secondOperand} is {quotient}");
            var remainder = firstOperand % secondOperand;
            Console.WriteLine($"The remainder of {firstOperand} divided by {secondOperand} is {remainder}");
        }
    }
}
