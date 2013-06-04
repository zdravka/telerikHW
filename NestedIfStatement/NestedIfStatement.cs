using System;

namespace NestedIfStatement
{
    class NestedIfStatement
    {
        static void Main()
        {
            int a, b, c, greater = 0;
            Console.Write("Enter the first number a:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number b:");
            b = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number c:");
            c = int.Parse(Console.ReadLine());
            
                if (a > b)
                {
                    if (a > c)
                    {
                        greater = a;
                    }
                }
                if (b > a)
                {
                    if (b > c)
                    {
                        greater = b;
                    }
                }
                if (c > a)
                {
                    if (c > b)
                    {
                        greater = c;
                    }
                }

                Console.WriteLine("Greater number is {0}", greater);
        }
    }
}
