using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            bool breakLoop = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                do
                {
                    try
                    {
                        Console.WriteLine("Enter a number: ");
                        numbers[i] = Convert.ToInt32(Console.ReadLine());
                        breakLoop = true;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Please enter a valid number.");
                        breakLoop = false;
                    }
                } while (!breakLoop);
            }

            Array.Sort(numbers);

            Console.WriteLine("The smallest number is: " + numbers[0]);
            Console.WriteLine("The median number is:: " + numbers[1]);
            Console.WriteLine("The largest number is: " + numbers[2]);
        }
    }
}