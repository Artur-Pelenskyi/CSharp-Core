using System;
using System.Collections.Generic;

namespace CSharpP3T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input b:");
            int b = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(int i = a; i<=b; i++)
            {
                if(i%3==0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Count of numbers are divided by 3 without remainder {count}");

            Console.Write("Input string:");
            string str = Console.ReadLine();
            for(var i = 0; i<str.Length; i+=2)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();

            var positiveIntegers = new List<int>();
            while (true)
            {
                Console.Write("Write element : ");
                int checker = Convert.ToInt32(Console.ReadLine());
                if (checker >= 0)
                {
                    positiveIntegers.Add(checker);
                }
                else
                {
                    break;
                }
            }
            int[] positiveIntegerNumbers = positiveIntegers.ToArray();
            int arithmetic = 0;
            foreach (var elementOfPositiveIntegers in positiveIntegerNumbers)
            {
                arithmetic += elementOfPositiveIntegers;
            }
            Console.WriteLine($"Arithmetic is {arithmetic / positiveIntegers.ToArray().Length}");

            Console.Write("Input year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year");
            }


            Console.Write("Input num: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while(num>0)
            {

                sum = sum + num % 10;
                num = num / 10;
            }
            
            Console.WriteLine($"Sum is {sum}");


            Console.Write("Input number: ");
            string number = Console.ReadLine();
            string message = string.Empty;
            for(var i = 0; i < number.Length; i++)
            {
                if((int)number[i] % 2 != 0)
                {
                    message = "Number contains only odd digits!";
                }
                else
                {
                    message = "Number contains even digit!";
                    break;
                }
            }
            Console.WriteLine(message);
        }
    }
}
