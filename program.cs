using System;

namespace CompareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the first number
            Console.WriteLine("Enter the first number:");
            double number1 = Convert.ToDouble(Console.ReadLine());

            // Prompt the user to enter the second number
            Console.WriteLine("Enter the second number:");
            double number2 = Convert.ToDouble(Console.ReadLine());

            // Compare the two numbers and display the result
            if (number1 > number2)
            {
                Console.WriteLine("The first number ({0}) is greater than the second number ({1}).", number1, number2);
            }
            else if (number1 < number2)
            {
                Console.WriteLine("The first number ({0}) is less than the second number ({1}).", number1, number2);
            }
            else
            {
                Console.WriteLine("The first number ({0}) is equal to the second number ({1}).", number1, number2);
            }

            // Wait for the user to press a key before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
