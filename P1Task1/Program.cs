using System;

namespace P1Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int result1 = a + b;
            int result2 = a - b;
            int result3 = a * b;
            int result4 = a / b;

            Console.WriteLine($"a+b = {result1} a-b = {result2} a*b = {result3} a/b = {result4}");


            Console.WriteLine("How are you?");
            string answer = Console.ReadLine();
            Console.WriteLine($"You are {answer}");

            Console.Write("Input three chars: ");
            string temp = Console.ReadLine();
            char c1 = temp[0];
            char c2 = temp[1];
            char c3 = temp[2];
        
            Console.WriteLine($"You enter {c1}, {c2}, {c3}");

            Console.Write("Input number1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input number2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            bool check1 = number1 > 0;
            bool check2 = number2 > 0;

            Console.WriteLine($"Number1 is positive! {check1}");
            Console.WriteLine($"Number2 is positive! {check2}");




        }
    }
}
