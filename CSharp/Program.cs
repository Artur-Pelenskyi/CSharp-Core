using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input text: ");
            string text = Console.ReadLine();
            int count = 0;
            for (var i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'i' || text[i] == 'e' || text[i] == 'o')
                {
                    count++;
                }
            }
            Console.WriteLine($"Count of characters 'a', 'o', 'i', 'e' in text is {count}");

            Console.Write("Input number of month: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num == 1 || num == 3 || num == 5 || num == 7 || num == 8 || num == 10 || num == 12)
            {
                Console.WriteLine($"Month number {num} has 31 days");
            }
            else if (num == 4 || num == 6 || num == 9 || num == 11 )
            {
                Console.WriteLine($"Month number {num} has 30 days");
            }
            else if (num == 2)
            {
                Console.WriteLine($"Month number {num} has 28-29 days");
            }    
            else
            {
                Console.WriteLine($"Month number {num} is incorrect");
            }

            int[] numbers = new int[10];
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Input {i} element: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            bool checker = true;
            string message = string.Empty;
            for (int i = 0; i < 5; i++)
            {
                if(numbers[i] > 0)
                {
                    message = "The first five numbers in array 'Numbers' are positive, so we search sum!";
                    checker = true;
                }
                else
                {
                    message = "The first five numbers in array 'Numbers' are not positive, so we search product!";
                    checker = false;
                }
      
            }

            int sum = 0;
            int product = 1;
            if (checker == true)
            {
                for(int i = 0; i<5; i++)
                {
                    sum += numbers[i];
                }
                Console.WriteLine($"Sum is {sum} ");
            }
            else
            {
                for (int i = 5; i < numbers.Length; i++)
                {
                    product *= numbers[i];
                }
                Console.WriteLine($"Product is {product} ");
            }


        }
    }
}
