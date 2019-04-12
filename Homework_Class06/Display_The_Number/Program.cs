using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_The_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program in C# to display the number and frequency of number from giving array.
            ________________________________________
            Expected Output :
            The number and the Frequency are :
            Number 5 appears 3 times
            Number 9 appears 2 times
            Number 1 appears 1 times
            */
            

            Action line = () => Console.WriteLine("-----------------------------------------------------------------------------");

            int[] numberArray = { 12, 23, 34, 45, 5, 5, 666, 7, 8666, 9, 4, 6, 7, 9, 3 };


            //SQL
            line();
            Console.WriteLine("----------SQL---------------");
            var n = from x in numberArray
                    group x by x into y
                    select y;
            Console.WriteLine("\nThe number and the Frequency are : \n");
            foreach (var arrNo in n)
            {
                Console.WriteLine("Number " + arrNo.Key + " appears " + arrNo.Count() + " times");
            }
            Console.WriteLine("\n");

            line();


            Console.WriteLine("---------Linq---------------");
            // resenie Linq
            var frequencies = numberArray.GroupBy(n1 => n1).Select(n1 => new { Value = n1.Key, Count = n1.Count()});

            foreach (var f in frequencies)
            {
                Console.WriteLine(string.Format("Number={0}, Frequency={1}", f.Value, f.Count));
            }

            line();


  
            // Write a program in C# to display the characters and frequency of character from giving string
            //________________________________________
            //Test Data :
            //Input the string: apple
            //Expected Output:
            // The frequency of the characters are :
            //Character a: 1 times
            //Character p: 2 times
            //Character l: 1 times
            //Character e: 1 times

            //SQL

            line();
            Console.WriteLine("----------SQL---------------");
            string inputStr;
            
            Console.WriteLine("Input the string: ");
            inputStr = Console.ReadLine();
            var freqChar = from x in inputStr group x by x into y select y;



            Console.WriteLine("\nThe Letter and the Frequency are : \n");
            foreach (var item in freqChar)
            {
                Console.WriteLine("Letter " + item.Key + " appears "+ item.Count() + " times");
            }


            line();
            Console.WriteLine("---------Linq---------------");
            // resenie Linq
            var frequencies2 = inputStr.GroupBy(n1 => n1).Select(n1 => new { Value = n1.Key, Count = n1.Count() });

            foreach (var f in frequencies2)
            {
                Console.WriteLine(string.Format("Letter={0}, Frequency={1}", f.Value, f.Count));
            }
            line();



            // Write a program in C# to Accept the members of a list through the keyboard and display the members more than a specific value.
            //________________________________________
            //Test Data :
            //Input the number of members on the List : 5
            //Member 0 : 10
            //Member 1 : 48
            //Member 2 : 52
            //Member 3 : 94
            //Member 4 : 63
            //Input the value above you want to display the members of the List: 59
            //Expected Output :
            //The numbers greater than 59 are:
            //94
            //63
            line();


            List<int> list = new List<int>();


            var member = 0;
            Console.WriteLine("Enter the number of members: ");
            member = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter {0} numbers : ", member);
            for (int i = 0; i < member; i++)
            {
               
                Console.Write("Enter number (" + (i + 1) + "): ");
                string input = Console.ReadLine();
                var input1 = int.Parse(input);
               
                list.Add(input1);
 
            }

            Console.WriteLine("Еnter the number to get the larger numbers from it: ");
            var borderNum = int.Parse(Console.ReadLine());

            foreach (var num in list)
            {
                if (num > borderNum)
                {
                    Console.WriteLine("Number {1} is larger then {0}",borderNum,num);
                }

            }

          line();


        }
    }
}


