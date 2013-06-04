using System;

namespace Equation
{
    class Equation
    {
        static void Main()
        {
            double descriminant;
            Console.Write("Enter the first number a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the third number c:");
            double c = double.Parse(Console.ReadLine());
            double x1 , x2;

            descriminant = b * b - 4 * a * c;
            
            if (descriminant > 0)
            {
                x1 = ( -b + Math.Sqrt(descriminant) ) /( 2 * a);
                x2 = ( b + Math.Sqrt(descriminant) ) / (2 * a);
                Console.WriteLine("x1={0}", x1);
                Console.WriteLine("x2={0}", x2);
            }
            else if (descriminant == 0)
            {
                x1 = x2 = -b / 2 * a;
                Console.WriteLine("x1={0}", x1);
                Console.WriteLine("x2={0}", x2);
            }
            else
            {
                Console.WriteLine("No real roots!");
            }
            
        }
    }
}
