using System;

namespace SortWithNestedIf
{
    class SortWithNestedIf
    {
        static void Main()
        {
            double a, b, c;
            Console.Write("Enter the first number a:");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number b:");
            b = double.Parse(Console.ReadLine());
            Console.Write("Enter the third number c:");
            c = double.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    if (b > c)
                    {
                        Console.WriteLine("Descending order: {0}, {1}, {2}", a, b, c);
                    }
                }
            }
            else
            {
                if (b > c)
                {
                    if (a > c)
                    {
                        Console.WriteLine("Descending order: {0}, {1}, {2}", b, a, c);
                    }
                    else
                    {
                        Console.WriteLine("Descending order: {0}, {1}, {2}", b, c, a);
                    }    
                }
                else
                {
                    Console.WriteLine("Descending order: {0}, {1}, {2}", c, b , a);
                }
                
            }
        }
    }
}
