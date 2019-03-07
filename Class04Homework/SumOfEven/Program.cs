using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfEven
{
    class Program
    {
           

        static void Main(string[] args)
        {
            int[] numValues = new int[6];
            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine("Enter number " + i + " :");
                int number;
                int.TryParse(Console.ReadLine(), out number);
                numValues[i - 1] = number;

            }
            int sum = 0;
            foreach (int value in numValues)
            {
                if (value % 2 == 0)
                {
                    sum += value;

                }

            }

            Console.WriteLine("Sum of Even number is: " + sum);
            Console.ReadLine();
        }
    }
}
