using System;

namespace CSharpP2T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input day:");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input month:");
            int month = Convert.ToInt32(Console.ReadLine());

            if ((day > 0 && day <= 31) && (month > 0 && month <= 12))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.Write("Write number : ");
            string number = Console.ReadLine();
            int result = 0;
            for (int elementOfNumber = 0; elementOfNumber < number.Length; elementOfNumber++)
            {
                if (number[elementOfNumber].ToString().Equals("."))
                {
                    result += Convert.ToInt32(number[elementOfNumber + 1].ToString());
                    result += Convert.ToInt32(number[elementOfNumber + 2].ToString());
                }
            }

            Console.WriteLine($"The sum of two digits after point is : {result}");

            Console.WriteLine("Input number between 0 and 24:");
            int hour = Convert.ToInt32(Console.ReadLine());

            if ((hour >= 22 && hour < 24) || (hour >= 0 && hour < 4))
            {
                Console.WriteLine("Good night!");
            }
            else if (hour >= 4 && hour < 12)
            {
                Console.WriteLine("Good morning!");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Good afternoon!");
            }
            else if (hour >= 18 && hour < 22)
            {
                Console.WriteLine("Good evening!");
            }
            else
            {
                Console.WriteLine("You input incorrect hour!");
            }


            var teststatus1 = TestCaseStatus.Fail;
            Console.WriteLine(teststatus1);

            RGB firstVariable;
            firstVariable.blue = 0;
            firstVariable.green = 0;
            firstVariable.red = 0;

            RGB secondVariable;
            secondVariable.blue = 255;
            secondVariable.green = 255;
            secondVariable.red = 255;
        }


        enum TestCaseStatus
        {
            Pass, Fail, Blocked, WP, Unexecuted
        }

        struct RGB
        {
            public byte red;
            public byte green;
            public byte blue;
        }




    }
}
