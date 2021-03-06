﻿using System;
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

        public static string Numbers(double num)
        {

            string num1 = num.ToString();
            
            return num1;

        }


        //reverse
        static double Reverse(double src)
        {
            double dst = 0;
            int decPoint = 0;

            while (src - (long)src > 0)
            {
                src = src * 10;
                decPoint++;
            }

            int totalDigits = 0;

            while (src > 0)
            {
                int d = (int)src % 10;
                dst = dst * 10 + d;
                src = (long)(src / 10);
                totalDigits++;
            }

            if (decPoint > 0)
            {
                int reversedDecPoint = totalDigits - decPoint;
                for (int i = 0; i < reversedDecPoint; i++) dst = dst / 10;
            }

            return dst;
        }

        static bool IsPalindrome(double num)
        {
            double revNumber = Reverse(num);
            if (num == revNumber)
            {
                return true;
            }
            return false;
        }

        static long Reverse(long src)
        {
            long dst = 0;
            long decPoint = 0;

            while (src - (long)src > 0)
            {
                src = src * 10;
                decPoint++;
            }

            long totalDigits = 0;

            while (src > 0)
            {
                long d = (long)src % 10;
                dst = dst * 10 + d;
                src = src / 10;
                totalDigits++;
            }

            if (decPoint > 0)
            {
                long reversedDecPoint = totalDigits - decPoint;
                for (int i = 0; i < reversedDecPoint; i++) dst = dst / 10;
            }

            return dst;
        }


        static bool IsPalindrome(long num)
        {
            long revNumber = Reverse(num);
            if (num == revNumber)
            {
                return true;
            }
            return false;
        }


        static void Main(string[] args)
        {

        
            
            string phrase;
            phrase = "Madam, I'm Adam";
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Phrase: '{phrase}' is Palindrome: {IsPalindrome(phrase)}");
            Console.WriteLine("----------------------------------------------");
            phrase = "Madam, I am Adam";
            Console.WriteLine($"Phrase: '{phrase}' is Palindrome: {IsPalindrome(phrase)}");
            Console.WriteLine("----------------------------------------------");
            phrase = "Refer, refer";
            Console.WriteLine($"Phrase: '{phrase}' is Palindrome: {IsPalindrome(phrase)}");


            double numeric = 123.321;
         
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Double number: '{numeric}' is Palindrome: {IsPalindrome(numeric)}");  
            Console.WriteLine("----------------------------------------------");


            int integer;
            integer = 11211;
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Integer number: '{integer}' is Palindrome: {IsPalindrome(integer)}");

            Console.WriteLine("----------------------------------------------");

            long bigInt;
            bigInt = 12345654321;
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Long number: '{bigInt}' is Palindrome: {IsPalindrome(bigInt)}");

            Console.WriteLine("----------------------------------------------");

            Console.ReadLine();

        }
    }
}

