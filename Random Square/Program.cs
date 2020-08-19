using System;
using System.Collections.Generic;

namespace Random_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            var randomNumbers = new List<int>();

            var squaredNumbers = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                var randomNum = random.Next(1, 20);
                randomNumbers.Add(randomNum);
                squaredNumbers.Add(randomNum * randomNum);
            }

            Console.WriteLine($"Random Number List: {string.Join(",", randomNumbers)}");
            Console.WriteLine($"Squared Number List: {string.Join(",", squaredNumbers)}");

            var evenNumberSquared = new List<int>();

            foreach (var number in squaredNumbers)
            {
                if (number %2 == 0)
                {
                    evenNumberSquared.Add(number);
                }
            }
            Console.WriteLine($"Even Number Squared: {string.Join(",", evenNumberSquared)}");
        }

    }
}
