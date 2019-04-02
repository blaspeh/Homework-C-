using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromApp
{
    class Program
    {
        
        public static string Letters(string phr)
        {
            
            string onlyLetters = "";
            onlyLetters = new String(phr.Where(c => Char.IsLetter(c)).ToArray());
            return onlyLetters.ToUpper();
        }
        
        public static bool IsPalindrome(string val)
        {
            string value = Letters(val);
            int first = 0;
            int last = value.Length - 1;
            while (true)
            {
                if (first > last)
                {
                    return true;
                }

                char a = value[first];
                char b = value[last];

                if(a != b)
                {
                    return false;
                }
                first++;
                last--;
            }
        }
        



        static void Main(string[] args)
        {

        

            string phrase;
            phrase = "Madam, I'm Adam";
          
            Console.WriteLine($"Phrase: '{phrase}' is Palindrome: {IsPalindrome(phrase)}");

            phrase = "Madam, I am Adam";
            Console.WriteLine($"Phrase: '{phrase}' is Palindrome: {IsPalindrome(phrase)}");

            phrase = "Refer, refer";
            Console.WriteLine($"Phrase: '{phrase}' is Palindrome: {IsPalindrome(phrase)}");

            double numeric;
            numeric = 123.321;

            string doubleNum;
            doubleNum = numeric.ToString();
            Console.WriteLine($"Phrase: '{numeric}' is Palindrome: {IsPalindrome(doubleNum)}");

            int integer;
            integer = 11211;
            string integerNum;
            integerNum = integer.ToString();
            Console.WriteLine($"Phrase: '{integer}' is Palindrome: {IsPalindrome(integerNum)}");

            long bigInt;
            bigInt = 12345654321;
            string bigIntNum;
            bigIntNum = bigInt.ToString();

            Console.WriteLine($"Phrase: '{bigInt}' is Palindrome: {IsPalindrome(bigIntNum)}");

            Console.ReadLine();

        }
    }
}

