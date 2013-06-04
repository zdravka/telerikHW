using System;
using System.Linq;

namespace GreatestOfFive
{
    class GreatestOfFive
    {
        static void Main()
        {
            double[] array = new double[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter number {0} = ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            double max = array.Max();
            Console.WriteLine("Max value is: {0}",max);
        }
    }
}
