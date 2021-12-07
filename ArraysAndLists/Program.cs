using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {  
            var numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };           
                var evens = new List<int>();
                var odds = new List<int>();

            /*for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evens.Add(numbers[i]);
                }
                else
                {
                    odds.Add(numbers[i]);
                }
            }
            */
            
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                    //Console.WriteLine($"{num} is an even number");
                }
                else
                {
                    odds.Add(num);
                    //Console.WriteLine($"{num} is an odd number");
                }
            }
            

            foreach (var item in evens)
            {
                Console.WriteLine($"{item} is an even number");
            }

            foreach (var item in odds)
            {
                Console.WriteLine($"{item} is an odd number");
            }
        }
    }
}
