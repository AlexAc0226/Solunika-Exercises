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
            bool continuar = true;
            bool latter = false;

            int addEvenNumbers = 0;
            int addUpOddNumbers = 0;
            int number = 0;

            List<int> listEvenNumbers = new List<int>();
            List<int> listOfOddNumbers = new List<int>();

            while (continuar)
            {
                do
                {
                    try
                    {
                        Console.WriteLine("Enter a number: ");
                        number = int.Parse(Console.ReadLine());
                        latter = false;
                    }
                    catch (FormatException ex)
                    {
                        // Console.WriteLine("Mensaje de error: " + ex.Message); 
                        latter = true;
                    }
                } while (latter);


                if (number % 2 == 0)
                {
                    listEvenNumbers.Add(number);
                }
                else
                {
                    listOfOddNumbers.Add(number);
                }


                Console.WriteLine("Press any key to continue, if you want to stop, press N or n");
                string respuesta = Console.ReadLine();

                if (respuesta == "N" || respuesta == "n")
                {
                    continuar = false;
                }

            }

            foreach (int numberP in listEvenNumbers)
            {
                addEvenNumbers += numberP;
            }

            foreach (int numberIP in listOfOddNumbers)
            {
                addUpOddNumbers += numberIP;
            }

            double promedioPares = addEvenNumbers / listEvenNumbers.Count;
            double promedioImpares = addUpOddNumbers / listOfOddNumbers.Count;

            if (promedioPares > promedioImpares)
            {
                Console.WriteLine("The average of the pairs is higher, it is " + promedioPares + " vs " + promedioImpares);
            }
            else
            {
                Console.WriteLine("The average of the odd is higher, it is " + promedioImpares + " vs " + promedioPares);
            }
        }
    }
}