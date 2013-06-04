using System;

namespace SubsetIsZero
{
    class SubsetIsZero
    {
        static void Main()
        {
            {
                int[] numbers = new int[5];
               
                int counter = 0;
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Enter {0} element: ",i);
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 1; i < 32; i++)
                {
                    int sum = 0;
                    for (int j = 0; j < 5; j++)
                    {
                        sum += ((i >> j) & 1) * numbers[j];
                    }
                    if (sum == 0)
                    {
                        counter++;
                    }
                }
                Console.WriteLine(counter + " Subset sums is 0");

            }
        }
    }
}
