using System;
namespace VSCodeCSharpExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# in VS Code!");
            Console.WriteLine("-------------------------");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            GreetUser(name);
            PerformCalculations();
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        static void GreetUser(string name)
        {
            Console.WriteLine($"\nHello, {name}! Current date/time: {DateTime.Now}");
        }
        static void PerformCalculations()
        {
            Console.WriteLine("\nLet's do some calculations!");
            
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine($"\nResults:");
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            
            if (num2 != 0)
            {
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero!");
            }
        }
    }
}