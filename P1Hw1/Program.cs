using System;

namespace CSharpP1HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int square = Convert.ToInt32(Math.Pow(a, 2));
            int perimeter = 4 * a;
            Console.WriteLine($"Square is {square} perimeter is {perimeter}");

            string name;
            int age;
            Console.Write("What is your name: ");
            name = Console.ReadLine();
            Console.Write($"How old are you, {name}? ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Name: {name}, Age: {age}");

            Console.Write("Input radius: ");
            double r = Convert.ToDouble(Console.ReadLine());
            const double pi = 3.14;
            double length = 2 * pi * r;
            double area = pi * Math.Pow(r, 2);
            double volume = 4 * pi * Math.Pow(r, 3) / 3;

            Console.WriteLine($"Lenght is {length} Area is {area} Volume is {volume}");


        }
    }
}