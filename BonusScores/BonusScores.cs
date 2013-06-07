using System;
using System.Linq;
namespace BonusScores
{
    class BonusScores
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            ushort number;
            while (!ushort.TryParse(Console.ReadLine(), out number) || !Enumerable.Range(1, 9).Contains(number))
            {
                Console.Write("please enter number in range 1 to 9:");
            }
            switch (Enumerable.Range(1, 9).Contains(number))
            {
                case true:

                        if (Enumerable.Range(1, 3).Contains(number))
                        {
                            switch (number)
                            {
                                case 1:
                                case 2:
                                case 3:
                                    Console.WriteLine("result: {0} * 10 = {1}", number, number * 10);
                                    break;
                            }
                        }
                        else if (Enumerable.Range(4, 6).Contains(number))
                        {
                            switch (number)
                            {
                                case 4:
                                case 5:
                                case 6:
                                    Console.WriteLine("result: {0} * 100 = {1}", number, number * 100);
                                    break;
                            }
                        }
                        else if (Enumerable.Range(7, 9).Contains(number))
                        {
                            switch (number)
                            {
                                case 7:
                                case 8:
                                case 9:
                                    Console.WriteLine("result: {0} * 1000 = {1}", number, number * 1000);
                                    break;
                            }
                        }

                    break;

               default: Console.WriteLine("ERR!");

                    break;
            }
        }
    }
}
