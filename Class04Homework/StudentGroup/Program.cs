using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
 
            string[] studentG1 = new string[5];
            string[] studentG2 = new string[5];

            for(int i =1; i<=5; i++)
            {
                Console.WriteLine("Enter name for student " +i+ " from G1 group: ");
                string nameG1 = "";
                nameG1 = Console.ReadLine();
                studentG1[i - 1] = nameG1; 
            }


            for(int j=1; j<=5; j++)
            {
                Console.WriteLine("Enter name for student " + j + " from G2 group: ");
                string nameG2 = "";
                nameG2 = Console.ReadLine();
                studentG2[j - 1] = nameG2;
            }

            Console.WriteLine("Enter 1 for student group G1 or enter2 for student group G2");
            var result = Console.ReadLine();
           

            switch (result)
            {

                case "1":
                    Console.WriteLine("The students from G1 group are: " );
                    foreach (string name in studentG1)
                    {
                        Console.WriteLine(name);

                    }
                    break;

                case "2":
                    Console.WriteLine("The students from G2 group are: ");
                    foreach (string name in studentG2)
                    {
                        Console.WriteLine(name);

                    }
                    break;
            }

          
            Console.ReadLine();
        }
    }
}
