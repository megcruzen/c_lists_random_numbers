using System;
using System.Collections.Generic;

namespace random_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Use the following code to create a list of random numbers. Each number will be between 0 and 9.

            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(10),
                random.Next(10),
                random.Next(10),
                random.Next(10),
                random.Next(10),
            };

            // 2. Use a for loop to iterate over all numbers between 0 and `numbers.Count - 1`

            for(int i = 0; i <= numbers.Count - 1 ; i++) {
                Console.WriteLine($"Random number: {numbers[i]}");
            }
            Console.WriteLine();

            for(int i = 0; i < numbers.Count; i++) {
                Console.WriteLine($"Random number: {numbers[i]}");
            }
            Console.WriteLine();

            // 3. Inside the body of the for loop determine if the current loop index is contained inside of the numbers list. Print a message to the console indicating whether the index is in the list.

            /*
            for(int i = 0; i <= numbers.Count - 1 ; i++) {
                Console.WriteLine($"Random number: {numbers[i]}");
                if (i == numbers[i]) {
                    Console.WriteLine($"Numbers list contains {i}");
                }
                else {
                    Console.WriteLine($"Numbers list does not contain {i}");
                }
            }
            */

            for(int i = 0; i <= numbers.Count - 1 ; i++) {
                Console.WriteLine($"Random number: {numbers[i]}");
                if (numbers.Contains(i)) {
                    Console.WriteLine($"Numbers list contains {i}");
                }
                else {
                    Console.WriteLine($"Numbers list does not contain {i}");
                }
            }

            // Expected output:
            // numbers list contains 0
            // numbers list does not contain 1
            // numbers list does not contain 2
            // numbers list contains 3
            // numbers list contains 4
        }
    }
}
