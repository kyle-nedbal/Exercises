using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello, World!";
            string answer = "y";
            do
            {
                Console.WriteLine(greeting);
                Console.WriteLine("Would You like to continue? (y/n)");
                answer = Console.ReadLine();
            } while (answer == "y");
            Console.WriteLine("Goodbye!");
        }
    }
}
