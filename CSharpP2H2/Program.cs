using System;

namespace CSharpP2H2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number1: ");
            float number1 = (float)Convert.ToDouble(Console.ReadLine());
            Console.Write("Input number2: ");
            float number2 = (float)Convert.ToDouble(Console.ReadLine());
            Console.Write("Input number3: ");
            float number3 = (float)Convert.ToDouble(Console.ReadLine());

            bool c1 = (number1 >= -5 && number1 <= 5);
            bool c2 = (number2 >= -5 && number2 <= 5);
            bool c3 = (number3 >= -5 && number3 <= 5);

            if(c1==c2 && c1 == c3)
            {
                Console.WriteLine("All numbers in range [-5;5]");
            }
            else
            {
                Console.WriteLine("All numbers are not in range [-5;5]");
            }


            Console.Write("Input num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input num3: ");
            int num3 = Convert.ToInt32(Console.ReadLine()); 

            if(num1 < num2 && num2 < num3)
            {
                Console.WriteLine($"Min is {num1}");
            }
            else if(num2 < num1 && num1 < num3)
            {
                Console.WriteLine($"Min is {num2}");
            }
            else if (num3 < num2 && num2 < num1)
            {
                Console.WriteLine($"Min is {num3}");
            }


            if (num1 > num2 && num2 > num3)
            {
                Console.WriteLine($"Max is {num1}");
            }
            else if (num2 > num1 && num1 > num3)
            {
                Console.WriteLine($"Max is {num2}");
            }
            else if (num3 > num2 && num2 > num1)
            {
                Console.WriteLine($"Max is {num3}");
            }

            Console.Write("Input error number:");
            int errorNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Name of HTTPError {errorNum} is: {(HTTPErrors)errorNum}");

            Dog myDog = new Dog();
            myDog.Age = 1;
            myDog.Mark = 3;
            myDog.Name = "Rico";
            Console.WriteLine(myDog.InString());


        }


        enum HTTPErrors
        {
            Bad_Request = 400,
            Unauthorized,
            Payment_Required,
            Forbidden,
            Not_Found
        }

        struct Dog
        {
            public string Name;
            public int Mark;
            public int Age;

            public  string InString()
            {
                return $"Name is {Name}, age is {Age}, mark is {Mark}";
            }
        }
    }
}
