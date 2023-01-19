using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCalculatingTheAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Request no more than 10 positive integers from the user. The user can stop accepting numbers by entering 0.
             * After stopping receiving integers (this happens if 10 numbers were entered,
             * or the user entered 0 so as not to enter all 10),
             * calculate the average value of positive integers multiples of three and output to the console.
             */
            int summa = 0;
            int counter = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter a positive integer: ");
                int number = int.Parse(Console.ReadLine());
                if (number == 0)
                {
                    break;
                }
                if (number > 1 && number % 3 == 0)
                {
                    summa = summa + number;
                    counter++;
                }
            }
            int srednee = summa / counter;
            Console.WriteLine();
            Console.WriteLine($"The sum of positive integers divisible by three: {summa}\nNumber of matching numbers: {counter}\nAverage value: {srednee}");
            Console.ReadLine();
        }
    }
}
