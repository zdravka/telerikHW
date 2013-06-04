using System;

namespace GreaterNumber
{
    class GreaterNumber
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int number1 = int.Parse(Console.ReadLine()); 
            
            Console.Write("Enter second number: ");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine("Greater number is {0}", number1);
            }
            else
            {
                Console.WriteLine("Greater number is {0}",number2);
            }
        }
    }
}
