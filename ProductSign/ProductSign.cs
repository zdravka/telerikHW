using System;

namespace ProductSign
{
    class ProductSign
    {
        static void Main()
        {
            decimal a, b, c;
            byte positive = 0;
            Console.Write("Enter the first number a:");
            a = decimal.Parse(Console.ReadLine());
            Console.Write("Enter the second number b:");
            b = decimal.Parse(Console.ReadLine());
            Console.Write("Enter the third number c:");
            c = decimal.Parse(Console.ReadLine());

                if (Math.Sign(a) == 1 && Math.Sign(b) == 1 && Math.Sign(c) == 1)
                {
                    positive = (byte)(positive + 1);
                }

                if (positive % 2 == 0)
                {
                    Console.WriteLine("The sign of the product is:  -");
                }
                else
                {
                    Console.WriteLine("The sign of the product is:  +");
                }
        }
    }
}
