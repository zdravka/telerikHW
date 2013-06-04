using System;

namespace DependingUserInput
{
    class DependingUserInput
    {
        static void Main()
        {

            Console.Write("Enter string, int or double: ");

            string userChoise = Console.ReadLine();

            double Number;
            bool isNumber;

            if (double.TryParse(userChoise, out Number))
            {
                isNumber = true;
            }
            else
            {
                isNumber = false;
            }
            switch (isNumber)
                {
                    case true:
                        userChoise += 1;
                        Console.WriteLine("Number --- {0}", userChoise);
                        break;
                    case false:
                        userChoise += "*";
                        Console.WriteLine("string --- {0}", userChoise);
                        break;
                    default:
                        Console.WriteLine("Symbol is not integer, double or string!");
                        break;
                }


        }
    }
}
