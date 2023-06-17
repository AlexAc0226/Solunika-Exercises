
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
            
            for(int i =0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter a number: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);

            Console.WriteLine("The smallest number is: chico es: " + numbers[0]);
            Console.WriteLine("The median number is:: " + numbers[1]);
            Console.WriteLine("The largest number is: " + numbers[2]);
        } 
    } 
} 