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
            List<int> numbers = new List<int>();
            int index = 1;
            
            var number = "";
           
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter a number: ");
                number = Console.ReadLine();
                
                if (int.TryParse(number, out int n))
                {
                    if (number == new string(number.Reverse().ToArray()) && (int.Parse(number) > 10)) 
                    {
                        numbers.Add(int.Parse(number));
                    } 
                }
            }

           
            if(numbers.Count == 0) 
            {
                Console.WriteLine("There are no tricky numbers");
            } else 
            {
                numbers.Sort();

                foreach (int n in numbers)
                {
                    Console.WriteLine("Position: " + index + ", number " + n);
                    
                    if (index == numbers.Count)
                    {
                        Console.WriteLine("There are no more capicua numbers");
                        break;
                    }

                    index++;
                }
            }
        } 
    } 
} 