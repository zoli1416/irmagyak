using System;
using System.Collections.Generic;
using System.Linq;

namespace irmagyak
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputs = new List<int>();
            int checkNumber = -1;

            Console.WriteLine("Enter 5 numbers to create a list of numbers:");

            Console.WriteLine("Enter a number for the list:");
            inputs.Add(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Enter a number for the list:");
            inputs.Add(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Enter a number for the list:");
            inputs.Add(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Enter a number for the list:");
            inputs.Add(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Enter a number for the list:");
            inputs.Add(Convert.ToInt32(Console.ReadLine()));


            Console.WriteLine("Enter number to check things with it:");
            checkNumber = Convert.ToInt32(Console.ReadLine());

            if (inputs.Contains(checkNumber))
            {
                Console.WriteLine("The list contains this number!");
            }
            else
            {
                Console.WriteLine("The list does not contains this number!");
            }

            if (inputs.Min(item => item) == checkNumber)
            {
                Console.WriteLine("The number is the smallest number in the list!");
            }
            else
            {
                Console.WriteLine("The number is not the smallest number in the list!");
            }

            if (inputs.Max(item => item) == checkNumber)
            {
                Console.WriteLine("The number is the biggest number in the list!");
            }
            else
            {
                Console.WriteLine("The number is not the biggest number in the list!");
            }


            Console.WriteLine("End of the program. Press enter to finish!");
            Console.ReadLine();

        }
    }
}
